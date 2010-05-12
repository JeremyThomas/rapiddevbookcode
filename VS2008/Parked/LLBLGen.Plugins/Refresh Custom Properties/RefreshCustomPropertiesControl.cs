using System;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ApplicationCore;

namespace WB.LLBLGen.Pro.Plugins
{
  public partial class RefreshCustomPropertiesControl : UserControl, IPluginConfigurationControl
  {
    public RefreshCustomPropertiesControl()
    {
      InitializeComponent();
    }

    #region IPluginConfigurationControl Members

    public event EventHandler DataIsInvalid;

    public event EventHandler DataIsValid;

    #endregion

    private void RefreshCustomPropertiesControl_Load(object sender, EventArgs e)
    {
      if (DataIsValid != null)
      {
        DataIsValid(this, new EventArgs());
      }
    }

        
    public bool IgnoreMSDesignerInformation
    {
      get
      {
        return IgnoreMsDesignerInfo.Checked;
      }
    }

    public bool MapFieldPropertiesForTypedList
    {
      get
      {
        return TypedListMap.Checked;
      }
    }

  }
}