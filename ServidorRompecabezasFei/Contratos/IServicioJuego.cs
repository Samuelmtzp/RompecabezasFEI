using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioJuegoCallback))]
    public interface IServicioJuego
    {
        [OperationContract]
        void NuevaSala(string nombreAnfitrion, string idSala);

        [OperationContract]
        void ConectarCuentaJugadorASala(string nombreJugador, string idSala, 
            string mensajeBienvenida);

        [OperationContract]
        void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala, 
            string mensajeDespedida);

        [OperationContract(IsOneWay = true)]
        void EnviarMensajeDeSala(string nombreJugador, string idSala, string mensaje);

        [OperationContract]
        string GenerarCodigoParaNuevaSala();
        
        [OperationContract]
        bool ExisteSalaDisponible(string idSala);               
    }

    [ServiceContract]
    public interface IServicioJuegoCallback
    {
        [OperationContract(IsOneWay = true)]
        void MensajeDeSalaCallBack(string mensaje);
    }
}
