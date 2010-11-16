using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
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
		private static readonly string[] AdditionalAssemblies = new[]
		                                                        	{
		                                                        		"AW.Helper.dll",
		                                                        		"SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll",
		                                                        		"SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll",
		                                                        		"AW.Helper.LLBL.dll", "System.Windows.Forms.dll",
		                                                        		"AW.Winforms.Helpers.dll", "AW.Winforms.Helpers.LLBL.dll"
		                                                        	};

		private static readonly string[] AdditionalNamespaces = new[]
		                                                        	{
		                                                        		"SD.LLBLGen.Pro.ORMSupportClasses", "AW.Helper",
		                                                        		"AW.Helper.LLBL",
		                                                        		"AW.Winforms.Helpers.DataEditor",
		                                                        		"AW.Winforms.Helpers.LLBL"
		                                                        	};

		#region Overrides of DataContextDriver

		public override string Name
		{
			get { return "AW LLBL V3.0 Driver"; }
		}

		public override string Author
		{
			get { return "Jeremy Thomas"; }
		}

		public override string GetConnectionDescription(IConnectionInfo cxInfo)
		{
			// For static drivers, we can use the description of the custom type & its assembly:
			return new[] {cxInfo.CustomTypeInfo.CustomTypeName, cxInfo.DatabaseInfo.GetDatabaseDescription(), cxInfo.AppConfigPath}.JoinAsString(" - ");
		}

		public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			// Prompt the user for a custom assembly and type name:
			return new ConnectionDialog(cxInfo, isNewConnection).ShowDialog() == true;
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
			var adapterTypeName = ConnectionDialog.GetAdapterType(cxInfo);
			if (string.IsNullOrEmpty(adapterTypeName))
				throw new ApplicationException("CommonDaoBase or adapter not found!");
			if (!File.Exists(cxInfo.CustomTypeInfo.CustomMetadataPath))
				throw new ApplicationException("Adapter assembly: " + cxInfo.CustomTypeInfo.CustomMetadataPath + " not found!");
			var dataAccessAdapterAssembly = Assembly.LoadFile(cxInfo.CustomTypeInfo.CustomMetadataPath);
			if (dataAccessAdapterAssembly == null)
				throw new ApplicationException("Adapter assembly: " + cxInfo.CustomTypeInfo.CustomMetadataPath + " could not be loaded!");
			var dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
			if (dataAccessAdapterType == null)
				throw new ApplicationException(string.Format("Adapter type: {0} could not be loaded from: {1}!", adapterTypeName, cxInfo.CustomTypeInfo.CustomMetadataPath));
			var linqMetaData = context as ILinqMetaData;
			if (linqMetaData != null)
			{
				var adapterToUseProperty = linqMetaData.GetType().GetProperty("AdapterToUse");
				DataAccessAdapterBase adapter;

				if (typeof (DataAccessAdapterBase).IsAssignableFrom(dataAccessAdapterType))
				{
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
							if (cxInfo.DatabaseInfo.Provider.Contains("Oracle"))
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
					var fullListQueryMethod = dataAccessAdapterType.GetMethod(cxInfo.DatabaseInfo.Provider, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new[] {typeof (string)}, null);
					if (fullListQueryMethod == null)
					{
						GeneralHelper.TraceOut(cxInfo.DatabaseInfo.Provider + " not found");
						adapter = null;
					}
					else
						try
						{
							adapter = fullListQueryMethod.Invoke(null, BindingFlags.InvokeMethod, null, new object[] {cxInfo.DatabaseInfo.CustomCxString}, null) as DataAccessAdapterBase;
						}
						catch (TargetInvocationException invocationException)
						{
							ThrowInnerException(invocationException);
							throw;
						}
				}

				if (adapter != null)
				{
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

		private static void ThrowInnerException(Exception invocationException)
		{
			if (invocationException.InnerException != null)
				ThrowInnerException(invocationException.InnerException);
			throw invocationException;
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

		public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
		{
			// Return the objects with which to populate the Schema Explorer by reflecting over customType.

			// We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
			var topLevelProps =
				(
					from prop in customType.GetProperties()
					where prop.PropertyType != typeof (string)
					// Display all properties of type IEnumerable<T> (except for string!)
					let ienumerableOfT = prop.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1")
					where ienumerableOfT != null
					orderby prop.Name
					select new ExplorerItem(prop.Name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
					       	{
					       		IsEnumerable = true,
					       		ToolTipText = FormatTypeName(prop.PropertyType, false),
					       		// Store the entity type to the Tag property. We'll use it later.
					       		Tag = ienumerableOfT.GetGenericArguments()[0]
					       	}
				).ToList();

			// Create a lookup keying each element type to the properties of that type. This will allow
			// us to build hyperlink targets allowing the user to click between associations:
			var elementTypeLookup = topLevelProps.ToLookup(tp => (Type) tp.Tag);

			// Populate the columns (properties) of each entity:
			foreach (var table in topLevelProps)
				table.Children = GetPropertiesToShowInSchema((Type) table.Tag)
					.Select(childProp => GetChildItem(elementTypeLookup, childProp))
					.OrderBy(childItem => childItem.Kind)
					.ToList();

			return topLevelProps;
		}

		public override IEnumerable<string> GetAssembliesToAdd()
		{
			return Settings.Default.AdditionalAssemblies == null ? AdditionalAssemblies : AdditionalAssemblies.Union(Settings.Default.AdditionalAssemblies.Cast<string>());
		}

		public override IEnumerable<string> GetNamespacesToAdd()
		{
			return Settings.Default.AdditionalNamespaces == null ? AdditionalNamespaces : AdditionalNamespaces.Union(Settings.Default.AdditionalNamespaces.Cast<string>());
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

		#endregion

		/// <summary>
		/// 	Gets the properties to show in schema. 
		/// 	They should be all the browsable properties with the addition of selfservicing entity properties.
		/// </summary>
		/// <remarks>
		/// 	See MetaDataHelper.GetPropertiesToDisplay
		/// </remarks>
		/// <param name = "type">The type.</param>
		/// <returns></returns>
		private static IEnumerable<PropertyDescriptor> GetPropertiesToShowInSchema(Type type)
		{
			return ListBindingHelper.GetListItemProperties(type).Cast<PropertyDescriptor>().Union(GetPropertiesOfTypeEntity(type));
		}

		/// <summary>
		/// 	Gets the properties of type entity since these properties are not browsable so they need to be handled as a special case.
		/// </summary>
		/// <param name = "type">The type.</param>
		/// <returns></returns>
		private static IEnumerable<PropertyDescriptor> GetPropertiesOfTypeEntity(Type type)
		{
			return from propertyDescriptor in TypeDescriptor.GetProperties(type, null).Cast<PropertyDescriptor>()
			       where typeof (IEntityCore).IsAssignableFrom(propertyDescriptor.PropertyType)
			       select propertyDescriptor;
		}

		private static ExplorerItem GetChildItem(ILookup<Type, ExplorerItem> elementTypeLookup, PropertyDescriptor childProp)
		{
			// If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
			// We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
			if (elementTypeLookup.Contains(childProp.PropertyType))
				return new ExplorerItem(childProp.Name, ExplorerItemKind.ReferenceLink, ExplorerIcon.ManyToOne)
				       	{
				       		HyperlinkTarget = elementTypeLookup[childProp.PropertyType].First(),
				       		// FormatTypeName is a helper method that returns a nicely formatted type name.
				       		ToolTipText = FormatTypeName(childProp.PropertyType, true)
				       	};

			// Is the property's type a collection of entities?
			var ienumerableOfT = childProp.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1");
			if (ienumerableOfT != null)
			{
				var elementType = ienumerableOfT.GetGenericArguments()[0];
				if (elementTypeLookup.Contains(elementType))
					return new ExplorerItem(childProp.Name, ExplorerItemKind.CollectionLink, ExplorerIcon.OneToMany)
					       	{
					       		HyperlinkTarget = elementTypeLookup[elementType].First(),
					       		ToolTipText = FormatTypeName(elementType, true)
					       	};
			}

			// Ordinary property:
			return new ExplorerItem(childProp.Name + " (" + FormatTypeName(childProp.PropertyType, false) + ")",
			                        ExplorerItemKind.Property, ExplorerIcon.Column);
		}
	}
}