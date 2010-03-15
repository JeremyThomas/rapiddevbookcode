using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public static class LLBLWinformHelper
  {
    #region Validatation

    public static bool ValidatePropertyAssignment<T>(
      Control controltoValidate,
      int fieldToValidate,
      T value, string errorMessage,
      ErrorProvider myError,
      EntityBase entity)
    {
      var validated = true;
      try
      {
        var validator = entity.Validator;
        if (value.Equals(entity.GetCurrentFieldValue(fieldToValidate)) == false
            && validator.ValidateFieldValue(entity, fieldToValidate, value) == false
          )
        {
          myError.SetError(controltoValidate, errorMessage);
          validated = false;
        }
        else
          myError.SetError(controltoValidate, "");
      }
      catch (Exception err)
      {
        myError.SetError(controltoValidate, err.Message);
        validated = false;
      }
      return validated;
    }

    public static bool ValidateForm(Control mycontrol, ErrorProvider myError)
    {
      var isValid = true;
      foreach (Control childControl in mycontrol.Controls)
      {
        if (myError.GetError(childControl) != "")
        {
          isValid = false;
          break;
        }
        if (childControl.Controls.Count > 0)
        {
          isValid = ValidateForm(childControl, myError);
          if (isValid == false)
            break;
        }
      }
      return isValid;
    }

    #endregion

    #region Self Servicing

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, ushort pageSize) where T : EntityBase
    {
      return enumerable.EditInDataGridView(EntityHelper.Save, EntityHelper.Delete, pageSize);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable) where T : EntityBase
    {
      return enumerable.EditInDataGridView(0);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, ushort pageSize)
    {
      return enumerable.EditInDataGridView(EntityHelper.Save, EntityHelper.Delete, pageSize, typeof (EntityBase));
    }

    #endregion

    #region Adapter

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize)
    {
      return (new DataGridViewAdapterHelper(dataAccessAdapter)).EditInDataGrid(enumerable, pageSize);
    }
    
    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize) where T : EntityBase2
    {
      return (new DataGridViewAdapterHelper<T>(dataAccessAdapter)).EditInDataGrid(enumerable, pageSize);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> query, ushort pageSize) where T : EntityBase2
    {
      return EditInDataGridView(query, EntityHelper.GetDataAccessAdapter(query), pageSize);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> query) where T : EntityBase2
    {
      return EditInDataGridView(query, 0);
    }

    private class DataGridViewAdapterHelper
    {
      private readonly IDataAccessAdapter _dataAccessAdapter;

      public DataGridViewAdapterHelper(IDataAccessAdapter dataAccessAdapter)
      {
        _dataAccessAdapter = dataAccessAdapter;
      }

      protected int Save(object dataToSave)
      {
        return EntityHelper.Save(dataToSave, _dataAccessAdapter);
      }

      protected int Delete(object dataToSave)
      {
        return EntityHelper.Delete(dataToSave, _dataAccessAdapter);
      }

      internal IEnumerable EditInDataGrid(IEnumerable enumerable, ushort pageSize)
      {
        return enumerable.EditInDataGridView(Save, Delete, pageSize, typeof (EntityBase2));
      }
    }

    private class DataGridViewAdapterHelper<T> : DataGridViewAdapterHelper where T : EntityBase2
    {
      public DataGridViewAdapterHelper(IDataAccessAdapter dataAccessAdapter)
        : base(dataAccessAdapter)
      {
      }

      internal IEnumerable<T> EditInDataGrid(IEnumerable<T> enumerable, ushort pageSize)
      {
        return enumerable.EditInDataGridView(Save, Delete, pageSize);
      }
    }

    #endregion
  }
}