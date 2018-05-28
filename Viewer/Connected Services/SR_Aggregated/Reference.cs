﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viewer.SR_Aggregated {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AggregatedPerson", Namespace="http://schemas.datacontract.org/2004/07/Shared")]
    [System.SerializableAttribute()]
    public partial class AggregatedPerson : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GivennameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsStudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ZipField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Givenname {
            get {
                return this.GivennameField;
            }
            set {
                if ((object.ReferenceEquals(this.GivennameField, value) != true)) {
                    this.GivennameField = value;
                    this.RaisePropertyChanged("Givenname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsStudent {
            get {
                return this.IsStudentField;
            }
            set {
                if ((this.IsStudentField.Equals(value) != true)) {
                    this.IsStudentField = value;
                    this.RaisePropertyChanged("IsStudent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((this.ZipField.Equals(value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Aggregated.IServiceAggregated")]
    public interface IServiceAggregated {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAggregated/GetAggregatedPersonData", ReplyAction="http://tempuri.org/IServiceAggregated/GetAggregatedPersonDataResponse")]
        Viewer.SR_Aggregated.AggregatedPerson[] GetAggregatedPersonData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAggregated/GetAggregatedPersonData", ReplyAction="http://tempuri.org/IServiceAggregated/GetAggregatedPersonDataResponse")]
        System.Threading.Tasks.Task<Viewer.SR_Aggregated.AggregatedPerson[]> GetAggregatedPersonDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAggregatedChannel : Viewer.SR_Aggregated.IServiceAggregated, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAggregatedClient : System.ServiceModel.ClientBase<Viewer.SR_Aggregated.IServiceAggregated>, Viewer.SR_Aggregated.IServiceAggregated {
        
        public ServiceAggregatedClient() {
        }
        
        public ServiceAggregatedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAggregatedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAggregatedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAggregatedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Viewer.SR_Aggregated.AggregatedPerson[] GetAggregatedPersonData() {
            return base.Channel.GetAggregatedPersonData();
        }
        
        public System.Threading.Tasks.Task<Viewer.SR_Aggregated.AggregatedPerson[]> GetAggregatedPersonDataAsync() {
            return base.Channel.GetAggregatedPersonDataAsync();
        }
    }
}
