////////////////////////////////////////////////////////////////////////////////////////////////////////
// LLBLGen Pro is (c) 2002-2008 Solutions Design. All rights reserved.
// http://www.llblgen.com
// The sourcecode for the Dynamic Data Support classes has been made available to LLBLGen Pro licensees
// so they can modify, update and/or extend it. Distribution of this sourcecode in textual, non-compiled, 
// non-binary form to non-licensees is prohibited. Distribution of binary compiled versions of this 
// sourcecode to non-licensees has been granted under the following license.
////////////////////////////////////////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2002-2008 Solutions Design. All rights reserved.
// http://www.llblgen.com
// 
// The Dynamic Data Support classes library sourcecode is released to LLBLGen Pro licensees under the 
// following license:
// --------------------------------------------------------------------------------------------
// 
// Redistribution and use of the sourcecode in compiled, binary forms, with or without modification, 
// are permitted provided that the following conditions are met: 
//
// 1) Redistributions must reproduce the above copyright notice, this list of 
//    conditions and the following disclaimer in the documentation and/or other materials 
//    provided with the distribution. 
// 2) Redistribution of the sourcecode in textual, non-binary, non-compiled form is prohibited.
// 
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
//
// The views and conclusions contained in the software and documentation are those of the authors 
// and should not be interpreted as representing official policies, either expressed or implied, 
// of Solutions Design. 
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
//		- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.DynamicData.ModelProviders;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;

using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

using LinqExpression = System.Linq.Expressions.Expression;
using LLBLExpression = SD.LLBLGen.Pro.ORMSupportClasses.Expression;
using System.Linq.Expressions;

namespace SD.LLBLGen.Pro.DynamicDataSupportClasses
{
	/// <summary>
	/// Class which provides meta model information about a table (entity) in DynamicData
	/// </summary>
	public class LLBLGenProEntityProvider : TableProvider
	{
		#region Class Member Declarations
		private IEntityFactoryCore _entityFactory;
		private ReadOnlyCollection<ColumnProvider> _entityFieldProviders;
		private Dictionary<string, LLBLGenProEntityFieldProvider> _fieldNameToEntityFieldProvider;
		private ILinqMetaData _linqMetaData;
		#endregion


		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProEntityProvider"/> class.
		/// </summary>
		/// <param name="dataModelProvider">The data model provider.</param>
		/// <param name="entityFactory">The entity factory.</param>
		/// <param name="linqMetaData">The linq meta data.</param>
		public LLBLGenProEntityProvider(LLBLGenProDataModelProvider dataModelProvider, IEntityFactoryCore entityFactory, ILinqMetaData linqMetaData)
			: base(dataModelProvider)
		{
			_entityFactory = entityFactory;
			_linqMetaData = linqMetaData;
			_fieldNameToEntityFieldProvider = new Dictionary<string, LLBLGenProEntityFieldProvider>();
			this.EntityType = _entityFactory.Create().GetType();
			this.Name = _entityFactory.ForEntityName;
			BuildEntityFieldProviderListFields();
		}


		/// <summary>
		/// Gets the queryable to fetch all instances of the entity represented by this provider.
		/// </summary>
		/// <param name="context">The context. Ignored</param>
		/// <returns>the queryable to fetch all instances of the entity represented by this provider</returns>
		public override IQueryable GetQuery(object context)
		{
			IEntityCore dummy = _entityFactory.Create();
			Dictionary<string, IEntityFieldCore> fieldsPerName = new Dictionary<string,IEntityFieldCore>();
			foreach(IEntityFieldCore field in dummy.Fields)
			{
				fieldsPerName.Add(field.Name, field);
			}

			ILLBLGenProQuery queryToReturn = (ILLBLGenProQuery)_linqMetaData.GetQueryableForEntity(dummy.LLBLGenProEntityTypeValue);
			if(_entityFactory is IEntityFactory2)
			{
				// set the adapter per query, as this is a multi-threaded environment.
				((LLBLGenProProvider2)queryToReturn.Provider).AdapterToUse = (IDataAccessAdapter)Activator.CreateInstance(
											((LLBLGenProDataModelProvider)this.DataModel).AdapterType);
			}

			HashSet<string> fieldNamesToExclude = new HashSet<string>();

			// exclude fields which have a huge size, as those aren't showing up in the filters anyway. 
			foreach(KeyValuePair<string, LLBLGenProEntityFieldProvider> pair in _fieldNameToEntityFieldProvider)
			{
				if((pair.Value.ColumnType == typeof(string)) || (pair.Value.ColumnType.IsArray))
				{
					// check if size exceeds 10KB
					if(pair.Value.MaxLength > (10 * 1024))
					{
						// exclude this field
						fieldNamesToExclude.Add(pair.Key);
					}
				}
			}

			IQueryable toReturn = queryToReturn;
			if(fieldNamesToExclude.Count > 0)
			{
				// exclude these fields. Do this by adding an expression object which is a methodcall to ExcludeFields which is an 
				// extension method to IQueryable<T>. 
				MethodInfo excludeFieldsMethod = typeof(QueryableExtensionMethods).GetMethod("ExcludeFields", BindingFlags.Static | BindingFlags.Public);
				if(excludeFieldsMethod != null)
				{
					Type funcType = typeof(Func<,>).MakeGenericType(dummy.GetType(), typeof(object));
					Type expressionArrayType = typeof(Expression<>).MakeGenericType(funcType);
					List<LinqExpression> expressionArguments = new List<LinqExpression>();
					PropertyInfo[] properties = dummy.GetType().GetProperties();
					foreach(PropertyInfo property in properties)
					{
						if(!fieldNamesToExclude.Contains(property.Name))
						{
							continue;
						}
						ParameterExpression parameter = LinqExpression.Parameter(dummy.GetType(), "p");
						expressionArguments.Add(LinqExpression.Lambda(
											LinqExpression.Convert(LinqExpression.MakeMemberAccess(parameter, property), typeof(object)),
											parameter));
					}
					Array argumentsArray = Array.CreateInstance(expressionArrayType, expressionArguments.Count);
					for(int i = 0; i < expressionArguments.Count; i++)
					{
						argumentsArray.SetValue(expressionArguments[i], i);
					}
					Type queryType = typeof(LLBLGenProQuery<>).MakeGenericType(dummy.GetType());
					excludeFieldsMethod = excludeFieldsMethod.MakeGenericMethod(dummy.GetType());
					toReturn = (IQueryable)excludeFieldsMethod.Invoke(null,
							new object[] { 
								queryToReturn,
								(object[])argumentsArray});
				}
			}
			return toReturn;
		}


		/// <summary>
		/// Builds the entity field provider list for associations and custom properties.
		/// </summary>
		internal void BuildEntityFieldProviderListAssociationsProperties()
		{
			List<ColumnProvider> entityFieldProviders = new List<ColumnProvider>(_entityFieldProviders);
			IEntityCore dummy = _entityFactory.Create();
			HashSet<string> namesAdded = new HashSet<string>();
			foreach(ColumnProvider provider in entityFieldProviders)
			{
				namesAdded.Add(provider.Name);
			}

			PropertyDescriptorCollection propertyDescriptors = TypeDescriptor.GetProperties(dummy);
			Dictionary<string, PropertyDescriptor> unusedPropertyDescriptorPerName = new Dictionary<string,PropertyDescriptor>();
			foreach(PropertyDescriptor descriptor in propertyDescriptors)
			{
				if(namesAdded.Contains(descriptor.Name) || (!descriptor.IsBrowsable && !typeof(IEntityCore).IsAssignableFrom(descriptor.PropertyType)))
				{
					continue;
				}
				unusedPropertyDescriptorPerName.Add(descriptor.Name, descriptor);
			}

			// relations 
			List<IEntityRelation> allRelations = dummy.GetAllRelations();
			foreach(IEntityRelation relation in allRelations)
			{
				if((relation.TypeOfRelation == RelationType.ManyToMany) || (relation.TypeOfRelation==RelationType.OneToOne) || 
						relation.IsHierarchyRelation)
				{
					// DynamicData doesn't support m:n or 1:1
					continue;
				}
				PropertyDescriptor descriptor = null;
				if(!unusedPropertyDescriptorPerName.TryGetValue(relation.MappedFieldName, out descriptor))
				{
					// hidden mapped field.
					continue;
				}
				IEntityRelation oppositeRelation = FindOppositeRelation(relation);
				if(oppositeRelation == null)
				{
					// opposite is hidden, ignore this one
					continue;
				}
				LLBLGenProEntityRelationProvider relationProvider = new LLBLGenProEntityRelationProvider(this, relation, oppositeRelation, descriptor);
				bool isOptional = false;
				if(relation.TypeOfRelation==RelationType.ManyToOne)
				{
					isOptional = relation.GetFKEntityFieldCore(0).IsNullable;
				}
				LLBLGenProEntityFieldProvider toAdd = new LLBLGenProEntityFieldProvider(this, descriptor.PropertyType, false, false, false, false, 0, 
						descriptor.Name, isOptional, relationProvider);
				entityFieldProviders.Add(toAdd);
				_fieldNameToEntityFieldProvider.Add(toAdd.Name, toAdd);
				namesAdded.Add(toAdd.Name);
			}

			// custom properties
#warning TODO: add custom property handling code as well. 

			_entityFieldProviders = new ReadOnlyCollection<ColumnProvider>(entityFieldProviders);
		}


		/// <summary>
		/// Finds the opposite relation of the relation specified
		/// </summary>
		/// <param name="relation">The relation.</param>
		/// <returns>the opposite relation of the relation specified or null if none found.</returns>
		private IEntityRelation FindOppositeRelation(IEntityRelation relation)
		{
			LLBLGenProDataModelProvider modelProvider = (LLBLGenProDataModelProvider)this.DataModel;
			string oppositeEntityName = string.Empty;
			if(relation.StartEntityIsPkSide)
			{
				oppositeEntityName = relation.GetFKEntityFieldCore(0).ActualContainingObjectName;
			}
			else
			{
				oppositeEntityName = relation.GetPKEntityFieldCore(0).ActualContainingObjectName;
			}
			
			IEntityRelation toReturn = null;
			LLBLGenProEntityProvider oppositeEntityProvider = null;
			if(!modelProvider.EntityNameToEntityProvider.TryGetValue(oppositeEntityName, out oppositeEntityProvider))
			{
				return null;
			}

			List<IEntityRelation> oppositeRelations = oppositeEntityProvider.EntityFactoryToUse.Create().GetAllRelations();
			// traverse fields. They should be equal
			List<IEntityFieldCore> fkFieldsRelation = relation.GetAllFKEntityFieldCoreObjects();
			List<IEntityFieldCore> pkFieldsRelation = relation.GetAllPKEntityFieldCoreObjects();
			foreach(IEntityRelation candidate in oppositeRelations)
			{
				// compare type of relation. if types aren't opposites, candidate isn't the one we're looking for. 
				switch(relation.TypeOfRelation)
				{
					case RelationType.ManyToOne:
						if(candidate.TypeOfRelation!=RelationType.OneToMany)
						{
							continue;
						}
						break;
					case RelationType.OneToMany:
						if(candidate.TypeOfRelation!=RelationType.ManyToOne)
						{
							continue;
						}
						break;
					// others aren't supported in DynamicData.
				}

				List<IEntityFieldCore> fkFieldsCandidate = candidate.GetAllFKEntityFieldCoreObjects();
				List<IEntityFieldCore> pkFieldsCandidate = candidate.GetAllPKEntityFieldCoreObjects();
				// compare pk fields of candidate with pk fields of relation and vice versa. 
				if((fkFieldsCandidate.Count != fkFieldsRelation.Count) || (pkFieldsCandidate.Count != pkFieldsRelation.Count))
				{
					// # of field don't match
					continue;
				}
				bool areEqual = true;
				for(int i = 0; i < fkFieldsRelation.Count; i++)
				{
					if(((IComparable)fkFieldsRelation[i]).CompareTo(fkFieldsCandidate[i]) != 0)
					{
						// already not equal.
						areEqual = false;
						break;
					}
				}
				if(!areEqual)
				{
					continue;
				}
				for(int i = 0; i < pkFieldsRelation.Count; i++)
				{
					if(((IComparable)pkFieldsRelation[i]).CompareTo(pkFieldsCandidate[i]) != 0)
					{
						// already not equal.
						areEqual = false;
						break;
					}
				}
				if(areEqual)
				{
					// found opposite
					toReturn = candidate;
					break;
				}
			}

			return toReturn;
		}


		/// <summary>
		/// Builds the entity field provider list.
		/// </summary>
		private void BuildEntityFieldProviderListFields()
		{
			List<ColumnProvider> entityFieldProviders = new List<ColumnProvider>();
			IEntityCore dummy = _entityFactory.Create();

			foreach(IEntityFieldCore field in dummy.Fields)
			{
				if(_fieldNameToEntityFieldProvider.ContainsKey(field.Name))
				{
					continue;
				}
				LLBLGenProEntityFieldProvider toAdd = new LLBLGenProEntityFieldProvider(this, field.DataType, false, field.IsForeignKey, 
															(field.IsPrimaryKey && (field.ActualContainingObjectName==field.ContainingObjectName)), 
																field.IsReadOnly, field.MaxLength, field.Name, field.IsNullable, null);
				entityFieldProviders.Add(toAdd);
				_fieldNameToEntityFieldProvider[field.Name]= toAdd;
			}

			_entityFieldProviders = new ReadOnlyCollection<ColumnProvider>(entityFieldProviders);
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets the entity factory to use.
		/// </summary>
		internal IEntityFactoryCore EntityFactoryToUse
		{
			get { return _entityFactory; }
		}

		/// <summary>
		/// Gets the field name to entity field provider list.
		/// </summary>
		internal Dictionary<string, LLBLGenProEntityFieldProvider> FieldNameToEntityFieldProvider
		{
			get { return _fieldNameToEntityFieldProvider; }
		}

		/// <summary>
		/// Gets the column providers for the fields of the entity (mapped on table / view fields or mapped onto relations)
		/// </summary>
		public override ReadOnlyCollection<ColumnProvider> Columns
		{
			get { return _entityFieldProviders; }
		}
		#endregion
	}
}
