using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace href.Controls.PropGridEx
{
    internal class ListItemMemberDescriptor : PropertyDescriptor
    {
        private IList m_List;
        private int m_Index;
        internal ListItemMemberDescriptor(IList list, int index)
            :
            base(String.Format("[{0}]", index), null)
        {
            this.m_List = list;
            this.m_Index = index;
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return typeof(IList); }
        }

        public override object GetValue(object component)
        {
            return this.m_List[this.m_Index];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType
        {
            get
            {
                object val = this.m_List[this.m_Index];
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


                string category = "IList";

                attributes.Add(new CategoryAttribute(category));

                attributes.Add(new DescriptionAttribute(String.Format("List item at position {0}", this.m_Index)));

                object value = this.m_List[ this.m_Index];
                if (value != null)
                {
                    Type valueType = value.GetType();
                    // add expandable type conv?
                    if ((!hasExpandebleTypeConverter) && (!valueType.IsValueType) && (valueType != typeof(string)))
                    {
                        attributes.Add(new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
                    }
                }
                AttributeCollection result = new AttributeCollection(attributes.ToArray());



                return result;
            }
        }
    }
}
