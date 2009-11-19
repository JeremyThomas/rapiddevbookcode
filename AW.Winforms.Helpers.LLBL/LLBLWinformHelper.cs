﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public static class LLBLWinformHelper
  {
    #region Validatation

    public static bool ValidatePropertyAssignment<T>(
      Control ControltoValidate,
      int FieldToValidate,
      T Value, string ErrorMessage,
      ErrorProvider myError,
      EntityBase Entity)
    {
      var Validated = true;
      try
      {
        var Validator = Entity.Validator;
        if (Value.Equals(Entity.GetCurrentFieldValue(FieldToValidate)) == false
            && Validator.ValidateFieldValue(Entity, FieldToValidate, Value) == false
          )
        {
          myError.SetError(ControltoValidate, ErrorMessage);
          Validated = false;
        }
        else
          myError.SetError(ControltoValidate, "");
      }
      catch (Exception err)
      {
        myError.SetError(ControltoValidate, err.Message);
        Validated = false;
      }
      return Validated;
    }

    public static bool ValidateForm(Control mycontrol, ErrorProvider MyError)
    {
      var IsValid = true;
      foreach (Control ChildControl in mycontrol.Controls)
      {
        if (MyError.GetError(ChildControl) != "")
        {
          IsValid = false;
          break;
        }
        if (ChildControl.Controls.Count > 0)
        {
          IsValid = ValidateForm(ChildControl, MyError);
          if (IsValid == false)
            break;
        }
      }
      return IsValid;
    }

    #endregion
  }
}
