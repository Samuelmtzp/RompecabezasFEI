using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioJuegoCallback))]
    public interface IServicioJuego
    {
        [OperationContract]
        void NuevaSala(string nombreAnfitrion, string codigoSala);

        [OperationContract]
        void ConectarCuentaJugadorASala(string nombreJugador, string codigoSala, 
            string mensajeBienvenida);

        [OperationContract]
        void DesconectarCuentaJugadorDeSala(string nombreJugador, string codigoSala, 
            string mensajeDespedida);

        [OperationContract(IsOneWay = true)]
        void EnviarMensajeDeSala(string nombreJugador, string codigoSala, string mensaje);

        [OperationContract]
        string GenerarCodigoParaNuevaSala();
        
        [OperationContract]
        bool ExisteSalaDisponible(string codigoSala);               
    }

    [ServiceContract]
    public interface IServicioJuegoCallback
    {
        [OperationContract(IsOneWay = true)]
        void MensajeDeSalaCallBack(string mensaje);
    }
}
