//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace SunatServices
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe", ConfigurationName="SunatServices.billService")]
    public interface billService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="http://service.sunat.gob.pe/billService/getStatusCdrResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SunatServices.getStatusCdrResponse> getStatusCdrAsync(SunatServices.getStatusCdrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="http://service.sunat.gob.pe/billService/getStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SunatServices.getStatusResponse> getStatusAsync(SunatServices.getStatusRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse
    {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdr", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusCdrRequest()
        {
        }
        
        public getStatusCdrRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante)
        {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdrResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SunatServices.statusResponse statusCdr;
        
        public getStatusCdrResponse()
        {
        }
        
        public getStatusCdrResponse(SunatServices.statusResponse statusCdr)
        {
            this.statusCdr = statusCdr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatus", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusRequest()
        {
        }
        
        public getStatusRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante)
        {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SunatServices.statusResponse status;
        
        public getStatusResponse()
        {
        }
        
        public getStatusResponse(SunatServices.statusResponse status)
        {
            this.status = status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface billServiceChannel : SunatServices.billService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class billServiceClient : System.ServiceModel.ClientBase<SunatServices.billService>, SunatServices.billService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public billServiceClient() : 
                base(billServiceClient.GetDefaultBinding(), billServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BillConsultServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public billServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(billServiceClient.GetBindingForEndpoint(endpointConfiguration), billServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public billServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(billServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public billServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(billServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public billServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SunatServices.getStatusCdrResponse> SunatServices.billService.getStatusCdrAsync(SunatServices.getStatusCdrRequest request)
        {
            return base.Channel.getStatusCdrAsync(request);
        }
        
        public System.Threading.Tasks.Task<SunatServices.getStatusCdrResponse> getStatusCdrAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante)
        {
            SunatServices.getStatusCdrRequest inValue = new SunatServices.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((SunatServices.billService)(this)).getStatusCdrAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SunatServices.getStatusResponse> SunatServices.billService.getStatusAsync(SunatServices.getStatusRequest request)
        {
            return base.Channel.getStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<SunatServices.getStatusResponse> getStatusAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante)
        {
            SunatServices.getStatusRequest inValue = new SunatServices.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((SunatServices.billService)(this)).getStatusAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BillConsultServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BillConsultServicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return billServiceClient.GetBindingForEndpoint(EndpointConfiguration.BillConsultServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return billServiceClient.GetEndpointAddress(EndpointConfiguration.BillConsultServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            BillConsultServicePort,
        }
    }
}
