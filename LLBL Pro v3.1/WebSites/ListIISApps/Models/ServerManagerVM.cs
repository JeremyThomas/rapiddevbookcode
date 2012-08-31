using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Web.Administration;
using Configuration = Microsoft.Web.Administration.Configuration;

namespace ListIISApps.Models
{
  public class ServerManagerVM
  {
    private readonly Application _application;
    private readonly Configuration _webConfiguration;
    private static IEnumerable<ServerManagerVM> _serverManagerVms;
    private Dictionary<string, object> _appSettingsDictionary;
    private IEnumerable<ConnectionStringSettings> _connectionStrings;

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
          return _appSettingsDictionary ?? (_appSettingsDictionary = GetAppSettings());
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    private Dictionary<string, object> GetAppSettings()
    {
      return _webConfiguration.GetSection("appSettings").GetCollection()
        .ToDictionary(configurationElement => Convert.ToString(configurationElement.Attributes["key"].Value),
                      configurationElement => configurationElement.Attributes["value"].Value);
    }

    public IEnumerable<ConnectionStringSettings> ConnectionStrings
    {
      get
      {
        if (_webConfiguration == null) return null;
        try
        {
          return _connectionStrings ?? (_connectionStrings = GetConnectionStrings());
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    public IEnumerable<ConnectionStringSettings> GetConnectionStrings()
    {
      return _webConfiguration.GetSection("connectionStrings").GetCollection()
        .Select(configurationElement => new ConnectionStringSettings(Convert.ToString(configurationElement.Attributes["Name"].Value),
                                                                     Convert.ToString(configurationElement.Attributes["connectionString"].Value), 
                                                                     Convert.ToString(configurationElement.Attributes["providerName"].Value)));
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Object" /> class.
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