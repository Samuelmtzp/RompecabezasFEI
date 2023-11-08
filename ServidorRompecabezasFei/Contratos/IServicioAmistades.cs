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
        bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB);

        [OperationContract]
        bool RegistrarNuevaAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB);

        [OperationContract]
        bool EliminarAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB);
    }
}
