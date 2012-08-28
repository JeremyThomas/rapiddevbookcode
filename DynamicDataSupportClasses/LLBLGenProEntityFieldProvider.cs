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
using System.Web.DynamicData.ModelProviders;

namespace SD.LLBLGen.Pro.DynamicDataSupportClasses
{
  /// <summary>
  ///   Class which provides meta model information about a column (field) in DynamicData
  /// </summary>
  public class LLBLGenProEntityFieldProvider : ColumnProvider
  {
    #region Class Member Declarations

    private readonly LLBLGenProEntityRelationProvider _relationProvider;

    #endregion

    /// <summary>
    ///   Initializes a new instance of the <see cref="LLBLGenProEntityFieldProvider" /> class.
    /// </summary>
    /// <param name="container"> The container. </param>
    /// <param name="fieldType"> Type of the field. </param>
    /// <param name="isCustomProperty"> if set to <c>true</c> [is custom property]. </param>
    /// <param name="isForeignKey"> if set to <c>true</c> [is foreign key]. </param>
    /// <param name="isPrimaryKey"> if set to <c>true</c> [is primary key]. </param>
    /// <param name="isReadOnly"> if set to <c>true</c> [is read only]. </param>
    /// <param name="size"> The size. </param>
    /// <param name="name"> The name. </param>
    /// <param name="isNullable"> if set to <c>true</c> [is nullable]. </param>
    /// <param name="relationProvider"> The relation provider. </param>
    public LLBLGenProEntityFieldProvider(LLBLGenProEntityProvider container, Type fieldType, bool isCustomProperty, bool isForeignKey,
                                         bool isPrimaryKey, bool isReadOnly, int size, string name, bool isNullable, LLBLGenProEntityRelationProvider relationProvider)
      : base(container)
    {
      ColumnType = fieldType;
      IsCustomProperty = isCustomProperty;
      IsForeignKeyComponent = isForeignKey;
      IsGenerated = isReadOnly;
      IsPrimaryKey = isPrimaryKey;
      MaxLength = size;
      Name = name;
      Nullable = isNullable;
      IsSortable = true;
      _relationProvider = relationProvider;
    }


    /// <summary>
    ///   Gets the association.
    /// </summary>
    public override AssociationProvider Association
    {
      get
      {
        if (_relationProvider == null)
        {
          return null;
        }
        else
        {
          _relationProvider.BuildMetaData();
          return _relationProvider;
        }
      }
    }
  }
}