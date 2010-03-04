using System;
using System.ComponentModel;
using System.Windows.Forms;
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
      //  TypeDescriptor.AddProvider(_commonEntityBaseTypeDescriptionProvider, typeof (object));

      if (_entityFieldsTypeDescriptionProvider == null)
        _entityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof(EntityFields));
      TypeDescriptor.AddProvider(_entityFieldsTypeDescriptionProvider, typeof(EntityFields));
      propertyGrid1.PropertyTabs.RemoveTabType(typeof(RawMemberTab));
      propertyGrid1.PropertyTabs.AddTabType(typeof(RawLLBLMemberTab), PropertyTabScope.Static); 
    }

    public FrmLLBLEntityViewer(object entity) : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      ObjectBrowser.ObjectToBrowse = entity;
    }

    public FrmLLBLEntityViewer(object entity, Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
      : this(entity)
    {
      gridDataEditor.SaveableTypes = saveableTypes;
      gridDataEditor.SaveFunction += saveFunction;
      gridDataEditor.DeleteFunction += deleteFunction;
    }

    public new static Form LaunchAsChildForm(object entity)
    {
      var frm = new FrmLLBLEntityViewer(entity);
      AWHelper.ShowFormModalIfParentLess(frm);
      return frm;
    }

    public static Form LaunchAsChildForm(object entity, Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
    {
      var frm = new FrmLLBLEntityViewer(entity, saveFunction, deleteFunction, saveableTypes);
      AWHelper.ShowFormModalIfParentLess(frm);
      return frm;
    }
  }
}