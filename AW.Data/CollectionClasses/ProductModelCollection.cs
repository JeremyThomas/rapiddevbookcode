///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
#if !CF
using System.Runtime.Serialization;
#endif

using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.CollectionClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Collection class for storing and retrieving collections of ProductModelEntity objects. </summary>
	[Serializable]
	public partial class ProductModelCollection : EntityCollectionBase<ProductModelEntity>
	{
		/// <summary> CTor</summary>
		public ProductModelCollection():base(new ProductModelEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public ProductModelCollection(IEnumerable<ProductModelEntity> initialContents):base(new ProductModelEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductModelCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  Relation of type 'm:n' with the passed in IllustrationEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingIllustrations(IEntity illustrationInstance)
		{
			return GetMultiManyToManyUsingIllustrations(illustrationInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in IllustrationEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingIllustrations(IEntity illustrationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingIllustrations(illustrationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a Relation of type 'm:n' with the passed in IllustrationEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingIllustrations(IEntity illustrationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingIllustrations(illustrationInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in IllustrationEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingIllustrations(IEntity illustrationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingIllustrations(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, illustrationInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in IllustrationEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingIllustrations(IEntity illustrationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingIllustrations(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, illustrationInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductDescriptionEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDescriptions(IEntity productDescriptionInstance)
		{
			return GetMultiManyToManyUsingDescriptions(productDescriptionInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductDescriptionEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDescriptions(IEntity productDescriptionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDescriptions(productDescriptionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a Relation of type 'm:n' with the passed in ProductDescriptionEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDescriptions(IEntity productDescriptionInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDescriptions(productDescriptionInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductDescriptionEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingDescriptions(IEntity productDescriptionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingDescriptions(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productDescriptionInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductDescriptionEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDescriptions(IEntity productDescriptionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingDescriptions(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productDescriptionInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductSubcategoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSubcategories(IEntity productSubcategoryInstance)
		{
			return GetMultiManyToManyUsingSubcategories(productSubcategoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSubcategories(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSubcategories(productSubcategoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a Relation of type 'm:n' with the passed in ProductSubcategoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSubcategories(IEntity productSubcategoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSubcategories(productSubcategoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSubcategories(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingSubcategories(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productSubcategoryInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductModelCollection object all ProductModelEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSubcategories(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductModelDAO().GetMultiUsingSubcategories(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productSubcategoryInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, null, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0);
		}
		
		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations, int pageNumber, int pageSize)
		{
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductModelFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductModelFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductModelFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductModelFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, groupByClause);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="relations">The relations to walk</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public virtual object GetScalar(ProductModelFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
		{
			EntityFields fields = new EntityFields(1);
			fields[0] = EntityFieldFactory.Create(fieldIndex);
			if((fields[0].ExpressionToApply == null) || (expressionToExecute != null))
			{
				fields[0].ExpressionToApply = expressionToExecute;
			}
			if((fields[0].AggregateFunctionToApply == AggregateFunction.None) || (aggregateToApply != AggregateFunction.None))
			{
				fields[0].AggregateFunctionToApply = aggregateToApply;
			}
			return DAOFactory.CreateProductModelDAO().GetScalar(fields, this.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductModelDAO();
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
