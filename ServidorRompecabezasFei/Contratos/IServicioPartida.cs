using Datos;
using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioPartidaCallback))]
    public interface IServicioPartida
    {
        [OperationContract]
        bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad, 
            int numeroImagen);

        [OperationContract]
        bool UnirseAPartida(string codigoSala, string nombreJugador);

        [OperationContract]
        void AbandonarPartida(string codigoSala, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void IniciarPartida(string codigoSala);

        [OperationContract(IsOneWay = true)]
        void BloquearPieza(string codigoSala, int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesbloquearPieza(string codigoSala, int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void ColocarPieza(string codigoSala, int numeroPieza, string nombreJugador, 
            Posicion posicion);

        [OperationContract]
        int ObtenerNumeroDePartidasJugadas(string nombreJugador);

        [OperationContract]
        int ObtenerNumeroDePartidasGanadas(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void ExpulsarJugadorEnPartida(string nombreJugadorExpulsion, string codigoSala);

        [OperationContract]
        List<CuentaJugador> ObtenerJugadoresEnPartida(string codigoSala);

        [OperationContract]
        void ConvertirJugadorEnAnfitrionDesdePartida(string nombreJugador, string codigoSala);
    }

    [ServiceContract]
    public interface IServicioPartidaCallback
    {
        [OperationContract(IsOneWay = true)]
        void MostrarTableroDePartida(Tablero tablero);

        [OperationContract(IsOneWay = true)]
        void MostrarBloqueoDePieza(int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void MostrarDesbloqueoDePieza(int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void MostrarColocacionDePieza(int numeroPieza, string nombreJugador, 
            int puntaje, Posicion posicion);

        [OperationContract(IsOneWay = true)]
        void MostrarResultadosDePartida();

        [OperationContract(IsOneWay = true)]
        void HabilitarOpcionDeRegresoASala();

        [OperationContract(IsOneWay = true)]
        void MostrarDesconexionDeJugadorEnPartida(string nombreJugadorDesconexion);

        [OperationContract(IsOneWay = true)]
        void MostrarNuevoJugadorEnPartida(CuentaJugador jugador);

        [OperationContract(IsOneWay = true)]
        void MostrarMensajePartidaCancelada();

        [OperationContract(IsOneWay = true)]
        void MostrarMensajeExpulsionDePartida();

        [OperationContract(IsOneWay = true)]
        void MostrarFuncionesDeAnfitrionEnPartida();
    }
}