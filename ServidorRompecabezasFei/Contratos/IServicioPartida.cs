using Datos;
using Logica;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioPartidaCallback))]
    public interface IServicioPartida
    {
        [OperationContract]
        bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad);

        [OperationContract]
        bool IniciarPartida(string codigoSala, int numeroImagenRompecabezas);

        [OperationContract]
        bool FinalizarPartida(string codigoSala);

        [OperationContract]
        void CambiarPosicionDePieza(string codigoSala, string nombreJugador, 
            int numeroPieza, double posicionX, double posicionY);

        [OperationContract]
        void MarcarPiezaComoSeleccionada(string codigoSala, int numeroPieza);

        [OperationContract]
        void MarcarPiezaComoCorrecta(string codigoSala, int numeroPieza, string nombreJugador);

        [OperationContract]
        bool ExpulsarJugador(string codigoSala, string nombreJugador);

        [OperationContract]
        int ObtenerNumeroPartidasJugadas(string nombreJugador);

        [OperationContract]
        int ObtenerNumeroPartidasGanadas(string nombreJugador);
    }

    [ServiceContract]
    public interface IServicioPartidaCallback
    {
        [OperationContract(IsOneWay = true)]
        void MostrarTablero(Tablero tablero);

        [OperationContract(IsOneWay = true)]
        void NotificarPiezaMarcadaComoBloqueada();

        [OperationContract(IsOneWay = true)]
        void ActualizarPosicionDePieza(int numeroPieza, double posicionX, double posicionY);

        [OperationContract(IsOneWay = true)]
        void NotificarPiezaMarcadaComoCorrecta(int numeroPieza, string jugador);

        [OperationContract(IsOneWay = true)]
        void NotificarFinDePartida();
    }
}