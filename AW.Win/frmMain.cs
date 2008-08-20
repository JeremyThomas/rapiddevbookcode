using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AW.Win
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        //private void LaunchChildForm(Form ChildForm)
        //{
        //    ChildForm.MdiParent = this;
        //    ChildForm.WindowState = FormWindowState.Normal;
        //    ChildForm.Show();
        //}
        public void LaunchChildForm(Form ChildForm)
        {
			bool FormAlreadyExists = false;
			foreach (Form myForm in this.MdiChildren)
			{
                if (myForm.GetType() == ChildForm.GetType())
                {
                    FormAlreadyExists = true;
                    ChildForm = myForm;
                    break;
                }
			}
			if (FormAlreadyExists == true)
			{
				ChildForm.BringToFront();
			}
			else
			{
				ChildForm.MdiParent = this;
				ChildForm.WindowState = FormWindowState.Normal;
				ChildForm.Show();
			}
        }
        private void ordersToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            LaunchChildForm(new frmOrderSearch());
        }
        private void customersToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            LaunchChildForm( new frmCustomers());
        }
        private void organizationToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            LaunchChildForm(new frmOrganization());
        }
        private void vacationBonusUtilityToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            LaunchChildForm(new frmVacationBonus());
        }
    }
}