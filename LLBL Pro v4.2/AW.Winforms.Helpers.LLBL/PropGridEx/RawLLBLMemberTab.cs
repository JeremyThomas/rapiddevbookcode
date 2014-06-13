using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Winforms.Helpers.PropGridEx;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL.PropGridEx
{
  internal class RawLLBLMemberTab : RawMemberTab
  {
    protected override void GetProperties(IList list, List<PropertyDescriptor> fields)
    {
      if (list != null)
      {
        var entityFields = list as IEntityFields;
        // add an ListItemMemberDescriptor fore each item in the list
        fields.AddRange(entityFields == null 
          ? list.Cast<object>().Select((t, i) => new ListItemMemberDescriptor(list, i)) 
// ReSharper disable once RedundantEnumerableCastCall
          : entityFields.Cast<object>().Select((t, i) => new EntityFieldMemberDescriptor(entityFields, i)).Cast<PropertyDescriptor>());
      }
    }
  }
}