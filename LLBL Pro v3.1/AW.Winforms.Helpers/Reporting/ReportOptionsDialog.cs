using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicTable
{
  /// <summary>
  /// Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
    public partial class ReportOptionsDialog : Form
    {
        public ReportOptionsDialog(List<string> availableFields)
        {
            InitializeComponent();
            foreach (string field in availableFields)
                fieldsListBox.Items.Add(field);
            for (int i = 0; i < fieldsListBox.Items.Count; i++)
                fieldsListBox.SetItemChecked(i, true);
        }

        public List<string> GetSelectedFields()
        {
            List<string> fields = new List<string>();
            for (int i = 0; i < fieldsListBox.CheckedItems.Count; i++)
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}