using System;
using System.ComponentModel;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.EntityViewer;
using AW.Winforms.Helpers.PropGridEx;
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

    public static Form LaunchAsChildForm(object entity, Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
    {
      var frm = new FrmLLBLEntityViewer(entity, new DataEditorPersister(saveFunction, deleteFunction, saveableTypes));
      AWHelper.ShowFormModalIfParentLess(frm);
      return frm;
    }

    public new static Form LaunchAsChildForm(object entity, IDataEditorPersister dataEditorPersister)
    {
      var frm = new FrmEntityViewer(entity, dataEditorPersister);
      AWHelper.ShowChildForm(frm);
      return frm;
    }
  }
}