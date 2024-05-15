﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Trimetric.LifePartner.Web.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.MatrimonyServiceSoap")]
    public interface MatrimonyServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Trimetric.LifePartner.Web.Calculator.HelloWorldResponse HelloWorld(Trimetric.LifePartner.Web.Calculator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.HelloWorldResponse> HelloWorldAsync(Trimetric.LifePartner.Web.Calculator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumOfNums", ReplyAction="*")]
        int SumOfNums(int FirstNumber, int SecondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumOfNums", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumOfNumsAsync(int FirstNumber, int SecondNumber);
        
        // CODEGEN: Generating message contract since the wrapper name (SumOfFloats) of message SumOfFloats does not match the default value (SumOfNums1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumOfFloats", ReplyAction="*")]
        Trimetric.LifePartner.Web.Calculator.SumOfFloats1 SumOfNums1(Trimetric.LifePartner.Web.Calculator.SumOfFloats request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumOfFloats", ReplyAction="*")]
        System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.SumOfFloats1> SumOfNums1Async(Trimetric.LifePartner.Web.Calculator.SumOfFloats request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Trimetric.LifePartner.Web.Calculator.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Trimetric.LifePartner.Web.Calculator.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Trimetric.LifePartner.Web.Calculator.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Trimetric.LifePartner.Web.Calculator.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SumOfFloats", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SumOfFloats {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public float FirstNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public float SecondNumber;
        
        public SumOfFloats() {
        }
        
        public SumOfFloats(float FirstNumber, float SecondNumber) {
            this.FirstNumber = FirstNumber;
            this.SecondNumber = SecondNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SumOfFloatsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SumOfFloats1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public float SumOfFloatsResult;
        
        public SumOfFloats1() {
        }
        
        public SumOfFloats1(float SumOfFloatsResult) {
            this.SumOfFloatsResult = SumOfFloatsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MatrimonyServiceSoapChannel : Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatrimonyServiceSoapClient : System.ServiceModel.ClientBase<Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap>, Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap {
        
        public MatrimonyServiceSoapClient() {
        }
        
        public MatrimonyServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatrimonyServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatrimonyServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatrimonyServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trimetric.LifePartner.Web.Calculator.HelloWorldResponse Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap.HelloWorld(Trimetric.LifePartner.Web.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Trimetric.LifePartner.Web.Calculator.HelloWorldRequest inValue = new Trimetric.LifePartner.Web.Calculator.HelloWorldRequest();
            inValue.Body = new Trimetric.LifePartner.Web.Calculator.HelloWorldRequestBody();
            Trimetric.LifePartner.Web.Calculator.HelloWorldResponse retVal = ((Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.HelloWorldResponse> Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap.HelloWorldAsync(Trimetric.LifePartner.Web.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.HelloWorldResponse> HelloWorldAsync() {
            Trimetric.LifePartner.Web.Calculator.HelloWorldRequest inValue = new Trimetric.LifePartner.Web.Calculator.HelloWorldRequest();
            inValue.Body = new Trimetric.LifePartner.Web.Calculator.HelloWorldRequestBody();
            return ((Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int SumOfNums(int FirstNumber, int SecondNumber) {
            return base.Channel.SumOfNums(FirstNumber, SecondNumber);
        }
        
        public System.Threading.Tasks.Task<int> SumOfNumsAsync(int FirstNumber, int SecondNumber) {
            return base.Channel.SumOfNumsAsync(FirstNumber, SecondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trimetric.LifePartner.Web.Calculator.SumOfFloats1 Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap.SumOfNums1(Trimetric.LifePartner.Web.Calculator.SumOfFloats request) {
            return base.Channel.SumOfNums1(request);
        }
        
        public float SumOfNums1(float FirstNumber, float SecondNumber) {
            Trimetric.LifePartner.Web.Calculator.SumOfFloats inValue = new Trimetric.LifePartner.Web.Calculator.SumOfFloats();
            inValue.FirstNumber = FirstNumber;
            inValue.SecondNumber = SecondNumber;
            Trimetric.LifePartner.Web.Calculator.SumOfFloats1 retVal = ((Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap)(this)).SumOfNums1(inValue);
            return retVal.SumOfFloatsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.SumOfFloats1> Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap.SumOfNums1Async(Trimetric.LifePartner.Web.Calculator.SumOfFloats request) {
            return base.Channel.SumOfNums1Async(request);
        }
        
        public System.Threading.Tasks.Task<Trimetric.LifePartner.Web.Calculator.SumOfFloats1> SumOfNums1Async(float FirstNumber, float SecondNumber) {
            Trimetric.LifePartner.Web.Calculator.SumOfFloats inValue = new Trimetric.LifePartner.Web.Calculator.SumOfFloats();
            inValue.FirstNumber = FirstNumber;
            inValue.SecondNumber = SecondNumber;
            return ((Trimetric.LifePartner.Web.Calculator.MatrimonyServiceSoap)(this)).SumOfNums1Async(inValue);
        }

        internal int Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}