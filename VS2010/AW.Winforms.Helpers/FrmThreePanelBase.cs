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
	}
}