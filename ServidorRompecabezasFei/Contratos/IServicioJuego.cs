using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioJuegoCallback))]
    public interface IServicioJuego
    {
        [OperationContract]
        bool NuevaSala(string nombreAnfitrion, string idSala);

        [OperationContract]
        void ConectarCuentaJugadorASala(string nombreJugador, string idSala);

        [OperationContract]
        void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala);

        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(string nombreJugador, string idSala, string mensaje);

        [OperationContract]
        string GenerarCodigoParaNuevaSala();
        [OperationContract]
        bool ExisteSalaDisponible(string idSala);
    }

    [ServiceContract]
    public interface IServicioJuegoCallback
    {
        [OperationContract(IsOneWay = true)]
        void MensajeCallBack(string mensaje);
    }
}
