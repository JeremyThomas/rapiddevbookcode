///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity base class which represents the base class for the entity 'Vendor'.<br/><br/>
	/// 
	/// MS_Description: Companies from whom Adventure Works Cycles purchases parts or other goods.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class VendorEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private AW.Data.CollectionClasses.PurchaseOrderHeaderCollection	_purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;
		private AW.Data.CollectionClasses.VendorAddressCollection	_vendorAddress;
		private bool	_alwaysFetchVendorAddress, _alreadyFetchedVendorAddress;
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaVendorAddress;
		private bool	_alwaysFetchAddressCollectionViaVendorAddress, _alreadyFetchedAddressCollectionViaVendorAddress;
		private AW.Data.CollectionClasses.AddressTypeCollection _addressTypeCollectionViaVendorAddress;
		private bool	_alwaysFetchAddressTypeCollectionViaVendorAddress, _alreadyFetchedAddressTypeCollectionViaVendorAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaVendorContact;
		private bool	_alwaysFetchContactCollectionViaVendorContact, _alreadyFetchedContactCollectionViaVendorContact;
		private AW.Data.CollectionClasses.ContactTypeCollection _contactTypeCollectionViaVendorContact;
		private bool	_alwaysFetchContactTypeCollectionViaVendorContact, _alreadyFetchedContactTypeCollectionViaVendorContact;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaPurchaseOrderHeader;
		private bool	_alwaysFetchEmployeeCollectionViaPurchaseOrderHeader, _alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaProductVendor;
		private bool	_alwaysFetchProductCollectionViaProductVendor, _alreadyFetchedProductCollectionViaProductVendor;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaPurchaseOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader, _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProductVendor;
		private bool	_alwaysFetchUnitMeasureCollectionViaProductVendor, _alreadyFetchedUnitMeasureCollectionViaProductVendor;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductVendor</summary>
			public static readonly string ProductVendor = "ProductVendor";
			/// <summary>Member name PurchaseOrderHeader</summary>
			public static readonly string PurchaseOrderHeader = "PurchaseOrderHeader";
			/// <summary>Member name VendorAddress</summary>
			public static readonly string VendorAddress = "VendorAddress";
			/// <summary>Member name VendorContact</summary>
			public static readonly string VendorContact = "VendorContact";
			/// <summary>Member name AddressCollectionViaVendorAddress</summary>
			public static readonly string AddressCollectionViaVendorAddress = "AddressCollectionViaVendorAddress";
			/// <summary>Member name AddressTypeCollectionViaVendorAddress</summary>
			public static readonly string AddressTypeCollectionViaVendorAddress = "AddressTypeCollectionViaVendorAddress";
			/// <summary>Member name ContactCollectionViaVendorContact</summary>
			public static readonly string ContactCollectionViaVendorContact = "ContactCollectionViaVendorContact";
			/// <summary>Member name ContactTypeCollectionViaVendorContact</summary>
			public static readonly string ContactTypeCollectionViaVendorContact = "ContactTypeCollectionViaVendorContact";
			/// <summary>Member name EmployeeCollectionViaPurchaseOrderHeader</summary>
			public static readonly string EmployeeCollectionViaPurchaseOrderHeader = "EmployeeCollectionViaPurchaseOrderHeader";
			/// <summary>Member name ProductCollectionViaProductVendor</summary>
			public static readonly string ProductCollectionViaProductVendor = "ProductCollectionViaProductVendor";
			/// <summary>Member name ShipMethodCollectionViaPurchaseOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaPurchaseOrderHeader = "ShipMethodCollectionViaPurchaseOrderHeader";
			/// <summary>Member name UnitMeasureCollectionViaProductVendor</summary>
			public static readonly string UnitMeasureCollectionViaProductVendor = "UnitMeasureCollectionViaProductVendor";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VendorEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public VendorEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		public VendorEntityBase(System.Int32 vendorID)
		{
			InitClassFetch(vendorID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public VendorEntityBase(System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(vendorID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntityBase(System.Int32 vendorID, IValidator validator)
		{
			InitClassFetch(vendorID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VendorEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productVendor = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendor", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");
			_purchaseOrderHeader = (AW.Data.CollectionClasses.PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeader", typeof(AW.Data.CollectionClasses.PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");
			_vendorAddress = (AW.Data.CollectionClasses.VendorAddressCollection)info.GetValue("_vendorAddress", typeof(AW.Data.CollectionClasses.VendorAddressCollection));
			_alwaysFetchVendorAddress = info.GetBoolean("_alwaysFetchVendorAddress");
			_alreadyFetchedVendorAddress = info.GetBoolean("_alreadyFetchedVendorAddress");
			_vendorContact = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContact", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");
			_addressCollectionViaVendorAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaVendorAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaVendorAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaVendorAddress");
			_alreadyFetchedAddressCollectionViaVendorAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaVendorAddress");
			_addressTypeCollectionViaVendorAddress = (AW.Data.CollectionClasses.AddressTypeCollection)info.GetValue("_addressTypeCollectionViaVendorAddress", typeof(AW.Data.CollectionClasses.AddressTypeCollection));
			_alwaysFetchAddressTypeCollectionViaVendorAddress = info.GetBoolean("_alwaysFetchAddressTypeCollectionViaVendorAddress");
			_alreadyFetchedAddressTypeCollectionViaVendorAddress = info.GetBoolean("_alreadyFetchedAddressTypeCollectionViaVendorAddress");
			_contactCollectionViaVendorContact = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaVendorContact = info.GetBoolean("_alwaysFetchContactCollectionViaVendorContact");
			_alreadyFetchedContactCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedContactCollectionViaVendorContact");
			_contactTypeCollectionViaVendorContact = (AW.Data.CollectionClasses.ContactTypeCollection)info.GetValue("_contactTypeCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.ContactTypeCollection));
			_alwaysFetchContactTypeCollectionViaVendorContact = info.GetBoolean("_alwaysFetchContactTypeCollectionViaVendorContact");
			_alreadyFetchedContactTypeCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedContactTypeCollectionViaVendorContact");
			_employeeCollectionViaPurchaseOrderHeader = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaPurchaseOrderHeader", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaPurchaseOrderHeader = info.GetBoolean("_alwaysFetchEmployeeCollectionViaPurchaseOrderHeader");
			_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader");
			_productCollectionViaProductVendor = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaProductVendor = info.GetBoolean("_alwaysFetchProductCollectionViaProductVendor");
			_alreadyFetchedProductCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedProductCollectionViaProductVendor");
			_shipMethodCollectionViaPurchaseOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaPurchaseOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader");
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader");
			_unitMeasureCollectionViaProductVendor = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProductVendor = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProductVendor");
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProductVendor");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((VendorFieldIndex)fieldIndex)
			{
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader.Count > 0);
			_alreadyFetchedVendorAddress = (_vendorAddress.Count > 0);
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedAddressCollectionViaVendorAddress = (_addressCollectionViaVendorAddress.Count > 0);
			_alreadyFetchedAddressTypeCollectionViaVendorAddress = (_addressTypeCollectionViaVendorAddress.Count > 0);
			_alreadyFetchedContactCollectionViaVendorContact = (_contactCollectionViaVendorContact.Count > 0);
			_alreadyFetchedContactTypeCollectionViaVendorContact = (_contactTypeCollectionViaVendorContact.Count > 0);
			_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = (_employeeCollectionViaPurchaseOrderHeader.Count > 0);
			_alreadyFetchedProductCollectionViaProductVendor = (_productCollectionViaProductVendor.Count > 0);
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = (_shipMethodCollectionViaPurchaseOrderHeader.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = (_unitMeasureCollectionViaProductVendor.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return VendorEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductVendor":
					toReturn.Add(VendorEntity.Relations.ProductVendorEntityUsingVendorID);
					break;
				case "PurchaseOrderHeader":
					toReturn.Add(VendorEntity.Relations.PurchaseOrderHeaderEntityUsingVendorID);
					break;
				case "VendorAddress":
					toReturn.Add(VendorEntity.Relations.VendorAddressEntityUsingVendorID);
					break;
				case "VendorContact":
					toReturn.Add(VendorEntity.Relations.VendorContactEntityUsingVendorID);
					break;
				case "AddressCollectionViaVendorAddress":
					toReturn.Add(VendorEntity.Relations.VendorAddressEntityUsingVendorID, "VendorEntity__", "VendorAddress_", JoinHint.None);
					toReturn.Add(VendorAddressEntity.Relations.AddressEntityUsingAddressID, "VendorAddress_", string.Empty, JoinHint.None);
					break;
				case "AddressTypeCollectionViaVendorAddress":
					toReturn.Add(VendorEntity.Relations.VendorAddressEntityUsingVendorID, "VendorEntity__", "VendorAddress_", JoinHint.None);
					toReturn.Add(VendorAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID, "VendorAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaVendorContact":
					toReturn.Add(VendorEntity.Relations.VendorContactEntityUsingVendorID, "VendorEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.ContactEntityUsingContactID, "VendorContact_", string.Empty, JoinHint.None);
					break;
				case "ContactTypeCollectionViaVendorContact":
					toReturn.Add(VendorEntity.Relations.VendorContactEntityUsingVendorID, "VendorEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.ContactTypeEntityUsingContactTypeID, "VendorContact_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaPurchaseOrderHeader":
					toReturn.Add(VendorEntity.Relations.PurchaseOrderHeaderEntityUsingVendorID, "VendorEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaProductVendor":
					toReturn.Add(VendorEntity.Relations.ProductVendorEntityUsingVendorID, "VendorEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.ProductEntityUsingProductID, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaPurchaseOrderHeader":
					toReturn.Add(VendorEntity.Relations.PurchaseOrderHeaderEntityUsingVendorID, "VendorEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProductVendor":
					toReturn.Add(VendorEntity.Relations.ProductVendorEntityUsingVendorID, "VendorEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "ProductVendor_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_productVendor", (!this.MarkedForDeletion?_productVendor:null));
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_purchaseOrderHeader", (!this.MarkedForDeletion?_purchaseOrderHeader:null));
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);
			info.AddValue("_vendorAddress", (!this.MarkedForDeletion?_vendorAddress:null));
			info.AddValue("_alwaysFetchVendorAddress", _alwaysFetchVendorAddress);
			info.AddValue("_alreadyFetchedVendorAddress", _alreadyFetchedVendorAddress);
			info.AddValue("_vendorContact", (!this.MarkedForDeletion?_vendorContact:null));
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_addressCollectionViaVendorAddress", (!this.MarkedForDeletion?_addressCollectionViaVendorAddress:null));
			info.AddValue("_alwaysFetchAddressCollectionViaVendorAddress", _alwaysFetchAddressCollectionViaVendorAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaVendorAddress", _alreadyFetchedAddressCollectionViaVendorAddress);
			info.AddValue("_addressTypeCollectionViaVendorAddress", (!this.MarkedForDeletion?_addressTypeCollectionViaVendorAddress:null));
			info.AddValue("_alwaysFetchAddressTypeCollectionViaVendorAddress", _alwaysFetchAddressTypeCollectionViaVendorAddress);
			info.AddValue("_alreadyFetchedAddressTypeCollectionViaVendorAddress", _alreadyFetchedAddressTypeCollectionViaVendorAddress);
			info.AddValue("_contactCollectionViaVendorContact", (!this.MarkedForDeletion?_contactCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchContactCollectionViaVendorContact", _alwaysFetchContactCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedContactCollectionViaVendorContact", _alreadyFetchedContactCollectionViaVendorContact);
			info.AddValue("_contactTypeCollectionViaVendorContact", (!this.MarkedForDeletion?_contactTypeCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchContactTypeCollectionViaVendorContact", _alwaysFetchContactTypeCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedContactTypeCollectionViaVendorContact", _alreadyFetchedContactTypeCollectionViaVendorContact);
			info.AddValue("_employeeCollectionViaPurchaseOrderHeader", (!this.MarkedForDeletion?_employeeCollectionViaPurchaseOrderHeader:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaPurchaseOrderHeader", _alwaysFetchEmployeeCollectionViaPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader", _alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader);
			info.AddValue("_productCollectionViaProductVendor", (!this.MarkedForDeletion?_productCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchProductCollectionViaProductVendor", _alwaysFetchProductCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedProductCollectionViaProductVendor", _alreadyFetchedProductCollectionViaProductVendor);
			info.AddValue("_shipMethodCollectionViaPurchaseOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaPurchaseOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader", _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader", _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader);
			info.AddValue("_unitMeasureCollectionViaProductVendor", (!this.MarkedForDeletion?_unitMeasureCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProductVendor", _alwaysFetchUnitMeasureCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProductVendor", _alreadyFetchedUnitMeasureCollectionViaProductVendor);


			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{

				case "ProductVendor":
					_alreadyFetchedProductVendor = true;
					if(entity!=null)
					{
						this.ProductVendor.Add((ProductVendorEntity)entity);
					}
					break;
				case "PurchaseOrderHeader":
					_alreadyFetchedPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.PurchaseOrderHeader.Add((PurchaseOrderHeaderEntity)entity);
					}
					break;
				case "VendorAddress":
					_alreadyFetchedVendorAddress = true;
					if(entity!=null)
					{
						this.VendorAddress.Add((VendorAddressEntity)entity);
					}
					break;
				case "VendorContact":
					_alreadyFetchedVendorContact = true;
					if(entity!=null)
					{
						this.VendorContact.Add((VendorContactEntity)entity);
					}
					break;
				case "AddressCollectionViaVendorAddress":
					_alreadyFetchedAddressCollectionViaVendorAddress = true;
					if(entity!=null)
					{
						this.AddressCollectionViaVendorAddress.Add((AddressEntity)entity);
					}
					break;
				case "AddressTypeCollectionViaVendorAddress":
					_alreadyFetchedAddressTypeCollectionViaVendorAddress = true;
					if(entity!=null)
					{
						this.AddressTypeCollectionViaVendorAddress.Add((AddressTypeEntity)entity);
					}
					break;
				case "ContactCollectionViaVendorContact":
					_alreadyFetchedContactCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.ContactCollectionViaVendorContact.Add((ContactEntity)entity);
					}
					break;
				case "ContactTypeCollectionViaVendorContact":
					_alreadyFetchedContactTypeCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.ContactTypeCollectionViaVendorContact.Add((ContactTypeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaPurchaseOrderHeader":
					_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaPurchaseOrderHeader.Add((EmployeeEntity)entity);
					}
					break;
				case "ProductCollectionViaProductVendor":
					_alreadyFetchedProductCollectionViaProductVendor = true;
					if(entity!=null)
					{
						this.ProductCollectionViaProductVendor.Add((ProductEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaPurchaseOrderHeader":
					_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaPurchaseOrderHeader.Add((ShipMethodEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProductVendor":
					_alreadyFetchedUnitMeasureCollectionViaProductVendor = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProductVendor.Add((UnitMeasureEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "ProductVendor":
					_productVendor.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderHeader":
					_purchaseOrderHeader.Add((PurchaseOrderHeaderEntity)relatedEntity);
					break;
				case "VendorAddress":
					_vendorAddress.Add((VendorAddressEntity)relatedEntity);
					break;
				case "VendorContact":
					_vendorContact.Add((VendorContactEntity)relatedEntity);
					break;

				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{

				case "ProductVendor":
					base.PerformRelatedEntityRemoval(_productVendor, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeader":
					base.PerformRelatedEntityRemoval(_purchaseOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorAddress":
					base.PerformRelatedEntityRemoval(_vendorAddress, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorContact":
					base.PerformRelatedEntityRemoval(_vendorContact, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_productVendor);
			toReturn.Add(_purchaseOrderHeader);
			toReturn.Add(_vendorAddress);
			toReturn.Add(_vendorContact);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID)
		{
			return FetchUsingPK(vendorID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(vendorID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(vendorID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(vendorID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.VendorID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(VendorFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(VendorFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new VendorRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch)
		{
			return GetMultiProductVendor(forceFetch, _productVendor.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductVendor(forceFetch, _productVendor.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductVendor(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_productVendor.GetMultiManyToOne(null, null, this, filter);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductVendor'. These settings will be taken into account
		/// when the property ProductVendor is requested or GetMultiProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productVendor.SortClauses=sortClauses;
			_productVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, _purchaseOrderHeader.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, _purchaseOrderHeader.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_purchaseOrderHeader.GetMultiManyToOne(null, null, this, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderHeader'. These settings will be taken into account
		/// when the property PurchaseOrderHeader is requested or GetMultiPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeader.SortClauses=sortClauses;
			_purchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch)
		{
			return GetMultiVendorAddress(forceFetch, _vendorAddress.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorAddress(forceFetch, _vendorAddress.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorAddress.GetMultiManyToOne(null, null, this, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorAddress'. These settings will be taken into account
		/// when the property VendorAddress is requested or GetMultiVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddress.SortClauses=sortClauses;
			_vendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorContact(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorContact.GetMultiManyToOne(null, null, this, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorContact'. These settings will be taken into account
		/// when the property VendorContact is requested or GetMultiVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContact.SortClauses=sortClauses;
			_vendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaVendorAddress(bool forceFetch)
		{
			return GetMultiAddressCollectionViaVendorAddress(forceFetch, _addressCollectionViaVendorAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaVendorAddress || forceFetch || _alwaysFetchAddressCollectionViaVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaVendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaVendorAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_addressCollectionViaVendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaVendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaVendorAddress.GetMulti(filter, GetRelationsForField("AddressCollectionViaVendorAddress"));
				_addressCollectionViaVendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaVendorAddress = true;
			}
			return _addressCollectionViaVendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaVendorAddress'. These settings will be taken into account
		/// when the property AddressCollectionViaVendorAddress is requested or GetMultiAddressCollectionViaVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaVendorAddress.SortClauses=sortClauses;
			_addressCollectionViaVendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaVendorAddress(bool forceFetch)
		{
			return GetMultiAddressTypeCollectionViaVendorAddress(forceFetch, _addressTypeCollectionViaVendorAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressTypeCollectionViaVendorAddress || forceFetch || _alwaysFetchAddressTypeCollectionViaVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressTypeCollectionViaVendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressTypeCollectionViaVendorAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_addressTypeCollectionViaVendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressTypeCollectionViaVendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressTypeCollectionViaVendorAddress.GetMulti(filter, GetRelationsForField("AddressTypeCollectionViaVendorAddress"));
				_addressTypeCollectionViaVendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressTypeCollectionViaVendorAddress = true;
			}
			return _addressTypeCollectionViaVendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressTypeCollectionViaVendorAddress'. These settings will be taken into account
		/// when the property AddressTypeCollectionViaVendorAddress is requested or GetMultiAddressTypeCollectionViaVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressTypeCollectionViaVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressTypeCollectionViaVendorAddress.SortClauses=sortClauses;
			_addressTypeCollectionViaVendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiContactCollectionViaVendorContact(forceFetch, _contactCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaVendorContact || forceFetch || _alwaysFetchContactCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_contactCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("ContactCollectionViaVendorContact"));
				_contactCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaVendorContact = true;
			}
			return _contactCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaVendorContact'. These settings will be taken into account
		/// when the property ContactCollectionViaVendorContact is requested or GetMultiContactCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaVendorContact.SortClauses=sortClauses;
			_contactCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiContactTypeCollectionViaVendorContact(forceFetch, _contactTypeCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactTypeCollectionViaVendorContact || forceFetch || _alwaysFetchContactTypeCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactTypeCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactTypeCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_contactTypeCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactTypeCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactTypeCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("ContactTypeCollectionViaVendorContact"));
				_contactTypeCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactTypeCollectionViaVendorContact = true;
			}
			return _contactTypeCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactTypeCollectionViaVendorContact'. These settings will be taken into account
		/// when the property ContactTypeCollectionViaVendorContact is requested or GetMultiContactTypeCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactTypeCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactTypeCollectionViaVendorContact.SortClauses=sortClauses;
			_contactTypeCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaPurchaseOrderHeader(forceFetch, _employeeCollectionViaPurchaseOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader || forceFetch || _alwaysFetchEmployeeCollectionViaPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaPurchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaPurchaseOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_employeeCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaPurchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaPurchaseOrderHeader.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaPurchaseOrderHeader"));
				_employeeCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = true;
			}
			return _employeeCollectionViaPurchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaPurchaseOrderHeader'. These settings will be taken into account
		/// when the property EmployeeCollectionViaPurchaseOrderHeader is requested or GetMultiEmployeeCollectionViaPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaPurchaseOrderHeader.SortClauses=sortClauses;
			_employeeCollectionViaPurchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductVendor(bool forceFetch)
		{
			return GetMultiProductCollectionViaProductVendor(forceFetch, _productCollectionViaProductVendor.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaProductVendor || forceFetch || _alwaysFetchProductCollectionViaProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaProductVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaProductVendor);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_productCollectionViaProductVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaProductVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaProductVendor.GetMulti(filter, GetRelationsForField("ProductCollectionViaProductVendor"));
				_productCollectionViaProductVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaProductVendor = true;
			}
			return _productCollectionViaProductVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaProductVendor'. These settings will be taken into account
		/// when the property ProductCollectionViaProductVendor is requested or GetMultiProductCollectionViaProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaProductVendor.SortClauses=sortClauses;
			_productCollectionViaProductVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiShipMethodCollectionViaPurchaseOrderHeader(forceFetch, _shipMethodCollectionViaPurchaseOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader || forceFetch || _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethodCollectionViaPurchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethodCollectionViaPurchaseOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_shipMethodCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shipMethodCollectionViaPurchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_shipMethodCollectionViaPurchaseOrderHeader.GetMulti(filter, GetRelationsForField("ShipMethodCollectionViaPurchaseOrderHeader"));
				_shipMethodCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = true;
			}
			return _shipMethodCollectionViaPurchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShipMethodCollectionViaPurchaseOrderHeader'. These settings will be taken into account
		/// when the property ShipMethodCollectionViaPurchaseOrderHeader is requested or GetMultiShipMethodCollectionViaPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethodCollectionViaPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethodCollectionViaPurchaseOrderHeader.SortClauses=sortClauses;
			_shipMethodCollectionViaPurchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProductVendor(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProductVendor(forceFetch, _unitMeasureCollectionViaProductVendor.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProductVendor || forceFetch || _alwaysFetchUnitMeasureCollectionViaProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProductVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProductVendor);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(VendorFields.VendorID, ComparisonOperator.Equal, this.VendorID, "VendorEntity__"));
				_unitMeasureCollectionViaProductVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProductVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProductVendor.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProductVendor"));
				_unitMeasureCollectionViaProductVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProductVendor = true;
			}
			return _unitMeasureCollectionViaProductVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProductVendor'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProductVendor is requested or GetMultiUnitMeasureCollectionViaProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProductVendor.SortClauses=sortClauses;
			_unitMeasureCollectionViaProductVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			VendorDAO dao = (VendorDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productVendor.ActiveContext = base.ActiveContext;
			_purchaseOrderHeader.ActiveContext = base.ActiveContext;
			_vendorAddress.ActiveContext = base.ActiveContext;
			_vendorContact.ActiveContext = base.ActiveContext;
			_addressCollectionViaVendorAddress.ActiveContext = base.ActiveContext;
			_addressTypeCollectionViaVendorAddress.ActiveContext = base.ActiveContext;
			_contactCollectionViaVendorContact.ActiveContext = base.ActiveContext;
			_contactTypeCollectionViaVendorContact.ActiveContext = base.ActiveContext;
			_employeeCollectionViaPurchaseOrderHeader.ActiveContext = base.ActiveContext;
			_productCollectionViaProductVendor.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaPurchaseOrderHeader.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProductVendor.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			VendorDAO dao = (VendorDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			VendorDAO dao = (VendorDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.VendorEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("ProductVendor", _productVendor);
			toReturn.Add("PurchaseOrderHeader", _purchaseOrderHeader);
			toReturn.Add("VendorAddress", _vendorAddress);
			toReturn.Add("VendorContact", _vendorContact);
			toReturn.Add("AddressCollectionViaVendorAddress", _addressCollectionViaVendorAddress);
			toReturn.Add("AddressTypeCollectionViaVendorAddress", _addressTypeCollectionViaVendorAddress);
			toReturn.Add("ContactCollectionViaVendorContact", _contactCollectionViaVendorContact);
			toReturn.Add("ContactTypeCollectionViaVendorContact", _contactTypeCollectionViaVendorContact);
			toReturn.Add("EmployeeCollectionViaPurchaseOrderHeader", _employeeCollectionViaPurchaseOrderHeader);
			toReturn.Add("ProductCollectionViaProductVendor", _productCollectionViaProductVendor);
			toReturn.Add("ShipMethodCollectionViaPurchaseOrderHeader", _shipMethodCollectionViaPurchaseOrderHeader);
			toReturn.Add("UnitMeasureCollectionViaProductVendor", _unitMeasureCollectionViaProductVendor);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The validator object for this VendorEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 vendorID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(vendorID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productVendor = new AW.Data.CollectionClasses.ProductVendorCollection(new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_purchaseOrderHeader = new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(new PurchaseOrderHeaderEntityFactory());
			_purchaseOrderHeader.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;
			_vendorAddress = new AW.Data.CollectionClasses.VendorAddressCollection(new VendorAddressEntityFactory());
			_vendorAddress.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchVendorAddress = false;
			_alreadyFetchedVendorAddress = false;
			_vendorContact = new AW.Data.CollectionClasses.VendorContactCollection(new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_addressCollectionViaVendorAddress = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaVendorAddress = false;
			_alreadyFetchedAddressCollectionViaVendorAddress = false;
			_addressTypeCollectionViaVendorAddress = new AW.Data.CollectionClasses.AddressTypeCollection(new AddressTypeEntityFactory());
			_alwaysFetchAddressTypeCollectionViaVendorAddress = false;
			_alreadyFetchedAddressTypeCollectionViaVendorAddress = false;
			_contactCollectionViaVendorContact = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaVendorContact = false;
			_alreadyFetchedContactCollectionViaVendorContact = false;
			_contactTypeCollectionViaVendorContact = new AW.Data.CollectionClasses.ContactTypeCollection(new ContactTypeEntityFactory());
			_alwaysFetchContactTypeCollectionViaVendorContact = false;
			_alreadyFetchedContactTypeCollectionViaVendorContact = false;
			_employeeCollectionViaPurchaseOrderHeader = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaPurchaseOrderHeader = false;
			_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = false;
			_productCollectionViaProductVendor = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaProductVendor = false;
			_alreadyFetchedProductCollectionViaProductVendor = false;
			_shipMethodCollectionViaPurchaseOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = false;
			_unitMeasureCollectionViaProductVendor = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProductVendor = false;
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = false;



			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			_customProperties.Add("MS_Description", @"Companies from whom Adventure Works Cycles purchases parts or other goods.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor account (identification) number.");
			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Company name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average");
			_fieldsCustomProperties.Add("CreditRating", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.");
			_fieldsCustomProperties.Add("PreferredVendorStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Vendor no longer used. 1 = Vendor is actively used.");
			_fieldsCustomProperties.Add("ActiveFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor URL.");
			_fieldsCustomProperties.Add("PurchasingWebServiceUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)VendorFieldIndex.VendorID].ForcedCurrentValueWrite(vendorID);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateVendorDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new VendorEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static VendorRelations Relations
		{
			get	{ return new VendorRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductVendor
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductVendorCollection(),
					(IEntityRelation)GetRelationsForField("ProductVendor")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("PurchaseOrderHeader")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorAddressCollection(),
					(IEntityRelation)GetRelationsForField("VendorAddress")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.VendorAddressEntity, 0, null, null, null, "VendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(),
					(IEntityRelation)GetRelationsForField("VendorContact")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaVendorAddress
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.VendorAddressEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "VendorAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaVendorAddress"), "AddressCollectionViaVendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressTypeCollectionViaVendorAddress
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.VendorAddressEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "VendorAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, GetRelationsForField("AddressTypeCollectionViaVendorAddress"), "AddressTypeCollectionViaVendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.VendorContactEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaVendorContact"), "ContactCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactTypeCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.VendorContactEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ContactTypeEntity, 0, null, null, GetRelationsForField("ContactTypeCollectionViaVendorContact"), "ContactTypeCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.PurchaseOrderHeaderEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaPurchaseOrderHeader"), "EmployeeCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.ProductVendorEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductVendor"), "ProductCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.PurchaseOrderHeaderEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaPurchaseOrderHeader"), "ShipMethodCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = VendorEntity.Relations.ProductVendorEntityUsingVendorID;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProductVendor"), "UnitMeasureCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "VendorEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return VendorEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return VendorEntity.FieldsCustomProperties;}
		}

		/// <summary> The VendorID property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)VendorFieldIndex.VendorID, true); }
			set	{ SetValue((int)VendorFieldIndex.VendorID, value, true); }
		}
		/// <summary> The AccountNumber property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: Vendor account (identification) number.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)VendorFieldIndex.AccountNumber, value, true); }
		}
		/// <summary> The Name property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: Company name.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.Name, true); }
			set	{ SetValue((int)VendorFieldIndex.Name, value, true); }
		}
		/// <summary> The CreditRating property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."CreditRating"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte CreditRating
		{
			get { return (System.Byte)GetValue((int)VendorFieldIndex.CreditRating, true); }
			set	{ SetValue((int)VendorFieldIndex.CreditRating, value, true); }
		}
		/// <summary> The PreferredVendorStatus property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PreferredVendorStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PreferredVendorStatus
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.PreferredVendorStatus, true); }
			set	{ SetValue((int)VendorFieldIndex.PreferredVendorStatus, value, true); }
		}
		/// <summary> The ActiveFlag property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: 0 = Vendor no longer used. 1 = Vendor is actively used.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ActiveFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ActiveFlag
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.ActiveFlag, true); }
			set	{ SetValue((int)VendorFieldIndex.ActiveFlag, value, true); }
		}
		/// <summary> The PurchasingWebServiceUrl property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: Vendor URL.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PurchasingWebServiceURL"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchasingWebServiceUrl
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, true); }
			set	{ SetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Vendor<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection ProductVendor
		{
			get	{ return GetMultiProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductVendor. When set to true, ProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductVendor
		{
			get	{ return _alwaysFetchProductVendor; }
			set	{ _alwaysFetchProductVendor = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductVendor already has been fetched. Setting this property to false when ProductVendor has been fetched
		/// will clear the ProductVendor collection well. Setting this property to true while ProductVendor hasn't been fetched disables lazy loading for ProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductVendor
		{
			get { return _alreadyFetchedProductVendor;}
			set 
			{
				if(_alreadyFetchedProductVendor && !value && (_productVendor != null))
				{
					_productVendor.Clear();
				}
				_alreadyFetchedProductVendor = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection PurchaseOrderHeader
		{
			get	{ return GetMultiPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get	{ return _alwaysFetchPurchaseOrderHeader; }
			set	{ _alwaysFetchPurchaseOrderHeader = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeader already has been fetched. Setting this property to false when PurchaseOrderHeader has been fetched
		/// will clear the PurchaseOrderHeader collection well. Setting this property to true while PurchaseOrderHeader hasn't been fetched disables lazy loading for PurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeader
		{
			get { return _alreadyFetchedPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeader && !value && (_purchaseOrderHeader != null))
				{
					_purchaseOrderHeader.Clear();
				}
				_alreadyFetchedPurchaseOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection VendorAddress
		{
			get	{ return GetMultiVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorAddress. When set to true, VendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddress
		{
			get	{ return _alwaysFetchVendorAddress; }
			set	{ _alwaysFetchVendorAddress = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorAddress already has been fetched. Setting this property to false when VendorAddress has been fetched
		/// will clear the VendorAddress collection well. Setting this property to true while VendorAddress hasn't been fetched disables lazy loading for VendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorAddress
		{
			get { return _alreadyFetchedVendorAddress;}
			set 
			{
				if(_alreadyFetchedVendorAddress && !value && (_vendorAddress != null))
				{
					_vendorAddress.Clear();
				}
				_alreadyFetchedVendorAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorContactCollection VendorContact
		{
			get	{ return GetMultiVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorContact. When set to true, VendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContact
		{
			get	{ return _alwaysFetchVendorContact; }
			set	{ _alwaysFetchVendorContact = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorContact already has been fetched. Setting this property to false when VendorContact has been fetched
		/// will clear the VendorContact collection well. Setting this property to true while VendorContact hasn't been fetched disables lazy loading for VendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorContact
		{
			get { return _alreadyFetchedVendorContact;}
			set 
			{
				if(_alreadyFetchedVendorContact && !value && (_vendorContact != null))
				{
					_vendorContact.Clear();
				}
				_alreadyFetchedVendorContact = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaVendorAddress
		{
			get { return GetMultiAddressCollectionViaVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaVendorAddress. When set to true, AddressCollectionViaVendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaVendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaVendorAddress
		{
			get	{ return _alwaysFetchAddressCollectionViaVendorAddress; }
			set	{ _alwaysFetchAddressCollectionViaVendorAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaVendorAddress already has been fetched. Setting this property to false when AddressCollectionViaVendorAddress has been fetched
		/// will clear the AddressCollectionViaVendorAddress collection well. Setting this property to true while AddressCollectionViaVendorAddress hasn't been fetched disables lazy loading for AddressCollectionViaVendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaVendorAddress
		{
			get { return _alreadyFetchedAddressCollectionViaVendorAddress;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaVendorAddress && !value && (_addressCollectionViaVendorAddress != null))
				{
					_addressCollectionViaVendorAddress.Clear();
				}
				_alreadyFetchedAddressCollectionViaVendorAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressTypeCollectionViaVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressTypeCollection AddressTypeCollectionViaVendorAddress
		{
			get { return GetMultiAddressTypeCollectionViaVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressTypeCollectionViaVendorAddress. When set to true, AddressTypeCollectionViaVendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressTypeCollectionViaVendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressTypeCollectionViaVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressTypeCollectionViaVendorAddress
		{
			get	{ return _alwaysFetchAddressTypeCollectionViaVendorAddress; }
			set	{ _alwaysFetchAddressTypeCollectionViaVendorAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressTypeCollectionViaVendorAddress already has been fetched. Setting this property to false when AddressTypeCollectionViaVendorAddress has been fetched
		/// will clear the AddressTypeCollectionViaVendorAddress collection well. Setting this property to true while AddressTypeCollectionViaVendorAddress hasn't been fetched disables lazy loading for AddressTypeCollectionViaVendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressTypeCollectionViaVendorAddress
		{
			get { return _alreadyFetchedAddressTypeCollectionViaVendorAddress;}
			set 
			{
				if(_alreadyFetchedAddressTypeCollectionViaVendorAddress && !value && (_addressTypeCollectionViaVendorAddress != null))
				{
					_addressTypeCollectionViaVendorAddress.Clear();
				}
				_alreadyFetchedAddressTypeCollectionViaVendorAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaVendorContact
		{
			get { return GetMultiContactCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaVendorContact. When set to true, ContactCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaVendorContact
		{
			get	{ return _alwaysFetchContactCollectionViaVendorContact; }
			set	{ _alwaysFetchContactCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaVendorContact already has been fetched. Setting this property to false when ContactCollectionViaVendorContact has been fetched
		/// will clear the ContactCollectionViaVendorContact collection well. Setting this property to true while ContactCollectionViaVendorContact hasn't been fetched disables lazy loading for ContactCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaVendorContact
		{
			get { return _alreadyFetchedContactCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaVendorContact && !value && (_contactCollectionViaVendorContact != null))
				{
					_contactCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedContactCollectionViaVendorContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactTypeCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactTypeCollection ContactTypeCollectionViaVendorContact
		{
			get { return GetMultiContactTypeCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactTypeCollectionViaVendorContact. When set to true, ContactTypeCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactTypeCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactTypeCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactTypeCollectionViaVendorContact
		{
			get	{ return _alwaysFetchContactTypeCollectionViaVendorContact; }
			set	{ _alwaysFetchContactTypeCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactTypeCollectionViaVendorContact already has been fetched. Setting this property to false when ContactTypeCollectionViaVendorContact has been fetched
		/// will clear the ContactTypeCollectionViaVendorContact collection well. Setting this property to true while ContactTypeCollectionViaVendorContact hasn't been fetched disables lazy loading for ContactTypeCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactTypeCollectionViaVendorContact
		{
			get { return _alreadyFetchedContactTypeCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedContactTypeCollectionViaVendorContact && !value && (_contactTypeCollectionViaVendorContact != null))
				{
					_contactTypeCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedContactTypeCollectionViaVendorContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaPurchaseOrderHeader
		{
			get { return GetMultiEmployeeCollectionViaPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaPurchaseOrderHeader. When set to true, EmployeeCollectionViaPurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaPurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaPurchaseOrderHeader
		{
			get	{ return _alwaysFetchEmployeeCollectionViaPurchaseOrderHeader; }
			set	{ _alwaysFetchEmployeeCollectionViaPurchaseOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaPurchaseOrderHeader already has been fetched. Setting this property to false when EmployeeCollectionViaPurchaseOrderHeader has been fetched
		/// will clear the EmployeeCollectionViaPurchaseOrderHeader collection well. Setting this property to true while EmployeeCollectionViaPurchaseOrderHeader hasn't been fetched disables lazy loading for EmployeeCollectionViaPurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaPurchaseOrderHeader
		{
			get { return _alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader && !value && (_employeeCollectionViaPurchaseOrderHeader != null))
				{
					_employeeCollectionViaPurchaseOrderHeader.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaPurchaseOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaProductVendor
		{
			get { return GetMultiProductCollectionViaProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaProductVendor. When set to true, ProductCollectionViaProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaProductVendor
		{
			get	{ return _alwaysFetchProductCollectionViaProductVendor; }
			set	{ _alwaysFetchProductCollectionViaProductVendor = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaProductVendor already has been fetched. Setting this property to false when ProductCollectionViaProductVendor has been fetched
		/// will clear the ProductCollectionViaProductVendor collection well. Setting this property to true while ProductCollectionViaProductVendor hasn't been fetched disables lazy loading for ProductCollectionViaProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaProductVendor
		{
			get { return _alreadyFetchedProductCollectionViaProductVendor;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaProductVendor && !value && (_productCollectionViaProductVendor != null))
				{
					_productCollectionViaProductVendor.Clear();
				}
				_alreadyFetchedProductCollectionViaProductVendor = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaPurchaseOrderHeader
		{
			get { return GetMultiShipMethodCollectionViaPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaPurchaseOrderHeader. When set to true, ShipMethodCollectionViaPurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaPurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethodCollectionViaPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethodCollectionViaPurchaseOrderHeader
		{
			get	{ return _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader; }
			set	{ _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethodCollectionViaPurchaseOrderHeader already has been fetched. Setting this property to false when ShipMethodCollectionViaPurchaseOrderHeader has been fetched
		/// will clear the ShipMethodCollectionViaPurchaseOrderHeader collection well. Setting this property to true while ShipMethodCollectionViaPurchaseOrderHeader hasn't been fetched disables lazy loading for ShipMethodCollectionViaPurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethodCollectionViaPurchaseOrderHeader
		{
			get { return _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader && !value && (_shipMethodCollectionViaPurchaseOrderHeader != null))
				{
					_shipMethodCollectionViaPurchaseOrderHeader.Clear();
				}
				_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProductVendor
		{
			get { return GetMultiUnitMeasureCollectionViaProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProductVendor. When set to true, UnitMeasureCollectionViaProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProductVendor
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProductVendor; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProductVendor = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProductVendor already has been fetched. Setting this property to false when UnitMeasureCollectionViaProductVendor has been fetched
		/// will clear the UnitMeasureCollectionViaProductVendor collection well. Setting this property to true while UnitMeasureCollectionViaProductVendor hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProductVendor
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProductVendor;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProductVendor && !value && (_unitMeasureCollectionViaProductVendor != null))
				{
					_unitMeasureCollectionViaProductVendor.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProductVendor = value;
			}
		}




		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.VendorEntity; }
		}
		#endregion

		
		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
