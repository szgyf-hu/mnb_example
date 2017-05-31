﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace mnb.hu.mnb.www {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CustomBinding_MNBArfolyamServiceSoap", Namespace="http://www.mnb.hu/webservices/")]
    public partial class MNBArfolyamServiceSoapImpl : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCurrenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCurrencyUnitsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCurrentExchangeRatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDateIntervalOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetExchangeRatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MNBArfolyamServiceSoapImpl() {
            this.Url = global::mnb.Properties.Settings.Default.mnb_hu_mnb_www_MNBArfolyamServiceSoapImpl;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCurrenciesCompletedEventHandler GetCurrenciesCompleted;
        
        /// <remarks/>
        public event GetCurrencyUnitsCompletedEventHandler GetCurrencyUnitsCompleted;
        
        /// <remarks/>
        public event GetCurrentExchangeRatesCompletedEventHandler GetCurrentExchangeRatesCompleted;
        
        /// <remarks/>
        public event GetDateIntervalCompletedEventHandler GetDateIntervalCompleted;
        
        /// <remarks/>
        public event GetExchangeRatesCompletedEventHandler GetExchangeRatesCompleted;
        
        /// <remarks/>
        public event GetInfoCompletedEventHandler GetInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencies", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetCurrenciesResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetCurrenciesResponseBody GetCurrencies([System.Xml.Serialization.XmlElementAttribute("GetCurrencies", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetCurrenciesRequestBody GetCurrencies1) {
            object[] results = this.Invoke("GetCurrencies", new object[] {
                        GetCurrencies1});
            return ((GetCurrenciesResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrenciesAsync(GetCurrenciesRequestBody GetCurrencies1) {
            this.GetCurrenciesAsync(GetCurrencies1, null);
        }
        
        /// <remarks/>
        public void GetCurrenciesAsync(GetCurrenciesRequestBody GetCurrencies1, object userState) {
            if ((this.GetCurrenciesOperationCompleted == null)) {
                this.GetCurrenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrenciesOperationCompleted);
            }
            this.InvokeAsync("GetCurrencies", new object[] {
                        GetCurrencies1}, this.GetCurrenciesOperationCompleted, userState);
        }
        
        private void OnGetCurrenciesOperationCompleted(object arg) {
            if ((this.GetCurrenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrenciesCompleted(this, new GetCurrenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencyUnits", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetCurrencyUnitsResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetCurrencyUnitsResponseBody GetCurrencyUnits([System.Xml.Serialization.XmlElementAttribute("GetCurrencyUnits", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetCurrencyUnitsRequestBody GetCurrencyUnits1) {
            object[] results = this.Invoke("GetCurrencyUnits", new object[] {
                        GetCurrencyUnits1});
            return ((GetCurrencyUnitsResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrencyUnitsAsync(GetCurrencyUnitsRequestBody GetCurrencyUnits1) {
            this.GetCurrencyUnitsAsync(GetCurrencyUnits1, null);
        }
        
        /// <remarks/>
        public void GetCurrencyUnitsAsync(GetCurrencyUnitsRequestBody GetCurrencyUnits1, object userState) {
            if ((this.GetCurrencyUnitsOperationCompleted == null)) {
                this.GetCurrencyUnitsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrencyUnitsOperationCompleted);
            }
            this.InvokeAsync("GetCurrencyUnits", new object[] {
                        GetCurrencyUnits1}, this.GetCurrencyUnitsOperationCompleted, userState);
        }
        
        private void OnGetCurrencyUnitsOperationCompleted(object arg) {
            if ((this.GetCurrencyUnitsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrencyUnitsCompleted(this, new GetCurrencyUnitsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrentExchangeRates", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetCurrentExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetCurrentExchangeRatesResponseBody GetCurrentExchangeRates([System.Xml.Serialization.XmlElementAttribute("GetCurrentExchangeRates", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates1) {
            object[] results = this.Invoke("GetCurrentExchangeRates", new object[] {
                        GetCurrentExchangeRates1});
            return ((GetCurrentExchangeRatesResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentExchangeRatesAsync(GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates1) {
            this.GetCurrentExchangeRatesAsync(GetCurrentExchangeRates1, null);
        }
        
        /// <remarks/>
        public void GetCurrentExchangeRatesAsync(GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates1, object userState) {
            if ((this.GetCurrentExchangeRatesOperationCompleted == null)) {
                this.GetCurrentExchangeRatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentExchangeRatesOperationCompleted);
            }
            this.InvokeAsync("GetCurrentExchangeRates", new object[] {
                        GetCurrentExchangeRates1}, this.GetCurrentExchangeRatesOperationCompleted, userState);
        }
        
        private void OnGetCurrentExchangeRatesOperationCompleted(object arg) {
            if ((this.GetCurrentExchangeRatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentExchangeRatesCompleted(this, new GetCurrentExchangeRatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetDateInterval", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetDateIntervalResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetDateIntervalResponseBody GetDateInterval([System.Xml.Serialization.XmlElementAttribute("GetDateInterval", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetDateIntervalRequestBody GetDateInterval1) {
            object[] results = this.Invoke("GetDateInterval", new object[] {
                        GetDateInterval1});
            return ((GetDateIntervalResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetDateIntervalAsync(GetDateIntervalRequestBody GetDateInterval1) {
            this.GetDateIntervalAsync(GetDateInterval1, null);
        }
        
        /// <remarks/>
        public void GetDateIntervalAsync(GetDateIntervalRequestBody GetDateInterval1, object userState) {
            if ((this.GetDateIntervalOperationCompleted == null)) {
                this.GetDateIntervalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDateIntervalOperationCompleted);
            }
            this.InvokeAsync("GetDateInterval", new object[] {
                        GetDateInterval1}, this.GetDateIntervalOperationCompleted, userState);
        }
        
        private void OnGetDateIntervalOperationCompleted(object arg) {
            if ((this.GetDateIntervalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDateIntervalCompleted(this, new GetDateIntervalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetExchangeRates", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetExchangeRatesResponseBody GetExchangeRates([System.Xml.Serialization.XmlElementAttribute("GetExchangeRates", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetExchangeRatesRequestBody GetExchangeRates1) {
            object[] results = this.Invoke("GetExchangeRates", new object[] {
                        GetExchangeRates1});
            return ((GetExchangeRatesResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetExchangeRatesAsync(GetExchangeRatesRequestBody GetExchangeRates1) {
            this.GetExchangeRatesAsync(GetExchangeRates1, null);
        }
        
        /// <remarks/>
        public void GetExchangeRatesAsync(GetExchangeRatesRequestBody GetExchangeRates1, object userState) {
            if ((this.GetExchangeRatesOperationCompleted == null)) {
                this.GetExchangeRatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExchangeRatesOperationCompleted);
            }
            this.InvokeAsync("GetExchangeRates", new object[] {
                        GetExchangeRates1}, this.GetExchangeRatesOperationCompleted, userState);
        }
        
        private void OnGetExchangeRatesOperationCompleted(object arg) {
            if ((this.GetExchangeRatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExchangeRatesCompleted(this, new GetExchangeRatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetInfo", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetInfoResponse", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)]
        public GetInfoResponseBody GetInfo([System.Xml.Serialization.XmlElementAttribute("GetInfo", Namespace="http://www.mnb.hu/webservices/", IsNullable=true)] GetInfoRequestBody GetInfo1) {
            object[] results = this.Invoke("GetInfo", new object[] {
                        GetInfo1});
            return ((GetInfoResponseBody)(results[0]));
        }
        
        /// <remarks/>
        public void GetInfoAsync(GetInfoRequestBody GetInfo1) {
            this.GetInfoAsync(GetInfo1, null);
        }
        
        /// <remarks/>
        public void GetInfoAsync(GetInfoRequestBody GetInfo1, object userState) {
            if ((this.GetInfoOperationCompleted == null)) {
                this.GetInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInfoOperationCompleted);
            }
            this.InvokeAsync("GetInfo", new object[] {
                        GetInfo1}, this.GetInfoOperationCompleted, userState);
        }
        
        private void OnGetInfoOperationCompleted(object arg) {
            if ((this.GetInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInfoCompleted(this, new GetInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrenciesRequestBody {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetInfoResponseBody {
        
        private string getInfoResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetInfoResult {
            get {
                return this.getInfoResultField;
            }
            set {
                this.getInfoResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetInfoRequestBody {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesResponseBody {
        
        private string getExchangeRatesResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetExchangeRatesResult {
            get {
                return this.getExchangeRatesResultField;
            }
            set {
                this.getExchangeRatesResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesRequestBody {
        
        private string startDateField;
        
        private string endDateField;
        
        private string currencyNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string currencyNames {
            get {
                return this.currencyNamesField;
            }
            set {
                this.currencyNamesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetDateIntervalResponseBody {
        
        private string getDateIntervalResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetDateIntervalResult {
            get {
                return this.getDateIntervalResultField;
            }
            set {
                this.getDateIntervalResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetDateIntervalRequestBody {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrentExchangeRatesResponseBody {
        
        private string getCurrentExchangeRatesResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetCurrentExchangeRatesResult {
            get {
                return this.getCurrentExchangeRatesResultField;
            }
            set {
                this.getCurrentExchangeRatesResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrentExchangeRatesRequestBody {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsResponseBody {
        
        private string getCurrencyUnitsResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetCurrencyUnitsResult {
            get {
                return this.getCurrencyUnitsResultField;
            }
            set {
                this.getCurrencyUnitsResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsRequestBody {
        
        private string currencyNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string currencyNames {
            get {
                return this.currencyNamesField;
            }
            set {
                this.currencyNamesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrenciesResponseBody {
        
        private string getCurrenciesResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetCurrenciesResult {
            get {
                return this.getCurrenciesResultField;
            }
            set {
                this.getCurrenciesResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetCurrenciesCompletedEventHandler(object sender, GetCurrenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetCurrenciesResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetCurrenciesResponseBody)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetCurrencyUnitsCompletedEventHandler(object sender, GetCurrencyUnitsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrencyUnitsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrencyUnitsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetCurrencyUnitsResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetCurrencyUnitsResponseBody)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetCurrentExchangeRatesCompletedEventHandler(object sender, GetCurrentExchangeRatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentExchangeRatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentExchangeRatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetCurrentExchangeRatesResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetCurrentExchangeRatesResponseBody)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetDateIntervalCompletedEventHandler(object sender, GetDateIntervalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDateIntervalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDateIntervalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetDateIntervalResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetDateIntervalResponseBody)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetExchangeRatesCompletedEventHandler(object sender, GetExchangeRatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExchangeRatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetExchangeRatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetExchangeRatesResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetExchangeRatesResponseBody)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetInfoCompletedEventHandler(object sender, GetInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetInfoResponseBody Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetInfoResponseBody)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591