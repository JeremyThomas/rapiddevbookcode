using System;
using AW.Winforms.Helpers.PropGridEx;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL.PropGridEx
{
  internal class EntityFieldMemberDescriptor : ListItemAbstractDescriptor
  {
    private readonly IEntityField _entityField;

    public EntityFieldMemberDescriptor(IEntityFields entityFields, int index)
      : base(entityFields[index].Name)
    {
      _entityField = entityFields[index];
    }

    public override object GetValue(object component)
    {
      return _entityField;
    }

    public override Type ComponentType
    {
      get { return typeof (IEntityFields); }
    }
  }
}