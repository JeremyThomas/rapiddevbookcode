using System;
using System.ServiceModel;
using Northwind.Business;


namespace SD.LLBLGen.Pro.Examples.WCF.Host
{
  /// <summary>
  /// The class which represents the WCF service to our application. 
  /// </summary>
    internal class WCFServiceHost
    {
    /// <summary>
    /// The global variable which is used to access the service. it's a desktop application so we keep the service alive in a static global
    /// variable. In webapplication, you're working multi-threaded and you can't use this method. 
    /// </summary>
        internal static ServiceHost serviceHost = null;

    /// <summary>
    /// Starts the service.
    /// </summary>
    /// <returns>true if service was successfully opened, false otherwise</returns>
        internal static bool StartService()
        {
            if (serviceHost == null)
            {
                //Instantiate new ServiceHost 
                serviceHost = new ServiceHost(new NorthwindService());
            }

            if (serviceHost.State != CommunicationState.Opened && serviceHost.State != CommunicationState.Opening)
            {
                //Open myServiceHost
                serviceHost.Open();
            }

            return (serviceHost.State == CommunicationState.Opened);
        }


    /// <summary>
    /// Stops the service.
    /// </summary>
    /// <returns>true if the service was successfully closed, false otherwise</returns>
        internal static bool StopService()
        {
            if (serviceHost != null)
            {
                //Call StopService from your shutdown logic (i.e. dispose method)
                if (serviceHost.State == CommunicationState.Opened)
                {
                    serviceHost.Close();
                }

                bool isClosed = (serviceHost.State == CommunicationState.Closed);

                // It appears that Close calls Dispose, then serviceHost must be set to null,
                // so that it get re-instatiated in the StartService method.
                // otherwise calling Open again on a Closed/Disposed service host will fail with the following exception:
                // System.ObjectDisposedException
                //{"Cannot access a disposed object.\r\nObject name: 'System.ServiceModel.ServiceHost'."}
                serviceHost = null;

                return isClosed;
            }

            return false;
        }

    }
}
