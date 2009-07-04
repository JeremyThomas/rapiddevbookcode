using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AW.Data.EntityClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntitiesAndFields : Form
  {
    public FrmEntitiesAndFields()
    {
      InitializeComponent();
    }

    private void EntitiesAndFields_Load(object sender, EventArgs e)
    {
      foreach (var entityType in GetEntitiesTypes())
      {
        var entityNode = treeViewEntities.Nodes.Add(entityType.Name);
        foreach (var info in entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
          var browsableAttributes = info.GetCustomAttributes(typeof(BrowsableAttribute), true);
          if (browsableAttributes.Count()==0 || ((BrowsableAttribute)browsableAttributes[0]).Browsable)
            entityNode.Nodes.Add(info.Name);
        }
      }
    }

    public static IEnumerable<PropertyInfo[]> GetFields()
    {
      return from entityType in GetEntitiesTypes()
             select entityType.GetProperties();
    }

    public static IEnumerable<Type> GetEntitiesTypes()
    {
      return GetDescendance(typeof(CommonEntityBase));
    }

    public static IEnumerable<Type> GetDescendance(Type ancestorType)
    {
      return from type in ancestorType.Assembly.GetExportedTypes()
             where type.IsPublic && !type.IsAbstract && type.IsSubclassOf(ancestorType)
             select type;
    }

    private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(e.Item, DragDropEffects.Move);
    }
  }
}
