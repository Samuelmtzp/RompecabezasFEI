using Logica;
using System.Collections.Generic;
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
    }

    [ServiceContract]
    public interface IServicioPartidaCallback
    {
        [OperationContract(IsOneWay = true)]
        void RefrescarMovimientoPieza(double posicionX, double posicionY);

        [OperationContract(IsOneWay = true)]
        void PosicionarPiezaEnCelda();
    }
}