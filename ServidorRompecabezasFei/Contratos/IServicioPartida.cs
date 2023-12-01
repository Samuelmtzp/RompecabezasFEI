using Datos;
using Logica;
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
        void ConectarJugadorAPartida(string codigoSala, string nombreJugador);

        [OperationContract]
        void DesconectarJugadorDePartida(string codigoSala, string nombreJugadorDesconexion);

        [OperationContract(IsOneWay = true)]
        void IniciarPartida(string codigoSala);

        [OperationContract(IsOneWay = true)]
        void BloquearPieza(string codigoSala, int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesbloquearPieza(string codigoSala, int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void ColocarPieza(string codigoSala, int numeroPieza, string nombreJugador, 
            double posicionX, double posicionY);

        [OperationContract]
        int ObtenerNumeroPartidasJugadas(string nombreJugador);

        [OperationContract]
        int ObtenerNumeroPartidasGanadas(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void ExpulsarAJugadorDePartida(string nombreJugadorExpulsion, string codigoSala);
    }

    [ServiceContract]
    public interface IServicioPartidaCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarInicioDePartida(Tablero tablero);

        [OperationContract(IsOneWay = true)]
        void NotificarBloqueoDePieza(int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void NotificarDesbloqueoDePieza(int numeroPieza, string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void NotificarColocacionDePieza(int numeroPieza, string nombreJugador, int puntaje, 
            double posicionX, double posicionY);

        [OperationContract(IsOneWay = true)]
        void NotificarFinDePartida();

        [OperationContract(IsOneWay = true)]
        void NotificarJugadorDesconectadoDePartida(string nombreJugadorDesconectado);
    }
}