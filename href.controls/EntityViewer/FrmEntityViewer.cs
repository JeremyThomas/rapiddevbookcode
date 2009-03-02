using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;
using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Entities;
using SD.LLBLGen.Pro.DBDriverCore;
using SD.LLBLGen.Pro.ORMSupportClasses;
using WB.LLBLGen.Pro.Plugins;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntityViewer: Form
  {
    private static TypeDescriptionProvider CommonEntityBaseTypeDescriptionProvider;
    private static TypeDescriptionProvider EntityFieldsTypeDescriptionProvider; //

    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridViewEnumerable.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (CommonEntityBaseTypeDescriptionProvider == null)
      {
        CommonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (object));
        TypeDescriptor.AddProvider(CommonEntityBaseTypeDescriptionProvider, typeof (object));
      }

      if (EntityFieldsTypeDescriptionProvider == null)
        EntityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
      // TypeDescriptor.AddProvider(EntityFieldsTypeDescriptionProvider, typeof(EntityFields));
    }

    public FrmEntityViewer(object entity)
      : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      propertyGrid1.SelectedObject = entity;
      stateBrowser.ObjectToBrowse = entity;
    }

    private void FrmEntityViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.EntityFieldColumns = AWHelper.SaveColumnState(dataGridViewFields);
    }

    private void FrmEntityViewer_Load(object sender, EventArgs e)
    {
      propertyGrid1.RefreshSelectedObject();
      AWHelper.RestoreColumnsState(Settings.Default.EntityFieldColumns, dataGridViewFields);
    }

    private void propertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
      if (e.NewSelection.Value != null && !(e.OldSelection == null && dataGridViewEnumerable.DataSource == propertyGrid1.SelectedObject))
        if (!(e.NewSelection.Value is string))
          if (e.NewSelection.Value is IEnumerable)
          {
            var enumerable = (IEnumerable)e.NewSelection.Value;
            try
            {
              bindingSourceEnumerable.DataSource = enumerable.AsQueryable();
            }
            catch (ArgumentException)
            {
              bindingSourceEnumerable.DataSource = enumerable;
            }
          }
          else if (!e.NewSelection.PropertyDescriptor.PropertyType.IsValueType)
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
      bindingSourceEnumerable.DataSource = propertyGrid1.SelectedObject;
      if (propertyGrid1.SelectedObject is IEntity)
        entityFieldBindingSource.DataSource = ((IEntity)propertyGrid1.SelectedObject).Fields.AsQueryable();
      if (propertyGrid1.SelectedObject is Project)
      {
        Text = "ProjectBrowser";
        dataGridViewFields.AutoGenerateColumns = true;
        entityFieldBindingSource.DataSource = ((Project)propertyGrid1.SelectedObject).Entities;
        toolStripButtonViewGroupedEntities.Visible = true;
      }
    }

    private Project TheProject
    {
      get { return (Project)propertyGrid1.SelectedObject; }
    }

    private void toolStripButtonViewGroupedEntities_Click(object sender, EventArgs e)
    {
      var x = from entity in TheProject.Entities.OfType<EntityDefinition>()
              select
                new
                  {
                    entity.ElementTargetName,
                    entity.ElementName,
                    entity.TargetType,
                    groups = string.Join(",", (from peg in TheProject.ProjectElementGroups.Values.OfType<ProjectElementGroup>()
                                               from ed in peg.Keys.OfType<EntityDefinition>()
                                               where !peg.IsSystemGroup && ed.ElementTargetName == entity.ElementTargetName
                                               select peg.Name).ToArray()),
                    Description = entity.CustomProperties.ContainsKey("MS_Description") ? entity.CustomProperties["MS_Description"].ToString() : string.Empty
                    //.Aggregate((current, next) => current + ", " + next)
                  };
      var t = from peg in TheProject.ProjectElementGroups.Values.OfType<ProjectElementGroup>()
              from ed in peg.Keys.OfType<EntityDefinition>()
              where !peg.IsSystemGroup && ed.ElementTargetName == "AQD.gn_Aircraft"
              select new {ed.ElementTargetName, ed.ElementName, peg.Name};
      bindingSourceEnumerable.DataSource = x;
    }

    private void toolStripButtonRunPlugin_Click(object sender, EventArgs e)
    {
      //PluginBase pluginToTest = new RenameRelatedFieldsPlugin {ProjectToTarget = TheProject, Callbacks = new Hashtable {{ProgressCallBack.LogLineToApplicationOutputCallBack, (ApplicationOutputLogLineCallBack)ApplicationOutputLogLine}}};
      PluginBase pluginToTest = new RefreshCustomProperties {ProjectToTarget = TheProject, Callbacks = new Hashtable {{ProgressCallBack.LogLineToApplicationOutputCallBack, (ApplicationOutputLogLineCallBack)ApplicationOutputLogLine}}};
      pluginToTest.Entities.AddRange(TheProject.Entities);
      pluginToTest.GetConfigurationControl();
      pluginToTest.Execute();
    }

    private static void ApplicationOutputLogLine(string lineToLog, string source, bool isVerboseMessage, bool appendNewLine)
    {
      if (appendNewLine)
        Trace.WriteLine(lineToLog);
      else
        Trace.Write(lineToLog);
    }
  }
}