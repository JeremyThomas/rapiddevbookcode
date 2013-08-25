using System;
using System.ComponentModel;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public delegate void CancelButtonEventHandler(object sender, CancelEventArgs e);

  public partial class FrmStatusBar : FrmPersistantLocation
  {
    public event CancelButtonEventHandler CancelButtonClicked;

    public FrmStatusBar()
    {
      InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      btnCancel.Enabled = false;
      var eventarg = new CancelEventArgs(true);
      CancelButtonClicked(sender, eventarg);
      Close();
    }
  }
}