﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachHang.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfTblKhachHang", Namespace="http://tempuri.org/", ItemName="tblKhachHang")]
    [System.SerializableAttribute()]
    public class ArrayOfTblKhachHang : System.Collections.Generic.List<QuanLiKhachHang.ServiceReference1.tblKhachHang> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblKhachHang", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class tblKhachHang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int MaKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoTenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GioiTinhField;
        
        private System.DateTime NamSinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CMNDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SDTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        private System.Nullable<int> DiemLuuField;
        
        private int DiemTichLuyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoaiKhachHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrangThaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int MaKH {
            get {
                return this.MaKHField;
            }
            set {
                if ((this.MaKHField.Equals(value) != true)) {
                    this.MaKHField = value;
                    this.RaisePropertyChanged("MaKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string HoTen {
            get {
                return this.HoTenField;
            }
            set {
                if ((object.ReferenceEquals(this.HoTenField, value) != true)) {
                    this.HoTenField = value;
                    this.RaisePropertyChanged("HoTen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string GioiTinh {
            get {
                return this.GioiTinhField;
            }
            set {
                if ((object.ReferenceEquals(this.GioiTinhField, value) != true)) {
                    this.GioiTinhField = value;
                    this.RaisePropertyChanged("GioiTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime NamSinh {
            get {
                return this.NamSinhField;
            }
            set {
                if ((this.NamSinhField.Equals(value) != true)) {
                    this.NamSinhField = value;
                    this.RaisePropertyChanged("NamSinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string CMND {
            get {
                return this.CMNDField;
            }
            set {
                if ((object.ReferenceEquals(this.CMNDField, value) != true)) {
                    this.CMNDField = value;
                    this.RaisePropertyChanged("CMND");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string SDT {
            get {
                return this.SDTField;
            }
            set {
                if ((object.ReferenceEquals(this.SDTField, value) != true)) {
                    this.SDTField = value;
                    this.RaisePropertyChanged("SDT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<int> DiemLuu {
            get {
                return this.DiemLuuField;
            }
            set {
                if ((this.DiemLuuField.Equals(value) != true)) {
                    this.DiemLuuField = value;
                    this.RaisePropertyChanged("DiemLuu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int DiemTichLuy {
            get {
                return this.DiemTichLuyField;
            }
            set {
                if ((this.DiemTichLuyField.Equals(value) != true)) {
                    this.DiemTichLuyField = value;
                    this.RaisePropertyChanged("DiemTichLuy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string LoaiKhachHang {
            get {
                return this.LoaiKhachHangField;
            }
            set {
                if ((object.ReferenceEquals(this.LoaiKhachHangField, value) != true)) {
                    this.LoaiKhachHangField = value;
                    this.RaisePropertyChanged("LoaiKhachHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TrangThaiField, value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        QuanLiKhachHang.ServiceReference1.HelloWorldResponse HelloWorld(QuanLiKhachHang.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.HelloWorldResponse> HelloWorldAsync(QuanLiKhachHang.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name tblKhachHangsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblKhachHangs", ReplyAction="*")]
        QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse tblKhachHangs(QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblKhachHangs", ReplyAction="*")]
        System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse> tblKhachHangsAsync(QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public QuanLiKhachHang.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(QuanLiKhachHang.ServiceReference1.HelloWorldRequestBody Body) {
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
        public QuanLiKhachHang.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(QuanLiKhachHang.ServiceReference1.HelloWorldResponseBody Body) {
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class tblKhachHangsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="tblKhachHangs", Namespace="http://tempuri.org/", Order=0)]
        public QuanLiKhachHang.ServiceReference1.tblKhachHangsRequestBody Body;
        
        public tblKhachHangsRequest() {
        }
        
        public tblKhachHangsRequest(QuanLiKhachHang.ServiceReference1.tblKhachHangsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class tblKhachHangsRequestBody {
        
        public tblKhachHangsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class tblKhachHangsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="tblKhachHangsResponse", Namespace="http://tempuri.org/", Order=0)]
        public QuanLiKhachHang.ServiceReference1.tblKhachHangsResponseBody Body;
        
        public tblKhachHangsResponse() {
        }
        
        public tblKhachHangsResponse(QuanLiKhachHang.ServiceReference1.tblKhachHangsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class tblKhachHangsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public QuanLiKhachHang.ServiceReference1.ArrayOfTblKhachHang tblKhachHangsResult;
        
        public tblKhachHangsResponseBody() {
        }
        
        public tblKhachHangsResponseBody(QuanLiKhachHang.ServiceReference1.ArrayOfTblKhachHang tblKhachHangsResult) {
            this.tblKhachHangsResult = tblKhachHangsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : QuanLiKhachHang.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<QuanLiKhachHang.ServiceReference1.WebService1Soap>, QuanLiKhachHang.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuanLiKhachHang.ServiceReference1.HelloWorldResponse QuanLiKhachHang.ServiceReference1.WebService1Soap.HelloWorld(QuanLiKhachHang.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            QuanLiKhachHang.ServiceReference1.HelloWorldRequest inValue = new QuanLiKhachHang.ServiceReference1.HelloWorldRequest();
            inValue.Body = new QuanLiKhachHang.ServiceReference1.HelloWorldRequestBody();
            QuanLiKhachHang.ServiceReference1.HelloWorldResponse retVal = ((QuanLiKhachHang.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.HelloWorldResponse> QuanLiKhachHang.ServiceReference1.WebService1Soap.HelloWorldAsync(QuanLiKhachHang.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            QuanLiKhachHang.ServiceReference1.HelloWorldRequest inValue = new QuanLiKhachHang.ServiceReference1.HelloWorldRequest();
            inValue.Body = new QuanLiKhachHang.ServiceReference1.HelloWorldRequestBody();
            return ((QuanLiKhachHang.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse QuanLiKhachHang.ServiceReference1.WebService1Soap.tblKhachHangs(QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest request) {
            return base.Channel.tblKhachHangs(request);
        }
        
        public QuanLiKhachHang.ServiceReference1.ArrayOfTblKhachHang tblKhachHangs() {
            QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest inValue = new QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest();
            inValue.Body = new QuanLiKhachHang.ServiceReference1.tblKhachHangsRequestBody();
            QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse retVal = ((QuanLiKhachHang.ServiceReference1.WebService1Soap)(this)).tblKhachHangs(inValue);
            return retVal.Body.tblKhachHangsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse> QuanLiKhachHang.ServiceReference1.WebService1Soap.tblKhachHangsAsync(QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest request) {
            return base.Channel.tblKhachHangsAsync(request);
        }
        
        public System.Threading.Tasks.Task<QuanLiKhachHang.ServiceReference1.tblKhachHangsResponse> tblKhachHangsAsync() {
            QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest inValue = new QuanLiKhachHang.ServiceReference1.tblKhachHangsRequest();
            inValue.Body = new QuanLiKhachHang.ServiceReference1.tblKhachHangsRequestBody();
            return ((QuanLiKhachHang.ServiceReference1.WebService1Soap)(this)).tblKhachHangsAsync(inValue);
        }
    }
}