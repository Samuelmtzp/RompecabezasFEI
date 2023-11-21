using System.ServiceModel;
using Logica;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioJugador
    {
        [OperationContract]
        bool Registrar(CuentaJugador cuentaJugador);
        
        [OperationContract]
        bool ExisteNombreJugador(string nombreJugador);
        
        [OperationContract]
        CuentaJugador IniciarSesion(string nombreJugador, string contrasena);

        [OperationContract]
        bool CerrarSesion(string nombreJugador);               
        
        [OperationContract]
        bool ActualizarInformacion(string nombreAnterior, string nuevoNombre, 
            int nuevoNumeroAvatar);
        
        [OperationContract]
        bool ActualizarContrasena(string correo, string contrasena);
    }
}