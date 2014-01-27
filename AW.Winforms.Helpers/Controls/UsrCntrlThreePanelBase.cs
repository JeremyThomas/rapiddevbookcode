using System;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.Controls
{
	public partial class UsrCntrlThreePanelBase : UserControl
	{
		private readonly SplitContainer[] _splitContainers;

    public UsrCntrlThreePanelBase()
		{
			InitializeComponent();
			_splitContainers = new[] {splitContainerVertical, splitContainerHorizontal};
		}

		private void splitContainerVertical_DoubleClick(object sender, EventArgs e)
		{
			if (splitContainerVertical.Panel2Collapsed)
				ExpandRightPanel();
			else
				CollapseRightPanel();
		}

		protected void CollapseRightPanel()
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