///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:24 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'Contact'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ContactEntity : ContactEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ContactEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		public ContactEntity(System.Int32 contactID):
			base(contactID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactEntity(System.Int32 contactID, IPrefetchPath prefetchPathToUse):
			base(contactID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		public ContactEntity(System.Int32 contactID, IValidator validator):
			base(contactID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        //public static ContactCollection GetContactCollection()
        //{
        //    ISortExpression Sort = new SortExpression();
        //    Sort.Add(ContactFields.LastName | SortOperator.Ascending);
        //    Sort.Add(ContactFields.FirstName | SortOperator.Ascending);
        //    ContactCollection Contacts = new ContactCollection();
        //    Contacts.GetMulti(null, 1000, Sort);
        //    return Contacts;
        //}
        public string DisplayName
        {
            get { return this.LastName + ", " + this.FirstName; }
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
