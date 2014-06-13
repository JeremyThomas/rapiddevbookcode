using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.Reporting
{
  /// <summary>
  ///   Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
  public partial class ReportOptionsDialog : Form
  {
    public ReportOptionsDialog(IEnumerable<string> availableFields)
    {
      InitializeComponent();
      foreach (var field in availableFields)
        fieldsListBox.Items.Add(field);
      for (var i = 0; i < fieldsListBox.Items.Count; i++)
        fieldsListBox.SetItemChecked(i, true);
    }

    public List<string> GetSelectedFields()
    {
      var fields = new List<string>();
      for (var i = 0; i < fieldsListBox.CheckedItems.Count; i++)
      {
        fields.Add(fieldsListBox.CheckedItems[i].ToString());
      }
      return fields;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      if (fieldsListBox.CheckedItems.Count == 0)
      {
        MessageBox.Show("At least one field must be selected");
        return;
      }
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}