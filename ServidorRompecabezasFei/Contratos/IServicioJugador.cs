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
    }
    
    [ServiceContract]
    public interface IServicioJugadorCallback
    {
        // El método ProbarConexionJugador no es utilizado explícitamente,
        // solamente se creó para definir una interfaz de callback para la
        // interfaz IServicioJugador, la cual notifica al jugador sobre
        // los eventos de cierre o fallo en el servidor en tiempo real
        [OperationContract(IsOneWay = true)]
        void ProbarConexionJugador();
    }
}