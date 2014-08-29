using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace AW.Helper
{
  /// <summary>
  ///   https://gist.github.com/tracker1/5675161
  /// </summary>
  public static class WcfUtility
  {
    #region Constants

    private const int WcfSerializerMaxStringContentLength = (16*1024*1024); //16MB;
    private const int WcfSerializerMaxArrayLength = 65535; //16bit
    private const int WcfSerializerMaxBytesPerRead = (16*1024*1024); //16MB
    private const int WcfSerializerMaxDepth = 65535; //16bit;
    private const int WcfSerializerMaxNameTableCharCount = 16384; //default 16K

    #endregion

    #region Factory Generator (GetChannelFactory<T>)

    /// <summary>
    ///   Gets a channel factory for the given service type
    /// </summary>
    /// <summary>Retrieves a WCF Client for the T interface.</summary>
    /// <typeparam name="T">The Interface the WCF Service Implements</typeparam>
    /// <param name="serviceEndpointUrl">
    ///   Optional URL for the service Endpoint. Will use an application setting of
    ///   "SERVICE_URL:Full.Namespace.For.T" by default.
    /// </param>
    /// <returns>An instance of the Interface T as a WCF Client.</returns>
    [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope"), SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", MessageId = "System.String.StartsWith(System.String)"),
     SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"),
     SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
    public static ChannelFactory<T> GetChannelFactory<T>(string serviceEndpointUrl = null)
    {
      //no serviceEndpontUrl specified
      if (String.IsNullOrWhiteSpace(serviceEndpointUrl))
      {
        var serviceBaseUrl = ConfigurationManager.AppSettings["WCFUrl"];

        //get default from config appsettings

        if (String.IsNullOrWhiteSpace(serviceBaseUrl))
        {
          //no appsetting, throw exception.
          throw new ApplicationException(String.Format("Missing Application Setting for '{0}'", "WCFUrl"));
        }
        serviceEndpointUrl = serviceBaseUrl + (typeof (T)).Name.TrimStart('I'); //+ ".svc";
      }

      var endpoint = new EndpointAddress(serviceEndpointUrl);

      //http/https binding
      if (serviceEndpointUrl.StartsWith("http://") || serviceEndpointUrl.StartsWith("https://"))
      {
        //var binding = new WebHttpBinding();

        //raise binding reader quotas to sane limits
        //binding.ReaderQuotas.MaxStringContentLength = WcfSerializerMaxStringContentLength;
        //binding.ReaderQuotas.MaxArrayLength = WcfSerializerMaxArrayLength;
        //binding.ReaderQuotas.MaxBytesPerRead = WcfSerializerMaxBytesPerRead;
        //binding.ReaderQuotas.MaxDepth = WcfSerializerMaxDepth;
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;


        var binding = new BasicHttpBinding {MaxReceivedMessageSize = 1000000, ReaderQuotas = {MaxDepth = 200}};
        var factory = new ChannelFactory<T>(binding, endpoint);
        // factory.Endpoint.Behaviors.Add(new WebHttpBehavior());
        return factory;
      }

      //tcp binding
      if (serviceEndpointUrl.StartsWith("net.tcp://"))
      {
        var binding = new NetTcpBinding();

        //raise binding reader quotas to sane limits
        if (binding.ReaderQuotas != null)
        {
          binding.ReaderQuotas.MaxStringContentLength = WcfSerializerMaxStringContentLength;
          binding.ReaderQuotas.MaxArrayLength = WcfSerializerMaxArrayLength;
          binding.ReaderQuotas.MaxBytesPerRead = WcfSerializerMaxBytesPerRead;
          binding.ReaderQuotas.MaxDepth = WcfSerializerMaxDepth;
        }
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;

        var factory = new ChannelFactory<T>(binding, endpoint);
        return factory;
      }

      //local net pipes binding
      if (serviceEndpointUrl.StartsWith("net.pipe://"))
      {
        var binding = new NetNamedPipeBinding
        {
          ReaderQuotas =
          {
            MaxStringContentLength = WcfSerializerMaxStringContentLength,
            MaxArrayLength = WcfSerializerMaxArrayLength,
            MaxBytesPerRead = WcfSerializerMaxBytesPerRead,
            MaxDepth = WcfSerializerMaxDepth
          }
        };

        //raise binding reader quotas to sane limits
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;

        var factory = new ChannelFactory<T>(binding, endpoint);
        return factory;
      }

      //no matching binding for the config
      throw new ApplicationException(String.Format("The service end point url specified does not match a supported protocol ({0}).", serviceEndpointUrl));
    }

    /// <summary>
    ///   Gets a channel factory for the given service type
    /// </summary>
    /// <param name="serviceInterface">The service interface.</param>
    /// <param name="serviceEndpointUrl">
    ///   Optional URL for the service Endpoint. Will use an application setting of
    ///   "SERVICE_URL:Full.Namespace.For.T" by default.
    /// </param>
    /// <returns>
    ///   An instance of the Interface T as a WCF Client.
    /// </returns>
    /// <exception cref="System.ApplicationException">
    /// </exception>
    [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope"), SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", MessageId = "System.String.StartsWith(System.String)"),
     SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"),
     SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
    public static ChannelFactory2 GetChannelFactory(Type serviceInterface, string serviceEndpointUrl = null)
    {
      //no serviceEndpontUrl specified
      if (String.IsNullOrWhiteSpace(serviceEndpointUrl))
      {
        var serviceBaseUrl = ConfigurationManager.AppSettings["WCFUrl"];

        //get default from config appsettings

        if (String.IsNullOrWhiteSpace(serviceBaseUrl))
        {
          //no appsetting, throw exception.
          throw new ApplicationException(String.Format("Missing Application Setting for '{0}'", "WCFUrl"));
        }
        serviceEndpointUrl = serviceBaseUrl + serviceInterface.Name.TrimStart('I'); // +".svc";
      }

      var endpoint = new EndpointAddress(serviceEndpointUrl);

      //http/https binding
      if (serviceEndpointUrl.StartsWith("http://") || serviceEndpointUrl.StartsWith("https://"))
      {
        //var binding = new WebHttpBinding();

        //raise binding reader quotas to sane limits
        //binding.ReaderQuotas.MaxStringContentLength = WcfSerializerMaxStringContentLength;
        //binding.ReaderQuotas.MaxArrayLength = WcfSerializerMaxArrayLength;
        //binding.ReaderQuotas.MaxBytesPerRead = WcfSerializerMaxBytesPerRead;
        //binding.ReaderQuotas.MaxDepth = WcfSerializerMaxDepth;
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;


        var binding = new BasicHttpBinding {MaxReceivedMessageSize = 1000000, ReaderQuotas = {MaxDepth = 200}};
        var factory = new ChannelFactory2(serviceInterface, binding, endpoint);
        // factory.Endpoint.Behaviors.Add(new WebHttpBehavior());
        return factory;
      }

      //tcp binding
      if (serviceEndpointUrl.StartsWith("net.tcp://"))
      {
        var binding = new NetTcpBinding();

        //raise binding reader quotas to sane limits
        if (binding.ReaderQuotas != null)
        {
          binding.ReaderQuotas.MaxStringContentLength = WcfSerializerMaxStringContentLength;
          binding.ReaderQuotas.MaxArrayLength = WcfSerializerMaxArrayLength;
          binding.ReaderQuotas.MaxBytesPerRead = WcfSerializerMaxBytesPerRead;
          binding.ReaderQuotas.MaxDepth = WcfSerializerMaxDepth;
        }
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;

        var factory = new ChannelFactory2(serviceInterface, binding, endpoint);
        return factory;
      }

      //local net pipes binding
      if (serviceEndpointUrl.StartsWith("net.pipe://"))
      {
        var binding = new NetNamedPipeBinding
        {
          ReaderQuotas =
          {
            MaxStringContentLength = WcfSerializerMaxStringContentLength,
            MaxArrayLength = WcfSerializerMaxArrayLength,
            MaxBytesPerRead = WcfSerializerMaxBytesPerRead,
            MaxDepth = WcfSerializerMaxDepth
          }
        };

        //raise binding reader quotas to sane limits
        //binding.ReaderQuotas.MaxNameTableCharCount = WcfSerializerMaxNameTableCharCount;

        var factory = new ChannelFactory2(serviceInterface, binding, endpoint);
        return factory;
      }

      //no matching binding for the config
      throw new ApplicationException(String.Format("The service end point url specified does not match a supported protocol ({0}).", serviceEndpointUrl));
    }

    #endregion

    /// <summary>
    ///   Given a class it returns the ServiceContract interface that it implements or itself if it is the contract
    ///   http://muxtonmumbles.blogspot.co.nz/2010/03/dynamically-creating-servicehost-for.html
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Type GetServiceContractType(Type type)
    {
      if (!type.IsClass)
        throw new ArgumentException();
      var contractInterface = type.GetInterfaces().FirstOrDefault(IsServiceContract);
      if (contractInterface != null)
        return contractInterface;
      if (IsServiceContract(type))
        return type;
      throw new InvalidOperationException();
    }

    /// <summary>
    ///   Gets all the classes in an assembly that implement WCF services.
    /// </summary>
    /// <param name="assemblies">The assemblies.</param>
    /// <returns></returns>
    public static IEnumerable<Type> GetServiceTypes(params Assembly[] assemblies)
    {
      Debug.Assert(assemblies != null);
      return assemblies.SelectMany(a => a.GetTypes().Where(IsWcfClass));
    }

    /// <summary>
    ///   Determines whether the specified class or one of it's interfaces has the ServiceContract Attribute and therefore
    ///   implements a WCF service.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private static bool IsWcfClass(Type type)
    {
      return type.IsClass && (IsServiceContract(type) || type.GetInterfaces().Any(IsServiceContract));
    }

    private static bool IsServiceContract(Type type)
    {
      return MetaDataHelper.GetCustomAttributes<ServiceContractAttribute>(type).Length > 0;
    }

    public static IEnumerable<Type> GetInterfacesThatHaveServiceContractAttribute(Assembly assembly)
    {
      return assembly.GetTypes().Where(x => x.IsInterface).Where(IsServiceContract);
    }

    public static void DoIncludeExceptionDetailInFaults(ServiceHostBase host)
    {
      var debug = host.Description.Behaviors.Find<ServiceDebugBehavior>();
      if (debug == null) // if not found - add behavior with setting turned on 
        host.Description.Behaviors.Add(new ServiceDebugBehavior {IncludeExceptionDetailInFaults = true});
      else // make sure setting is turned ON
        if (!debug.IncludeExceptionDetailInFaults)
          debug.IncludeExceptionDetailInFaults = true;
    }

    public static ServiceHost CreateHost(Type serviceType, string baseAddress, Binding binding, params IServiceBehavior[] serviceBehaviors)
    {
      var contractType = GetServiceContractType(serviceType);

      var fullBaseAddress = string.Concat(baseAddress, serviceType.Name);

      var host = new ServiceHost(serviceType, new Uri(fullBaseAddress));

      host.AddServiceEndpoint(contractType, binding, "");
      DoIncludeExceptionDetailInFaults(host);
      foreach (var serviceBehavior in serviceBehaviors)
        host.Description.Behaviors.Add(serviceBehavior);

      host.AddServiceEndpoint(typeof (IMetadataExchange), binding, "MEX");
      host.Open();
      Console.WriteLine("{0}: Host for {1} is open", serviceType.Name, DateTime.Now);
      return host;
    }
  }
}