﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RompecabezasFei.ServicioGestionJugador {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/Datos")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RompecabezasFei.ServicioGestionJugador.Jugador JugadorField;
        
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
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RompecabezasFei.ServicioGestionJugador.Jugador Jugador {
            get {
                return this.JugadorField;
            }
            set {
                if ((object.ReferenceEquals(this.JugadorField, value) != true)) {
                    this.JugadorField = value;
                    this.RaisePropertyChanged("Jugador");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Jugador", Namespace="http://schemas.datacontract.org/2004/07/Datos")]
    [System.SerializableAttribute()]
    public partial class Jugador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short NumeroAvatarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RompecabezasFei.ServicioGestionJugador.Usuario UsuarioField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RompecabezasFei.ServicioGestionJugador.Usuario Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioGestionJugador.IServicioGestionJugador")]
    public interface IServicioGestionJugador {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/Registrar", ReplyAction="http://tempuri.org/IServicioGestionJugador/RegistrarResponse")]
        bool Registrar(RompecabezasFei.ServicioGestionJugador.Usuario usuario, RompecabezasFei.ServicioGestionJugador.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/Registrar", ReplyAction="http://tempuri.org/IServicioGestionJugador/RegistrarResponse")]
        System.Threading.Tasks.Task<bool> RegistrarAsync(RompecabezasFei.ServicioGestionJugador.Usuario usuario, RompecabezasFei.ServicioGestionJugador.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronico", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronicoResponse")]
        bool ExisteCorreoElectronico(string correoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronico", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteCorreoElectronicoResponse")]
        System.Threading.Tasks.Task<bool> ExisteCorreoElectronicoAsync(string correoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteNombreUsuario", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteNombreUsuarioResponse")]
        bool ExisteNombreUsuario(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ExisteNombreUsuario", ReplyAction="http://tempuri.org/IServicioGestionJugador/ExisteNombreUsuarioResponse")]
        System.Threading.Tasks.Task<bool> ExisteNombreUsuarioAsync(string nombreUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioGestionJugadorChannel : RompecabezasFei.ServicioGestionJugador.IServicioGestionJugador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioGestionJugadorClient : System.ServiceModel.ClientBase<RompecabezasFei.ServicioGestionJugador.IServicioGestionJugador>, RompecabezasFei.ServicioGestionJugador.IServicioGestionJugador {
        
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
        
        public bool Registrar(RompecabezasFei.ServicioGestionJugador.Usuario usuario, RompecabezasFei.ServicioGestionJugador.Jugador jugador) {
            return base.Channel.Registrar(usuario, jugador);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarAsync(RompecabezasFei.ServicioGestionJugador.Usuario usuario, RompecabezasFei.ServicioGestionJugador.Jugador jugador) {
            return base.Channel.RegistrarAsync(usuario, jugador);
        }
        
        public bool ExisteCorreoElectronico(string correoElectronico) {
            return base.Channel.ExisteCorreoElectronico(correoElectronico);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteCorreoElectronicoAsync(string correoElectronico) {
            return base.Channel.ExisteCorreoElectronicoAsync(correoElectronico);
        }
        
        public bool ExisteNombreUsuario(string nombreUsuario) {
            return base.Channel.ExisteNombreUsuario(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteNombreUsuarioAsync(string nombreUsuario) {
            return base.Channel.ExisteNombreUsuarioAsync(nombreUsuario);
        }
    }
}
