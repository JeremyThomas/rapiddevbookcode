using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

//http://www.codeproject.com/KB/grid/PropertyGridExWinForms.aspx

namespace AW.Helper.PropertyDescriptors
{
  /// <summary>
  ///   Custom PropertyDescriptor for Fields
  /// </summary>
  public class FieldMemberDescriptor : PropertyDescriptor
  {
    private readonly FieldInfo m_FieldInfo;

    public FieldMemberDescriptor(FieldInfo field)
      : base(String.Concat(field.DeclaringType.Name, ".", field.Name), (Attribute[]) field.GetCustomAttributes(typeof (Attribute), true))
    {
      m_FieldInfo = field;
    }


    public override bool CanResetValue(object component)
    {
      return false;
    }

    public override Type ComponentType
    {
      get { return m_FieldInfo.FieldType; }
    }

    public override object GetValue(object component)
    {
      // can be used for static fields too 
      if (m_FieldInfo.IsStatic)
        return m_FieldInfo.GetValue(null);
      var value = m_FieldInfo.GetValue(component);
      var theDelegate = value as Delegate;
      if (theDelegate != null)
      {
        var m = theDelegate.Method;
        if (m.DeclaringType != null) return m.DeclaringType.FullName + "." + m.Name;
      }
      return m_FieldInfo.GetValue(component);
    }


    /// <summary>
    ///   Create an AttributeCollection that ensures an ExpandableObjectConverter
    ///   and add Description and Category attributes
    /// </summary>
    public override AttributeCollection Attributes
    {
      get
      {
        var hasExpandebleTypeConverter = false;
        var baseAttribs = base.Attributes;
        var attributes = new List<Attribute>(baseAttribs.Count);
        foreach (Attribute baseAttribute in baseAttribs)
        {
          var tca = baseAttribute as TypeConverterAttribute;

          if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof (ExpandableObjectConverter))))
          {
            attributes.Add(baseAttribute);
            hasExpandebleTypeConverter = true;
          }
          else
          {
            attributes.Add(baseAttribute);
          }
        }


        var category = "";
        if (m_FieldInfo.IsPublic)
          category = "public";
        else if (m_FieldInfo.IsPrivate)
          category = "private";
        else if (m_FieldInfo.IsFamily)
          category = "protected";
        else if (m_FieldInfo.IsFamilyAndAssembly)
          category = "protected internal";
        else if (m_FieldInfo.IsAssembly)
          category = "internal";


        attributes.Add(new CategoryAttribute(category));

        attributes.Add(new DescriptionAttribute(String.Format("{0} {1} {2}\n\rDefined in class {3}", category, m_FieldInfo.FieldType, m_FieldInfo.Name, m_FieldInfo.DeclaringType == null ? null : m_FieldInfo.DeclaringType.FullName)));


        // add expandable type conv?
        if ((!hasExpandebleTypeConverter) && (!m_FieldInfo.FieldType.IsValueType) && (m_FieldInfo.FieldType != typeof (string)))
        {
          attributes.Add(new TypeConverterAttribute(typeof (ExpandableObjectConverter)));
        }

        var result = new AttributeCollection(attributes.ToArray());


        return result;
      }
    }

    public override bool IsReadOnly
    {
      get { return false; }
    }

    public override Type PropertyType
    {
      get { return m_FieldInfo.FieldType; }
    }

    public FieldInfo FieldInfo
    {
      get { return m_FieldInfo; }
    }

    public override void ResetValue(object component)
    {
      throw new Exception("The method or operation is not implemented.");
    }

    public override void SetValue(object component, object value)
    {
      m_FieldInfo.SetValue(component, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
      return false;
    }

    public override PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
    {
      // get default child properties
      var props = base.GetChildProperties(instance, filter);

      // if it is an IList
      var list = instance as IList;
      if (list != null)
      {
        // add special property Descriptors for the items
        for (var i = 0; i < list.Count; i++)
        {
          props.Add(new ListItemMemberDescriptor(list, i));
        }
      }

      // if it is an IDictionary
      var dict = instance as IDictionary;
      if (dict != null)
      {
        foreach (var key in dict.Keys)
        {
          // add special property Descriptors for the values
          props.Add(new DictionaryItemMemberDescriptor(dict, key));
        }
      }
      return props;
    }
  }
}