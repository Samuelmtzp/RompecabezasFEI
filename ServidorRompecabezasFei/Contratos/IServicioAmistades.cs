using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioAmistades
    {
        [OperationContract]
        bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        List<CuentaJugador> ObtenerJugadoresConSolicitudDeAmistadSinAceptar(string nombreJugador);

        [OperationContract]
        List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador);

        [OperationContract]
        bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, 
            string nombreJugadorDestino);

        [OperationContract]
        bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2);

        [OperationContract]
        bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, string nombreJugador2);

        [OperationContract]
        bool EliminarAmistadEntreJugadores(string nombreJugador1, string nombreJugador2);
    }
}
