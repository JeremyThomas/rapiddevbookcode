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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web.DynamicData.ModelProviders;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.DynamicDataSupportClasses
{
  /// <summary>
  ///   Class which provides meta model information about an association in DynamicData
  /// </summary>
  public class LLBLGenProEntityRelationProvider : AssociationProvider
  {
    #region Class Member Declarations

    private readonly IEntityRelation _entityRelation;
    private readonly IEntityRelation _oppositeRelation;
    private readonly LLBLGenProEntityProvider _container;
    private PropertyDescriptor _descriptor;
    private List<LLBLGenProEntityFieldProvider> _fromFieldProviders;
    private bool _metaDataBuild;
    private ReadOnlyCollection<string> _foreignKeyNames;

    #endregion

    /// <summary>
    ///   Initializes a new instance of the <see cref="LLBLGenProEntityRelationProvider" /> class.
    /// </summary>
    /// <param name="container"> The container. </param>
    /// <param name="entityRelation"> The entity relation. </param>
    /// <param name="oppositeRelation"> The opposite relation. </param>
    /// <param name="descriptor"> The descriptor. </param>
    public LLBLGenProEntityRelationProvider(LLBLGenProEntityProvider container, IEntityRelation entityRelation,
                                            IEntityRelation oppositeRelation, PropertyDescriptor descriptor)
    {
      _container = container;
      _descriptor = descriptor;
      _entityRelation = entityRelation;
      _oppositeRelation = oppositeRelation;
    }


    /// <summary>
    ///   Builds the meta data.
    /// </summary>
    internal void BuildMetaData()
    {
      if (_metaDataBuild)
      {
        return;
      }

      var fkFields = _entityRelation.GetAllFKEntityFieldCoreObjects();
      var pkFields = _entityRelation.GetAllPKEntityFieldCoreObjects();
      IEntityFieldCore fromEntityField = null;
      IEntityFieldCore toEntityField = null;
      List<IEntityFieldCore> fromFields = null;
      if (_entityRelation.StartEntityIsPkSide)
      {
        fromEntityField = pkFields[0];
        toEntityField = fkFields[0];
        fromFields = pkFields;
      }
      else
      {
        fromEntityField = fkFields[0];
        toEntityField = pkFields[0];
        fromFields = fkFields;
      }

      var fromContainer =
        ((LLBLGenProDataModelProvider) _container.DataModel).EntityNameToEntityProvider[fromEntityField.ActualContainingObjectName];
      var toContainer =
        ((LLBLGenProDataModelProvider) _container.DataModel).EntityNameToEntityProvider[toEntityField.ActualContainingObjectName];

      _fromFieldProviders = new List<LLBLGenProEntityFieldProvider>();
      foreach (var field in fromFields)
      {
        _fromFieldProviders.Add(fromContainer.FieldNameToEntityFieldProvider[field.Name]);
      }

      LLBLGenProEntityFieldProvider fieldProvider = null;
      if (!fromContainer.FieldNameToEntityFieldProvider.TryGetValue(_entityRelation.MappedFieldName, out fieldProvider))
      {
        throw new ORMGeneralOperationException(string.Format("Model error: name '{0}' not found in entity '{1}'. Dynamic Data can't deal with relations which are hidden on one side. Please map a field onto the relation '{1}' - '{2}'.",
                                                             _entityRelation.MappedFieldName, fromEntityField.ActualContainingObjectName, toEntityField.ActualContainingObjectName));
      }
      else
      {
        FromColumn = fieldProvider;
      }
      if (!toContainer.FieldNameToEntityFieldProvider.TryGetValue(_oppositeRelation.MappedFieldName, out fieldProvider))
      {
        throw new ORMGeneralOperationException(string.Format("Model error: name '{0}' not found in entity '{1}'. Dynamic Data can't deal with relations which are hidden on one side. Please map a field onto the relation '{1}' - '{2}'.",
                                                             _oppositeRelation.MappedFieldName, toEntityField.ActualContainingObjectName, fromEntityField.ActualContainingObjectName));
      }
      else
      {
        ToColumn = fieldProvider;
      }
      IsPrimaryKeyInThisTable = false;
      switch (_entityRelation.TypeOfRelation)
      {
        case RelationType.ManyToOne:
          Direction = AssociationDirection.ManyToOne;
          break;
        case RelationType.OneToMany:
          Direction = AssociationDirection.OneToMany;
          break;
        case RelationType.OneToOne:
          Direction = AssociationDirection.OneToOne;
          break;
        case RelationType.ManyToMany:
          Direction = AssociationDirection.ManyToMany;
          break;
      }
      _metaDataBuild = true;
      _foreignKeyNames = new ReadOnlyCollection<string>((from f in fkFields select f.Name).ToList());
    }

    #region Class Property Declarations

    public IEntityRelation Relation
    {
      get { return _entityRelation; }
    }

    /// <summary>
    ///   Gets the foreign key names.
    /// </summary>
    public override ReadOnlyCollection<string> ForeignKeyNames
    {
      get { return _foreignKeyNames; }
    }

    #endregion
  }
}