using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using AW.Winforms.Helpers;
using Microsoft.Reporting.WinForms;

namespace DynamicTable
{
	/// <summary>
	/// Based on http://www.gotreportviewer.com/DynamicTable.zip
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
			var properties = TypeDescriptor.GetProperties((new BindingSource(_dataSet, "")).Current);
			var availableFields = new List<string>();
			for (var i = 0; i < properties.Count; i++)
			{
				var t = properties[i];
				if ((t.PropertyType.IsValueType || t.PropertyType == typeof (string)) && t.Name[0] != '<')
					availableFields.Add(t.Name);
			}
			return availableFields;
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
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}