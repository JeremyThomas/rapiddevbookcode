using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.PropGridEx
{
  class EntityFieldMemberDescriptor : ListItemAbstractDescriptor
  {
    private readonly IEntityField entityField;

    public EntityFieldMemberDescriptor(IEntityFields entityFields, int index)
      : base(entityFields[index].Name)
    {
      entityField = entityFields[index];
    }

    public override object GetValue(object component)
    {
      return entityField;
    }

    public override Type ComponentType
    {
      get { return typeof(IEntityFields); }
    }
  }
}