using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web.Configuration;
using AW.Helper;
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
    private AuthenticationMode _authenticationMode;
    private IEnumerable<SectionGroup> _sectionGroups;

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
          return _connectionStrings ?? (_connectionStrings = GetConnectionStrings(WebConfiguration).ToList());
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

    public System.Web.Configuration.AuthenticationMode AuthenticationMode
    {
      get
      {
        if (WebConfiguration == null) return AuthenticationMode.None;
        try
        {
          return _authenticationMode != AuthenticationMode.None ? _authenticationMode : (_authenticationMode = (AuthenticationMode)(int)GetAuthenticationMode(WebConfiguration).Value);
        }
        catch (Exception)
        {
          return AuthenticationMode.None;
        }
      }
    }

    public static ConfigurationAttribute GetAuthenticationMode(Configuration webConfiguration)
    {
      return webConfiguration.GetSection("system.web/authentication").GetAttribute("mode");
    }

    public IEnumerable<SectionGroup> SectionGroups
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return _sectionGroups ?? (_sectionGroups = WebConfiguration.RootSectionGroup.DescendantsAndSelf(sg => sg.SectionGroups).ToList());
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    public IEnumerable<SectionDefinition> Sections
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return from sg in SectionGroups
                 from s in sg.Sections
                 select s;
        }
        catch (Exception)
        {
          return null;
        }
      }
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
      get { return _serverManagerVms ?? (_serverManagerVms = GetServerManagerVms().ToList()); }
    }

    public static IEnumerable<ServerManagerVM> GetServerManagerVms()
    {
      return from site in new ServerManager().Sites
             from application in site.Applications
             let smvm = new ServerManagerVM(application)
             where smvm.WebConfiguration != null
             select smvm;
    }
  }
}