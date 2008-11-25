﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 2.0.5.0
// 
namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginDto", Namespace="http://www.puremvc.org/")]
    public partial class LoginDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string UsernameField;
        
        private string PasswordField;
        
        private System.DateTime LoginDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime LoginDate {
            get {
                return this.LoginDateField;
            }
            set {
                if ((this.LoginDateField.Equals(value) != true)) {
                    this.LoginDateField = value;
                    this.RaisePropertyChanged("LoginDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.puremvc.org/", ConfigurationName="LoginService.LoginServiceSoap")]
    public interface LoginServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.puremvc.org/DoLogin", ReplyAction="*")]
        System.IAsyncResult BeginDoLogin(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequest request, System.AsyncCallback callback, object asyncState);
        
        PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse EndDoLogin(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoLogin", Namespace="http://www.puremvc.org/", Order=0)]
        public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequestBody Body;
        
        public DoLoginRequest() {
        }
        
        public DoLoginRequest(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.puremvc.org/")]
    public partial class DoLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto;
        
        public DoLoginRequestBody() {
        }
        
        public DoLoginRequestBody(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto) {
            this.loginDto = loginDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoLoginResponse", Namespace="http://www.puremvc.org/", Order=0)]
        public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponseBody Body;
        
        public DoLoginResponse() {
        }
        
        public DoLoginResponse(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.puremvc.org/")]
    public partial class DoLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto DoLoginResult;
        
        public DoLoginResponseBody() {
        }
        
        public DoLoginResponseBody(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto DoLoginResult) {
            this.DoLoginResult = DoLoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface LoginServiceSoapChannel : PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class DoLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DoLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class LoginServiceSoapClient : System.ServiceModel.ClientBase<PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap>, PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap {
        
        private BeginOperationDelegate onBeginDoLoginDelegate;
        
        private EndOperationDelegate onEndDoLoginDelegate;
        
        private System.Threading.SendOrPostCallback onDoLoginCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public LoginServiceSoapClient() {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<DoLoginCompletedEventArgs> DoLoginCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap.BeginDoLogin(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoLogin(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginDoLogin(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto, System.AsyncCallback callback, object asyncState) {
            PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequest inValue = new PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequest();
            inValue.Body = new PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequestBody();
            inValue.Body.loginDto = loginDto;
            return ((PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap)(this)).BeginDoLogin(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap.EndDoLogin(System.IAsyncResult result) {
            return base.Channel.EndDoLogin(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto EndDoLogin(System.IAsyncResult result) {
            PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse retVal = ((PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap)(this)).EndDoLogin(result);
            return retVal.Body.DoLoginResult;
        }
        
        private System.IAsyncResult OnBeginDoLogin(object[] inValues, System.AsyncCallback callback, object asyncState) {
            PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto = ((PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto)(inValues[0]));
            return this.BeginDoLogin(loginDto, callback, asyncState);
        }
        
        private object[] OnEndDoLogin(System.IAsyncResult result) {
            PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto retVal = this.EndDoLogin(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDoLoginCompleted(object state) {
            if ((this.DoLoginCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoLoginCompleted(this, new DoLoginCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoLoginAsync(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto) {
            this.DoLoginAsync(loginDto, null);
        }
        
        public void DoLoginAsync(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginDto loginDto, object userState) {
            if ((this.onBeginDoLoginDelegate == null)) {
                this.onBeginDoLoginDelegate = new BeginOperationDelegate(this.OnBeginDoLogin);
            }
            if ((this.onEndDoLoginDelegate == null)) {
                this.onEndDoLoginDelegate = new EndOperationDelegate(this.OnEndDoLogin);
            }
            if ((this.onDoLoginCompletedDelegate == null)) {
                this.onDoLoginCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoLoginCompleted);
            }
            base.InvokeAsync(this.onBeginDoLoginDelegate, new object[] {
                        loginDto}, this.onEndDoLoginDelegate, this.onDoLoginCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap CreateChannel() {
            return new LoginServiceSoapClientChannel(this);
        }
        
        private class LoginServiceSoapClientChannel : ChannelBase<PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap>, PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap {
            
            public LoginServiceSoapClientChannel(System.ServiceModel.ClientBase<PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.LoginServiceSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDoLogin(PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("DoLogin", _args, callback, asyncState);
                return _result;
            }
            
            public PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse EndDoLogin(System.IAsyncResult result) {
                object[] _args = new object[0];
                PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse _result = ((PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginResponse)(base.EndInvoke("DoLogin", _args, result)));
                return _result;
            }
        }
    }
}
