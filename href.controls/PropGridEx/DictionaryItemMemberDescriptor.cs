using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace href.Controls.PropGridEx
{

    /// <summary>
    /// PropertyDescriptor for all items in an IDictionary
    /// </summary>
    internal class DictionaryItemMemberDescriptor : PropertyDescriptor
    {
        private IDictionary m_Dict;
        private object m_Key;

        internal DictionaryItemMemberDescriptor(IDictionary list, object key)
            :
            base(String.Format("[{0}]", key), null)
        {
            this.m_Dict = list;
            this.m_Key = key;
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return typeof(IDictionary); }
        }

        public override object GetValue(object component)
        {
            return this.m_Dict[this.m_Key];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType
        {
            get
            {
                object val = this.m_Dict[this.m_Key];
                if (val != null)
                    return val.GetType();
                else
                    return typeof(object);
            }
        }

        public override void ResetValue(object component)
        {

        }

        public override void SetValue(object component, object value)
        {

        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }


        /// <summary>
        /// Create an AttributeCollection that ensures an ExpandableObjectConverter
        /// and add Description and Category attributes
        /// </summary>
        public override AttributeCollection Attributes
        {
            get
            {
                bool hasExpandebleTypeConverter = false;
                AttributeCollection baseAttribs = base.Attributes;
                List<Attribute> attributes = new List<Attribute>(baseAttribs.Count);
                foreach (Attribute baseAttribute in baseAttribs)
                {
                    TypeConverterAttribute tca = baseAttribute as TypeConverterAttribute;

                    if ( (tca != null) && (Type.GetType( tca.ConverterTypeName).IsSubclassOf(typeof(ExpandableObjectConverter)) ) )
                    {
                        attributes.Add(baseAttribute);
                        hasExpandebleTypeConverter = true;
                    
                    }
                    else
                    {
                        attributes.Add(baseAttribute);
                    }
                }


                string category = "IDictionary";

                attributes.Add(new CategoryAttribute(category));

                attributes.Add(new DescriptionAttribute(String.Format("Dictionary item with key '{0}'", this.m_Key)));


                // add expandable type conv?
                if (this.m_Key != null)
                {
                    object value = this.m_Dict[ this.m_Key];
                    if (value != null)
                    {
                        Type valueType = value.GetType();
                        // add expandable type conv?
                        if ((!hasExpandebleTypeConverter) && (!valueType.IsValueType) && (valueType != typeof(string)))
                        {
                            attributes.Add(new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
                        }
                    }
                }
                AttributeCollection result = new AttributeCollection(attributes.ToArray());



                return result;
            }
        }
    }
   
}
