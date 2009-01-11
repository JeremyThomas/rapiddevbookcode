using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing.Design;
using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

namespace href.Controls.PropGridEx
{

    /// <summary>
    /// Special PropertyGrid that has an aditional TabPage for the instance members
    /// and leverages IPropertyValueUIService 
    /// </summary>
    public class PropertyGridEx : PropertyGrid
    {

        private IServiceProvider m_ServiceProvider;
        private ServiceContainer m_PrivateContainer; // if no service provider is provided
        private href.Controls.Hosting.DummySite m_DummySite;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PropertyGridEx()
            : this(null)
        {
            
        }

        /// <summary>
        /// Use this constructor if you already have an ServiceProvider infrastructure
        /// </summary>
        /// <param name="serviceProvider">a ServiceProvider</param>
        public PropertyGridEx(IServiceProvider serviceProvider)
            :base()
        {
            this.DrawFlat = true;
            // add the RawPage now and for ever (static)
            this.PropertyTabs.AddTabType(typeof(RawMemberTab), PropertyTabScope.Static);

            this.SetServiceProvider(serviceProvider);

           
        }

        /// <summary>
        /// Set/Get the current ServiceProvider
        /// </summary>
        /// <param name="serviceProvider">a ServiceProvider</param>
        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            RemovePropUIHandler();

            // no valid service provider
            if (serviceProvider == null)
            {
                // create own
                if (this.m_PrivateContainer == null)
                {
                    this.m_PrivateContainer = new ServiceContainer();
                    // add our own IPropertyValueUIService
                    this.m_PrivateContainer.AddService(typeof(IPropertyValueUIService), new href.Controls.Hosting.PropertyValueUIService());
                }
                this.m_ServiceProvider = this.m_PrivateContainer;
            }
            else
            {
                // use provided one (if no IPropertyValueUIService is provided, the overlay icons will not work)
                this.m_ServiceProvider = serviceProvider;
            }

            // propagate ServiceProvider to the DummySite
            if (this.m_DummySite != null)
                this.m_DummySite.ServiceProvider = this.m_ServiceProvider;

            AddPropUIHandler();
        }

        /// <summary>
        /// Remove the PropertyValueUIHandler
        /// this is used when the ServiceProvider  changes or the control disposes
        /// </summary>
        protected void RemovePropUIHandler()
        {
            if (this.m_ServiceProvider != null)
            {
                IPropertyValueUIService propValUiService = this.m_ServiceProvider.GetService(typeof(IPropertyValueUIService)) as IPropertyValueUIService;
                if (propValUiService != null)
                {
                    propValUiService.RemovePropertyValueUIHandler(new PropertyValueUIHandler(this.PropertyValueUIHandler));
                }
            }
        }
        
        /// <summary>
        /// Add the PropertyValueUIHandler
        /// this is called when the ServiceProvider 
        /// If there is no ServiceProvider available or the current
        /// ServiceProivder does not provide the IPropertyValueUIService
        /// custom overlay images will not be supported
        /// </summary>
        protected void AddPropUIHandler()
        {
            if (this.m_ServiceProvider != null)
            {
                IPropertyValueUIService propValUiService = this.m_ServiceProvider.GetService(typeof(IPropertyValueUIService)) as IPropertyValueUIService;
                if (propValUiService != null)
                {
                    propValUiService.AddPropertyValueUIHandler(new PropertyValueUIHandler(this.PropertyValueUIHandler));
                }
            }
        }

        protected override void  Dispose(bool disposing)
        {
            // make sure the custom PropUIHandler is removed
            RemovePropUIHandler();
 	        base.Dispose(disposing);
        }


        /// <summary>
        /// Used to check if a Type does implement the ISerializable interface
        /// </summary>
        /// <returns></returns>
        internal static bool SerializableInterfaceFilter(Type typeObj, Object criteriaObj)
        {
            if (typeObj == typeof(ISerializable))
                return true;
            else
                return false;
        }

     
        /// <summary>
        /// The sample handler
        /// This simly opens a new SerializationForm 
        /// </summary>
        private void SerializablePropUiHandler(ITypeDescriptorContext context, PropertyDescriptor propDesc, PropertyValueUIItem invokedItem)
        {
            SerializationView serView = new SerializationView(context.Instance);
            if (this.m_ServiceProvider != null)
            {
                IUIService uiService = this.m_ServiceProvider.GetService(typeof(IUIService)) as IUIService;
                if (uiService != null)
                {
                    uiService.ShowDialog(serView);
                    return;
                }
            }
            serView.ShowDialog();
        }

        /// <summary>
        /// Add the custom PropUIHandlers
        /// </summary>
        /// <remarks>
        /// in this sample icons for the serialization options of a property or field are marked
        /// the double click action opens a SerializationView Form (which is still very weak)
        /// </remarks>
        private void PropertyValueUIHandler(ITypeDescriptorContext context, PropertyDescriptor propDesc, ArrayList valueUIItemList)
        {

            FieldMemberDescriptor fmd = propDesc as FieldMemberDescriptor;
            if (fmd != null)
            {
                // serializable
                if (  (fmd.PropertyType.IsSerializable) && (!fmd.FieldInfo.IsNotSerialized))
                {
                    PropertyValueUIItem valItem = new PropertyValueUIItem(Properties.Resources.save16, new PropertyValueUIItemInvokeHandler(SerializablePropUiHandler), "Serialized");
                    valueUIItemList.Add(valItem);

                    // implements ISerializable
                    if ((fmd.PropertyType.IsClass) && (fmd.PropertyType.FindInterfaces(new TypeFilter(SerializableInterfaceFilter), null).Length > 0))
                    {
                        valItem = new PropertyValueUIItem(Properties.Resources.save_as16, new PropertyValueUIItemInvokeHandler(SerializablePropUiHandler), "Implements ISerializable");
                        valueUIItemList.Add(valItem);
                    }
                }

               
            }
            else
            {
                // Xml Serializable?
                if ((context.Instance != null) && (context.Instance.GetType().IsSerializable))
                {
                    string xmlAttributeName = null;
                    bool isXmlIgnore = false;
                    foreach (Attribute attrib in propDesc.Attributes)
                    {
                        if (attrib is System.Xml.Serialization.XmlIgnoreAttribute)
                        {
                            isXmlIgnore = true;
                            break;
                        }

                        System.Xml.Serialization.XmlAttributeAttribute xmlAttribAttrib = attrib as System.Xml.Serialization.XmlAttributeAttribute;
                        if (xmlAttribAttrib != null)
                        {
                            xmlAttributeName = xmlAttribAttrib.AttributeName;
                        }
                    }

                    if (!isXmlIgnore)
                    {
                        if (xmlAttributeName != null)
                        {
                            PropertyValueUIItem valItem = new PropertyValueUIItem(Properties.Resources.XmlAttribute, new PropertyValueUIItemInvokeHandler(SerializablePropUiHandler), xmlAttributeName);
                            valueUIItemList.Add(valItem);
                        }
                        else
                        {
                            PropertyValueUIItem valItem = new PropertyValueUIItem(Properties.Resources.XmlElement, new PropertyValueUIItemInvokeHandler(SerializablePropUiHandler), string.Format("<{0}>",propDesc.Name));
                            valueUIItemList.Add(valItem);
                        }

                    }
                }
            }

        }


        #region Stuff needed for the PropView to have access to our IServiceProvider
        
        /// <summary>
        /// Strange enough, the proeprtygrid does not use it own GetService method (in some cases it does) 
        /// to access the IPropertyValueUIService but the one of its Site !?
        /// </summary>
        protected override object GetService(Type service)
        {
            object result =  base.GetService(service);
            if ((result == null) && (this.m_ServiceProvider != null))
            {
                return this.m_ServiceProvider.GetService(service);
            }
            return result;
        }
        

        public override ISite Site
        {
            get
            {
                // not in design mode....
                if (this.DesignMode)
                    return base.Site;

                // make sure we have a site
                if (base.Site == null)
                {
                    if (this.m_DummySite == null)
                        this.m_DummySite = new href.Controls.Hosting.DummySite(this, this.m_ServiceProvider, "PropertyGridEx");
                    return this.m_DummySite;
                }
                return base.Site;
            }
            set
            {
                base.Site = value;
            }
        }
        public void ShowEvents(bool show)
        {
            base.ShowEventsButton(show);
//            if (show)
//                this.PropertyTabs.AddTabType(typeof(System.Windows.Forms.Design.EventsTab));
        }
        #endregion

        public bool DrawFlat
        {
            get { return DrawFlatToolbar; }
            set { DrawFlatToolbar = value; }
        }

        protected override void OnSelectedObjectsChanged(EventArgs e)
        {
            base.OnSelectedObjectsChanged(e);
        }
    }


}
