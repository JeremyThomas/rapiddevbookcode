using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web.Configuration;
using Microsoft.Web.Administration;
using Configuration = Microsoft.Web.Administration.Configuration;

namespace ListIISApps.Models
{
  public class ServerManagerVM
  {
    private readonly Application _application;
    public Configuration WebConfiguration { get; private set; }
    private static IEnumerable<ServerManagerVM> _serverManagerVms;
    private NameValueCollection _appSettingsDictionary;
    private IEnumerable<ConnectionStringSettings> _connectionStrings;
    private ConfigurationAttribute _authenticationMode;

    public Application Application
    {
      get { return _application; }
    }

    public string PhysicalPath
    {
      get { return Application.VirtualDirectories.First().PhysicalPath; }
    }

    public NameValueCollection AppSettings
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return _appSettingsDictionary ?? (_appSettingsDictionary = GetAppSettings(WebConfiguration));
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    private static NameValueCollection GetAppSettings(Configuration webConfiguration)
    {
      var dictionary = new NameValueCollection();
      foreach (var element in webConfiguration.GetSection("appSettings").GetCollection())
        dictionary.Add(Convert.ToString(element.Attributes["key"].Value), Convert.ToString(element.Attributes["value"].Value));
      return dictionary;
    }

    public IEnumerable<ConnectionStringSettings> ConnectionStrings
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return _connectionStrings ?? (_connectionStrings = GetConnectionStrings(WebConfiguration));
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    public static IEnumerable<ConnectionStringSettings> GetConnectionStrings(Configuration webConfiguration)
    {
      return webConfiguration.GetSection("connectionStrings").GetCollection()
        .Select(configurationElement => new ConnectionStringSettings(Convert.ToString(configurationElement.Attributes["Name"].Value),
                                                                     Convert.ToString(configurationElement.Attributes["connectionString"].Value),
                                                                     Convert.ToString(configurationElement.Attributes["providerName"].Value)));
    }

    public ConfigurationAttribute AuthenticationMode
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return _authenticationMode ?? (_authenticationMode = GetAuthenticationMode(WebConfiguration));
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    public static ConfigurationAttribute GetAuthenticationMode(Configuration webConfiguration)
    {
      return webConfiguration.GetSection("system.web/authentication").GetAttribute("mode");
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
      WebConfiguration = application.GetWebConfiguration();
      try
      {
        WebConfiguration.GetEffectiveSectionGroup();
      }
      catch (Exception)
      {
        WebConfiguration = null;
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