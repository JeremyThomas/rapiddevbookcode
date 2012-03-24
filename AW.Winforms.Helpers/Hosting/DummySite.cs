using System;
using System.ComponentModel;

namespace AW.Winforms.Helpers.Hosting
{
	/// <summary>
	/// Dummy site. Used by the PropertyGridEx to have a site with a valid
	/// ServiceProvider
	/// </summary>
	internal class DummySite : ISite
	{
		private readonly IComponent m_Component;
		private readonly Container m_Container;
		private IServiceProvider m_ServiceProvider;

		public DummySite(IComponent component, IServiceProvider serviceProvider)
			: this(component, serviceProvider, "DummySite")
		{
		}

		public DummySite(IComponent component, IServiceProvider serviceProvider, string name)
		{
			m_Component = component;
			m_Container = new Container();
			Name = name;
			m_ServiceProvider = serviceProvider;
		}

		public IServiceProvider ServiceProvider
		{
			get { return m_ServiceProvider; }
			set { m_ServiceProvider = value; }
		}

		#region ISite Members

		public IComponent Component
		{
			get { return m_Component; }
		}

		public IContainer Container
		{
			get { return m_Container; }
		}

		public bool DesignMode
		{
			get { return false; }
		}

		public string Name { get; set; }

		#endregion

		#region IServiceProvider Members

		public object GetService(Type serviceType)
		{
			return m_ServiceProvider != null ? m_ServiceProvider.GetService(serviceType) : null;
		}

		#endregion
	}
}