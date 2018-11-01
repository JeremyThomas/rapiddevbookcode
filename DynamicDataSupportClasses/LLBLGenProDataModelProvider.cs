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
using System.Collections.ObjectModel;
using System.Web.DynamicData.ModelProviders;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.DynamicDataSupportClasses
{
  /// <summary>
  ///   Class which provides model meta data for dynamic data.
  /// </summary>
  public class LLBLGenProDataModelProvider : DataModelProvider
  {
    #region Class Member Declarations

    private ReadOnlyCollection<TableProvider> _knownEntityProviders;
    private Type _adapterType, _entityTypeEnum;
    private Dictionary<string, LLBLGenProEntityProvider> _entityNameToEntityProvider;
    private ILinqMetaData _linqMetaData;
    private IElementCreatorCore _elementCreator;

    #endregion

    /// <summary>
    ///   Initializes a new instance of the <see cref="LLBLGenProDataModelProvider" /> class. Selfservicing specific
    /// </summary>
    /// <param name="entityTypeEnum"> The entity type enum. </param>
    /// <param name="linqMetaData"> The linq meta data. </param>
    /// <param name="elementCreator"> The element creator. </param>
    public LLBLGenProDataModelProvider(Type entityTypeEnum, ILinqMetaData linqMetaData, IElementCreator elementCreator)
    {
      InitClass(null, entityTypeEnum, linqMetaData, elementCreator);
    }


    /// <summary>
    ///   Initializes a new instance of the <see cref="LLBLGenProDataModelProvider" /> class. Adapter specific
    /// </summary>
    /// <param name="adapterType"> Type of the adapter. </param>
    /// <param name="entityTypeEnum"> The entity type enum. </param>
    /// <param name="linqMetaData"> The linq meta data. </param>
    /// <param name="elementCreator"> The element creator. </param>
    public LLBLGenProDataModelProvider(Type adapterType, Type entityTypeEnum, ILinqMetaData linqMetaData, IElementCreator2 elementCreator)
    {
      if (adapterType == null)
      {
        throw new ArgumentNullException("adapterType");
      }
      InitClass(adapterType, entityTypeEnum, linqMetaData, elementCreator);
    }


    /// <summary>
    ///   Inits the class.
    /// </summary>
    /// <param name="adapterType"> Type of the adapter. </param>
    /// <param name="entityTypeEnum"> The entity type enum. </param>
    private void InitClass(Type adapterType, Type entityTypeEnum, ILinqMetaData linqMetaData, IElementCreatorCore elementCreator)
    {
      _adapterType = adapterType;
      if (entityTypeEnum == null)
      {
        throw new ArgumentNullException("entityTypeEnum");
      }
      if (!entityTypeEnum.IsEnum)
      {
        throw new ArgumentException("entityTypeEnum has to be an enum type");
      }

      _linqMetaData = linqMetaData ?? throw new ArgumentNullException("linqMetaData");
      _elementCreator = elementCreator ?? throw new ArgumentNullException("elementCreator");
      _entityTypeEnum = entityTypeEnum;
      _entityNameToEntityProvider = new Dictionary<string, LLBLGenProEntityProvider>();
      ContextType = typeof (object); // has to be non-null, but other than that can be any type.
      BuildEntityProviderList();
    }


    /// <summary>
    ///   Builds the entity provider list.
    /// </summary>
    private void BuildEntityProviderList()
    {
      var entityProviders = new List<TableProvider>();
      var entityTypeInts = Enum.GetValues(_entityTypeEnum);
      for (var i = 0; i < entityTypeInts.Length; i++)
      {
        var factory = _elementCreator.GetFactory((int) entityTypeInts.GetValue(i));
        var toAdd = new LLBLGenProEntityProvider(this, factory, _linqMetaData);
        entityProviders.Add(toAdd);
        _entityNameToEntityProvider.Add(factory.ForEntityName, toAdd);
      }

      // we can now build the associations per entity as all entity providers have their field providers now defined.
      foreach (LLBLGenProEntityProvider entityProvider in entityProviders)
      {
        entityProvider.BuildEntityFieldProviderListAssociationsProperties();
      }
      _knownEntityProviders = new ReadOnlyCollection<TableProvider>(entityProviders);
    }


    /// <summary>
    ///   Creates the context.
    /// </summary>
    /// <returns> dummy context </returns>
    public override object CreateContext()
    {
      return new object(); // not used in LLBLGen Pro, return a non-null object.
    }

    #region Class Property Declarations

    /// <summary>
    ///   Gets or sets the type of the DataAccessAdapter class to use. Adapter specific
    /// </summary>
    internal Type AdapterType
    {
      get { return _adapterType; }
      set { _adapterType = value; }
    }


    /// <summary>
    ///   Gets the entity name to entity provider list.
    /// </summary>
    internal Dictionary<string, LLBLGenProEntityProvider> EntityNameToEntityProvider
    {
      get { return _entityNameToEntityProvider; }
    }


    /// <summary>
    ///   Gets the table providers.
    /// </summary>
    public override ReadOnlyCollection<TableProvider> Tables
    {
      get { return _knownEntityProviders; }
    }

    #endregion
  }
}