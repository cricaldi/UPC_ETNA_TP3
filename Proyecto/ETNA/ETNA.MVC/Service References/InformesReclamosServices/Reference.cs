﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETNA.MVC.InformesReclamosServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformeReclamoDto", Namespace="http://schemas.datacontract.org/2004/07/ETNA.DTOs.PV")]
    [System.SerializableAttribute()]
    public partial class InformeReclamoDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AprobadoPorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoInformeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoReclamoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionEstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetalleInformeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ElaboradoPorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaAprobacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaElaboracionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaHoraReclamoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InformeReclamoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreAprobadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreElaboradorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacionAprobadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReclamoIdField;
        
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
        public System.Nullable<int> AprobadoPorId {
            get {
                return this.AprobadoPorIdField;
            }
            set {
                if ((this.AprobadoPorIdField.Equals(value) != true)) {
                    this.AprobadoPorIdField = value;
                    this.RaisePropertyChanged("AprobadoPorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoInforme {
            get {
                return this.CodigoInformeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoInformeField, value) != true)) {
                    this.CodigoInformeField = value;
                    this.RaisePropertyChanged("CodigoInforme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoReclamo {
            get {
                return this.CodigoReclamoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoReclamoField, value) != true)) {
                    this.CodigoReclamoField = value;
                    this.RaisePropertyChanged("CodigoReclamo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionEstado {
            get {
                return this.DescripcionEstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionEstadoField, value) != true)) {
                    this.DescripcionEstadoField = value;
                    this.RaisePropertyChanged("DescripcionEstado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DetalleInforme {
            get {
                return this.DetalleInformeField;
            }
            set {
                if ((object.ReferenceEquals(this.DetalleInformeField, value) != true)) {
                    this.DetalleInformeField = value;
                    this.RaisePropertyChanged("DetalleInforme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ElaboradoPorId {
            get {
                return this.ElaboradoPorIdField;
            }
            set {
                if ((this.ElaboradoPorIdField.Equals(value) != true)) {
                    this.ElaboradoPorIdField = value;
                    this.RaisePropertyChanged("ElaboradoPorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaAprobacion {
            get {
                return this.FechaAprobacionField;
            }
            set {
                if ((this.FechaAprobacionField.Equals(value) != true)) {
                    this.FechaAprobacionField = value;
                    this.RaisePropertyChanged("FechaAprobacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaElaboracion {
            get {
                return this.FechaElaboracionField;
            }
            set {
                if ((this.FechaElaboracionField.Equals(value) != true)) {
                    this.FechaElaboracionField = value;
                    this.RaisePropertyChanged("FechaElaboracion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraReclamo {
            get {
                return this.FechaHoraReclamoField;
            }
            set {
                if ((this.FechaHoraReclamoField.Equals(value) != true)) {
                    this.FechaHoraReclamoField = value;
                    this.RaisePropertyChanged("FechaHoraReclamo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InformeReclamoId {
            get {
                return this.InformeReclamoIdField;
            }
            set {
                if ((this.InformeReclamoIdField.Equals(value) != true)) {
                    this.InformeReclamoIdField = value;
                    this.RaisePropertyChanged("InformeReclamoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreAprobador {
            get {
                return this.NombreAprobadorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreAprobadorField, value) != true)) {
                    this.NombreAprobadorField = value;
                    this.RaisePropertyChanged("NombreAprobador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCliente {
            get {
                return this.NombreClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreClienteField, value) != true)) {
                    this.NombreClienteField = value;
                    this.RaisePropertyChanged("NombreCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreElaborador {
            get {
                return this.NombreElaboradorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreElaboradorField, value) != true)) {
                    this.NombreElaboradorField = value;
                    this.RaisePropertyChanged("NombreElaborador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ObservacionAprobador {
            get {
                return this.ObservacionAprobadorField;
            }
            set {
                if ((object.ReferenceEquals(this.ObservacionAprobadorField, value) != true)) {
                    this.ObservacionAprobadorField = value;
                    this.RaisePropertyChanged("ObservacionAprobador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReclamoId {
            get {
                return this.ReclamoIdField;
            }
            set {
                if ((this.ReclamoIdField.Equals(value) != true)) {
                    this.ReclamoIdField = value;
                    this.RaisePropertyChanged("ReclamoId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InformesReclamosServices.IInformesReclamos")]
    public interface IInformesReclamos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/InsertarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/InsertarInformeReclamoResponse")]
        int InsertarInformeReclamo(string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int IdUsuario, int aprobadoPorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/InsertarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/InsertarInformeReclamoResponse")]
        System.Threading.Tasks.Task<int> InsertarInformeReclamoAsync(string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int IdUsuario, int aprobadoPorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/EditarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/EditarInformeReclamoResponse")]
        bool EditarInformeReclamo(int idInforme, string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/EditarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/EditarInformeReclamoResponse")]
        System.Threading.Tasks.Task<bool> EditarInformeReclamoAsync(int idInforme, string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ListaInfomesReclamos", ReplyAction="http://tempuri.org/IInformesReclamos/ListaInfomesReclamosResponse")]
        ETNA.MVC.InformesReclamosServices.InformeReclamoDto[] ListaInfomesReclamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ListaInfomesReclamos", ReplyAction="http://tempuri.org/IInformesReclamos/ListaInfomesReclamosResponse")]
        System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto[]> ListaInfomesReclamosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ListaInformesReclamosPendientes", ReplyAction="http://tempuri.org/IInformesReclamos/ListaInformesReclamosPendientesResponse")]
        ETNA.MVC.InformesReclamosServices.InformeReclamoDto[] ListaInformesReclamosPendientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ListaInformesReclamosPendientes", ReplyAction="http://tempuri.org/IInformesReclamos/ListaInformesReclamosPendientesResponse")]
        System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto[]> ListaInformesReclamosPendientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/AprobarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/AprobarInformeReclamoResponse")]
        bool AprobarInformeReclamo(int idInforme, System.DateTime fechaAprobacion, string observacionAprobador, string estado, int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/AprobarInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/AprobarInformeReclamoResponse")]
        System.Threading.Tasks.Task<bool> AprobarInformeReclamoAsync(int idInforme, System.DateTime fechaAprobacion, string observacionAprobador, string estado, int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ObtenerInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/ObtenerInformeReclamoResponse")]
        ETNA.MVC.InformesReclamosServices.InformeReclamoDto ObtenerInformeReclamo(int idInforme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformesReclamos/ObtenerInformeReclamo", ReplyAction="http://tempuri.org/IInformesReclamos/ObtenerInformeReclamoResponse")]
        System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto> ObtenerInformeReclamoAsync(int idInforme);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInformesReclamosChannel : ETNA.MVC.InformesReclamosServices.IInformesReclamos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InformesReclamosClient : System.ServiceModel.ClientBase<ETNA.MVC.InformesReclamosServices.IInformesReclamos>, ETNA.MVC.InformesReclamosServices.IInformesReclamos {
        
        public InformesReclamosClient() {
        }
        
        public InformesReclamosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InformesReclamosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformesReclamosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformesReclamosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int InsertarInformeReclamo(string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int IdUsuario, int aprobadoPorId) {
            return base.Channel.InsertarInformeReclamo(codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, IdUsuario, aprobadoPorId);
        }
        
        public System.Threading.Tasks.Task<int> InsertarInformeReclamoAsync(string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int IdUsuario, int aprobadoPorId) {
            return base.Channel.InsertarInformeReclamoAsync(codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, IdUsuario, aprobadoPorId);
        }
        
        public bool EditarInformeReclamo(int idInforme, string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId) {
            return base.Channel.EditarInformeReclamo(idInforme, codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, elboradoPorId, aprobadoPorId);
        }
        
        public System.Threading.Tasks.Task<bool> EditarInformeReclamoAsync(int idInforme, string codigoInforme, string descripcion, string detalleInforme, System.DateTime fechaAprobacion, System.DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId) {
            return base.Channel.EditarInformeReclamoAsync(idInforme, codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, elboradoPorId, aprobadoPorId);
        }
        
        public ETNA.MVC.InformesReclamosServices.InformeReclamoDto[] ListaInfomesReclamos() {
            return base.Channel.ListaInfomesReclamos();
        }
        
        public System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto[]> ListaInfomesReclamosAsync() {
            return base.Channel.ListaInfomesReclamosAsync();
        }
        
        public ETNA.MVC.InformesReclamosServices.InformeReclamoDto[] ListaInformesReclamosPendientes() {
            return base.Channel.ListaInformesReclamosPendientes();
        }
        
        public System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto[]> ListaInformesReclamosPendientesAsync() {
            return base.Channel.ListaInformesReclamosPendientesAsync();
        }
        
        public bool AprobarInformeReclamo(int idInforme, System.DateTime fechaAprobacion, string observacionAprobador, string estado, int idUsuario) {
            return base.Channel.AprobarInformeReclamo(idInforme, fechaAprobacion, observacionAprobador, estado, idUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> AprobarInformeReclamoAsync(int idInforme, System.DateTime fechaAprobacion, string observacionAprobador, string estado, int idUsuario) {
            return base.Channel.AprobarInformeReclamoAsync(idInforme, fechaAprobacion, observacionAprobador, estado, idUsuario);
        }
        
        public ETNA.MVC.InformesReclamosServices.InformeReclamoDto ObtenerInformeReclamo(int idInforme) {
            return base.Channel.ObtenerInformeReclamo(idInforme);
        }
        
        public System.Threading.Tasks.Task<ETNA.MVC.InformesReclamosServices.InformeReclamoDto> ObtenerInformeReclamoAsync(int idInforme) {
            return base.Channel.ObtenerInformeReclamoAsync(idInforme);
        }
    }
}
