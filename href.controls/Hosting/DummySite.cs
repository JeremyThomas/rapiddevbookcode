using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace href.Controls.Hosting
{
    /// <summary>
    /// Dummy site. Used by the PropertyGridEx to have a site with a valid
    /// ServiceProvider
    /// </summary>
    internal class DummySite : ISite
    {
        private IComponent m_Component;
        private Container m_Container;
        private string m_Name;
        IServiceProvider m_ServiceProvider;
        public DummySite(IComponent component, IServiceProvider serviceProvider)
            :this (component, serviceProvider, "DummySite")
        {
        }

        public DummySite(IComponent component, IServiceProvider serviceProvider, string name)
        {
            this.m_Component = component;
            this.m_Container = new Container();
            this.m_Name = name;
            this.m_ServiceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider
        {
            get { return this.m_ServiceProvider; }
            set { this.m_ServiceProvider = value; }
        }

        #region ISite Members

        public IComponent Component
        {
            get { return this.m_Component; }
        }

        public IContainer Container
        {
            get { return this.m_Container; }
        }

        public bool DesignMode
        {
            get { return false; }
        }

        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }

        #endregion

        #region IServiceProvider Members

        public object GetService(Type serviceType)
        {

            if (this.m_ServiceProvider != null)
                return this.m_ServiceProvider.GetService(serviceType);
            return null;
        }

        #endregion
    }
}
