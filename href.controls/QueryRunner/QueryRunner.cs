using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.EntityViewer;
using CSScriptLibrary;
using DynamicTable;

namespace AW.Winforms.Helpers.QueryRunner
{
  public partial class QueryRunner : UserControl
  {
    public QueryRunner()
    {
      InitializeComponent();
      dataGridViewScript.AutoGenerateColumns = true;
    }

    public IEnumerable QueryProject(LinqMetaData metaData)
    {
        var customerlist = from customer in (metaData).Customer
                         from customerAddress in customer.CustomerAddresses
                         select new
                                  {
                                    customerAddress.Address.AddressLine1,
                                    customerAddress.Address.AddressLine2,
                                    customerAddress.Address.City,
                                    AddressType = customerAddress.AddressType.Name,
                                    customer.Individual.Contact.Title,
                                    customer.Individual.Contact.FirstName,
                                    customer.Individual.Contact.MiddleName,
                                    customer.Individual.Contact.LastName,
                                    customer.Individual.Contact.Suffix,
                                    customer.Individual.Contact.EmailAddress,
                                    customer.Individual.Contact.EmailPromotion,
                                    CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
                                    StateProvinceName = customerAddress.Address.StateProvince.Name,
                                    customer.CustomerID
                                  };
      return customerlist.Take(5);
    }

    private void toolStripButtonViewRunQuery_Click(object sender, EventArgs e)
    {
      //BindingSourceScript.DataSource = QueryProject(MetaSingletons.MetaData);
      AsmHelper myAsmHelper;
      var query = CreateQuery(textBoxScript.Text, out myAsmHelper);
      AWHelper.BindEnumerable(query.QueryProject(MetaSingletons.MetaData), BindingSourceScript);
      myAsmHelper.Dispose();
      if (BindingSourceScript.Count > 0)
      {
        copyToolStripButtonQuery.Enabled = true;
        printToolStripButtonViewReport.Enabled = true;
          if (dataGridViewScript.Height < 30)
        splitContainerScript.SplitterDistance = Height/2;
      }
    }

    private static ILinqToLLBLQueryScript CreateQuery(string scriptText, out AsmHelper helper)
    {
      helper = new AsmHelper(CSScript.LoadCode(scriptText, null, true));
      return (ILinqToLLBLQueryScript)helper.CreateObject("Script");
    }

    private void printToolStripButtonViewReport_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
      frm.OpenDataSet(BindingSourceScript, false);
      frm.Show();
    }

    private void copyToolStripButtonQuery_Click(object sender, EventArgs e)
    {
      AWHelper.CopyEntireDataGridViewToClipboard(dataGridViewScript);
    }

    private void QueryRunner_Load(object sender, EventArgs e)
    {
      var dataGridViewScriptClipboardCopyMode = dataGridViewScript.ClipboardCopyMode;
      toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof(DataGridViewClipboardCopyMode));
      toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
      splitContainerScript.SplitterDistance = Height - bindingNavigatorScript.Height;
    }

    internal void Save(string fileName)
    {
       File.WriteAllText(fileName,textBoxScript.Text);
    }

    internal void LoadFile(string fileName)
    {
      textBoxScript.Text = File.ReadAllText(fileName);
    }

    internal void Save(StreamWriter streamWriter)
    {
      //streamWriter.
      //File.WriteAllText(fileName, textBoxScript.Text);
    }

    internal void LoadStream(StreamReader streamReader)
    {
      textBoxScript.Text = streamReader.ReadToEnd();
    }
  }

  public interface ILinqToLLBLQueryScript
  {
    IEnumerable QueryProject(LinqMetaData metaData);
  }
}