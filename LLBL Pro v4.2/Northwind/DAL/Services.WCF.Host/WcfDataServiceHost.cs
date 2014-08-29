using System;
using System.Data.Services;
using System.ServiceModel;
using System.ServiceModel.Description;
using Northwind.DAL.Services;

namespace Services.WCF.Host
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
    private static DataServiceHost _serviceHost;

    /// <summary>
    ///   Starts the service.
    /// </summary>
    /// <returns>true if service was successfully opened, false otherwise</returns>
    internal static bool StartService()
    {
      if (_serviceHost == null)
      {
        var baseAddress = new Uri("http://localhost:6000/");
        var baseAddresses = new[] {baseAddress};
        //Instantiate new ServiceHost 
        _serviceHost = new DataServiceHost(typeof (NorthwindODataService), baseAddresses);
        var debug = _serviceHost.Description.Behaviors.Find<ServiceDebugBehavior>();

        // if not found - add behavior with setting turned on 
        if (debug == null)
        {
          _serviceHost.Description.Behaviors.Add(
            new ServiceDebugBehavior {IncludeExceptionDetailInFaults = true});
        }
        else
        {
          // make sure setting is turned ON
          if (!debug.IncludeExceptionDetailInFaults)
          {
            debug.IncludeExceptionDetailInFaults = true;
          }
        }
      }

      if (_serviceHost.State != CommunicationState.Opened && _serviceHost.State != CommunicationState.Opening)
      {
        //Open myServiceHost
        _serviceHost.Open();
      }

      return (_serviceHost.State == CommunicationState.Opened);
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