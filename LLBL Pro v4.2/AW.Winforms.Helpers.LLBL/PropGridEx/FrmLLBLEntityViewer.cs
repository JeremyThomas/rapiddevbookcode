using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Helper.PropertyDescriptors;
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

    private FrmLLBLEntityViewer(object entity, IDataEditorPersister dataEditorPersister)
      : base(entity, dataEditorPersister)
    {
    }

    private FrmLLBLEntityViewer(object entity, IDataAccessAdapter dataAccessAdapter)
      : base(entity, dataAccessAdapter == null ? null : new DataEditorLLBLAdapterPersister(dataAccessAdapter))
    {
    }

    public FrmLLBLEntityViewer(object entity, ILinqMetaData linqMetaData)
      : this(entity, EntityHelper.GetDataAccessAdapter(linqMetaData))
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
      return Show(entity, new DataEditorLLBLSelfServicingPersister());
    }

    public static Form Show(object entity, IDataAccessAdapter dataAccessAdapter)
    {
      return Show(entity, new DataEditorLLBLAdapterPersister(dataAccessAdapter));
    }

    public static Form Show(ILinqMetaData linqMetaData)
    {
      var adapter = EntityHelper.GetDataAccessAdapter(linqMetaData);
      return adapter == null ? Show((object) linqMetaData) : Show(linqMetaData, new DataEditorLLBLAdapterPersister(adapter));
    }

    private static Form Show(object entity, IDataEditorPersister dataEditorPersister)
    {
      var frm = new FrmLLBLEntityViewer(entity, dataEditorPersister);
      AWHelper.ShowForm(frm);
      return frm;
    }

    private void InitializeComponent()
    {
      splitContainerVertical.Panel1.SuspendLayout();
      splitContainerVertical.Panel2.SuspendLayout();
      splitContainerVertical.SuspendLayout();
      splitContainerHorizontal.Panel1.SuspendLayout();
      splitContainerHorizontal.Panel2.SuspendLayout();
      splitContainerHorizontal.SuspendLayout();
      SuspendLayout();
      // 
      // propertyGrid1
      // 
      propertyGrid1.Size = new Size(684, 280);
      // 
      // ObjectBrowser
      // 
      ObjectBrowser.ShowDataTypes = false;
      ObjectBrowser.Size = new Size(343, 619);
      // 
      // gridDataEditor
      // 
      gridDataEditor.Size = new Size(684, 272);
      // 
      // splitContainerVertical
      // 
      splitContainerVertical.Size = new Size(1031, 619);
      // 
      // splitContainerHorizontal
      // 
      splitContainerHorizontal.Size = new Size(684, 619);
      // 
      // FrmLLBLEntityViewer
      // 
      AutoScaleDimensions = new SizeF(6F, 13F);
      ClientSize = new Size(1031, 641);
      Name = "FrmLLBLEntityViewer";
      splitContainerVertical.Panel1.ResumeLayout(false);
      splitContainerVertical.Panel2.ResumeLayout(false);
      splitContainerVertical.ResumeLayout(false);
      splitContainerHorizontal.Panel1.ResumeLayout(false);
      splitContainerHorizontal.Panel2.ResumeLayout(false);
      splitContainerHorizontal.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }
  }
}