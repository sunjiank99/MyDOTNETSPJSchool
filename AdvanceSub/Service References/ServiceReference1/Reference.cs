﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvanceSub.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.BoxServiceSoap")]
    public interface BoxServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 BoxUserCodeB 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBoxUserInfo", ReplyAction="*")]
        AdvanceSub.ServiceReference1.GetBoxUserInfoResponse GetBoxUserInfo(AdvanceSub.ServiceReference1.GetBoxUserInfoRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 GetAllBoxInfoResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBoxInfo", ReplyAction="*")]
        AdvanceSub.ServiceReference1.GetAllBoxInfoResponse GetAllBoxInfo(AdvanceSub.ServiceReference1.GetAllBoxInfoRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 BoxUserCode 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetBoxInfo", ReplyAction="*")]
        AdvanceSub.ServiceReference1.SetBoxInfoResponse SetBoxInfo(AdvanceSub.ServiceReference1.SetBoxInfoRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 ID 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetBoxGroupInfo", ReplyAction="*")]
        AdvanceSub.ServiceReference1.SetBoxGroupInfoResponse SetBoxGroupInfo(AdvanceSub.ServiceReference1.SetBoxGroupInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBoxUserInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBoxUserInfo", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.GetBoxUserInfoRequestBody Body;
        
        public GetBoxUserInfoRequest() {
        }
        
        public GetBoxUserInfoRequest(AdvanceSub.ServiceReference1.GetBoxUserInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBoxUserInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BoxUserCodeB;
        
        public GetBoxUserInfoRequestBody() {
        }
        
        public GetBoxUserInfoRequestBody(string BoxUserCodeB) {
            this.BoxUserCodeB = BoxUserCodeB;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBoxUserInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBoxUserInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.GetBoxUserInfoResponseBody Body;
        
        public GetBoxUserInfoResponse() {
        }
        
        public GetBoxUserInfoResponse(AdvanceSub.ServiceReference1.GetBoxUserInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBoxUserInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetBoxUserInfoResult;
        
        public GetBoxUserInfoResponseBody() {
        }
        
        public GetBoxUserInfoResponseBody(string GetBoxUserInfoResult) {
            this.GetBoxUserInfoResult = GetBoxUserInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBoxInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBoxInfo", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.GetAllBoxInfoRequestBody Body;
        
        public GetAllBoxInfoRequest() {
        }
        
        public GetAllBoxInfoRequest(AdvanceSub.ServiceReference1.GetAllBoxInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllBoxInfoRequestBody {
        
        public GetAllBoxInfoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBoxInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBoxInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.GetAllBoxInfoResponseBody Body;
        
        public GetAllBoxInfoResponse() {
        }
        
        public GetAllBoxInfoResponse(AdvanceSub.ServiceReference1.GetAllBoxInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllBoxInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllBoxInfoResult;
        
        public GetAllBoxInfoResponseBody() {
        }
        
        public GetAllBoxInfoResponseBody(string GetAllBoxInfoResult) {
            this.GetAllBoxInfoResult = GetAllBoxInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetBoxInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetBoxInfo", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.SetBoxInfoRequestBody Body;
        
        public SetBoxInfoRequest() {
        }
        
        public SetBoxInfoRequest(AdvanceSub.ServiceReference1.SetBoxInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SetBoxInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BoxUserCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string BoxUserCodeB;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string boxid;
        
        public SetBoxInfoRequestBody() {
        }
        
        public SetBoxInfoRequestBody(string BoxUserCode, string BoxUserCodeB, string boxid) {
            this.BoxUserCode = BoxUserCode;
            this.BoxUserCodeB = BoxUserCodeB;
            this.boxid = boxid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetBoxInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetBoxInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.SetBoxInfoResponseBody Body;
        
        public SetBoxInfoResponse() {
        }
        
        public SetBoxInfoResponse(AdvanceSub.ServiceReference1.SetBoxInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SetBoxInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SetBoxInfoResult;
        
        public SetBoxInfoResponseBody() {
        }
        
        public SetBoxInfoResponseBody(string SetBoxInfoResult) {
            this.SetBoxInfoResult = SetBoxInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetBoxGroupInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetBoxGroupInfo", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.SetBoxGroupInfoRequestBody Body;
        
        public SetBoxGroupInfoRequest() {
        }
        
        public SetBoxGroupInfoRequest(AdvanceSub.ServiceReference1.SetBoxGroupInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SetBoxGroupInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Content;
        
        public SetBoxGroupInfoRequestBody() {
        }
        
        public SetBoxGroupInfoRequestBody(string ID, string Content) {
            this.ID = ID;
            this.Content = Content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetBoxGroupInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetBoxGroupInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdvanceSub.ServiceReference1.SetBoxGroupInfoResponseBody Body;
        
        public SetBoxGroupInfoResponse() {
        }
        
        public SetBoxGroupInfoResponse(AdvanceSub.ServiceReference1.SetBoxGroupInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SetBoxGroupInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SetBoxGroupInfoResult;
        
        public SetBoxGroupInfoResponseBody() {
        }
        
        public SetBoxGroupInfoResponseBody(string SetBoxGroupInfoResult) {
            this.SetBoxGroupInfoResult = SetBoxGroupInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BoxServiceSoapChannel : AdvanceSub.ServiceReference1.BoxServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BoxServiceSoapClient : System.ServiceModel.ClientBase<AdvanceSub.ServiceReference1.BoxServiceSoap>, AdvanceSub.ServiceReference1.BoxServiceSoap {
        
        public BoxServiceSoapClient() {
        }
        
        public BoxServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BoxServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoxServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoxServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvanceSub.ServiceReference1.GetBoxUserInfoResponse AdvanceSub.ServiceReference1.BoxServiceSoap.GetBoxUserInfo(AdvanceSub.ServiceReference1.GetBoxUserInfoRequest request) {
            return base.Channel.GetBoxUserInfo(request);
        }
        
        public string GetBoxUserInfo(string BoxUserCodeB) {
            AdvanceSub.ServiceReference1.GetBoxUserInfoRequest inValue = new AdvanceSub.ServiceReference1.GetBoxUserInfoRequest();
            inValue.Body = new AdvanceSub.ServiceReference1.GetBoxUserInfoRequestBody();
            inValue.Body.BoxUserCodeB = BoxUserCodeB;
            AdvanceSub.ServiceReference1.GetBoxUserInfoResponse retVal = ((AdvanceSub.ServiceReference1.BoxServiceSoap)(this)).GetBoxUserInfo(inValue);
            return retVal.Body.GetBoxUserInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvanceSub.ServiceReference1.GetAllBoxInfoResponse AdvanceSub.ServiceReference1.BoxServiceSoap.GetAllBoxInfo(AdvanceSub.ServiceReference1.GetAllBoxInfoRequest request) {
            return base.Channel.GetAllBoxInfo(request);
        }
        
        public string GetAllBoxInfo() {
            AdvanceSub.ServiceReference1.GetAllBoxInfoRequest inValue = new AdvanceSub.ServiceReference1.GetAllBoxInfoRequest();
            inValue.Body = new AdvanceSub.ServiceReference1.GetAllBoxInfoRequestBody();
            AdvanceSub.ServiceReference1.GetAllBoxInfoResponse retVal = ((AdvanceSub.ServiceReference1.BoxServiceSoap)(this)).GetAllBoxInfo(inValue);
            return retVal.Body.GetAllBoxInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvanceSub.ServiceReference1.SetBoxInfoResponse AdvanceSub.ServiceReference1.BoxServiceSoap.SetBoxInfo(AdvanceSub.ServiceReference1.SetBoxInfoRequest request) {
            return base.Channel.SetBoxInfo(request);
        }
        
        public string SetBoxInfo(string BoxUserCode, string BoxUserCodeB, string boxid) {
            AdvanceSub.ServiceReference1.SetBoxInfoRequest inValue = new AdvanceSub.ServiceReference1.SetBoxInfoRequest();
            inValue.Body = new AdvanceSub.ServiceReference1.SetBoxInfoRequestBody();
            inValue.Body.BoxUserCode = BoxUserCode;
            inValue.Body.BoxUserCodeB = BoxUserCodeB;
            inValue.Body.boxid = boxid;
            AdvanceSub.ServiceReference1.SetBoxInfoResponse retVal = ((AdvanceSub.ServiceReference1.BoxServiceSoap)(this)).SetBoxInfo(inValue);
            return retVal.Body.SetBoxInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvanceSub.ServiceReference1.SetBoxGroupInfoResponse AdvanceSub.ServiceReference1.BoxServiceSoap.SetBoxGroupInfo(AdvanceSub.ServiceReference1.SetBoxGroupInfoRequest request) {
            return base.Channel.SetBoxGroupInfo(request);
        }
        
        public string SetBoxGroupInfo(string ID, string Content) {
            AdvanceSub.ServiceReference1.SetBoxGroupInfoRequest inValue = new AdvanceSub.ServiceReference1.SetBoxGroupInfoRequest();
            inValue.Body = new AdvanceSub.ServiceReference1.SetBoxGroupInfoRequestBody();
            inValue.Body.ID = ID;
            inValue.Body.Content = Content;
            AdvanceSub.ServiceReference1.SetBoxGroupInfoResponse retVal = ((AdvanceSub.ServiceReference1.BoxServiceSoap)(this)).SetBoxGroupInfo(inValue);
            return retVal.Body.SetBoxGroupInfoResult;
        }
    }
}
