using System;
using System.Configuration;
using System.Data.Services;
using System.ServiceModel;
using System.ServiceModel.Description;
using AW.Helper;

namespace Northwind.DAL.Services.WCF.Host
{
  /// <summary>
  ///   The class which represents the WCF service to our application.
  /// </summary>
  internal static class WcfDataServiceHost
  {
    /// <summary>
    ///   The global variable which is used to access the service. it's a desktop application so we keep the service alive in
    ///   a static global
    ///   variable. In webapplication, you're working multi-threaded and you can't use this method.
    /// </summary>
    private static ServiceHost _serviceHost;

    public static ServiceHost CreateDataServiceHost(Type serviceType, string baseAddress)
    {
      var fullBaseAddress = string.Concat(baseAddress, serviceType.Name);
      var host = new DataServiceHost(serviceType, new[] {new Uri(fullBaseAddress)});
      WcfUtility.DoIncludeExceptionDetailInFaults(host);
      return host;
    }

    /// <summary>
    ///   Starts the service.
    /// </summary>
    /// <returns>true if service was successfully opened, false otherwise</returns>
    internal static ServiceHost StartService()
    {
      if (_serviceHost == null)
      {
        var baseAddress = ConfigurationManager.AppSettings["WCFUrl"];
        //Instantiate new ServiceHost 
        _serviceHost = CreateDataServiceHost(typeof(NorthwindODataService), baseAddress);
        _serviceHost.Open();
      }

      if (_serviceHost.State != CommunicationState.Opened && _serviceHost.State != CommunicationState.Opening)
      {
        //Open myServiceHost
        _serviceHost.Open();
      }

      return _serviceHost;
    }


    /// <summary>
    ///   Stops the service.
    /// </summary>
    /// <returns>true if the service was successfully closed, false otherwise</returns>
    internal static bool StopService()
    {
      if (_serviceHost != null)
      {
        //Call StopService from your shutdown logic (i.e. dispose method)
        if (_serviceHost.State == CommunicationState.Opened)
        {
          _serviceHost.Close();
        }

        var isClosed = (_serviceHost.State == CommunicationState.Closed);

        // It appears that Close calls Dispose, then serviceHost must be set to null,
        // so that it get re-instatiated in the StartService method.
        // otherwise calling Open again on a Closed/Disposed service host will fail with the following exception:
        // System.ObjectDisposedException
        //{"Cannot access a disposed object.\r\nObject name: 'System.ServiceModel.ServiceHost'."}
        _serviceHost = null;

        return isClosed;
      }

      return false;
    }
  }
}