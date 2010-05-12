using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AW.Win
{
 	public delegate void CancelButtonEventHandler(
 		object sender, 
 		CancelEventArgs e);
    public partial class frmStatusBar : Form
    {
        public event CancelButtonEventHandler CancelButtonClicked;
        public frmStatusBar()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
      		CancelEventArgs eventarg = new CancelEventArgs(true);
			CancelButtonClicked(sender, eventarg);
			this.Close();
        }
    }
}