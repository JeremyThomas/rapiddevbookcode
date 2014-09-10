using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Services;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using AW.Helper;
using ProLinq.Wcf.Behaviors;

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
    private static List<ServiceHost> _serviceHosts;

    /// <summary>
    ///   Starts the service.
    /// </summary>
    /// <returns>true if service was successfully opened, false otherwise</returns>
    internal static IEnumerable<ServiceHost> StartService()
    {
      var baseAddress = ConfigurationManager.AppSettings["WcfDataServiceUrl"];
      if (_serviceHosts == null)
      {
        var serviceBehaviors = new IServiceBehavior[] {new ServiceMetadataBehavior {HttpGetEnabled = true,HttpsGetEnabled = true},new QueryableBehavior(), new SerializationServiceBehavior(), };
        //Instantiate new ServiceHosts 
        _serviceHosts = new List<ServiceHost>(WcfUtility.CreateServiceHosts(baseAddress, null, true, serviceBehaviors, typeof(RemoteAdapter), typeof(NorthwindLLBLPersistence)) 
          //
          ) { CreateDataServiceHost(typeof(NorthwindODataService), baseAddress), };
      }
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
    
    public static ServiceHost CreateDataServiceHost(Type serviceType, string baseAddress)
    {
      var fullBaseAddress = string.Concat(baseAddress, serviceType.Name);
      var host = new DataServiceHost(serviceType, new[] {new Uri(fullBaseAddress)});
      WcfUtility.DoIncludeExceptionDetailInFaults(host);
      return host;
    }
  }
}