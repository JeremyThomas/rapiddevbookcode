using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LLBLGen.DataContextDriver.Properties;
using AW.Winforms.Helpers.LLBL;
using LINQPad;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// 	This static driver let users query any data source that looks like a Data Context - in other words,
	/// 	that exposes properties of type IEnumerable of T.
	/// </summary>
	public class LLBLGenStaticDriver : StaticDataContextDriver
	{
		#region Constants

		public static readonly string[] AdditionalAssemblies = new[]
		                                                       	{
		                                                       		"SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll",
		                                                       		"SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll",
		                                                       		"AW.Helper.dll", "AW.Helper.LLBL.dll", "System.Windows.Forms.dll",
		                                                       		"AW.Winforms.Helpers.dll", "AW.Winforms.Helpers.LLBL.dll"
		                                                       	};

		public static readonly string[] AdditionalNamespaces = new[]
		                                                       	{
		                                                       		"SD.LLBLGen.Pro.ORMSupportClasses",
		                                                       		"SD.LLBLGen.Pro.LinqSupportClasses",
		                                                       		"AW.Helper",
		                                                       		"AW.Helper.LLBL",
		                                                       		"AW.Winforms.Helpers.DataEditor",
		                                                       		"AW.Winforms.Helpers.LLBL"
		                                                       	};

		#endregion

		#region Overrides of DataContextDriver

		public override string Name
		{
			get { return Constants.DriverName; }
		}

		public override string Author
		{
			get { return Constants.Author; }
		}

		public override string GetConnectionDescription(IConnectionInfo cxInfo)
		{
			// For static drivers, we can use the description of the custom type & its assembly:
			return new[] {cxInfo.CustomTypeInfo.CustomTypeName, cxInfo.DatabaseInfo.GetDatabaseDescription(), cxInfo.AppConfigPath}.JoinAsString(" - ");
		}

		public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			// Prompt the user for a custom assembly and type name:
			try
			{
				return new ConnectionDialog(cxInfo, isNewConnection).ShowDialog() == true;
			}
			catch (Exception e)
			{
				GeneralHelper.TraceOut(e.Message);
				Application.OnThreadException(e);
			}
			return true;
		}

		#region SQLTranslationWriter

		private void SetSQLTranslationWriter(Type typeBeingTraced, QueryExecutionManager executionManager)
		{
			SetSQLTranslationWriter(typeBeingTraced, null, executionManager);
		}

		private void SetSQLTranslationWriter(DataAccessAdapterBase adapter, QueryExecutionManager executionManager)
		{
			SetSQLTranslationWriter(adapter.GetType(), adapter, executionManager);
		}

		private void SetSQLTranslationWriter(Type typeBeingTraced, object objectBeingTraced, QueryExecutionManager executionManager)
		{
			var eventInfo = typeBeingTraced.GetEvent("SQLTraceEvent");
			if (eventInfo != null && eventInfo.EventHandlerType != null)
				try
				{
					//EventHandler<SQLTraceEventArgs> handler = (sender, e) => WriteSQLTranslation(executionManager.SqlTranslationWriter, e);
					//Delegate.CreateDelegate(eventInfo.EventHandlerType, handler.Method);

					var handlerSQLTraceEvent = GetType().GetMethod("SQLTraceEventHandler", BindingFlags.NonPublic | BindingFlags.Instance);

					_executionManager = executionManager;
					var typedDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, handlerSQLTraceEvent);
					eventInfo.GetAddMethod().Invoke(objectBeingTraced, new[] {typedDelegate});
				}
				catch (Exception e)
				{
					GeneralHelper.TraceOut(e.Message);
				}
		}

		private QueryExecutionManager _executionManager;

		private void SQLTraceEventHandler(object sender, EventArgs e)
		{
			if (_executionManager != null)
				WriteSQLTranslation(_executionManager.SqlTranslationWriter, e);
		}

		private static void WriteSQLTranslation(TextWriter sqlTranslationWriter, EventArgs e)
		{
			if (sqlTranslationWriter != null && e != null)
			{
				if (e is SQLTraceEventArgs)
				{
					var sqlTraceEventArgs = (SQLTraceEventArgs) e;
					if (!string.IsNullOrEmpty(sqlTraceEventArgs.SQLTrace))
					{
						sqlTranslationWriter.WriteLine(sqlTraceEventArgs.SQLTrace);
						return;
					}
					if (sqlTraceEventArgs.Query != null)
					{
						sqlTranslationWriter.WriteLine(QueryToSQL.GetExecutableSQLFromQuery(sqlTraceEventArgs.Query));
						return;
					}
				}
				else if (e is QueryTraceEventArgs)
				{
					var queryTraceEventArgs = (QueryTraceEventArgs) e;
					if (queryTraceEventArgs.Query != null)
					{
						sqlTranslationWriter.WriteLine(QueryToSQL.GetExecutableSQLFromQuery(queryTraceEventArgs.Query));
						return;
					}
				}
				else
				{
					var sqlTracePi = e.GetType().GetProperty("SQLTrace");
					if (sqlTracePi != null)
					{
						var sqlTrace = sqlTracePi.GetValue(e, null) as string;
						if (!string.IsNullOrEmpty(sqlTrace))
						{
							sqlTranslationWriter.WriteLine(sqlTrace);
							return;
						}
					}
					var queryPi = e.GetType().GetProperty("Query");
					if (queryPi != null)
					{
						var query = queryPi.GetValue(e, null) as IQuery;
						if (query != null)
							sqlTranslationWriter.WriteLine(QueryToSQL.GetExecutableSQLFromQuery(query));
					}
				}
			}
		}

		#endregion

		//public override bool AreRepositoriesEquivalent(IConnectionInfo c1, IConnectionInfo c2)
		//{
		//  return base.AreRepositoriesEquivalent(c1, c2);
		//}

		public override IEnumerable<string> GetAssembliesToAdd()
		{
			var globalAdditionalAssemblies = Settings.Default.AdditionalAssemblies.AsEnumerable();
			return globalAdditionalAssemblies == null ? AdditionalAssemblies : AdditionalAssemblies.Union(globalAdditionalAssemblies);
		}

		public override IEnumerable<string> GetNamespacesToAdd()
		{
			var globalAdditionalNamespaces = Settings.Default.AdditionalNamespaces.AsEnumerable();
			return globalAdditionalNamespaces == null ? AdditionalNamespaces : AdditionalNamespaces.Union(globalAdditionalNamespaces);
		}

		public override IEnumerable<string> GetNamespacesToRemove()
		{
			return new[] {"System.Data.Linq"};
		}

		/// <summary>
		/// 	Gets the custom display member provider.
		/// </summary>
		/// <param name = "objectToWrite">The object to write.</param>
		/// <returns></returns>
		public override ICustomMemberProvider GetCustomDisplayMemberProvider(object objectToWrite)
		{
			return LLBLMemberProvider.CreateCustomDisplayMemberProviderIfNeeded(objectToWrite);
		}

		public override void InitializeContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
		{
			try
			{
				LLBLWinformHelper.ForceInitialization();
				var assembly = Assembly.LoadFile(cxInfo.CustomTypeInfo.CustomAssemblyPath);
				var type = assembly.GetTypes().Where(t => t.Name.Contains("CommonDaoBase") && t.IsClass).SingleOrDefault();
				if (type == null)
				{
					InitializeAdapter(cxInfo, context, executionManager);
				}
				else
				{
					InitializeSelfservicing(cxInfo, type, context, executionManager);
				}
			}
			catch (Exception e)
			{
				GeneralHelper.TraceOut(e.Message);
			}
		}

		// Return the objects with which to populate the Schema Explorer by reflecting over customType.

		// We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
		public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
		{
			var usefieldsElement = cxInfo.DriverData.Element(ConnectionDialog.ElementNameUseFields);
			return usefieldsElement != null && usefieldsElement.Value == true.ToString() ? GetSchemaFromEntities(cxInfo, customType) : GetSchemaByReflection(cxInfo, customType);
		}

		#endregion

		#region Initialization

		private void InitializeSelfservicing(IConnectionInfo cxInfo, Type commonDaoBaseType, object context, QueryExecutionManager executionManager)
		{
			var actualConnectionStringField = commonDaoBaseType.GetField("ActualConnectionString");
#if DEBUG
			var actualConnectionString = Convert.ToString(actualConnectionStringField.GetValue(context));
			GeneralHelper.DebugOut(actualConnectionString);
#endif
			actualConnectionStringField.SetValue(context, cxInfo.DatabaseInfo.CustomCxString);
#if DEBUG
			GeneralHelper.DebugOut(Convert.ToString(actualConnectionStringField.GetValue(context)));
#endif
			SetSQLTranslationWriter(commonDaoBaseType, executionManager);
		}

		private void InitializeAdapter(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
		{
			var linqMetaData = context as ILinqMetaData;
			if (linqMetaData == null)
			{
				var type = context.GetType();
				type = type.BaseType ?? type;
				GeneralHelper.TraceOut(type.AssemblyQualifiedName + Environment.NewLine + "is not a" + Environment.NewLine + typeof (ILinqMetaData).AssemblyQualifiedName);
			}
			else
			{
				var adapter = GetAdapter(cxInfo);
				if (adapter != null)
				{
					var adapterToUseProperty = linqMetaData.GetType().GetProperty("AdapterToUse");
					adapterToUseProperty.SetValue(linqMetaData, adapter, null);
					if (string.IsNullOrEmpty(adapter.ConnectionString))
						if (!string.IsNullOrEmpty(cxInfo.AppConfigPath))
						{
							var firstConnectionString = (from connectionStringSetting in ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>()
							                             select connectionStringSetting).FirstOrDefault();
							if (firstConnectionString != null)
								adapter.ConnectionString = firstConnectionString.ConnectionString;
						}
					SetSQLTranslationWriter(adapter, executionManager);
				}
			}
		}

		private static DataAccessAdapterBase GetAdapter(IConnectionInfo cxInfo)
		{
			ConnectionDialog.UpGradeDriverDataElements(cxInfo);
			var adapterTypeName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameAdaptertype);
			var factoryTypeName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryType);
			if (string.IsNullOrEmpty(adapterTypeName) && string.IsNullOrEmpty(factoryTypeName))
				throw new ApplicationException("CommonDaoBase or adapter not found!");

			var adapterAssemblyPath = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameAdapterAssembly);
			var factoryAssemblyPath = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryAssembly);
			if (!File.Exists(adapterAssemblyPath) && !File.Exists(factoryAssemblyPath))
				throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " not found!" + Environment.NewLine +
				                               "Factory assembly: " + factoryAssemblyPath + " not found!");
			int connectionTypeIndex;
			Assembly dataAccessAdapterAssembly = null;
			Type dataAccessAdapterType = null;
			if (!int.TryParse(ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameConnectionType), out connectionTypeIndex))
			{
				dataAccessAdapterAssembly = Assembly.LoadFile(adapterAssemblyPath);
				dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
				connectionTypeIndex = typeof (DataAccessAdapterBase).IsAssignableFrom(dataAccessAdapterType) ? (int) LLBLConnectionType.Adapter : (int) LLBLConnectionType.AdapterFactory;
				cxInfo.DriverData.SetElementValue(ConnectionDialog.ElementNameConnectionType, connectionTypeIndex);
			}
			return GetAdapter(cxInfo, adapterTypeName, factoryTypeName, adapterAssemblyPath, factoryAssemblyPath, dataAccessAdapterAssembly, dataAccessAdapterType, connectionTypeIndex);
		}

		private static DataAccessAdapterBase GetAdapter(IConnectionInfo cxInfo, string adapterTypeName, string factoryTypeName, string adapterAssemblyPath, string factoryAssemblyPath, Assembly dataAccessAdapterAssembly, Type dataAccessAdapterType,
		                                                int connectionTypeIndex)
		{
			DataAccessAdapterBase adapter;
			if (connectionTypeIndex == (int) LLBLConnectionType.Adapter)
			{
				if (dataAccessAdapterAssembly == null)
					dataAccessAdapterAssembly = Assembly.LoadFile(adapterAssemblyPath);
				if (dataAccessAdapterAssembly == null)
					throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " could not be loaded!");
				if (dataAccessAdapterType == null)
					dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
				if (dataAccessAdapterType == null)
					throw new ApplicationException(string.Format("Adapter type: {0} could not be loaded from: {1}!", adapterTypeName, adapterAssemblyPath));
				if (string.IsNullOrEmpty(cxInfo.DatabaseInfo.CustomCxString))
				{
					adapter = dataAccessAdapterAssembly.CreateInstance(adapterTypeName) as DataAccessAdapterBase;
				}
				else
				{
					if (cxInfo.DatabaseInfo.IsSqlServer)
						adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
						                                                          	{
						                                                          		cxInfo.DatabaseInfo.CustomCxString,
						                                                          		true, CatalogNameUsage.Clear, null
						                                                          	}) as DataAccessAdapterBase;
					else
					{
						if (cxInfo.DatabaseInfo.CustomCxString.Contains("Oracle"))
							adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
							                                                          	{
							                                                          		cxInfo.DatabaseInfo.CustomCxString,
							                                                          		true, SchemaNameUsage.Default, null
							                                                          	}) as DataAccessAdapterBase;
						else
							adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
							                                                          	{
							                                                          		cxInfo.DatabaseInfo.CustomCxString
							                                                          	}) as DataAccessAdapterBase;
					}
				}
			}
			else
			{
				var factoryMethodName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryMethod);
				var factoryAdapterAssembly = Assembly.LoadFile(factoryAssemblyPath);
				if (factoryAdapterAssembly == null)
					throw new ApplicationException("Adapter assembly: " + factoryAssemblyPath + " could not be loaded!");
				var factoryType = factoryAdapterAssembly.GetType(factoryTypeName);
				if (factoryType == null)
					throw new ApplicationException(string.Format("Adapter type: {0} could not be loaded from: {1}!", factoryTypeName, factoryAssemblyPath));
				var fullListQueryMethod = factoryType.GetMethod(factoryMethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new[] {typeof (string)}, null);
				if (fullListQueryMethod == null)
				{
					GeneralHelper.TraceOut(factoryMethodName + " not found");
					adapter = null;
				}
				else
					try
					{
						adapter = fullListQueryMethod.Invoke(null, BindingFlags.InvokeMethod, null, new object[] {cxInfo.DatabaseInfo.CustomCxString}, null) as DataAccessAdapterBase;
					}
					catch (TargetInvocationException invocationException)
					{
						GeneralHelper.ThrowInnerException(invocationException);
						throw;
					}
			}
			return adapter;
		}

		#endregion

		#region Schema helpers

		private static List<ExplorerItem> GetSchemaFromEntities(IConnectionInfo cxInfo, Type customType)
		{
			var elementCreator = EntityHelper.CreateElementCreator(customType);
			var adapter = GetDataAccessAdapter(cxInfo, elementCreator is IElementCreator2);

			var topLevelProps = (from type in EntityHelper.GetEntitiesTypes(customType.Assembly)
			                     let entity = LinqUtils.CreateEntityInstanceFromEntityType(type, elementCreator)
			                     let name = EntityHelper.GetNameFromEntity(entity)
			                     orderby name
			                     select CreateTableExplorerItem(entity, name, adapter)
			                    ).ToList();

			// Create a lookup keying each element type to the properties of that type. This will allow
			// us to build hyperlink targets allowing the user to click between associations:
			var elementTypeLookup = topLevelProps.ToLookup(tp => tp.Tag.GetType());

			// Populate the columns (properties) of each entity:
			foreach (var table in topLevelProps)
			{
				var entity = (IEntityCore) table.Tag;
				table.Children.AddRange(EntityHelper.GetNavigatorProperties(entity).Select(navigatorProperty => CreateNavigatorExplorerItem(entity, navigatorProperty, elementTypeLookup)));
				table.Tag = null;
			}

			return topLevelProps;
		}

		private static DataAccessAdapterBase GetDataAccessAdapter(IConnectionInfo cxInfo, bool isAdapter)
		{
			if (isAdapter)
				try
				{
					return GetAdapter(cxInfo);
				}
				catch (Exception e)
				{
					GeneralHelper.TraceOut(e.Message);
				}
			return null;
		}

		private static ExplorerItem CreateTableExplorerItem(IEntityCore entity, string name, IDataAccessAdapter adapter)
		{
			var tableExplorerItem = new ExplorerItem(name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
			                        	{
			                        		IsEnumerable = true,
			                        		DragText = name,
			                        		// Store the entity to the Tag property. We'll use it later.
			                        		Tag = entity
			                        	};

			tableExplorerItem.Children = CreateFieldExplorerItems(tableExplorerItem, adapter);
			return tableExplorerItem;
		}

		private static List<ExplorerItem> CreateFieldExplorerItems(ExplorerItem explorerItem, IDataAccessAdapter adapter)
		{
			var entity = (IEntityCore) explorerItem.Tag;

			IFieldPersistenceInfo fieldPersistenceInfo = null;

			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(entity.GetType());
			var fieldExplorerItems = new List<ExplorerItem>();

			foreach (var field in entity.GetFields().Where(f => f.Name.Equals(f.Alias)))
			{
				fieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfo(field, adapter);
				fieldExplorerItems.Add(new ExplorerItem(CreateFieldText(field), ExplorerItemKind.Property, ExplorerIcon.Column)
				                       	{
				                       		DragText = field.Name,
				                       		//SqlName = fieldPersistenceInfo == null ? null : fieldPersistenceInfo.SourceColumnName,
				                       		//SqlTypeDeclaration = fieldPersistenceInfo == null ? null : fieldPersistenceInfo.SourceColumnDbType,
				                       		ToolTipText = CreateFieldToolTipText(entity, field, fieldPersistenceInfo, propertyDescriptors.First(pd => pd.Name == field.Name))
				                       	});
			}

			explorerItem.ToolTipText = CreateTableToolTipText(entity, fieldPersistenceInfo);
			return fieldExplorerItems;
		}
		
		private static ExplorerItem CreateNavigatorExplorerItem(IEntityCore entity, PropertyDescriptor navigatorProperty, ILookup<Type, ExplorerItem> elementTypeLookup)
		{
			var entityRelation = entity.GetRelationsForFieldOfType(navigatorProperty.Name)[0] as IEntityRelation;
			var elementType = MetaDataHelper.GetElementType(navigatorProperty.PropertyType);
			var hyperlinkTarget = elementTypeLookup[elementType].First();
			var explorerIcon = ExplorerIcon.OneToMany;
			if (entityRelation != null)
				explorerIcon = GetExplorerIcon(entityRelation.TypeOfRelation);
			var explorerItemKind = GetExplorerItemKind(explorerIcon);
			return new ExplorerItem(navigatorProperty.Name, explorerItemKind, explorerIcon)
			       	{
			       		DragText = navigatorProperty.Name,
			       		HyperlinkTarget = hyperlinkTarget,
			       		ToolTipText = CreateNavigatorToolTipText(entity, navigatorProperty, hyperlinkTarget),
			       	};
		}

		private static ExplorerItemKind GetExplorerItemKind(ExplorerIcon explorerIcon)
		{
			switch (explorerIcon)
			{
				case ExplorerIcon.Schema:
					break;
				case ExplorerIcon.Table:
					return ExplorerItemKind.QueryableObject;
				case ExplorerIcon.View:
					break;
				case ExplorerIcon.Column:
					return ExplorerItemKind.Property;
				case ExplorerIcon.Key:
					break;
				case ExplorerIcon.StoredProc:
					break;
				case ExplorerIcon.ScalarFunction:
					break;
				case ExplorerIcon.TableFunction:
					break;
				case ExplorerIcon.Parameter:
					break;
				case ExplorerIcon.ManyToOne:
				case ExplorerIcon.OneToOne:
					return ExplorerItemKind.ReferenceLink;
				case ExplorerIcon.OneToMany:
				case ExplorerIcon.ManyToMany:
					return ExplorerItemKind.CollectionLink;
				case ExplorerIcon.Inherited:
					break;
				case ExplorerIcon.LinkedDatabase:
					break;
				case ExplorerIcon.Box:
					break;
				default:
					throw new ArgumentOutOfRangeException("explorerIcon");
			}
			return ExplorerItemKind.CollectionLink;
		}

		private static ExplorerIcon GetExplorerIcon(RelationType typeOfRelation)
		{
			switch (typeOfRelation)
			{
				case RelationType.OneToMany:
					return ExplorerIcon.OneToMany;
				case RelationType.OneToOne:
					return ExplorerIcon.OneToOne;
				case RelationType.ManyToOne:
					return ExplorerIcon.ManyToOne;
				case RelationType.ManyToMany:
					return ExplorerIcon.ManyToMany;
				default:
					throw new ArgumentOutOfRangeException("typeOfRelation");
			}
		}

		private static string CreateFieldText(IFieldInfo field)
		{
			return field.Name + " (" + FormatTypeName(field.DataType, false) + ")";
		}

		private static string CreateTableToolTipText(IEntityCore entity, IFieldPersistenceInfo fieldPersistenceInfo)
		{
			var type = entity.GetType();
			var tableToolTipText = GeneralHelper.Join(FormatTypeName(type, false), entity.CustomPropertiesOfType.Values.JoinAsString(),
				MetaDataHelper.GetDisplayNameAttributes(type).Select(da => da.DisplayName).JoinAsString(), 
				MetaDataHelper.GetDescriptionAttributes(type).Select(da => da.Description).JoinAsString());
			return fieldPersistenceInfo == null
			       	? tableToolTipText
							: GeneralHelper.Join(tableToolTipText, fieldPersistenceInfo.SourceObjectName, fieldPersistenceInfo.SourceSchemaName, fieldPersistenceInfo.SourceCatalogName);
		}

		private static string CreateNavigatorToolTipText(IEntityCore entity, PropertyDescriptor navigatorProperty, ExplorerItem hyperlinkTarget)
		{
			return GeneralHelper.Join(navigatorProperty.DisplayName, FormatTypeName(navigatorProperty.PropertyType, false), navigatorProperty.Description, GetFieldsCustomProperties(entity, navigatorProperty.Name).JoinAsString(), hyperlinkTarget.ToolTipText);
		}

		private static string CreateFieldToolTipText(IEntityCore entity, IFieldInfo field, IFieldPersistenceInfo fieldPersistenceInfo, MemberDescriptor propertyDescriptor)
		{
			if (fieldPersistenceInfo == null) return GeneralHelper.Join(GetFieldsCustomProperties(entity, field.Name).JoinAsString(), propertyDescriptor.DisplayName, propertyDescriptor.Description);
			return GeneralHelper.Join(GetFieldsCustomProperties(entity, field.Name).JoinAsString(), propertyDescriptor.DisplayName, propertyDescriptor.Description
			                          , fieldPersistenceInfo.SourceColumnName, fieldPersistenceInfo.SourceColumnDbType, fieldPersistenceInfo.SourceColumnMaxLength.ToString());
		}

		private static IEnumerable<string> GetFieldsCustomProperties(IEntityCore entity, string key)
		{
			if (entity.FieldsCustomPropertiesOfType.ContainsKey(key))
				return entity.FieldsCustomPropertiesOfType[key].Values;
			return Enumerable.Empty<string>();
		}

		private static List<ExplorerItem> GetSchemaByReflection(IConnectionInfo cxInfo, Type customType)
		{
			List<ExplorerItem> topLevelProps;
			if (typeof (IElementCreatorCore).IsAssignableFrom(customType))
			{
				topLevelProps = (from type in EntityHelper.GetEntitiesTypes(customType.Assembly)
				                	let name = type.Name.Replace("Entity", "")
				                	orderby name
				                	select new ExplorerItem(name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
				                	       	{
				                	       		IsEnumerable = true,
				                	       		ToolTipText = FormatTypeName(type, false),
				                	       		// + entity.CustomPropertiesOfType.Values.JoinAsString(),
				                	       		DragText = name,
				                	       		// Store the entity type to the Tag property. We'll use it later.
				                	       		Tag = type
				                	       	}
				                ).ToList();
			}
			else
				topLevelProps = (from prop in MetaDataHelper.GetPropertyDescriptors(customType)
				                	let elementType = MetaDataHelper.GetElementType(prop.PropertyType)
				                	where typeof (IEntityCore).IsAssignableFrom(elementType)
				                	orderby prop.Name
				                	select new ExplorerItem(prop.Name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
				                	       	{
				                	       		IsEnumerable = true,
				                	       		ToolTipText = GeneralHelper.Join(FormatTypeName(prop.PropertyType, false), prop.DisplayName, prop.Description),
				                	       		DragText = prop.Name,
				                	       		// Store the entity type to the Tag property. We'll use it later.
				                	       		Tag = elementType
				                	       	}
				                ).ToList();

			// Create a lookup keying each element type to the properties of that type. This will allow
			// us to build hyperlink targets allowing the user to click between associations:
			var elementTypeLookup = topLevelProps.ToLookup(tp => (Type) tp.Tag);

			// Populate the columns (properties) of each entity:
			foreach (var table in topLevelProps)
				table.Children = CreateFieldExplorerItems(GetPropertiesToShowInSchema((Type) table.Tag), elementTypeLookup);

			return topLevelProps;
		}

		private static List<ExplorerItem> CreateFieldExplorerItems(IEnumerable<PropertyDescriptor> fieldsToShowInSchema, ILookup<Type, ExplorerItem> elementTypeLookup)
		{
			if (fieldsToShowInSchema != null)
				return fieldsToShowInSchema
					.Select(childProp => GetChildItem(elementTypeLookup, childProp))
					.OrderBy(childItem => childItem.Kind)
					.ToList();
			return null;
		}

		/// <summary>
		/// 	Gets the properties to show in schema. 
		/// 	They should be all the browsable properties with the addition of self servicing entity properties.
		/// </summary>
		/// <remarks>
		/// 	See MetaDataHelper.GetPropertiesToDisplay
		/// </remarks>
		/// <param name = "type">The type.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesToShowInSchema(Type type)
		{
			return ListBindingHelper.GetListItemProperties(type).Cast<PropertyDescriptor>().Union(EntityHelper.GetPropertiesOfTypeEntity(type));
		}

		private static ExplorerItem GetChildItem(ILookup<Type, ExplorerItem> elementTypeLookup, PropertyDescriptor childProp)
		{
			// If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
			// We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
			var explorerItem = CreateEntityExplorerItem(childProp, elementTypeLookup, childProp.PropertyType, ExplorerItemKind.ReferenceLink, ExplorerIcon.ManyToOne);
			if (explorerItem == null)
			{
				// Is the property's type a collection of entities?
				var elementType = MetaDataHelper.GetElementType(childProp.PropertyType);
				if (elementType != childProp.PropertyType)
					explorerItem = CreateEntityExplorerItem(childProp, elementTypeLookup, elementType, ExplorerItemKind.CollectionLink, ExplorerIcon.OneToMany);
			}

			if (explorerItem == null)
				// Ordinary property:
				return new ExplorerItem(childProp.Name + " (" + FormatTypeName(childProp.PropertyType, false) + ")",
				                        ExplorerItemKind.Property, ExplorerIcon.Column)
				       	{
				       		DragText = childProp.Name,
				       		ToolTipText = GeneralHelper.Join(childProp.DisplayName, childProp.Description),
				       	};
			return explorerItem;
		}

		private static ExplorerItem CreateEntityExplorerItem(MemberDescriptor childProp, ILookup<Type, ExplorerItem> elementTypeLookup, Type elementType, ExplorerItemKind kind, ExplorerIcon icon)
		{
			return elementTypeLookup.Contains(elementType)
			       	? CreateEntityExplorerItem2(childProp, elementTypeLookup, elementType, kind, icon)
			       	: null;
		}

		private static ExplorerItem CreateEntityExplorerItem2(MemberDescriptor childProp, ILookup<Type, ExplorerItem> elementTypeLookup, Type elementType, ExplorerItemKind kind, ExplorerIcon icon)
		{
			return new ExplorerItem(childProp.Name, kind, icon)
			       	{
			       		HyperlinkTarget = elementTypeLookup[elementType].First(),
			       		ToolTipText = GeneralHelper.Join(FormatTypeName(elementType, true), childProp.DisplayName, childProp.Description),
			       		DragText = childProp.Name
			       	};
		}
	}

	#endregion
}