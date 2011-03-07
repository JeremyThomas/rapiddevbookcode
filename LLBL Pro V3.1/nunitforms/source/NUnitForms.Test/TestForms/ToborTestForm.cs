using System;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.Test.TestForms
{
    ///<summary>
    /// Form to test <see cref="Tobor"/>,
    /// the NUnitForms simplifier.
    ///</summary>
    public partial class ToborTestForm : Form
    {
        ///<summary>
        /// Constructs a new <see cref="ToborTestForm"/>.
        ///</summary>
        public ToborTestForm()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            labelResult.Text = (Int32.Parse(textBoxA.Text) + Int32.Parse(textBoxB.Text)).ToString();
        }
    }
}