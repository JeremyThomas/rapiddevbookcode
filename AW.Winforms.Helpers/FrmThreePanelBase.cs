using System;
using System.Windows.Forms;

namespace AW.Winforms.Helpers
{
  public partial class FrmThreePanelBase : FrmPersistantLocation
  {
    private readonly SplitContainer[] _splitContainers;

// ReSharper disable once MemberCanBeProtected.Global
    public FrmThreePanelBase()
    {
      InitializeComponent();
      _splitContainers = new[] {splitContainerVertical, splitContainerHorizontal};
    }

    #region Overrides of FrmPersistantLocation

    protected override SplitContainer[] Splitters
    {
      get { return _splitContainers; }
    }

    #endregion

    private void splitContainerVertical_DoubleClick(object sender, EventArgs e)
    {
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
      else
        CollapseRightPanel();
    }

    private void CollapseRightPanel()
    {
      var panel2Width = splitContainerVertical.Panel2.Width;
      splitContainerVertical.Panel2Collapsed = true;
      var oldSplitContainerVerticalWidth = splitContainerVertical.Width;
      splitContainerVertical.Width -= panel2Width;
      if (Width > oldSplitContainerVerticalWidth)
        Width -= (panel2Width + splitContainerVertical.SplitterWidth);
      else
      {
        if (splitContainerVertical.Width > Width)
          Width = splitContainerVertical.Width;
      }
    }

    protected void ExpandRightPanel()
    {
      var panel1Width = splitContainerVertical.Panel1.Width;
      var expandedWidth = ((Panel) splitContainerVertical.Panel2).Width + splitContainerVertical.SplitterWidth;
      var oldsp = splitContainerVertical.SplitterDistance;
      Width += expandedWidth;
      splitContainerVertical.Panel2Collapsed = false;
      splitContainerVertical.SplitterDistance = Math.Max(panel1Width, oldsp);
    }

    //private void splitContainerVertical_SizeChanged(object sender, EventArgs e)
    //{
    //  Text = splitContainerVertical.Panel1.Width + "-" + splitContainerVertical.SplitterDistance + "-" + this.ClientSize.Width;
    //}
  }
}