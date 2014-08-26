using System.ServiceModel;
using System.ServiceModel.Description;

namespace Northwind.Business.WCF.Host
{
    /// <summary>
    ///     The class which represents the WCF service to our application.
    /// </summary>
    internal class WCFServiceHost
    {
        /// <summary>
        ///     The global variable which is used to access the service. it's a desktop application so we keep the service alive in
        ///     a static global
        ///     variable. In webapplication, you're working multi-threaded and you can't use this method.
        /// </summary>
        internal static ServiceHost ServiceHost = null;

        /// <summary>
        ///     Starts the service.
        /// </summary>
        /// <returns>true if service was successfully opened, false otherwise</returns>
        internal static bool StartService()
        {
            if (ServiceHost == null)
            {
                //Instantiate new ServiceHost 
                ServiceHost = new ServiceHost(new NorthwindService());
                var debug = ServiceHost.Description.Behaviors.Find<ServiceDebugBehavior>();

                // if not found - add behavior with setting turned on 
                if (debug == null)
                {
                    ServiceHost.Description.Behaviors.Add(
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

            if (ServiceHost.State != CommunicationState.Opened && ServiceHost.State != CommunicationState.Opening)
            {
                //Open myServiceHost
                ServiceHost.Open();
            }

            return (ServiceHost.State == CommunicationState.Opened);
        }


        /// <summary>
        ///     Stops the service.
        /// </summary>
        /// <returns>true if the service was successfully closed, false otherwise</returns>
        internal static bool StopService()
        {
            if (ServiceHost != null)
            {
                //Call StopService from your shutdown logic (i.e. dispose method)
                if (ServiceHost.State == CommunicationState.Opened)
                {
                    ServiceHost.Close();
                }

                var isClosed = (ServiceHost.State == CommunicationState.Closed);

                // It appears that Close calls Dispose, then serviceHost must be set to null,
                // so that it get re-instatiated in the StartService method.
                // otherwise calling Open again on a Closed/Disposed service host will fail with the following exception:
                // System.ObjectDisposedException
                //{"Cannot access a disposed object.\r\nObject name: 'System.ServiceModel.ServiceHost'."}
                ServiceHost = null;

                return isClosed;
            }

            return false;
        }
    }
}