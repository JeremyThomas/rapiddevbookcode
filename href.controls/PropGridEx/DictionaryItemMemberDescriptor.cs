using System;
using System.Collections;

namespace href.Controls.PropGridEx
{
  /// <summary>
  /// PropertyDescriptor for all items in an IDictionary
  /// </summary>
  public class DictionaryItemMemberDescriptor : ListItemAbstractDescriptor
  {
    private readonly IDictionary m_Dict;
    private readonly object m_Key;

    internal DictionaryItemMemberDescriptor(IDictionary list, object key)
      :
        base(String.Format("[{0}]", key), null)
    {
      m_Dict = list;
      m_Key = key;
    }

    public override Type ComponentType
    {
      get { return typeof (IDictionary); }
    }

    public override object GetValue(object component)
    {
      return m_Key != null ? m_Dict[m_Key] : null;
    }

    // string category = "IDictionary";
    //        attributes.Add(new CategoryAttribute(category));
    public override string Category
    {
      get { return "IList"; }
    }

    //        attributes.Add(new DescriptionAttribute(String.Format("Dictionary item with key '{0}'", this.m_Key)));
    public override string Description
    {
      get { return String.Format("Dictionary item with key '{0}'", m_Key); }
    }
  }
}