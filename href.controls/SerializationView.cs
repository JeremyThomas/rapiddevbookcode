using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

namespace href.Controls
{
    public partial class SerializationView : Form
    {
        private object m_Object;
        private Dictionary<object, SerializationInfo> m_SerializationInfos;
        private StreamingContext m_Context;
        private FieldInfo m_FldMemberNames;
        private FieldInfo m_FldMemberValues;

        public SerializationView()
        {
            InitializeComponent();

            // thanks to reflector... 
            Type tSerinfo = typeof(SerializationInfo);
            this.m_FldMemberNames = tSerinfo.GetField("m_members", BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance);
            this.m_FldMemberValues = tSerinfo.GetField("m_data", BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance);

        }

        public SerializationView(object objToSerialize)
            : this()
        {
            this.Object = objToSerialize;


        }


        public override void Refresh()
        {
            base.Refresh();

            this.binSerTree.Nodes.Clear();
            this.m_SerializationInfos = new Dictionary<object, SerializationInfo>();
            this.m_Context = new StreamingContext(StreamingContextStates.Persistence, this);
            if (this.Object != null)
            {
                TreeNode root = new TreeNode();
                IComponent comp = this.Object as IComponent;
                if ( (comp != null) && (comp.Site != null) && (comp.Site.Name != null) )
                {
                    root.Text = comp.Site.Name;
                }
                else
                {
                    root.Text = this.Object.GetType().Name;
                }

                Serialize(this.Object,root);
                this.binSerTree.Nodes.Add(root);
            }


        }

        private void Serialize(object p, TreeNode parent)
        {
            // nothing to serialize?
            if (p == null)
                return;
            // already serlialized?
            if ( !p.GetType().IsValueType && this.m_SerializationInfos.ContainsKey(p))
                return;

            
            ISerializable serializable = p as ISerializable;
            SerializationInfo serInfo = new SerializationInfo(p.GetType(), new FormatterConverter());
            // use ISerializable?
            if (serializable != null)
            {
                serializable.GetObjectData(serInfo, this.m_Context);
            }
            else // use reflection
            {
                FieldInfo[] fields = p.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                foreach (FieldInfo field in fields)
                {
                    if (field.IsNotSerialized)
                        continue;
                    // array?
                    if (field.FieldType.IsArray)
                    {
                        Array ar = field.GetValue(p) as Array;
                        if (ar != null)
                        {
                            // array of ValueTypes?
                            string typeName = ar.GetType().FullName;
                            typeName = typeName.Substring(0, typeName.Length - 2);
                            Type elementType = Type.GetType(typeName + ", " + ar.GetType().Assembly.FullName);
                            if ((elementType != null) && ((elementType.IsValueType) || (elementType == typeof(string))))
                            {
                                serInfo.AddValue(string.Format("{0} {1}[{2}]", field.Name, elementType.Name, ar.Length), ar);
                            }
                            else
                            {



                                System.Collections.IEnumerator enumAr = ar.GetEnumerator();
                                for (int i = 0; (i < ar.Length) && (enumAr.MoveNext()); i++)
                                {
                                    serInfo.AddValue(string.Format("{0}[{1}]", field.Name, i), enumAr.Current);
                                }
                            }
                        }
                    } 
                   
                    else
                    {
                        serInfo.AddValue(field.Name, field.GetValue(p));
                      
                    }

                }
            }

            if (p is System.Collections.IList)
            {
                System.Collections.IList list = p as System.Collections.IList;
                for (int i = 0; i < list.Count; i++)
                {
                    serInfo.AddValue(string.Format("{0}[{1}]", parent.Text, i), list[i]);
                }
            }
            else if (p is System.Collections.IDictionary)
            {
                System.Collections.IDictionary dict = p as System.Collections.IDictionary;
                foreach (object key in dict.Keys)
                {
                    serInfo.AddValue(string.Format("{0}[{1}]", parent.Text, key), dict[dict]);
                }
            }

            parent.Tag = serInfo;
            if (!p.GetType().IsValueType)
            {
                this.m_SerializationInfos.Add(p, serInfo);

                string[] memberNames = (string[])this.m_FldMemberNames.GetValue(serInfo);
                object[] memberValues = (object[])this.m_FldMemberValues.GetValue(serInfo);
                for (int i = 0; i < serInfo.MemberCount; i++)
                {
                    bool serializeChidlren = true;
                    string name = memberNames[i];
                    if ((name == null) || (name.Length == 0))
                        name = "#" + i.ToString();
                    object value = memberValues[i];
                    if (value == null)
                        name = name + " (null)";
                    else
                    {
                        // array of ValueTypes?
                        if (value.GetType().IsArray)
                        {
                            Array ar = value as Array;
                            string typeName = value.GetType().FullName;
                            typeName = typeName.Substring(0, typeName.Length - 2);
                            Type elementType = Type.GetType(typeName + ", " + ar.GetType().Assembly.FullName);
                            if ((elementType != null) && ((elementType.IsValueType) || (elementType == typeof(string))))
                            {
                                name = string.Format("{0} : {1}[{2}]", memberNames[i], elementType.Name, ar.Length);
                                serializeChidlren = false;
                            }
                            else
                                name = name + " (" + value.GetType().Name + ")";
                        }
                        else
                            name = name + " : " + value.GetType().Name;
                    }


                    TreeNode subNode = new TreeNode(name);
                    parent.Nodes.Add(subNode);

                    if ( (value != null) && (serializeChidlren) )
                        Serialize(value, subNode);

                }
            }
        }

        public object Object
        {
            get { return this.m_Object; }
            set
            {
                this.m_Object = value;
                Refresh();
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            if (this.Object == null)
                return;
            this.Refresh();   
        }

    }
}