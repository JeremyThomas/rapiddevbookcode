using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using Microsoft.Reporting.WinForms;

namespace AW.Winforms.Helpers.Reporting
{
  /// <summary>
  ///   Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
  public partial class FrmReportViewer : FrmPersistantLocation
  {
    private IEnumerable _dataSet;
    private MemoryStream _rdl;

    public FrmReportViewer()
    {
      InitializeComponent();
    }

    private void ShowReport()
    {
      reportViewer1.Reset();
      reportViewer1.LocalReport.LoadReportDefinition(_rdl);
      reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("MyData", _dataSet));
      reportViewer1.RefreshReport();
    }

    private static MemoryStream GenerateRdl(List<string> allFields, List<string> selectedFields)
    {
      var ms = new MemoryStream();
      var gen = new RdlGenerator {AllFields = allFields, SelectedFields = selectedFields};
      gen.WriteXml(ms);
      ms.Position = 0;
      return ms;
    }

    private static void DumpRdl(MemoryStream rdl)
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
      return MetaDataHelper.GetPropertiesToDisplay(_dataSet).Select(p => p.Name).ToList();
    }

    public void OpenDataSet(IEnumerable dataSet, bool showOptionsDialog)
    {
      try
      {
        _dataSet = dataSet;

        var allFields = GetAvailableFields();
        var dlg = new ReportOptionsDialog(allFields);
        if (showOptionsDialog)
        {
          if (dlg.ShowDialog() != DialogResult.OK)
            return;
        }
        var selectedFields = dlg.GetSelectedFields();

        if (_rdl != null)
          _rdl.Dispose();
        _rdl = GenerateRdl(allFields, selectedFields);
        DumpRdl(_rdl);

        ShowReport();
      }
      catch (Exception ex)
      {
        // ReSharper disable once LocalizableElement
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}