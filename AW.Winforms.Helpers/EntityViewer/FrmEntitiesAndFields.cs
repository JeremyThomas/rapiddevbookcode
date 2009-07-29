using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntitiesAndFields : Form
  {
    private readonly Type BaseType;
    private readonly Assembly EntityAssembly;
    private static FrmEntitiesAndFields FormSingleton;

    public static void ShowEntitiesAndFields(Type baseType)
    {
      ShowEntitiesAndFields(baseType, null);
    }

    public static void ShowEntitiesAndFields(Type baseType, Form parent)
    {
      if (FormSingleton == null)
        FormSingleton = new FrmEntitiesAndFields(baseType);
      FormSingleton.WindowState = FormWindowState.Normal;
      if (parent == null)
        FormSingleton.ShowDialog();
      else
      {
        FormSingleton.Parent = parent;
        FormSingleton.Show();
      }
    }

    public FrmEntitiesAndFields()
    {
      InitializeComponent();
    }

    public FrmEntitiesAndFields(Assembly entityAssembly) : this()
    {
      EntityAssembly = entityAssembly;
    }

    public FrmEntitiesAndFields(Type baseType) : this(baseType.Assembly)
    {
      BaseType = baseType;
    }

    private void FrmEntitiesAndFields_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.EntitiesAndFieldsSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.Save();
    }

    private void EntitiesAndFields_Load(object sender, EventArgs e)
    {
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntitiesAndFieldsSizeLocation);
      treeViewEntities.Nodes.Clear();
      foreach (var entityType in GetEntitiesTypes())
      {
        var entityNode = treeViewEntities.Nodes.Add(entityType.Name);

        foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>())
          entityNode.Nodes.Add(browsableProperty.Name);
      }
    }

    public IEnumerable<Type> GetEntitiesTypes()
    {
      if (BaseType != null)
        return MetaDataHelper.GetDescendance(BaseType);
      if (EntityAssembly == null) 
        return MetaDataHelper.GetAllLoadedDescendance(typeof (EntityBase));
      return MetaDataHelper.GetDescendance(typeof (EntityBase), EntityAssembly.GetExportedTypes());
    }

    private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(((TreeNode) e.Item).Text, DragDropEffects.All);
    }


  }
}