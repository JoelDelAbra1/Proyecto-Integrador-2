﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.urbansa.com/", ConfigurationName="ServiceReference1.TimbradoSoap")]
    public interface TimbradoSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarF", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarFResponse> TimbrarFAsync(ServiceReference1.TimbrarFRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/VerificarXML", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.VerificarXMLResponse> VerificarXMLAsync(ServiceReference1.VerificarXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarCP", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarCPResponse> TimbrarCPAsync(ServiceReference1.TimbrarCPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarN2", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarN2Response> TimbrarN2Async(ServiceReference1.TimbrarN2Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarFRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarF", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarFRequestBody Body;
        
        public TimbrarFRequest()
        {
        }
        
        public TimbrarFRequest(ServiceReference1.TimbrarFRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarFRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StrXml;
        
        public TimbrarFRequestBody()
        {
        }
        
        public TimbrarFRequestBody(string Usuario, string Password, string StrXml)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.StrXml = StrXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarFResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarFResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarFResponseBody Body;
        
        public TimbrarFResponse()
        {
        }
        
        public TimbrarFResponse(ServiceReference1.TimbrarFResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarFResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarFResult;
        
        public TimbrarFResponseBody()
        {
        }
        
        public TimbrarFResponseBody(byte[] TimbrarFResult)
        {
            this.TimbrarFResult = TimbrarFResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarXMLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarXML", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.VerificarXMLRequestBody Body;
        
        public VerificarXMLRequest()
        {
        }
        
        public VerificarXMLRequest(ServiceReference1.VerificarXMLRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class VerificarXMLRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StrXml;
        
        public VerificarXMLRequestBody()
        {
        }
        
        public VerificarXMLRequestBody(string Usuario, string Password, string StrXml)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.StrXml = StrXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarXMLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarXMLResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.VerificarXMLResponseBody Body;
        
        public VerificarXMLResponse()
        {
        }
        
        public VerificarXMLResponse(ServiceReference1.VerificarXMLResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class VerificarXMLResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VerificarXMLResult;
        
        public VerificarXMLResponseBody()
        {
        }
        
        public VerificarXMLResponseBody(string VerificarXMLResult)
        {
            this.VerificarXMLResult = VerificarXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarCPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarCP", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarCPRequestBody Body;
        
        public TimbrarCPRequest()
        {
        }
        
        public TimbrarCPRequest(ServiceReference1.TimbrarCPRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarCPRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Cadena;
        
        public TimbrarCPRequestBody()
        {
        }
        
        public TimbrarCPRequestBody(string Usuario, string Password, string Cadena)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.Cadena = Cadena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarCPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarCPResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarCPResponseBody Body;
        
        public TimbrarCPResponse()
        {
        }
        
        public TimbrarCPResponse(ServiceReference1.TimbrarCPResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarCPResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarCPResult;
        
        public TimbrarCPResponseBody()
        {
        }
        
        public TimbrarCPResponseBody(byte[] TimbrarCPResult)
        {
            this.TimbrarCPResult = TimbrarCPResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarN2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarN2", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarN2RequestBody Body;
        
        public TimbrarN2Request()
        {
        }
        
        public TimbrarN2Request(ServiceReference1.TimbrarN2RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarN2RequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Cadena;
        
        public TimbrarN2RequestBody()
        {
        }
        
        public TimbrarN2RequestBody(string Usuario, string Password, string Cadena)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.Cadena = Cadena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarN2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarN2Response", Namespace="http://ws.urbansa.com/", Order=0)]
        public ServiceReference1.TimbrarN2ResponseBody Body;
        
        public TimbrarN2Response()
        {
        }
        
        public TimbrarN2Response(ServiceReference1.TimbrarN2ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarN2ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarN2Result;
        
        public TimbrarN2ResponseBody()
        {
        }
        
        public TimbrarN2ResponseBody(byte[] TimbrarN2Result)
        {
            this.TimbrarN2Result = TimbrarN2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface TimbradoSoapChannel : ServiceReference1.TimbradoSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class TimbradoSoapClient : System.ServiceModel.ClientBase<ServiceReference1.TimbradoSoap>, ServiceReference1.TimbradoSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), TimbradoSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarFResponse> ServiceReference1.TimbradoSoap.TimbrarFAsync(ServiceReference1.TimbrarFRequest request)
        {
            return base.Channel.TimbrarFAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.TimbrarFResponse> TimbrarFAsync(string Usuario, string Password, string StrXml)
        {
            ServiceReference1.TimbrarFRequest inValue = new ServiceReference1.TimbrarFRequest();
            inValue.Body = new ServiceReference1.TimbrarFRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.StrXml = StrXml;
            return ((ServiceReference1.TimbradoSoap)(this)).TimbrarFAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.VerificarXMLResponse> ServiceReference1.TimbradoSoap.VerificarXMLAsync(ServiceReference1.VerificarXMLRequest request)
        {
            return base.Channel.VerificarXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.VerificarXMLResponse> VerificarXMLAsync(string Usuario, string Password, string StrXml)
        {
            ServiceReference1.VerificarXMLRequest inValue = new ServiceReference1.VerificarXMLRequest();
            inValue.Body = new ServiceReference1.VerificarXMLRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.StrXml = StrXml;
            return ((ServiceReference1.TimbradoSoap)(this)).VerificarXMLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarCPResponse> ServiceReference1.TimbradoSoap.TimbrarCPAsync(ServiceReference1.TimbrarCPRequest request)
        {
            return base.Channel.TimbrarCPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.TimbrarCPResponse> TimbrarCPAsync(string Usuario, string Password, string Cadena)
        {
            ServiceReference1.TimbrarCPRequest inValue = new ServiceReference1.TimbrarCPRequest();
            inValue.Body = new ServiceReference1.TimbrarCPRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.Cadena = Cadena;
            return ((ServiceReference1.TimbradoSoap)(this)).TimbrarCPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.TimbrarN2Response> ServiceReference1.TimbradoSoap.TimbrarN2Async(ServiceReference1.TimbrarN2Request request)
        {
            return base.Channel.TimbrarN2Async(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.TimbrarN2Response> TimbrarN2Async(string Usuario, string Password, string Cadena)
        {
            ServiceReference1.TimbrarN2Request inValue = new ServiceReference1.TimbrarN2Request();
            inValue.Body = new ServiceReference1.TimbrarN2RequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.Cadena = Cadena;
            return ((ServiceReference1.TimbradoSoap)(this)).TimbrarN2Async(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://ws.urbansa.com/app/timbrado.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://ws.urbansa.com/app/timbrado.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            TimbradoSoap,
            
            TimbradoSoap12,
        }
    }
}