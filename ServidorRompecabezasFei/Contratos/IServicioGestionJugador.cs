using System;
using System.ServiceModel;
using Logica;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioGestionJugador
    {

        [OperationContract]
        bool Registrar(Logica.Jugador jugador);
        [OperationContract]
        bool ExisteCorreoElectronico(string correoElectronico);
        [OperationContract]
        bool ExisteNombreUsuario(string nombreUsuario);
        [OperationContract]
        Logica.Jugador IniciarSesion(string nombreUsuario, string contrasena);

        [OperationContract]
        bool EnviarValidacionCorreo(String toEmail, String affair, int codigoVerificacion);

    }
}
