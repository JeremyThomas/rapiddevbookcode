///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Northwind.DAL;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
#if !CF
using System.Runtime.Serialization;
#endif
namespace Northwind.DAL.EntityClasses
{
  // __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using AW.Helper;
  using AW.Helper.LLBL;
  using System.Linq;
  using System.Xml.Serialization;
  using System.Diagnostics;
  using System.ComponentModel;

	[DebuggerDisplay("{Identity}")]

  // __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Common base class which is the base class for all generated entities which aren't a subtype of another entity.</summary>
	[Serializable]
	public abstract partial class CommonEntityBase : EntityBase2
    // __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
    // __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
    // __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
    // __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary>CTor</summary>
		protected CommonEntityBase()
		{
		}
		
		/// <summary> CTor</summary>
		protected CommonEntityBase(string name):base(name)
		{
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CommonEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
      // __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
      // __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)</summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates the entity collection and stores it in destination if destination is null</summary>
		/// <typeparam name="T">type of the element to store in the collection</typeparam>
		/// <typeparam name="TFactory">The type of the factory to pass to the entitycollection ctor.</typeparam>
		/// <param name="navigatorName">Name of the property this collection is for.</param>
		/// <param name="setContainingEntityInfo">if set to <see langword="true"/> the collection is for an 1:n relationship, and the containing entity info has to be set</param>
		/// <param name="forMN">if set to <see langword="true"/> the collection is for an m:n relationship, otherwise for an 1:n relationship</param>
		/// <param name="destination">The destination member variable.</param>
		/// <returns>the collection referred to by destination if destination isn't null, otherwise the newly created collection (which is then stored in destination</returns>
		protected EntityCollection<T> GetOrCreateEntityCollection<T, TFactory>(string navigatorName, bool setContainingEntityInfo, bool forMN, ref EntityCollection<T> destination)
			where T:EntityBase2 , IEntity2
		{
			if(destination==null)
			{
				destination = new EntityCollection<T>(EntityFactoryCache2.GetEntityFactory(typeof(TFactory)));
				if(forMN)
				{
					((IEntityCollectionCore)destination).IsForMN = true;
				}
				else
				{
					if(setContainingEntityInfo)
					{
						destination.SetContainingEntityInfo(this, navigatorName);
					}
				}
				destination.ActiveContext = this.ActiveContext;
			}
			return destination;
		}

		#region Custom Entity code
		
    // __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

    static CommonEntityBase()
    {
      MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof(CommonEntityBase));
      ProfilerHelper.InitializeOrmProfiler();
      CacheController.RegisterCache("", new ResultsetCache()); 
      MarkSavedEntitiesAsFetched = true;
    }

    public static void Initialize()
    {
    }

    //[Browsable(false)]
    //[IgnoreDataMember]
    //[System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute]
    //public new IAuditor AuditorToUse
    //{
    //  get
    //  {
    //    return base.AuditorToUse;
    //  }
    //  set
    //  {
    //    base.AuditorToUse = value;
    //  }
    //}

    /// <summary>
    ///   Called right at the beginning of SetValue(), which is called from an entity field property setter
    /// </summary>
    /// <param name="fieldIndex">Index of the field to set.</param>
    /// <param name="valueToSet">The value to set.</param>
    /// <param name="cancel">if set to true, the setvalue is cancelled and the set action is terminated</param>
    /// <remarks>
    ///   This code fixes the flaw of the IDataErrorInfo + Refresh field value in controls.
    ///   For more explanation on this issue, please visit this forum's post:
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=12166
    /// </remarks>
    protected override void OnSetValue(int fieldIndex, object valueToSet, out bool cancel)
    {
      EntityHelper.SetEntityFieldErrorIfNeeded(this, fieldIndex, valueToSet);
      base.OnSetValue(fieldIndex, valueToSet, out cancel);
    }

    protected override bool OnValidateFieldValue(int fieldIndex, object value)
    {
      return base.OnValidateFieldValue(fieldIndex, value)|| Validation.ValidateFieldValue(this, fieldIndex, value);
    }

    #region Identity

    /// <summary>
    /// Gets or sets the string representation of the primary key.
    /// </summary>
    /// <value>The primary key.</value>
    [Browsable(false)]
    [XmlIgnore]
    public virtual string PkId
    {
      get { return EntityHelper.GetPkIdStringFromEntity(this); }
    }

    /// <summary>
    /// Gets the identity of the entity.
    /// </summary>
    /// <value>The identity.</value>
    [Browsable(false)]
    [XmlIgnore]
    public virtual string Identity
    {
      get { return String.Format("{0}<{1}>", (EntityType)LLBLGenProEntityTypeValue, PkId); }
    }

    /// <summary>
    /// Gets the DisplayName of the entity.
    /// </summary>
    [Browsable(false)]
    [XmlIgnore]
    public virtual string EntityName
    {
      get
      {
        var displayName = MetaDataHelper.GetDisplayName(GetType());
        return string.IsNullOrWhiteSpace(displayName) ? EntityHelper.GetNameFromEntityName(((IEntityCore)this).LLBLGenProEntityName) : displayName;
      }
    }

    /// <summary>
    /// DisplayName + LogValue
    /// </summary>
    [Browsable(false)]
    [XmlIgnore]
    public virtual string EntityNameAndValue
    {
      get
      {
        return GeneralHelper.Join(" ", EntityName, PkId);
      }
    }

    #endregion

    // __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
