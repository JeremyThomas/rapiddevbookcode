using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test.Helpers
{
  public class GridDataEditorTestBase : NUnitFormMSTest
  {
    protected int ExpectedColumnCount;
    protected int ActualColumnCount;
    public const BindingFlags FieldBindingFlags = BindingFlags.Instance | BindingFlags.Public;

    protected void TestShowInGrid<T>(IEnumerable<T> enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
    {
      ModalFormHandler = Handler;
      numProperties = GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = FrmDataEditor.ShowInGrid(enumerable, dataEditorPersister);
      Application.DoEvents();
      Assert.AreEqual(enumerable, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      TestEditInDataGridView(enumerable, numProperties, numFieldsToShow, dataEditorPersister);
    }

    protected int GetNumberOfColumns<T>(int numProperties, ref int numFieldsToShow)
    {
      ExpectedColumnCount = numProperties + numFieldsToShow;
      if (ExpectedColumnCount < 0)
      {
        numProperties = MetaDataHelper.GetPropertiesToDisplay(typeof(T)).Count();
        numFieldsToShow = typeof(T).GetFields(FieldBindingFlags).Length;
        ExpectedColumnCount = numProperties + numFieldsToShow;
      }
      return numProperties;
    }

    protected void TestEditInDataGridView(IEnumerable enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
    {
      if (enumerable != null)
        ModalFormHandler = Handler;
      ExpectedColumnCount = numProperties + numFieldsToShow;
      var actual = FrmDataEditor.ShowInGrid(enumerable, dataEditorPersister);
      Application.DoEvents();
      Assert.AreEqual(enumerable, actual);
      if (enumerable != null)
      {
        var propertiesToDisplay = MetaDataHelper.GetPropertiesToDisplay(enumerable);
        var displayPropertyCount = propertiesToDisplay.Count();
        if (displayPropertyCount == 0)
        {
          if (ValueTypeWrapper.TypeNeedsWrappingForBinding(MetaDataHelper.GetEnumerableItemType(enumerable)))
            displayPropertyCount = MetaDataHelper.GetPropertiesToDisplay(ValueTypeWrapper.CreateWrapperForBinding(enumerable)).Count();
        }
        else if (displayPropertyCount == 1)
        {
          var enumerableItemType = MetaDataHelper.GetEnumerableItemType(enumerable);
          if (enumerableItemType.IsArray)
          {
            var current = enumerable.Cast<Array>().FirstOrDefault(); //enumerable.GetEnumerator().Current as Array;
            if (current != null)
              displayPropertyCount = current.Length;
          }
          else if (enumerableItemType.Implements(typeof(IList)))
          {
            var current = enumerable.Cast<IList>().FirstOrDefault(); //enumerable.GetEnumerator().Current as Array;
            if (current != null)
              displayPropertyCount = current.Count;
          }
        }

        if (numProperties > 0)
        {
          // Debugger.Break();
          Assert.AreEqual(numProperties, displayPropertyCount, "Properties of " + enumerable.GetType() + " " + propertiesToDisplay.Select(p => p.Name).JoinAsString());
        }
        else if (numProperties < 0)
        {
          ExpectedColumnCount = displayPropertyCount;
        }
        Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      }
    }

    protected void Handler(string name, IntPtr hWnd, Form form)
    {
      //Assert.AreEqual(1, ((FrmDataEditor)form). .ColumnCount);
      //var dataGridView = new DataGridViewTester("dataGridView", name);
      //	if (_expectedColumnCount > 0)
      {
        var dataGridView = GetDataGridViewFromGridDataEditor(form);
        ActualColumnCount = dataGridView.ColumnCount;
        if (ExpectedColumnCount == ActualColumnCount)
          form.Close();
        else
        {
          Application.DoEvents();
          ActualColumnCount = dataGridView.ColumnCount;
          if (ExpectedColumnCount == ActualColumnCount)
            form.Close();
          else
            Debugger.Break();
        }
      }
    }

    /// <summary>
    ///   Use this to leave the form showing
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="hWnd">The h WND.</param>
    /// <param name="form">The form.</param>
    protected void NullHandler(string name, IntPtr hWnd, Form form)
    {
    }

    public static DataGridView GetDataGridViewFromGridDataEditor(Form form)
    {
      return ((DataGridView) form.Controls.All().FirstOrDefault(c => c is DataGridView));
    }
  }
}