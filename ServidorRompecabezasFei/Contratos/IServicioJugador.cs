using System.ServiceModel;
using Logica;
using Logica.Enumeraciones;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioJugadorCallback))]
    public interface IServicioJugador
    {
        [OperationContract]
        bool RegistrarJugador(CuentaJugador cuentaJugador);
        
        [OperationContract]
        CuentaJugador IniciarSesionComoJugador(string nombreJugador, string contrasena);

        [OperationContract]
        CuentaJugador IniciarSesionComoInvitado(string nombreInvitado);

        [OperationContract(IsOneWay = true)]
        void CerrarSesion(string nombreJugador);

        [OperationContract]
        bool ActualizarNombreJugador(string nombreAnterior, string nuevoNombre);
        
        [OperationContract]        
        bool ActualizarNumeroAvatar(string nombreJugador, int nuevoNumeroAvatar);

        [OperationContract]
        bool ActualizarContrasena(string correo, string contrasena);

        [OperationContract]
        bool EsLaMismaContrasenaDeJugador(string nombreJugador, string contrasena);

        [OperationContract]
        bool ExisteNombreJugadorRegistrado(string nombreJugador);

        [OperationContract]
        void CambiarEstadoJugador(string nombreJugador, EstadoJugador estado);

        [OperationContract(IsOneWay = true)]
        void ProbarConexionServidor();
    }

    [ServiceContract]
    public interface IServicioJugadorCallback
    {
        [OperationContract(IsOneWay = true)]
        void ProbarConexionJugador();
    }
}