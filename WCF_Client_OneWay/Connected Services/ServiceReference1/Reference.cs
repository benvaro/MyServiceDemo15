﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Client_OneWay.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IReply")]
    public interface IReply {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReply/FastReply")]
        void FastReply();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReply/FastReply")]
        System.Threading.Tasks.Task FastReplyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReply/SlowReply", ReplyAction="http://tempuri.org/IReply/SlowReplyResponse")]
        void SlowReply();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReply/SlowReply", ReplyAction="http://tempuri.org/IReply/SlowReplyResponse")]
        System.Threading.Tasks.Task SlowReplyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReplyChannel : WCF_Client_OneWay.ServiceReference1.IReply, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReplyClient : System.ServiceModel.ClientBase<WCF_Client_OneWay.ServiceReference1.IReply>, WCF_Client_OneWay.ServiceReference1.IReply {
        
        public ReplyClient() {
        }
        
        public ReplyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReplyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void FastReply() {
            base.Channel.FastReply();
        }
        
        public System.Threading.Tasks.Task FastReplyAsync() {
            return base.Channel.FastReplyAsync();
        }
        
        public void SlowReply() {
            base.Channel.SlowReply();
        }
        
        public System.Threading.Tasks.Task SlowReplyAsync() {
            return base.Channel.SlowReplyAsync();
        }
    }
}
