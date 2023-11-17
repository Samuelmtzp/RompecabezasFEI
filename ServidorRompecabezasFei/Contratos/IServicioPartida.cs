using Logica;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioPartidaCallback))]
    public interface IServicioPartida
    {
        [OperationContract]
        bool CrearNuevaPartida(string codigoSala);

        [OperationContract]
        bool IniciarPartida(string codigoSala);

        [OperationContract]
        bool FinalizarPartida(string codigoSala, 
            CuentaJugador cuentaJugador, bool esGanador);

        [OperationContract]
        bool GenerarTablero(string codigoSala);

        [OperationContract]
        void MoverPiezaPosicionX(double posicionX);

        [OperationContract]
        void MoverPiezaPosicionY(bool posicionY); 

        [OperationContract]
        bool NotificarJugadorPreparado(string codigoSala, 
            string nombreJugador);        

        [OperationContract]
        bool ExpulsarJugadorPartida(string codigoSala, 
            string nombreJugador);

        [OperationContract]
        int ObtenerNumeroPartidasJugadas(string nombreJugador);

        [OperationContract]
        int ObtenerNumeroPartidasGanadas(string nombreJugador);
    }

    [ServiceContract]
    public interface IServicioPartidaCallback
    {
        [OperationContract(IsOneWay = true)]
        void ActualizarNuevaPosicionDePieza(double posicionX, double posicionY);
    }
}