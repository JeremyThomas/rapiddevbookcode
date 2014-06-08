using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AW.Winforms.Helpers.Hosting;

namespace AW.Winforms.Helpers.PropGridEx
{
  /// <summary>
  ///   Special PropertyGrid that has an aditional TabPage for the instance members
  ///   and leverages IPropertyValueUIService
  /// </summary>
  public class PropertyGridEx : PropertyGrid
  {
    private IServiceProvider _serviceProvider;
    private ServiceContainer _privateContainer; // if no service provider is provided
    private DummySite _dummySite;

    /// <summary>
    ///   Default constructor
    /// </summary>
    public PropertyGridEx()
      : this(null)
    {
    }

    /// <summary>
    ///   Use this constructor if you already have an ServiceProvider infrastructure
    /// </summary>
    /// <param name="serviceProvider">a ServiceProvider</param>
    private PropertyGridEx(IServiceProvider serviceProvider)
    {
      DrawFlat = true;
      // add the RawPage now and for ever (static)
      PropertyTabs.AddTabType(typeof (RawMemberTab), PropertyTabScope.Static);

      SetServiceProvider(serviceProvider);
    }

    /// <summary>
    ///   Set/Get the current ServiceProvider
    /// </summary>
    /// <param name="serviceProvider">a ServiceProvider</param>
    private void SetServiceProvider(IServiceProvider serviceProvider)
    {
      // no valid service provider
      if (serviceProvider == null)
      {
        // create own
        if (_privateContainer == null)
          _privateContainer = new ServiceContainer();
        // add our own IPropertyValueUIService
        //this.m_PrivateContainer.AddService(typeof(IPropertyValueUIService), new AW.Winforms.Helpers.Hosting.PropertyValueUIService());
        _serviceProvider = _privateContainer;
      }
      else
        // use provided one (if no IPropertyValueUIService is provided, the overlay icons will not work)
        _serviceProvider = serviceProvider;

      // propagate ServiceProvider to the DummySite
      if (_dummySite != null)
        _dummySite.ServiceProvider = _serviceProvider;
    }

    #region Stuff needed for the PropView to have access to our IServiceProvider

    /// <summary>
    ///   Strange enough, the proeprtygrid does not use it own GetService method (in some cases it does)
    ///   to access the IPropertyValueUIService but the one of its Site !?
    /// </summary>
    protected override object GetService(Type service)
    {
      var result = base.GetService(service);
      if ((result == null) && (_serviceProvider != null))
        return _serviceProvider.GetService(service);
      return result;
    }


    public override ISite Site
    {
      get
      {
        // not in design mode....
        if (DesignMode)
          return base.Site;

        // make sure we have a site
        if (base.Site == null)
        {
          return _dummySite ?? (_dummySite = new DummySite(this, _serviceProvider, "PropertyGridEx"));
        }
        return base.Site;
      }
      set { base.Site = value; }
    }

    #endregion

    public bool DrawFlat
    {
      get { return DrawFlatToolbar; }
      set { DrawFlatToolbar = value; }
    }

    private void ShowEvents(bool show)
    {
      if (show)
        PropertyTabs.AddTabType(typeof (EventsTab));
      ShowEventsButton(show);
    }

    /// <summary>
    ///   Refreshes the selected object as the property tab goes invisible is SelectedObject is set in the forms constructor.
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