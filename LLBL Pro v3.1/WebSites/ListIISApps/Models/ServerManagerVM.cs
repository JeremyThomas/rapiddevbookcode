using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Web.Administration;

namespace ListIISApps.Models
{
  public class ServerManagerVM
  {
    private readonly Application _application;
    private readonly Configuration _webConfiguration;
    private static IEnumerable<ServerManagerVM> _serverManagerVms;

    public Application Application
    {
      get { return _application; }
    }

    public string PhysicalPath
    {
      get { return Application.VirtualDirectories.First().PhysicalPath; }
    }

    public Dictionary<string, object> AppSettings
    {
      get
      {
        if (_webConfiguration == null) return null;
        try
        {
          return _webConfiguration.GetSection("appSettings").GetCollection()
            .ToDictionary(configurationElement => Convert.ToString(configurationElement.Attributes.First().Value), 
            configurationElement => configurationElement.Attributes.Last().Value);
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object"/> class.
    /// </summary>
    public ServerManagerVM()
    {
    }

    public ServerManagerVM(Application application)
    {
      _application = application;
      _webConfiguration = application.GetWebConfiguration();
      try
      {
        _webConfiguration.GetEffectiveSectionGroup();
      }
      catch (Exception)
      {
        _webConfiguration = null;
      }
    }

    public static IEnumerable<ServerManagerVM> ServerManagerVms
    {
      get { return _serverManagerVms ?? (_serverManagerVms = GetServerManagerVms()); }
    }

    public static IEnumerable<ServerManagerVM> GetServerManagerVms()
    {
      var mgr = new ServerManager();
      return from site in mgr.Sites
                          from application in site.Applications
                          let config = application.GetWebConfiguration()
                          select new ServerManagerVM(application);
    }
  }
}