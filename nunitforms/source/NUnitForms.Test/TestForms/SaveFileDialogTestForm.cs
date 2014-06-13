using System;
using System.IO;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
    public partial class SaveFileDialogTestForm : Form
    {
        private string defaultFilename = String.Empty;

        public SaveFileDialogTestForm()
        {
            InitializeComponent();
        }

        public void SetDefaultTestFileName(string filename)
        {
            defaultFilename = filename;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dlg = new SaveFileDialog();
            if (defaultFilename != String.Empty)
            {
                save_dlg.InitialDirectory = Path.GetDirectoryName(defaultFilename);
                save_dlg.FileName = Path.GetFileName(defaultFilename);
            }

            if (save_dlg.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = save_dlg.FileName;
            }
            else
            {
                lblFileName.Text = "cancel pressed";
            }
        }
    }
}