﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConductorSync.SchedulesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchedulesService.ConductorSoap")]
    public interface ConductorSoap {
        
        // CODEGEN: Generating message contract since element name Usr from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteConductors", ReplyAction="*")]
        ConductorSync.SchedulesService.DeleteConductorsResponse DeleteConductors(ConductorSync.SchedulesService.DeleteConductorsRequest request);
        
        // CODEGEN: Generating message contract since element name Title from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertConductors", ReplyAction="*")]
        ConductorSync.SchedulesService.InsertConductorsResponse InsertConductors(ConductorSync.SchedulesService.InsertConductorsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteConductorsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteConductors", Namespace="http://tempuri.org/", Order=0)]
        public ConductorSync.SchedulesService.DeleteConductorsRequestBody Body;
        
        public DeleteConductorsRequest() {
        }
        
        public DeleteConductorsRequest(ConductorSync.SchedulesService.DeleteConductorsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteConductorsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime Start;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime End;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Usr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Pwd;
        
        public DeleteConductorsRequestBody() {
        }
        
        public DeleteConductorsRequestBody(System.DateTime Start, System.DateTime End, string Usr, string Pwd) {
            this.Start = Start;
            this.End = End;
            this.Usr = Usr;
            this.Pwd = Pwd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteConductorsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteConductorsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConductorSync.SchedulesService.DeleteConductorsResponseBody Body;
        
        public DeleteConductorsResponse() {
        }
        
        public DeleteConductorsResponse(ConductorSync.SchedulesService.DeleteConductorsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class DeleteConductorsResponseBody {
        
        public DeleteConductorsResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertConductorsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertConductors", Namespace="http://tempuri.org/", Order=0)]
        public ConductorSync.SchedulesService.InsertConductorsRequestBody Body;
        
        public InsertConductorsRequest() {
        }
        
        public InsertConductorsRequest(ConductorSync.SchedulesService.InsertConductorsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertConductorsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Title;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Duration;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime Dt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Url;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Usr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Pwd;
        
        public InsertConductorsRequestBody() {
        }
        
        public InsertConductorsRequestBody(string Title, string Description, string Duration, System.DateTime Dt, string Url, string Usr, string Pwd) {
            this.Title = Title;
            this.Description = Description;
            this.Duration = Duration;
            this.Dt = Dt;
            this.Url = Url;
            this.Usr = Usr;
            this.Pwd = Pwd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertConductorsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertConductorsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConductorSync.SchedulesService.InsertConductorsResponseBody Body;
        
        public InsertConductorsResponse() {
        }
        
        public InsertConductorsResponse(ConductorSync.SchedulesService.InsertConductorsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertConductorsResponseBody {
        
        public InsertConductorsResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConductorSoapChannel : ConductorSync.SchedulesService.ConductorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConductorSoapClient : System.ServiceModel.ClientBase<ConductorSync.SchedulesService.ConductorSoap>, ConductorSync.SchedulesService.ConductorSoap {
        
        public ConductorSoapClient() {
        }
        
        public ConductorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConductorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConductorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConductorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConductorSync.SchedulesService.DeleteConductorsResponse ConductorSync.SchedulesService.ConductorSoap.DeleteConductors(ConductorSync.SchedulesService.DeleteConductorsRequest request) {
            return base.Channel.DeleteConductors(request);
        }
        
        public void DeleteConductors(System.DateTime Start, System.DateTime End, string Usr, string Pwd) {
            ConductorSync.SchedulesService.DeleteConductorsRequest inValue = new ConductorSync.SchedulesService.DeleteConductorsRequest();
            inValue.Body = new ConductorSync.SchedulesService.DeleteConductorsRequestBody();
            inValue.Body.Start = Start;
            inValue.Body.End = End;
            inValue.Body.Usr = Usr;
            inValue.Body.Pwd = Pwd;
            ConductorSync.SchedulesService.DeleteConductorsResponse retVal = ((ConductorSync.SchedulesService.ConductorSoap)(this)).DeleteConductors(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConductorSync.SchedulesService.InsertConductorsResponse ConductorSync.SchedulesService.ConductorSoap.InsertConductors(ConductorSync.SchedulesService.InsertConductorsRequest request) {
            return base.Channel.InsertConductors(request);
        }
        
        public void InsertConductors(string Title, string Description, string Duration, System.DateTime Dt, string Url, string Usr, string Pwd) {
            ConductorSync.SchedulesService.InsertConductorsRequest inValue = new ConductorSync.SchedulesService.InsertConductorsRequest();
            inValue.Body = new ConductorSync.SchedulesService.InsertConductorsRequestBody();
            inValue.Body.Title = Title;
            inValue.Body.Description = Description;
            inValue.Body.Duration = Duration;
            inValue.Body.Dt = Dt;
            inValue.Body.Url = Url;
            inValue.Body.Usr = Usr;
            inValue.Body.Pwd = Pwd;
            ConductorSync.SchedulesService.InsertConductorsResponse retVal = ((ConductorSync.SchedulesService.ConductorSoap)(this)).InsertConductors(inValue);
        }
    }
}
