using System.ComponentModel;
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
			var adapter = EntityHelper.GetDataAccessAdapter(linqMetaData.GetQueryableForEntity(0).Provider);
			return adapter == null ? Show((object)linqMetaData) : Show(linqMetaData, new LLBLWinformHelper.DataEditorLLBLAdapterPersister(adapter));
		}

		public static Form Show(object entity, IDataEditorPersister dataEditorPersister)
		{
			var frm = new FrmLLBLEntityViewer(entity, dataEditorPersister);
			AWHelper.ShowForm(frm);
			return frm;
		}
	}
}