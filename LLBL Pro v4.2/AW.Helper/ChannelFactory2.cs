using System;
using System.Globalization;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace AW.Helper
{
    /// <summary>
    ///     http://social.msdn.microsoft.com/Forums/vstudio/en-US/9efd9c01-062c-48df-9aed-2d554ae98d2e/how-to-replace-remoting-by-wfc-without-svcutil-?forum=wcf
    /// </summary>
    public class ChannelFactory2 : ChannelFactory
    {
        private Type _channelType;

        private IChannelFactory _factory;

        private object _tp;
        
        public ChannelFactory2(Type channelType, string endpointConfig)
        {
            if (!channelType.IsInterface)
                throw new InvalidOperationException("The channelType must be Interface");
            _channelType = channelType;
            InitializeEndpoint(endpointConfig, null);
        }
        
        public ChannelFactory2(Type channelType, Binding binding, EndpointAddress remoteAddress)
        {
            if (!channelType.IsInterface)
                throw new InvalidOperationException("The channelType must be Interface");
            _channelType = channelType;
            InitializeEndpoint(binding, remoteAddress);
        }
        
        public object CreateChannel()
        {
            // create transparent proxy
            EnsureOpened();
            object[] objArray = {_channelType, Endpoint.Address, null};
            _tp = _factory.GetType().InvokeMember("CreateChannel",
                BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                null,
                _factory,
                objArray,
                CultureInfo.InvariantCulture);
            return _tp;
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            _factory = base.CreateFactory();
            var baseType = GetType().BaseType;
            if (baseType != null)
                baseType.InvokeMember("innerFactory",
                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance,
                    null,
                    this,
                    new object[] {_factory},
                    CultureInfo.InvariantCulture);
            base.OnOpen(timeout);
        }
        
        protected override ServiceEndpoint CreateDescription()
        {
            var desc = ContractDescription.GetContract(_channelType);
            return new ServiceEndpoint(desc);
        }
        
        public object InvokeMethod(string methodName, object[] args)
        {
            // invoke method on the transparent proxy
            if (_tp == null)
                throw new NullReferenceException("The channel is not created");
            var retVal = _tp.GetType().InvokeMember(methodName,
                BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                null,
                _tp,
                args,
                CultureInfo.InvariantCulture);
            return retVal;
        }
    }
}