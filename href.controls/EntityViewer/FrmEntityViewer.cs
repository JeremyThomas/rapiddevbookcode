using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using AW.LLBLGen.Plugins;
using AW.Winforms.Helpers.Properties;
using CSScriptLibrary;
using DynamicTable;
using JesseJohnston;
using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Entities;
using SD.LLBLGen.Pro.DBDriverCore;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntityViewer: Form
  {
    private static TypeDescriptionProvider CommonEntityBaseTypeDescriptionProvider;
    private static TypeDescriptionProvider EntityFieldsTypeDescriptionProvider; //

    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridViewScript.AutoGenerateColumns = true;
      dataGridViewEnumerable.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (CommonEntityBaseTypeDescriptionProvider == null)
        CommonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (object));
      //  TypeDescriptor.AddProvider(CommonEntityBaseTypeDescriptionProvider, typeof (object));

      if (EntityFieldsTypeDescriptionProvider == null)
        EntityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
      // TypeDescriptor.AddProvider(EntityFieldsTypeDescriptionProvider, typeof(EntityFields));
    }

    public FrmEntityViewer(object entity)
      : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      propertyGrid1.SelectedObject = entity;
      ObjectBrowser.ObjectToBrowse = entity;
    }

    private void FrmEntityViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.EntityFieldColumns = AWHelper.SaveColumnState(dataGridViewEnumerable);
    }

    private void FrmEntityViewer_Load(object sender, EventArgs e)
    {
      propertyGrid1.RefreshSelectedObject();
      AWHelper.RestoreColumnsState(Settings.Default.EntityFieldColumns, dataGridViewEnumerable);
      var dataGridViewScriptClipboardCopyMode = dataGridViewScript.ClipboardCopyMode;
      toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof(DataGridViewClipboardCopyMode));
      toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
    }

    private void propertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
      if (e.NewSelection.Value != null && !(e.OldSelection == null && dataGridViewScript.DataSource == propertyGrid1.SelectedObject))
        if (!ShowEnumerable(e.NewSelection.Value as IEnumerable))
          if (!e.NewSelection.PropertyDescriptor.PropertyType.IsValueType)
            bindingSourceEnumerable.DataSource = e.NewSelection.Value;
    }

    private void propertyGrid2_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
    }

    private void selectObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (propertyGrid1.SelectedGridItem.Expandable)
        propertyGrid1.SelectedObject = propertyGrid1.SelectedGridItem.Value;
    }

    private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
    {
      if (propertyGrid1.SelectedObject is Project)
        Text = "ProjectBrowser";
    }

    private Project TheProject
    {
      get { return (Project)ObjectBrowser.ObjectToBrowse; }
    }

    private void toolStripButtonViewGroupedEntities_Click(object sender, EventArgs e)
    {
      //var t = from peg in TheProject.ProjectElementGroups.Values.OfType<ProjectElementGroup>()
      //        from ed in peg.Keys.OfType<EntityDefinition>()
      //        where !peg.IsSystemGroup && ed.ElementTargetName == "AQD.gn_Aircraft"
      //        select new {ed.ElementTargetName, ed.ElementName, peg.Name};

      AsmHelper myAsmHelper;
      var query = AWHelper.CreateQuery(textBoxScript.Text, out myAsmHelper);
      AWHelper.BindEnumerable(query.QueryProject(TheProject), BindingSourceScript);
      myAsmHelper.Dispose();
      //bindingSourceEnumerable.DataSource = GetEntityTableMapping(TheProject);
    }

    private static IEnumerable GetEntityTableMapping(Project project)
    {
      return from entity in project.Entities.OfType<EntityDefinition>()
             select
               new
                 {
                   Groups = string.Join(", ", (from peg in project.ProjectElementGroups.Values.OfType<ProjectElementGroup>()
                                              from ed in peg.Keys.OfType<EntityDefinition>()
                                              where !peg.IsSystemGroup && ed.ElementName == entity.ElementName
                                              select peg.Name).Distinct().ToArray()),
                   entity.ElementTargetName,
                   entity.ElementName,
                   entity.TargetType,
                   Description = entity.CustomProperties.ContainsKey("MS_Description") ? entity.CustomProperties["MS_Description"].ToString() : string.Empty
                 };
    }

    private void toolStripButtonRunPlugin_Click(object sender, EventArgs e)
    {
      PluginBase pluginToTest = new RenameRelatedFieldsPlugin {ProjectToTarget = TheProject, Callbacks = new Hashtable {{ProgressCallBack.LogLineToApplicationOutputCallBack, (ApplicationOutputLogLineCallBack)AWHelper.ApplicationOutputLogLine}}};
      //PluginBase pluginToTest = new RefreshCustomProperties {ProjectToTarget = TheProject, Callbacks = new Hashtable {{ProgressCallBack.LogLineToApplicationOutputCallBack, (ApplicationOutputLogLineCallBack) ApplicationOutputLogLine}}};
      pluginToTest.Entities.AddRange(TheProject.Entities);
      pluginToTest.GetConfigurationControl();
      pluginToTest.Execute();
    }

    private void toolStripButtonViewReport_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {MdiParent = MdiParent, WindowState = FormWindowState.Normal};
      frm.OpenDataSet(BindingSourceScript, false);
      frm.Show();
    }

    private void ObjectBrowser_NodeSelected(object sender, EventArgs e)
    {
      propertyGrid1.SelectedObject = sender;
      if (!ShowEnumerable(sender as IEnumerable))
      {
        bindingSourceEnumerable.DataSource = null;
        splitContainerValues.Panel2Collapsed = true;
        //splitContainerValues.SplitterDistance = splitContainerValues.Height;
      }
      else
        splitContainerValues.Panel2Collapsed = false;
    }

    private bool ShowEnumerable(IEnumerable enumerable)
    {
      return AWHelper.BindEnumerable(enumerable, bindingSourceEnumerable);
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      TheProject.Save();
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      AWHelper.CopyEntireDataGridViewToClipboard(dataGridViewEnumerable);
    }

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {MdiParent = MdiParent, WindowState = FormWindowState.Normal};
      frm.OpenDataSet(bindingSourceEnumerable, false);
      frm.Show();
    }

    private void copyToolStripButtonQuery_Click(object sender, EventArgs e)
    {
      AWHelper.CopyEntireDataGridViewToClipboard(dataGridViewScript);
    }

    private void toolStripComboBoxClipboardCopyMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      dataGridViewScript.ClipboardCopyMode = (DataGridViewClipboardCopyMode)toolStripComboBoxClipboardCopyMode.SelectedItem;
    }
  }

  public interface IQueryScript
  {
    IEnumerable QueryProject(Project project);
  }
}