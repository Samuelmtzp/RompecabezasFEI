using Logica.Enumeraciones;
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
        bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino);

        [OperationContract]
        bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB);

        [OperationContract]
        bool EliminarAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB);

        [OperationContract(IsOneWay = true)]
        void ActivarNotificacionesDeAmistades(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesactivarNotificacionesDeAmistades(string nombreJugador);
    }

    [ServiceContract]
    public interface IServicioAmistadesCallback
    {
        [OperationContract(IsOneWay = true)]
        void MostrarSolicitudDeAmistadRecibida(CuentaJugador cuentaNuevaSolicitud);

        [OperationContract(IsOneWay = true)]
        void MostrarNuevoAmigo(CuentaJugador cuentaNuevoAmigo);

        [OperationContract(IsOneWay = true)]
        void RemoverAmigoConAmistadCancelada(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void ActualizarEstadoDeJugador(string nombreJugador,
            EstadoJugador estado);
    }
}