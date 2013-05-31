using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Configuration;
using AW.Helper;
using Microsoft.Web.Administration;
using Configuration = System.Configuration.Configuration;
using ConfigurationSection = System.Configuration.ConfigurationSection;
using WebConfigurationManager = System.Web.Configuration.WebConfigurationManager;

namespace ListIISApps.Models
{
  public class AssemblyInfo
  {
    public string Name { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public string Version { get; private set; }

    public string InformationalVersion { get; private set; }

    public AssemblyInfo(string name, string title, string description, string version, string informationalVersion)
    {
      Name = name;
      Title = title;
      Description = description;
      Version = version;
      InformationalVersion = informationalVersion;
    }

    #region Overrides of Object

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
      return string.Format("{0}, {1}, {2}, {3}, {4}", Name, Title, Description, InformationalVersion, Version);
    }

    #endregion
  }

  public class ServerManagerVM
  {
    private readonly Application _application;
    private static IEnumerable<ServerManagerVM> _serverManagerVms;
    private NameValueCollection _appSettingsDictionary;
    private IEnumerable<ConnectionStringSettings> _connectionStrings;
    private AuthenticationMode _authenticationMode;
    private IEnumerable<SectionGroup> _sectionGroupsDefinitions;
    private Configuration _webConfig;
    private IEnumerable<ConfigurationSectionGroup> _sectionGroups;
    public Microsoft.Web.Administration.Configuration WebConfiguration { get; private set; }

    public Application Application
    {
      get { return _application; }
    }

    public string PhysicalPath
    {
      get { return Application.VirtualDirectories.First().PhysicalPath; }
    }

    public Configuration WebConfig
    {
      get
      {
        try
        {
          if (_webConfig != null) return _webConfig;
          var vdm = new VirtualDirectoryMapping(PhysicalPath, true, "web.config");
          var wcfm = new WebConfigurationFileMap();
          wcfm.VirtualDirectories.Add("/", vdm);
          return _webConfig = WebConfigurationManager.OpenMappedWebConfiguration(wcfm, "/");
          //return _webConfig ?? (_webConfig = WebConfigurationManager.OpenWebConfiguration(PhysicalPath));
        }
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
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
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
    }

    public List<Exception> Exceptions { get; private set; }

    private static NameValueCollection GetAppSettings(Microsoft.Web.Administration.Configuration webConfiguration)
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
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
    }

    public static IEnumerable<ConnectionStringSettings> GetConnectionStrings(Microsoft.Web.Administration.Configuration webConfiguration)
    {
      return webConfiguration.GetSection("connectionStrings").GetCollection()
                             .Select(configurationElement => new ConnectionStringSettings(Convert.ToString(configurationElement.Attributes["Name"].Value),
                                                                                          Convert.ToString(configurationElement.Attributes["connectionString"].Value),
                                                                                          Convert.ToString(configurationElement.Attributes["providerName"].Value)));
    }

    public AuthenticationMode AuthenticationMode
    {
      get
      {
        if (WebConfiguration == null) return AuthenticationMode.None;
        try
        {
          return _authenticationMode != AuthenticationMode.None ? _authenticationMode : (_authenticationMode = (AuthenticationMode) (int) GetAuthenticationMode(WebConfiguration).Value);
        }
        catch (Exception e)
        {
          Exceptions.Add(e);
          return AuthenticationMode.None;
        }
      }
    }

    public static ConfigurationAttribute GetAuthenticationMode(Microsoft.Web.Administration.Configuration webConfiguration)
    {
      return webConfiguration.GetSection("system.web/authentication").GetAttribute("mode");
    }

    public IEnumerable<SectionGroup> SectionGroupsDefinitions
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return _sectionGroupsDefinitions ?? (_sectionGroupsDefinitions = WebConfiguration.RootSectionGroup.DescendantsAndSelf(sg => sg.SectionGroups).ToList());
        }
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
    }

    public IEnumerable<SectionDefinition> SectionsDefinitions
    {
      get
      {
        if (WebConfiguration == null) return null;
        try
        {
          return from sg in SectionGroupsDefinitions
                 from s in sg.Sections
                 select s;
        }
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
    }

    public IEnumerable<ConfigurationSectionGroup> SectionGroups
    {
      get
      {
        if (WebConfig == null) return null;
        try
        {
          return _sectionGroups ?? (_sectionGroups = WebConfig.RootSectionGroup.Descendants(sg => sg.SectionGroups.Cast<ConfigurationSectionGroup>()).ToList());
        }
        catch (Exception e)
        {
          Exceptions.Add(e);
          return null;
        }
      }
    }

    public IEnumerable<ConfigurationSection> Sections
    {
      get
      {
        var list = new List<ConfigurationSection>();
        foreach (var sg in SectionGroups)
          for (var i = 0; i < sg.Sections.Count - 1; i++)
            try
            {
              list.Add(sg.Sections[i]);
            }
            catch (Exception e)
            {
              Exceptions.Add(e);
            }
        return list;
      }
    }

    public IEnumerable<Assembly> Assemblies
    {
      get
      {
        var binDir = Path.Combine(PhysicalPath, "Bin");
        var allAssemblies = new List<Assembly>(); 
        foreach (var dll in Directory.GetFiles(binDir, "*.dll"))
          try
          {
            allAssemblies.Add(Assembly.LoadFrom(dll));
            //allAssemblies.Add(Assembly.ReflectionOnlyLoadFrom(dll));
          }
          catch (Exception e)
          {
            Exceptions.Add(e);
          }
        return allAssemblies;
      }
    }

    public IEnumerable<AssemblyInfo> AssembliesInfo
    {
      get
      {
        return from a in Assemblies
                select new AssemblyInfo(a.GetName().Name, a.GetTitle(), a. GetDescription(), a.GetVersion(), a.GetInformationalVersionAttribute());
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
      Exceptions = new List<Exception>();
      WebConfiguration = application.GetWebConfiguration();
      try
      {
        WebConfiguration.GetEffectiveSectionGroup();
      }
      catch (Exception e)
      {
        Exceptions.Add(e);
        WebConfiguration = null;
      }
    }

    public static void Refresh()
    {
      _serverManagerVms = null;
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