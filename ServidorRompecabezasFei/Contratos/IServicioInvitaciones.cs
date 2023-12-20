using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioInvitacionesCallback))]
    public interface IServicioInvitaciones
    {
        [OperationContract(IsOneWay = true)]
        void SuscribirJugadorAInvitacionesDeSala(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesuscribirJugadorDeInvitacionesDeSala(string nombreJugador);
    }

    [ServiceContract]
    public interface IServicioInvitacionesCallback
    {
        [OperationContract]
        void MostrarInvitacionDeSala(string nombreJugador, string codigoSala);
    }
}