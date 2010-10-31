using System;
using System.Windows.Forms;

namespace AW.Winforms.Helpers
{
	public partial class FrmThreePanelBase : FrmPersistantLocation
	{
		private readonly SplitContainer[] _splitContainers;

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

		protected void CollapseRightPanel()
		{
			if (!splitContainerVertical.Panel2Collapsed)
			{
				var panel2Width = splitContainerVertical.Panel2.Width;
				splitContainerVertical.Panel2Collapsed = true;
				var oldSplitContainerVerticalWidth = splitContainerVertical.Width;
				splitContainerVertical.Width -= panel2Width;
				if (Width > oldSplitContainerVerticalWidth)
					Width -= panel2Width;
				else
				{
					if (splitContainerVertical.Width>Width)
					Width = splitContainerVertical.Width;
				}
			}
		}

		protected void ExpandRightPanel()
		{
			if (splitContainerVertical.Panel2Collapsed)
			{
				var panel1Width = splitContainerVertical.Panel1.Width;
				var expandedWidth = ((Panel) splitContainerVertical.Panel2).Width;
				var oldsp = splitContainerVertical.SplitterDistance;
				var oldSplitContainerVerticalWidth = splitContainerVertical.Width;
				Width += expandedWidth;
				splitContainerVertical.Panel2Collapsed = false;
				splitContainerVertical.SplitterDistance = Math.Max(panel1Width,oldsp);
				//Width += splitContainerVertical.Panel2.Width;
			}
		}
	}
}