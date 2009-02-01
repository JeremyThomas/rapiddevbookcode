using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using SD.LLBLGen.Pro.ORMSupportClasses;
using FieldInfo=System.Reflection.FieldInfo;

namespace href.Controls.PropGridEx
{
    /// <summary>
    /// A custom PropertyTab that simply list all instance fields
    /// </summary>
    public class RawMemberTab : PropertyTab
    {

        public RawMemberTab()
        {
        }

        public RawMemberTab(IServiceProvider serviceProvider)
        {
        }

        public RawMemberTab(IDesignerHost designerHost)
        {
        }

        /// <summary>
        /// extend everything
        /// </summary>
        public override bool CanExtend(object extendee)
        {
            return true;
        }

        /// <summary>
        /// the tab's iumage
        /// </summary>
        public override System.Drawing.Bitmap Bitmap
        {
            get
            {
                return Properties.Resources.Members;
            }
        }

        /// <summary>
        /// the tab's name
        /// </summary>
        public override string TabName
        {
            get { return "Raw View"; }
        }


        /// <summary>
        /// used to filter implemented interfaces in a type
        /// </summary>
        /// <returns>true if the requested interfaces are implemented</returns>
        protected static bool InterfaceFilter(Type typeObj, Object criteriaObj)
        {
            Type t = criteriaObj as Type;
            if (t == null)
                return false;
            if (typeObj == t)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Add the instance fields of an object
        /// </summary>
        private static void AddTypeFields(object component, Type type, List<PropertyDescriptor> fields, List<string> addedMemberNames)
        {

            // stop at List / ArrayList / Dictionary / SortedList / Hashtable 
            if ( (type == typeof(ArrayList)) || 
                (type == typeof(Hashtable)) || 
                (type == typeof(SortedList) )  )
                return;


            // get all instance FieldInfos
            FieldInfo[] fieldInfos = type.GetFields( BindingFlags.Instance | 
                BindingFlags.Public | 
                BindingFlags.NonPublic);


            for (int i = 0; i < fieldInfos.Length; i++)
            {
                FieldInfo field = fieldInfos[i];

                // ignore doublette names
                if (addedMemberNames.Contains(field.Name))
                    continue;

                // this one made it in the list... 
                addedMemberNames.Add(field.Name);
                fields.Add( new FieldMemberDescriptor(field) );
            }
            

        }

        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(object component)
        {
            return this.GetProperties(component, null);
        }

        /// <summary>
        /// Gather all PropertyDescriptors for the RawMemberTab
        /// </summary>
        public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
        {
            if (component == null)
            {
                return new PropertyDescriptorCollection(null, true);
            }

            // use a stack to reverse hierarchy
            // if fieldnames occure in more than one class
            // use the one from the class that is highest in the class hierarchy
            Stack<Type> objectHierarchy = new Stack<Type>();
            Type curType = component.GetType();
            while (curType != null)
            {
                objectHierarchy.Push(curType);
                curType = curType.BaseType;
            }

            // list of the PropertyDescriptors that will be returned
            List<PropertyDescriptor> fields = new List<PropertyDescriptor>();
            // list to rememnber already added names
            List<string> addedMemberNames = new List<string>();

            // special treatment for classes implementing IList
            IList list = component as IList;
            if (list != null)
            {
              IEntityFields entityFields = component as IEntityFields;
              if (entityFields == null)
                // add an ListItemMemberDescriptor fore each item in the list
                for (int i = 0; i < list.Count; i++)
                {
                    fields.Add(new ListItemMemberDescriptor(list, i));
                }
              else
                for (int i = 0; i < entityFields.Count; i++)
                {
                  fields.Add(new EntityFieldMemberDescriptor(entityFields, i));
                }

            }

            // special treatment for classes implementing IDictionary
            IDictionary dict = component as IDictionary;
            if (dict != null)
            {
                foreach (Object key in dict.Keys)
                {
                    // add an DictionaryItemMemberDescriptor fore each key in the list
                    fields.Add(new DictionaryItemMemberDescriptor(dict, key));
                }
            }


            // add all the instance fields
            while (objectHierarchy.Count > 0)
            {
                AddTypeFields(component, objectHierarchy.Pop(), fields, addedMemberNames);
            }
           

            return new PropertyDescriptorCollection(fields.ToArray());

        }

        

    }
}
