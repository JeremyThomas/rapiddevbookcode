using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Data.EntityClasses;
using AW.Helper;

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

        foreach (var browsableProperty in MetaDataHelper.GetBrowsableProperties(entityType))
          entityNode.Nodes.Add(browsableProperty.Name);

        //foreach (var info in entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        //{
        //  var browsableAttributes = info.GetCustomAttributes(typeof(BrowsableAttribute), true);
        //  if (browsableAttributes.Count()==0 || ((BrowsableAttribute)browsableAttributes[0]).Browsable)
        //    entityNode.Nodes.Add(info.Name);
        //}
      }
    }

    public static IEnumerable<PropertyInfo[]> GetFields()
    {
      return from entityType in GetEntitiesTypes()
             select entityType.GetProperties();
    }

    public static IEnumerable<Type> GetEntitiesTypes()
    {
      return MetaDataHelper.GetDescendance(typeof (CommonEntityBase));
    }

    private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(e.Item, DragDropEffects.Move);
    }
  }
}