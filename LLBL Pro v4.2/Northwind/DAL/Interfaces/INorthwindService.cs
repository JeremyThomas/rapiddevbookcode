using System.ServiceModel;
using Northwind.DAL.DTO;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Interfaces
{
    /// <summary>
    /// Service interface which is implemented by our service and which is utilized by the client so we don't have to
    /// reference the service assembly in the client to know the API specifics of the service.
  /// This service uses a ServiceContract so WCF knows what's offered by the service and which types are offered. We don't use generic types
  /// as webservices and WCF use XML and generic types serialized into XML isn't possible because the deserialization framework in WCF doesn't know
  /// to which type to deserialize the data to.
  /// From https://github.com/SolutionsDesign/LLBLGenProExamples_4.x/
    /// </summary>
    [ServiceContract()]
    [ServiceKnownType(typeof(CustomerEntity))]
    [ServiceKnownType(typeof(OrderEntity))]
    [ServiceKnownType(typeof(EntityCollection))]
  [ServiceKnownType(typeof(EntityField2))]
  [ServiceKnownType(typeof(UnitOfWork2))]
    public interface INorthwindService
    {
    /// <summary>
    /// Gets the statistics for the start screen.
    /// </summary>
    /// <returns>filled NWStatistics object</returns>
    [OperationContract]
    NWStatistics GetStatistics();
        /// <summary>
        /// Gets all customer entities
        /// </summary>
        /// <returns>entity collection with all customers</returns>
        [OperationContract]
        IEntityCollection2 GetAllCustomers();
        /// <summary>
        /// Gets all customers who have bought the product with the product id specified.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>an entity collection with 0 or more customers who have purchased the product with the id specified</returns>
        [OperationContract]
        IEntityCollection2 GetAllCustomersFilteredOnProduct(int productId);
    /// <summary>
    /// Gets a collection of Products sorted by the passed in field, and direction of sort.
    /// </summary>
    /// <param name="sortField">The sort field.</param>
    /// <param name="direction">direction of sort</param>
    /// <returns>a sorted products collection</returns>
    /// <remarks>Shows how to use message parameters to specify sorting.
    /// </remarks>
        [OperationContract]
        IEntityCollection2 GetProductsSortedBy(EntityField2 sortField, SortOperator direction);
        /// <summary>
        /// Gets the numer of times product was sold.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>the number of times the product was sold.</returns>
        [OperationContract]
        int GetNumerOfTimesProductWasSold(int productId);
        /// <summary>
        /// Gets the customer entity + orders + order details for the customer of the customer id passed in.
        /// </summary>
        /// <param name="customerId">The customer id.</param>
        /// <returns>Customer entity with its order entities + order details entities per order for the customer passed in.</returns>
        [OperationContract]
        CustomerEntity GetCustomerWithFullOrders(string customerId);
    /// <summary>
    /// Commits the customer manager changes specified in the unit of work passed in.
    /// </summary>
    /// <param name="uow">The unit of work with the work to commit.</param>
    /// <returns>true if commit succeeded, false otherwise</returns>
    [OperationContract]
    bool CommitCustomerManagerChanges(UnitOfWork2 uow);
    }
}
