using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AW.Data.EntityClasses;

namespace AW.Win
{
    public partial class frmVacationBonus : Form
    {
        public frmVacationBonus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = EmployeeEntity.AddBonusVacationHours(
            dtpHireDate.Value,
            Convert.ToInt32(nudSalariedHours.Value),
            Convert.ToInt32(nudUnsalariedHours.Value)).ToString();
        }
    }
}