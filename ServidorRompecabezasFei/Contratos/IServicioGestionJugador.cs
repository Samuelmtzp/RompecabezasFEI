using System;
using System.ServiceModel;
using Logica;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioGestionJugador
    {

        [OperationContract]
        bool Registrar(CuentaJugador cuentaJugador);
        [OperationContract]
        bool ExisteCorreoElectronico(string correoElectronico);
        [OperationContract]
        bool ExisteNombreJugador(string nombreJugador);
        [OperationContract]
        CuentaJugador IniciarSesion(string nombreJugador, string contrasena);
        [OperationContract]
        bool EnviarMensajeCorreo(string encabezado, string correoDestino, 
            string asunto, string mensaje);
        [OperationContract]
        int ObtenerNumeroPartidasJugadas(string nombreUsuario);
        [OperationContract]
        int ObtenerNumeroPartidasGanadas(string nombreUsuario);
    }
}
