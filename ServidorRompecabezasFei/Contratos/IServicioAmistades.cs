using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioAmistadesCallback))]
    public interface IServicioAmistades
    {
        [OperationContract]
        List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(string nombreJugador);

        [OperationContract]
        List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador);

        [OperationContract]
        bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino);

        [OperationContract]
        bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB);

        [OperationContract]
        bool EliminarAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB);

        [OperationContract(IsOneWay = true)]
        void SuscribirJugadorANotificacionesDeAmistades(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesuscribirJugadorDeNotificacionesDeAmistades(string nombreJugador);
    }

    [ServiceContract]
    public interface IServicioAmistadesCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarSolicitudAmistadEnviada(CuentaJugador cuentaNuevaSolicitud);

        [OperationContract(IsOneWay = true)]
        void NotificarSolicitudAmistadAceptada(CuentaJugador cuentaNuevoAmigo);

        [OperationContract(IsOneWay = true)]
        void NotificarAmistadEliminada(string nombreAmigoEliminacion);

        [OperationContract(IsOneWay = true)]
        void NotificarEstadoConectividadDeJugador(string nombreJugador,
            ConectividadJugador estado);
    }
}