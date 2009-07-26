using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntitiesAndFields : Form
  {
    private readonly Type BaseType;
    private readonly Assembly EntityAssembly;

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

    public IEnumerable<PropertyInfo[]> GetFields()
    {
      return from entityType in GetEntitiesTypes()
             select entityType.GetProperties();
    }

    public IEnumerable<Type> GetEntitiesTypes()
    {
      if (BaseType != null)
        return MetaDataHelper.GetDescendance(BaseType);
      return EntityAssembly != null ? MetaDataHelper.GetDescendance(typeof (EntityBase), EntityAssembly.GetExportedTypes()) :
        MetaDataHelper.GetAllLoadedDescendance(typeof (EntityBase));
    }

    private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(e.Item, DragDropEffects.Move);
    }
  }
}