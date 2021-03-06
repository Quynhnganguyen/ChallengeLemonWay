﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChallengeLemonwayConsumer.ChallengeLemonwayService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ChallengeLemonway.org/", ConfigurationName="ChallengeLemonwayService.ChallengeLemonwayServiceSoap")]
    public interface ChallengeLemonwayServiceSoap {
        
        // CODEGEN: Generating message contract since element name FibonacciResult from namespace http://ChallengeLemonway.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ChallengeLemonway.org/Fibonacci", ReplyAction="*")]
        ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse Fibonacci(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ChallengeLemonway.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse> FibonacciAsync(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest request);
        
        // CODEGEN: Generating message contract since element name xml from namespace http://ChallengeLemonway.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ChallengeLemonway.org/XmlToJson", ReplyAction="*")]
        ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse XmlToJson(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ChallengeLemonway.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse> XmlToJsonAsync(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Fibonacci", Namespace="http://ChallengeLemonway.org/", Order=0)]
        public ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequestBody Body;
        
        public FibonacciRequest() {
        }
        
        public FibonacciRequest(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ChallengeLemonway.org/")]
    public partial class FibonacciRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int n;
        
        public FibonacciRequestBody() {
        }
        
        public FibonacciRequestBody(int n) {
            this.n = n;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FibonacciResponse", Namespace="http://ChallengeLemonway.org/", Order=0)]
        public ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponseBody Body;
        
        public FibonacciResponse() {
        }
        
        public FibonacciResponse(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ChallengeLemonway.org/")]
    public partial class FibonacciResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FibonacciResult;
        
        public FibonacciResponseBody() {
        }
        
        public FibonacciResponseBody(string FibonacciResult) {
            this.FibonacciResult = FibonacciResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://ChallengeLemonway.org/", Order=0)]
        public ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ChallengeLemonway.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://ChallengeLemonway.org/", Order=0)]
        public ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ChallengeLemonway.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChallengeLemonwayServiceSoapChannel : ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChallengeLemonwayServiceSoapClient : System.ServiceModel.ClientBase<ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap>, ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap {
        
        public ChallengeLemonwayServiceSoapClient() {
        }
        
        public ChallengeLemonwayServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChallengeLemonwayServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChallengeLemonwayServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChallengeLemonwayServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap.Fibonacci(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest request) {
            return base.Channel.Fibonacci(request);
        }
        
        public string Fibonacci(int n) {
            ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest inValue = new ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest();
            inValue.Body = new ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequestBody();
            inValue.Body.n = n;
            ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse retVal = ((ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap)(this)).Fibonacci(inValue);
            return retVal.Body.FibonacciResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse> ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap.FibonacciAsync(ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest request) {
            return base.Channel.FibonacciAsync(request);
        }
        
        public System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciResponse> FibonacciAsync(int n) {
            ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest inValue = new ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequest();
            inValue.Body = new ChallengeLemonwayConsumer.ChallengeLemonwayService.FibonacciRequestBody();
            inValue.Body.n = n;
            return ((ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap)(this)).FibonacciAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap.XmlToJson(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest inValue = new ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest();
            inValue.Body = new ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse retVal = ((ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse> ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap.XmlToJsonAsync(ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest inValue = new ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequest();
            inValue.Body = new ChallengeLemonwayConsumer.ChallengeLemonwayService.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((ChallengeLemonwayConsumer.ChallengeLemonwayService.ChallengeLemonwayServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
