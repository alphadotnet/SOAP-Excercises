﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://tempuri.org/")]
    public partial class Country : object
    {
        
        private string CodeField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://tempuri.org/")]
    public partial class City : object
    {
        
        private int IDField;
        
        private string NameField;
        
        private string CountryCodeField;
        
        private string DistrictField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldServiceReference.WorldServiceSoap")]
    public interface WorldServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCountries", ReplyAction="*")]
        System.Threading.Tasks.Task<WorldServiceReference.GetAllCountriesResponse> GetAllCountriesAsync(WorldServiceReference.GetAllCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCountryByCode", ReplyAction="*")]
        System.Threading.Tasks.Task<WorldServiceReference.GetCountryByCodeResponse> GetCountryByCodeAsync(WorldServiceReference.GetCountryByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCitiesByCountryCode", ReplyAction="*")]
        System.Threading.Tasks.Task<WorldServiceReference.GetCitiesByCountryCodeResponse> GetCitiesByCountryCodeAsync(WorldServiceReference.GetCitiesByCountryCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCityByName", ReplyAction="*")]
        System.Threading.Tasks.Task<WorldServiceReference.GetCityByNameResponse> GetCityByNameAsync(WorldServiceReference.GetCityByNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCountriesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCountries", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetAllCountriesRequestBody Body;
        
        public GetAllCountriesRequest()
        {
        }
        
        public GetAllCountriesRequest(WorldServiceReference.GetAllCountriesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllCountriesRequestBody
    {
        
        public GetAllCountriesRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCountriesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetAllCountriesResponseBody Body;
        
        public GetAllCountriesResponse()
        {
        }
        
        public GetAllCountriesResponse(WorldServiceReference.GetAllCountriesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllCountriesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WorldServiceReference.Country[] GetAllCountriesResult;
        
        public GetAllCountriesResponseBody()
        {
        }
        
        public GetAllCountriesResponseBody(WorldServiceReference.Country[] GetAllCountriesResult)
        {
            this.GetAllCountriesResult = GetAllCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCountryByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCountryByCode", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCountryByCodeRequestBody Body;
        
        public GetCountryByCodeRequest()
        {
        }
        
        public GetCountryByCodeRequest(WorldServiceReference.GetCountryByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCountryByCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string code;
        
        public GetCountryByCodeRequestBody()
        {
        }
        
        public GetCountryByCodeRequestBody(string code)
        {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCountryByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCountryByCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCountryByCodeResponseBody Body;
        
        public GetCountryByCodeResponse()
        {
        }
        
        public GetCountryByCodeResponse(WorldServiceReference.GetCountryByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCountryByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WorldServiceReference.Country GetCountryByCodeResult;
        
        public GetCountryByCodeResponseBody()
        {
        }
        
        public GetCountryByCodeResponseBody(WorldServiceReference.Country GetCountryByCodeResult)
        {
            this.GetCountryByCodeResult = GetCountryByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesByCountryCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCitiesByCountryCode", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCitiesByCountryCodeRequestBody Body;
        
        public GetCitiesByCountryCodeRequest()
        {
        }
        
        public GetCitiesByCountryCodeRequest(WorldServiceReference.GetCitiesByCountryCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCitiesByCountryCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string code;
        
        public GetCitiesByCountryCodeRequestBody()
        {
        }
        
        public GetCitiesByCountryCodeRequestBody(string code)
        {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesByCountryCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCitiesByCountryCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCitiesByCountryCodeResponseBody Body;
        
        public GetCitiesByCountryCodeResponse()
        {
        }
        
        public GetCitiesByCountryCodeResponse(WorldServiceReference.GetCitiesByCountryCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCitiesByCountryCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WorldServiceReference.City[] GetCitiesByCountryCodeResult;
        
        public GetCitiesByCountryCodeResponseBody()
        {
        }
        
        public GetCitiesByCountryCodeResponseBody(WorldServiceReference.City[] GetCitiesByCountryCodeResult)
        {
            this.GetCitiesByCountryCodeResult = GetCitiesByCountryCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCityByName", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCityByNameRequestBody Body;
        
        public GetCityByNameRequest()
        {
        }
        
        public GetCityByNameRequest(WorldServiceReference.GetCityByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCityByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetCityByNameRequestBody()
        {
        }
        
        public GetCityByNameRequestBody(string name)
        {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCityByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public WorldServiceReference.GetCityByNameResponseBody Body;
        
        public GetCityByNameResponse()
        {
        }
        
        public GetCityByNameResponse(WorldServiceReference.GetCityByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCityByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WorldServiceReference.City GetCityByNameResult;
        
        public GetCityByNameResponseBody()
        {
        }
        
        public GetCityByNameResponseBody(WorldServiceReference.City GetCityByNameResult)
        {
            this.GetCityByNameResult = GetCityByNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface WorldServiceSoapChannel : WorldServiceReference.WorldServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class WorldServiceSoapClient : System.ServiceModel.ClientBase<WorldServiceReference.WorldServiceSoap>, WorldServiceReference.WorldServiceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WorldServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WorldServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), WorldServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorldServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WorldServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorldServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WorldServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorldServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WorldServiceReference.GetAllCountriesResponse> WorldServiceReference.WorldServiceSoap.GetAllCountriesAsync(WorldServiceReference.GetAllCountriesRequest request)
        {
            return base.Channel.GetAllCountriesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WorldServiceReference.GetAllCountriesResponse> GetAllCountriesAsync()
        {
            WorldServiceReference.GetAllCountriesRequest inValue = new WorldServiceReference.GetAllCountriesRequest();
            inValue.Body = new WorldServiceReference.GetAllCountriesRequestBody();
            return ((WorldServiceReference.WorldServiceSoap)(this)).GetAllCountriesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WorldServiceReference.GetCountryByCodeResponse> WorldServiceReference.WorldServiceSoap.GetCountryByCodeAsync(WorldServiceReference.GetCountryByCodeRequest request)
        {
            return base.Channel.GetCountryByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WorldServiceReference.GetCountryByCodeResponse> GetCountryByCodeAsync(string code)
        {
            WorldServiceReference.GetCountryByCodeRequest inValue = new WorldServiceReference.GetCountryByCodeRequest();
            inValue.Body = new WorldServiceReference.GetCountryByCodeRequestBody();
            inValue.Body.code = code;
            return ((WorldServiceReference.WorldServiceSoap)(this)).GetCountryByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WorldServiceReference.GetCitiesByCountryCodeResponse> WorldServiceReference.WorldServiceSoap.GetCitiesByCountryCodeAsync(WorldServiceReference.GetCitiesByCountryCodeRequest request)
        {
            return base.Channel.GetCitiesByCountryCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WorldServiceReference.GetCitiesByCountryCodeResponse> GetCitiesByCountryCodeAsync(string code)
        {
            WorldServiceReference.GetCitiesByCountryCodeRequest inValue = new WorldServiceReference.GetCitiesByCountryCodeRequest();
            inValue.Body = new WorldServiceReference.GetCitiesByCountryCodeRequestBody();
            inValue.Body.code = code;
            return ((WorldServiceReference.WorldServiceSoap)(this)).GetCitiesByCountryCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WorldServiceReference.GetCityByNameResponse> WorldServiceReference.WorldServiceSoap.GetCityByNameAsync(WorldServiceReference.GetCityByNameRequest request)
        {
            return base.Channel.GetCityByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WorldServiceReference.GetCityByNameResponse> GetCityByNameAsync(string name)
        {
            WorldServiceReference.GetCityByNameRequest inValue = new WorldServiceReference.GetCityByNameRequest();
            inValue.Body = new WorldServiceReference.GetCityByNameRequestBody();
            inValue.Body.name = name;
            return ((WorldServiceReference.WorldServiceSoap)(this)).GetCityByNameAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WorldServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WorldServiceSoap12))
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
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WorldServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44343/WorldService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WorldServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44343/WorldService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WorldServiceSoap,
            
            WorldServiceSoap12,
        }
    }
}
