using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Administration;
using Microsoft.Web.Administration.Interop;

namespace ListIISApps.Models
{
  [DebuggerDisplay("Path = {Path}")]
  public sealed class Application : ConfigurationElement
  {
    private VirtualDirectoryDefaults _virtualDirectoryDefaults;
    private VirtualDirectoryCollection _virtualDirectories;
    private Site _site;
    private ServerManager _owner;
   

    public string ApplicationPoolName
    {
      get
      {
        return (string)this["applicationPool"];
      }
      set
      {
        this["applicationPool"] = (object)value;
      }
    }

    public string EnabledProtocols
    {
      get
      {
        return (string)this["enabledProtocols"];
      }
      set
      {
        this["enabledProtocols"] = (object)value;
      }
    }

    public string Path
    {
      get
      {

        return null;
      }
      set
      {
 
      }
    }


    internal Site Site
    {
      get
      {
        return this._site;
      }
    }

    public VirtualDirectoryCollection VirtualDirectories
    {
      get
      {
        if (this._virtualDirectories == null)
        {
          this._virtualDirectories = (VirtualDirectoryCollection)this.GetCollection(typeof(VirtualDirectoryCollection));
        }
        return this._virtualDirectories;
      }
    }

    public VirtualDirectoryDefaults VirtualDirectoryDefaults
    {
      get
      {

        return this._virtualDirectoryDefaults;
      }
    }

    internal Application(ServerManager owner, Site site)
    {
      this._site = site;
      this._owner = owner;
    }

    public Configuration GetWebConfiguration()
    {
      return this._owner.GetWebConfiguration(this.Site.Name, this.Path);
    }


  }

}