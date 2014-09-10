using System;
using System.Collections.ObjectModel;
using System.Data.Objects;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Northwind.DAL.Services.WCF.Host
{
	public class ProxyDataContractResolverBehavior : IOperationBehavior
	{
		public void AddBindingParameters(OperationDescription description, BindingParameterCollection parameters)
		{
		}

		public void ApplyClientBehavior(OperationDescription description, ClientOperation proxy)
		{
			var dataContractSerializerOperationBehavior =
				description.Behaviors.Find<DataContractSerializerOperationBehavior>();
			dataContractSerializerOperationBehavior.DataContractResolver =
				new ProxyDataContractResolver();
		}

		public void ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch)
		{
			var dataContractSerializerOperationBehavior =
				description.Behaviors.Find<DataContractSerializerOperationBehavior>();
			dataContractSerializerOperationBehavior.DataContractResolver =
				new ProxyDataContractResolver();
		}

		public void Validate(OperationDescription description)
		{
			// Do validation.
		}
	}

	public class SerializationServiceBehavior : IServiceBehavior
	{
		#region IServiceBehavior Members

		public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase,
										 Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		{
			foreach (var operation in serviceDescription.Endpoints.SelectMany(e => e.Contract.Operations))
			{
        if (operation.Behaviors.Contains(typeof(ProxyDataContractResolverBehavior)))
          operation.Behaviors.Add(new ProxyDataContractResolverBehavior());
			}
		}

		public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		{
		}

		#endregion
	}

	public class SerializationServiceBehaviorElement : BehaviorExtensionElement
	{
		public override Type BehaviorType
		{
			get { return typeof(SerializationServiceBehavior); }
		}

		protected override object CreateBehavior()
		{
			return new SerializationServiceBehavior();
		}
	}
}