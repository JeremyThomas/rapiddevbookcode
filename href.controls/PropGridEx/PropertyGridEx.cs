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
            // no valid service provider
            if (serviceProvider == null)
            {
                // create own
                if (this.m_PrivateContainer == null)
                {
                    this.m_PrivateContainer = new ServiceContainer();
                    // add our own IPropertyValueUIService
                    //this.m_PrivateContainer.AddService(typeof(IPropertyValueUIService), new href.Controls.Hosting.PropertyValueUIService());
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

        #endregion

        public bool DrawFlat
        {
            get { return DrawFlatToolbar; }
            set { DrawFlatToolbar = value; }
        }

        public void ShowEvents(bool show)
        {
          if (show)
            this.PropertyTabs.AddTabType(typeof(System.Windows.Forms.Design.EventsTab));
          base.ShowEventsButton(show);
        }

        /// <summary>
        /// Refreshes the selected object as the property tab goes invisible is SelectedObject is set in the forms constructor.
        /// </summary>
        public void RefreshSelectedObject()
        {
          var so = SelectedObject;
          SelectedObject = null;
          SelectedObject = so;
        }

        protected override void OnSelectedObjectsChanged(EventArgs e)
        {
          base.OnSelectedObjectsChanged(e);
          ShowEvents(true);
        }
    }


}
