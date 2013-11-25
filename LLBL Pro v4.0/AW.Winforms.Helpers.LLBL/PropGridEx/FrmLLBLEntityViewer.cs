using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.EntityViewer;
using AW.Winforms.Helpers.PropGridEx;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL.PropGridEx
{
	public class FrmLLBLEntityViewer : FrmEntityViewer
	{
		private static TypeDescriptionProvider _entityFieldsTypeDescriptionProvider;

		public FrmLLBLEntityViewer()
		{
		}

		public FrmLLBLEntityViewer(object entity)
			: base(entity)
		{
		}

		public FrmLLBLEntityViewer(object entity, IDataEditorPersister dataEditorPersister)
			: base(entity, dataEditorPersister)
		{
		}

		#region Overrides of FrmEntityViewer

		protected override void Initialize()
		{
			//  TypeDescriptor.AddProvider(_commonEntityBaseTypeDescriptionProvider, typeof (object));

			if (_entityFieldsTypeDescriptionProvider == null)
				_entityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
			TypeDescriptor.AddProvider(_entityFieldsTypeDescriptionProvider, typeof (EntityFields));
			propertyGrid1.PropertyTabs.RemoveTabType(typeof (RawMemberTab));
			propertyGrid1.PropertyTabs.AddTabType(typeof (RawLLBLMemberTab), PropertyTabScope.Static);
		}

		#endregion

		public static Form Show(object entity)
		{
			return Show(entity, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
		}

		public static Form Show(object entity, IDataAccessAdapter dataAccessAdapter)
		{
			return Show(entity, new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter));
		}

		public static Form Show(ILinqMetaData linqMetaData)
		{
			var adapter = EntityHelper.GetDataAccessAdapter(linqMetaData);
			return adapter == null ? Show((object) linqMetaData) : Show(linqMetaData, new LLBLWinformHelper.DataEditorLLBLAdapterPersister(adapter));
		}

	  public static Form Show(object entity, IDataEditorPersister dataEditorPersister)
		{
			var frm = new FrmLLBLEntityViewer(entity, dataEditorPersister);
			AWHelper.ShowForm(frm);
			return frm;
		}

		private void InitializeComponent()
		{
			this.splitContainerVertical.Panel1.SuspendLayout();
			this.splitContainerVertical.Panel2.SuspendLayout();
			this.splitContainerVertical.SuspendLayout();
			this.splitContainerHorizontal.Panel1.SuspendLayout();
			this.splitContainerHorizontal.Panel2.SuspendLayout();
			this.splitContainerHorizontal.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Size = new System.Drawing.Size(684, 280);
			// 
			// ObjectBrowser
			// 
			this.ObjectBrowser.ShowDataTypes = false;
			this.ObjectBrowser.Size = new System.Drawing.Size(343, 619);
			// 
			// gridDataEditor
			// 
			this.gridDataEditor.Size = new System.Drawing.Size(684, 272);
			// 
			// splitContainerVertical
			// 
			this.splitContainerVertical.Size = new System.Drawing.Size(1031, 619);
			// 
			// splitContainerHorizontal
			// 
			this.splitContainerHorizontal.Size = new System.Drawing.Size(684, 619);
			this.splitContainerHorizontal.SplitterDistance = 343;
			// 
			// FrmLLBLEntityViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(1031, 641);
			this.Name = "FrmLLBLEntityViewer";
			this.splitContainerVertical.Panel1.ResumeLayout(false);
			this.splitContainerVertical.Panel2.ResumeLayout(false);
			this.splitContainerVertical.ResumeLayout(false);
			this.splitContainerHorizontal.Panel1.ResumeLayout(false);
			this.splitContainerHorizontal.Panel2.ResumeLayout(false);
			this.splitContainerHorizontal.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}