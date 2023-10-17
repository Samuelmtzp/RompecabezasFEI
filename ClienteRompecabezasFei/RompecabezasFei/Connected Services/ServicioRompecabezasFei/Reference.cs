﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RompecabezasFei.ServicioRompecabezasFei {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CuentaJugador", Namespace="http://schemas.datacontract.org/2004/07/Logica")]
    [System.SerializableAttribute()]
    public partial class CuentaJugador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short NumeroAvatarField;
        
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
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCuenta {
            get {
                return this.IdCuentaField;
            }
            set {
                if ((this.IdCuentaField.Equals(value) != true)) {
                    this.IdCuentaField = value;
                    this.RaisePropertyChanged("IdCuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdJugador {
            get {
                return this.IdJugadorField;
            }
            set {
                if ((this.IdJugadorField.Equals(value) != true)) {
                    this.IdJugadorField = value;
                    this.RaisePropertyChanged("IdJugador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreJugador {
            get {
                return this.NombreJugadorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreJugadorField, value) != true)) {
                    this.NombreJugadorField = value;
                    this.RaisePropertyChanged("NombreJugador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short NumeroAvatar {
            get {
                return this.NumeroAvatarField;
            }
            set {
                if ((this.NumeroAvatarField.Equals(value) != true)) {
                    this.NumeroAvatarField = value;
                    this.RaisePropertyChanged("NumeroAvatar");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioRompecabezasFei.IServicioGestionJugador")]
    public interface IServicioGestionJugador {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/Registrar", ReplyAction="http://tempuri.org/IServicioGestionJugador/RegistrarResponse")]
        bool Registrar(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/Registrar", ReplyAction="http://tempuri.org/IServicioGestionJugador/RegistrarResponse")]
        System.Threading.Tasks.Task<bool> RegistrarAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronico", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronicoResponse")]
        bool ExisteCorreoElectronico(string correoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronico", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronicoResponse")]
        System.Threading.Tasks.Task<bool> ExisteCorreoElectronicoAsync(string correoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteNombreJugador", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteNombreJugadorResponse")]
        bool ExisteNombreJugador(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteNombreJugador", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteNombreJugadorResponse")]
        System.Threading.Tasks.Task<bool> ExisteNombreJugadorAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/IniciarSesion", ReplyAction="http://tempuri.org/IServicioGestionJugador/IniciarSesionResponse")]
        RompecabezasFei.ServicioRompecabezasFei.CuentaJugador IniciarSesion(string nombreJugador, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/IniciarSesion", ReplyAction="http://tempuri.org/IServicioGestionJugador/IniciarSesionResponse")]
        System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador> IniciarSesionAsync(string nombreJugador, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/EnviarValidacionCorreo", ReplyAction="http://tempuri.org/IServicioGestionJugador/EnviarValidacionCorreoResponse")]
        bool EnviarValidacionCorreo(string correoDestino, string asunto, int codigoVerificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/EnviarValidacionCorreo", ReplyAction="http://tempuri.org/IServicioGestionJugador/EnviarValidacionCorreoResponse")]
        System.Threading.Tasks.Task<bool> EnviarValidacionCorreoAsync(string correoDestino, string asunto, int codigoVerificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadasResponse")]
        int ObtenerNumeroPartidasJugadas(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadasResponse")]
        System.Threading.Tasks.Task<int> ObtenerNumeroPartidasJugadasAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadasResponse")]
        int ObtenerNumeroPartidasGanadas(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadasResponse")]
        System.Threading.Tasks.Task<int> ObtenerNumeroPartidasGanadasAsync(string nombreUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioGestionJugadorChannel : RompecabezasFei.ServicioRompecabezasFei.IServicioGestionJugador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioGestionJugadorClient : System.ServiceModel.ClientBase<RompecabezasFei.ServicioRompecabezasFei.IServicioGestionJugador>, RompecabezasFei.ServicioRompecabezasFei.IServicioGestionJugador {
        
        public ServicioGestionJugadorClient() {
        }
        
        public ServicioGestionJugadorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioGestionJugadorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGestionJugadorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGestionJugadorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Registrar(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.Registrar(cuentaJugador);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.RegistrarAsync(cuentaJugador);
        }
        
        public bool ExisteCorreoElectronico(string correoElectronico) {
            return base.Channel.ExisteCorreoElectronico(correoElectronico);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteCorreoElectronicoAsync(string correoElectronico) {
            return base.Channel.ExisteCorreoElectronicoAsync(correoElectronico);
        }
        
        public bool ExisteNombreJugador(string nombreJugador) {
            return base.Channel.ExisteNombreJugador(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteNombreJugadorAsync(string nombreJugador) {
            return base.Channel.ExisteNombreJugadorAsync(nombreJugador);
        }
        
        public RompecabezasFei.ServicioRompecabezasFei.CuentaJugador IniciarSesion(string nombreJugador, string contrasena) {
            return base.Channel.IniciarSesion(nombreJugador, contrasena);
        }
        
        public System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador> IniciarSesionAsync(string nombreJugador, string contrasena) {
            return base.Channel.IniciarSesionAsync(nombreJugador, contrasena);
        }
        
        public bool EnviarValidacionCorreo(string correoDestino, string asunto, int codigoVerificacion) {
            return base.Channel.EnviarValidacionCorreo(correoDestino, asunto, codigoVerificacion);
        }
        
        public System.Threading.Tasks.Task<bool> EnviarValidacionCorreoAsync(string correoDestino, string asunto, int codigoVerificacion) {
            return base.Channel.EnviarValidacionCorreoAsync(correoDestino, asunto, codigoVerificacion);
        }
        
        public int ObtenerNumeroPartidasJugadas(string nombreUsuario) {
            return base.Channel.ObtenerNumeroPartidasJugadas(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<int> ObtenerNumeroPartidasJugadasAsync(string nombreUsuario) {
            return base.Channel.ObtenerNumeroPartidasJugadasAsync(nombreUsuario);
        }
        
        public int ObtenerNumeroPartidasGanadas(string nombreUsuario) {
            return base.Channel.ObtenerNumeroPartidasGanadas(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<int> ObtenerNumeroPartidasGanadasAsync(string nombreUsuario) {
            return base.Channel.ObtenerNumeroPartidasGanadasAsync(nombreUsuario);
        }
    }
}
