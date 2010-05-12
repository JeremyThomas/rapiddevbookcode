using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Reporting.WinForms;

namespace DynamicTable
{
  /// <summary>
  /// Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
    public partial class FrmReportViewer : Form
    {
      private IEnumerable m_dataSet;
        private MemoryStream m_rdl;

        public FrmReportViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowReport()
        {
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.LoadReportDefinition(m_rdl);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("MyData", m_dataSet));
            this.reportViewer1.RefreshReport();
        }

        private MemoryStream GenerateRdl(List<string> allFields, List<string> selectedFields)
        {
            MemoryStream ms = new MemoryStream();
            RdlGenerator gen = new RdlGenerator();
            gen.AllFields = allFields;
            gen.SelectedFields = selectedFields;
            gen.WriteXml(ms);
            ms.Position = 0;
            return ms;
        }

        private void DumpRdl(MemoryStream rdl)
        {
#if DEBUG_RDLC
            using (FileStream fs = new FileStream(@"c:\test.rdlc", FileMode.Create))
            {
                rdl.WriteTo(fs);
            }
#endif
        }

        private List<string> GetAvailableFields()
        {
          var properties = TypeDescriptor.GetProperties((new BindingSource(m_dataSet, "")).Current);
            List<string> availableFields = new List<string>();
            for (int i = 0; i < properties.Count; i++)
            {
              var t = properties[i];
              if ((t.PropertyType.IsValueType||t.PropertyType==typeof(string)) && t.Name[0]!='<')
                availableFields.Add(t.Name);
            }
            return availableFields;
        }

        public void OpenDataSet(IEnumerable dataSet, bool showOptionsDialog)
        {
            try
            {
                m_dataSet = dataSet;

                List<string> allFields = GetAvailableFields();
                ReportOptionsDialog dlg = new ReportOptionsDialog(allFields);
                if (showOptionsDialog)
                {
                    if (dlg.ShowDialog() != DialogResult.OK)
                        return;
                }
                List<string> selectedFields = dlg.GetSelectedFields();

                if (m_rdl != null)
                    m_rdl.Dispose();
                m_rdl = GenerateRdl(allFields, selectedFields);
                DumpRdl(m_rdl);

                ShowReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
