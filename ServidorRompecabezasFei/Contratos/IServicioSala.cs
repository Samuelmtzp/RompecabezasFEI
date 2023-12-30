using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioSalaCallback))]
    public interface IServicioSala
    {
        [OperationContract]
        bool CrearNuevaSala(string nombreAnfitrion, string codigoSala);

        [OperationContract]
        bool UnirseASala(string nombreJugador, string codigoSala);

        [OperationContract]
        void ActivarNotificacionesDeSala(string nombreJugador);

        [OperationContract]
        void DesactivarNotificacionesDeSala(string nombreJugador);

        [OperationContract]
        void AbandonarSala(string nombreJugador, string codigoSala);

        [OperationContract]
        List<CuentaJugador> ObtenerJugadoresEnSala(string codigoSala);

        [OperationContract(IsOneWay = true)]
        void EnviarMensajeDeSala(string nombreJugador, string codigoSala, string mensaje);

        [OperationContract]
        string GenerarCodigoParaNuevaSala();
        
        [OperationContract]
        bool ExisteSalaDisponible(string codigoSala);

        [OperationContract]
        void ConvertirJugadorEnAnfitrionDesdeSala(string nombreJugador, string codigoSala);

        [OperationContract(IsOneWay = true)]
        void InvitarJugador(string nombreJugador, string nombreAnfitrion, string codigoSala);

        [OperationContract(IsOneWay = true)]
        void ExpulsarJugadorEnSala(string nombreJugadorExpulsion, string codigoSala);
    }

    [ServiceContract]
    public interface IServicioSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void MostrarNuevaPartida();

        [OperationContract(IsOneWay = true)]
        void MostrarMensajeDeSala(string mensaje);

        [OperationContract(IsOneWay = true)]
        void MostrarNuevoJugadorEnSala(CuentaJugador nuevoJugador);

        [OperationContract(IsOneWay = true)]
        void MostrarMensajeExpulsionDeSala();

        [OperationContract(IsOneWay = true)]
        void MostrarDesconexionDeJugadorEnSala(string nombreJugadorDesconexion);

        [OperationContract(IsOneWay = true)]
        void MostrarFuncionesDeAnfitrionEnSala();

        [OperationContract(IsOneWay = true)]
        void HabilitarInicioDePartida();

        [OperationContract(IsOneWay = true)]
        void DeshabilitarInicioDePartida();

        [OperationContract(IsOneWay = true)]
        void MostrarAmigoDisponible(CuentaJugador cuentaAmigo);

        [OperationContract(IsOneWay = true)]
        void OcultarAmigoNoDisponible(string nombreAmigo);
    }
}