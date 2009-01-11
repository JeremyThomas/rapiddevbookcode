using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Reflection;

namespace href.Controls.PropGridEx
{
    /// <summary>
    /// Custom PropertyDescriptor for Fields
    /// </summary>
    internal class FieldMemberDescriptor : PropertyDescriptor
    {
        private FieldInfo m_FieldInfo;
        private Type m_ObjectType;
        internal FieldMemberDescriptor(Type objectType, FieldInfo field)
            : base(String.Concat(objectType.Name, ".", field.Name), null)
        {
            this.m_FieldInfo = field;
            this.m_ObjectType = objectType;
        }


        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return this.m_FieldInfo.FieldType; }
        }

        public override object GetValue(object component)
        {
            if (component == null)
                return null;
            // can be used for static fields too 
            if (this.m_FieldInfo.IsStatic)
                return this.m_FieldInfo.GetValue(null);
            else
                return this.m_FieldInfo.GetValue(component);
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


                string category = "";
                if (this.m_FieldInfo.IsPublic)
                    category = "public";
                else if (this.m_FieldInfo.IsPrivate)
                    category = "private";
                else if (this.m_FieldInfo.IsFamily)
                    category = "protected";
                else if (this.m_FieldInfo.IsFamilyAndAssembly)
                    category = "protected internal";
                else if (this.m_FieldInfo.IsAssembly)
                    category = "internal";



                attributes.Add(new CategoryAttribute(category));

                attributes.Add(new DescriptionAttribute(String.Format("{0} {1} {2}\n\rDefined in class {3}", category , this.m_FieldInfo.FieldType, this.m_FieldInfo.Name, this.m_ObjectType.FullName ) ));


                // add expandable type conv?
                if ((!hasExpandebleTypeConverter) && (!this.m_FieldInfo.FieldType.IsValueType) && (this.m_FieldInfo.FieldType != typeof(string)))
                {
                    attributes.Add(new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
                }

                AttributeCollection result = new AttributeCollection(attributes.ToArray());

                
                return result;
            }
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType
        {
            get { return this.m_FieldInfo.FieldType; }
        }

        public FieldInfo FieldInfo
        {
            get { return this.m_FieldInfo; }
        }

        public override void ResetValue(object component)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void SetValue(object component, object value)
        {
            if (component == null)
                return;
            this.m_FieldInfo.SetValue(component, value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        public override PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
        {
            // get default child properties
            PropertyDescriptorCollection props = base.GetChildProperties(instance, filter);
            
            // if it is an IList
            IList list = instance as IList;
            if (list != null)
            {
                // add special property Descriptors for the items
                for (int i = 0; i < list.Count; i++)
                {
                    props.Add(new ListItemMemberDescriptor(list, i));
                }
            }

            // if it is an IDictionary
            IDictionary dict = instance as IDictionary;
            if (dict != null)
            {
                foreach (Object key in dict.Keys)
                {
                    // add special property Descriptors for the values
                    props.Add(new DictionaryItemMemberDescriptor(dict, key));
                }
            }
            return props;
        }

    }
}
