using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using AW.Helper;

namespace Northwind.Business.WCF.Host
{
  /// <summary>
  ///   The class which represents the WCF service to our application.
  /// </summary>
  internal static class WcfServiceHost
  {
    /// <summary>
    ///   The global variable which is used to access the service. it's a desktop application so we keep the service alive in
    ///   a static global
    ///   variable. In webapplication, you're working multi-threaded and you can't use this method.
    /// </summary>
    private static List<ServiceHost> _serviceHosts;

    /// <summary>
    ///   Starts the service.
    /// </summary>
    /// <returns>true if service was successfully opened, false otherwise</returns>
    internal static IEnumerable<ServiceHost> StartService()
    {
      var baseAddress = ConfigurationManager.AppSettings["WCFUrl"];
      if (_serviceHosts == null)
        //Instantiate new ServiceHosts 
        _serviceHosts = WcfUtility.CreateServiceHosts(baseAddress, null, true,
          new IServiceBehavior[] {new ServiceMetadataBehavior {HttpGetEnabled = true}},
          typeof (NorthwindService).Assembly).ToList();
      WcfUtility.Open(_serviceHosts);

      return _serviceHosts;
    }

    /// <summary>
    ///   Stops the service.
    /// </summary>
    /// <returns>true if the service was successfully closed, false otherwise</returns>
    internal static bool StopService()
    {
      if (_serviceHosts != null)
      {
        var isClosed = WcfUtility.Close(_serviceHosts);

        // It appears that Close calls Dispose, then serviceHost must be set to null,
        // so that it get re-instatiated in the StartService method.
        // otherwise calling Open again on a Closed/Disposed service host will fail with the following exception:
        // System.ObjectDisposedException
        //{"Cannot access a disposed object.\r\nObject name: 'System.ServiceModel.ServiceHost'."}
        _serviceHosts = null;
        return isClosed;
      }
      return false;
    }
  }
}