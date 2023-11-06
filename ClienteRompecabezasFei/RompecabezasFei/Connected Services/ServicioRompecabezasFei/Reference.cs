﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/EnviarMensajeCorreo", ReplyAction="http://tempuri.org/IServicioGestionJugador/EnviarMensajeCorreoResponse")]
        bool EnviarMensajeCorreo(string encabezado, string correoDestino, string asunto, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/EnviarMensajeCorreo", ReplyAction="http://tempuri.org/IServicioGestionJugador/EnviarMensajeCorreoResponse")]
        System.Threading.Tasks.Task<bool> EnviarMensajeCorreoAsync(string encabezado, string correoDestino, string asunto, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadasResponse")]
        int ObtenerNumeroPartidasJugadas(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasJugadasResponse")]
        System.Threading.Tasks.Task<int> ObtenerNumeroPartidasJugadasAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadasResponse")]
        int ObtenerNumeroPartidasGanadas(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadas", ReplyAction="http://tempuri.org/IServicioGestionJugador/ObtenerNumeroPartidasGanadasResponse")]
        System.Threading.Tasks.Task<int> ObtenerNumeroPartidasGanadasAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ActualizarInformacion", ReplyAction="http://tempuri.org/IServicioGestionJugador/ActualizarInformacionResponse")]
        bool ActualizarInformacion(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ActualizarInformacion", ReplyAction="http://tempuri.org/IServicioGestionJugador/ActualizarInformacionResponse")]
        System.Threading.Tasks.Task<bool> ActualizarInformacionAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ActualizarContrasena", ReplyAction="http://tempuri.org/IServicioGestionJugador/ActualizarContrasenaResponse")]
        bool ActualizarContrasena(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/ActualizarContrasena", ReplyAction="http://tempuri.org/IServicioGestionJugador/ActualizarContrasenaResponse")]
        System.Threading.Tasks.Task<bool> ActualizarContrasenaAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/RestablecerContrasena", ReplyAction="http://tempuri.org/IServicioGestionJugador/RestablecerContrasenaResponse")]
        bool RestablecerContrasena(string correo, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestionJugador/RestablecerContrasena", ReplyAction="http://tempuri.org/IServicioGestionJugador/RestablecerContrasenaResponse")]
        System.Threading.Tasks.Task<bool> RestablecerContrasenaAsync(string correo, string contrasena);
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
        
        public bool EnviarMensajeCorreo(string encabezado, string correoDestino, string asunto, string mensaje) {
            return base.Channel.EnviarMensajeCorreo(encabezado, correoDestino, asunto, mensaje);
        }
        
        public System.Threading.Tasks.Task<bool> EnviarMensajeCorreoAsync(string encabezado, string correoDestino, string asunto, string mensaje) {
            return base.Channel.EnviarMensajeCorreoAsync(encabezado, correoDestino, asunto, mensaje);
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
        
        public bool ActualizarInformacion(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.ActualizarInformacion(cuentaJugador);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarInformacionAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.ActualizarInformacionAsync(cuentaJugador);
        }
        
        public bool ActualizarContrasena(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.ActualizarContrasena(cuentaJugador);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarContrasenaAsync(RompecabezasFei.ServicioRompecabezasFei.CuentaJugador cuentaJugador) {
            return base.Channel.ActualizarContrasenaAsync(cuentaJugador);
        }
        
        public bool RestablecerContrasena(string correo, string contrasena) {
            return base.Channel.RestablecerContrasena(correo, contrasena);
        }
        
        public System.Threading.Tasks.Task<bool> RestablecerContrasenaAsync(string correo, string contrasena) {
            return base.Channel.RestablecerContrasenaAsync(correo, contrasena);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioRompecabezasFei.IServicioJuego", CallbackContract=typeof(RompecabezasFei.ServicioRompecabezasFei.IServicioJuegoCallback))]
    public interface IServicioJuego {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/NuevaSala", ReplyAction="http://tempuri.org/IServicioJuego/NuevaSalaResponse")]
        void NuevaSala(string nombreAnfitrion, string idSala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/NuevaSala", ReplyAction="http://tempuri.org/IServicioJuego/NuevaSalaResponse")]
        System.Threading.Tasks.Task NuevaSalaAsync(string nombreAnfitrion, string idSala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/ConectarCuentaJugadorASala", ReplyAction="http://tempuri.org/IServicioJuego/ConectarCuentaJugadorASalaResponse")]
        void ConectarCuentaJugadorASala(string nombreJugador, string idSala, string mensajeBienvenida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/ConectarCuentaJugadorASala", ReplyAction="http://tempuri.org/IServicioJuego/ConectarCuentaJugadorASalaResponse")]
        System.Threading.Tasks.Task ConectarCuentaJugadorASalaAsync(string nombreJugador, string idSala, string mensajeBienvenida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/DesconectarCuentaJugadorDeSala", ReplyAction="http://tempuri.org/IServicioJuego/DesconectarCuentaJugadorDeSalaResponse")]
        void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala, string mensajeDespedida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/DesconectarCuentaJugadorDeSala", ReplyAction="http://tempuri.org/IServicioJuego/DesconectarCuentaJugadorDeSalaResponse")]
        System.Threading.Tasks.Task DesconectarCuentaJugadorDeSalaAsync(string nombreJugador, string idSala, string mensajeDespedida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioJuego/EnviarMensajeDeSala")]
        void EnviarMensajeDeSala(string nombreJugador, string idSala, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioJuego/EnviarMensajeDeSala")]
        System.Threading.Tasks.Task EnviarMensajeDeSalaAsync(string nombreJugador, string idSala, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/GenerarCodigoParaNuevaSala", ReplyAction="http://tempuri.org/IServicioJuego/GenerarCodigoParaNuevaSalaResponse")]
        string GenerarCodigoParaNuevaSala();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/GenerarCodigoParaNuevaSala", ReplyAction="http://tempuri.org/IServicioJuego/GenerarCodigoParaNuevaSalaResponse")]
        System.Threading.Tasks.Task<string> GenerarCodigoParaNuevaSalaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/ExisteSalaDisponible", ReplyAction="http://tempuri.org/IServicioJuego/ExisteSalaDisponibleResponse")]
        bool ExisteSalaDisponible(string idSala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioJuego/ExisteSalaDisponible", ReplyAction="http://tempuri.org/IServicioJuego/ExisteSalaDisponibleResponse")]
        System.Threading.Tasks.Task<bool> ExisteSalaDisponibleAsync(string idSala);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioJuegoCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioJuego/MensajeDeSalaCallBack")]
        void MensajeDeSalaCallBack(string mensaje);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioJuegoChannel : RompecabezasFei.ServicioRompecabezasFei.IServicioJuego, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioJuegoClient : System.ServiceModel.DuplexClientBase<RompecabezasFei.ServicioRompecabezasFei.IServicioJuego>, RompecabezasFei.ServicioRompecabezasFei.IServicioJuego {
        
        public ServicioJuegoClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServicioJuegoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServicioJuegoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioJuegoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioJuegoClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void NuevaSala(string nombreAnfitrion, string idSala) {
            base.Channel.NuevaSala(nombreAnfitrion, idSala);
        }
        
        public System.Threading.Tasks.Task NuevaSalaAsync(string nombreAnfitrion, string idSala) {
            return base.Channel.NuevaSalaAsync(nombreAnfitrion, idSala);
        }
        
        public void ConectarCuentaJugadorASala(string nombreJugador, string idSala, string mensajeBienvenida) {
            base.Channel.ConectarCuentaJugadorASala(nombreJugador, idSala, mensajeBienvenida);
        }
        
        public System.Threading.Tasks.Task ConectarCuentaJugadorASalaAsync(string nombreJugador, string idSala, string mensajeBienvenida) {
            return base.Channel.ConectarCuentaJugadorASalaAsync(nombreJugador, idSala, mensajeBienvenida);
        }
        
        public void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala, string mensajeDespedida) {
            base.Channel.DesconectarCuentaJugadorDeSala(nombreJugador, idSala, mensajeDespedida);
        }
        
        public System.Threading.Tasks.Task DesconectarCuentaJugadorDeSalaAsync(string nombreJugador, string idSala, string mensajeDespedida) {
            return base.Channel.DesconectarCuentaJugadorDeSalaAsync(nombreJugador, idSala, mensajeDespedida);
        }
        
        public void EnviarMensajeDeSala(string nombreJugador, string idSala, string mensaje) {
            base.Channel.EnviarMensajeDeSala(nombreJugador, idSala, mensaje);
        }
        
        public System.Threading.Tasks.Task EnviarMensajeDeSalaAsync(string nombreJugador, string idSala, string mensaje) {
            return base.Channel.EnviarMensajeDeSalaAsync(nombreJugador, idSala, mensaje);
        }
        
        public string GenerarCodigoParaNuevaSala() {
            return base.Channel.GenerarCodigoParaNuevaSala();
        }
        
        public System.Threading.Tasks.Task<string> GenerarCodigoParaNuevaSalaAsync() {
            return base.Channel.GenerarCodigoParaNuevaSalaAsync();
        }
        
        public bool ExisteSalaDisponible(string idSala) {
            return base.Channel.ExisteSalaDisponible(idSala);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteSalaDisponibleAsync(string idSala) {
            return base.Channel.ExisteSalaDisponibleAsync(idSala);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioRompecabezasFei.IServicioAmistades")]
    public interface IServicioAmistades {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/EnviarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/EnviarSolicitudDeAmistadResponse")]
        bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/EnviarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/EnviarSolicitudDeAmistadResponse")]
        System.Threading.Tasks.Task<bool> EnviarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ObtenerJugadoresConSolicitudDeAmistadSinAce" +
            "ptar", ReplyAction="http://tempuri.org/IServicioAmistades/ObtenerJugadoresConSolicitudDeAmistadSinAce" +
            "ptarResponse")]
        RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[] ObtenerJugadoresConSolicitudDeAmistadSinAceptar(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ObtenerJugadoresConSolicitudDeAmistadSinAce" +
            "ptar", ReplyAction="http://tempuri.org/IServicioAmistades/ObtenerJugadoresConSolicitudDeAmistadSinAce" +
            "ptarResponse")]
        System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[]> ObtenerJugadoresConSolicitudDeAmistadSinAceptarAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ObtenerAmigosDeJugador", ReplyAction="http://tempuri.org/IServicioAmistades/ObtenerAmigosDeJugadorResponse")]
        RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[] ObtenerAmigosDeJugador(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ObtenerAmigosDeJugador", ReplyAction="http://tempuri.org/IServicioAmistades/ObtenerAmigosDeJugadorResponse")]
        System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[]> ObtenerAmigosDeJugadorAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/AceptarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/AceptarSolicitudDeAmistadResponse")]
        bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/AceptarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/AceptarSolicitudDeAmistadResponse")]
        System.Threading.Tasks.Task<bool> AceptarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/RechazarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/RechazarSolicitudDeAmistadResponse")]
        bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/RechazarSolicitudDeAmistad", ReplyAction="http://tempuri.org/IServicioAmistades/RechazarSolicitudDeAmistadResponse")]
        System.Threading.Tasks.Task<bool> RechazarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ExisteSolicitudDeAmistadSinAceptar", ReplyAction="http://tempuri.org/IServicioAmistades/ExisteSolicitudDeAmistadSinAceptarResponse")]
        bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ExisteSolicitudDeAmistadSinAceptar", ReplyAction="http://tempuri.org/IServicioAmistades/ExisteSolicitudDeAmistadSinAceptarResponse")]
        System.Threading.Tasks.Task<bool> ExisteSolicitudDeAmistadSinAceptarAsync(string nombreJugadorOrigen, string nombreJugadorDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ExisteAmistadConJugador", ReplyAction="http://tempuri.org/IServicioAmistades/ExisteAmistadConJugadorResponse")]
        bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/ExisteAmistadConJugador", ReplyAction="http://tempuri.org/IServicioAmistades/ExisteAmistadConJugadorResponse")]
        System.Threading.Tasks.Task<bool> ExisteAmistadConJugadorAsync(string nombreJugador1, string nombreJugador2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/RegistrarNuevaAmistadEntreJugadores", ReplyAction="http://tempuri.org/IServicioAmistades/RegistrarNuevaAmistadEntreJugadoresResponse" +
            "")]
        bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, string nombreJugador2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/RegistrarNuevaAmistadEntreJugadores", ReplyAction="http://tempuri.org/IServicioAmistades/RegistrarNuevaAmistadEntreJugadoresResponse" +
            "")]
        System.Threading.Tasks.Task<bool> RegistrarNuevaAmistadEntreJugadoresAsync(string nombreJugador1, string nombreJugador2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/EliminarAmistadEntreJugadores", ReplyAction="http://tempuri.org/IServicioAmistades/EliminarAmistadEntreJugadoresResponse")]
        bool EliminarAmistadEntreJugadores(string nombreJugador1, string nombreJugador2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAmistades/EliminarAmistadEntreJugadores", ReplyAction="http://tempuri.org/IServicioAmistades/EliminarAmistadEntreJugadoresResponse")]
        System.Threading.Tasks.Task<bool> EliminarAmistadEntreJugadoresAsync(string nombreJugador1, string nombreJugador2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioAmistadesChannel : RompecabezasFei.ServicioRompecabezasFei.IServicioAmistades, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioAmistadesClient : System.ServiceModel.ClientBase<RompecabezasFei.ServicioRompecabezasFei.IServicioAmistades>, RompecabezasFei.ServicioRompecabezasFei.IServicioAmistades {
        
        public ServicioAmistadesClient() {
        }
        
        public ServicioAmistadesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioAmistadesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioAmistadesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioAmistadesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.EnviarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public System.Threading.Tasks.Task<bool> EnviarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.EnviarSolicitudDeAmistadAsync(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[] ObtenerJugadoresConSolicitudDeAmistadSinAceptar(string nombreJugador) {
            return base.Channel.ObtenerJugadoresConSolicitudDeAmistadSinAceptar(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[]> ObtenerJugadoresConSolicitudDeAmistadSinAceptarAsync(string nombreJugador) {
            return base.Channel.ObtenerJugadoresConSolicitudDeAmistadSinAceptarAsync(nombreJugador);
        }
        
        public RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[] ObtenerAmigosDeJugador(string nombreJugador) {
            return base.Channel.ObtenerAmigosDeJugador(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<RompecabezasFei.ServicioRompecabezasFei.CuentaJugador[]> ObtenerAmigosDeJugadorAsync(string nombreJugador) {
            return base.Channel.ObtenerAmigosDeJugadorAsync(nombreJugador);
        }
        
        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.AceptarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public System.Threading.Tasks.Task<bool> AceptarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.AceptarSolicitudDeAmistadAsync(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.RechazarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public System.Threading.Tasks.Task<bool> RechazarSolicitudDeAmistadAsync(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.RechazarSolicitudDeAmistadAsync(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.ExisteSolicitudDeAmistadSinAceptar(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteSolicitudDeAmistadSinAceptarAsync(string nombreJugadorOrigen, string nombreJugadorDestino) {
            return base.Channel.ExisteSolicitudDeAmistadSinAceptarAsync(nombreJugadorOrigen, nombreJugadorDestino);
        }
        
        public bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2) {
            return base.Channel.ExisteAmistadConJugador(nombreJugador1, nombreJugador2);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteAmistadConJugadorAsync(string nombreJugador1, string nombreJugador2) {
            return base.Channel.ExisteAmistadConJugadorAsync(nombreJugador1, nombreJugador2);
        }
        
        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, string nombreJugador2) {
            return base.Channel.RegistrarNuevaAmistadEntreJugadores(nombreJugador1, nombreJugador2);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarNuevaAmistadEntreJugadoresAsync(string nombreJugador1, string nombreJugador2) {
            return base.Channel.RegistrarNuevaAmistadEntreJugadoresAsync(nombreJugador1, nombreJugador2);
        }
        
        public bool EliminarAmistadEntreJugadores(string nombreJugador1, string nombreJugador2) {
            return base.Channel.EliminarAmistadEntreJugadores(nombreJugador1, nombreJugador2);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAmistadEntreJugadoresAsync(string nombreJugador1, string nombreJugador2) {
            return base.Channel.EliminarAmistadEntreJugadoresAsync(nombreJugador1, nombreJugador2);
        }
    }
}
