using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Winforms.Helpers.PropGridEx;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL.PropGridEx
{
  class RawLLBLMemberTab : RawMemberTab
  {
    public override void GetProperties(IList list, List<PropertyDescriptor> fields)
    {
      if (list != null)
      {
        var entityFields = list as IEntityFields;
        if (entityFields == null)
          // add an ListItemMemberDescriptor fore each item in the list
          fields.AddRange(list.Cast<object>().Select((t, i) => new ListItemMemberDescriptor(list, i)).Cast<PropertyDescriptor>());
        else
          fields.AddRange(entityFields.Cast<object>().Select((t, i) => new EntityFieldMemberDescriptor(entityFields, i)).Cast<PropertyDescriptor>());
      }
    }
  }
}