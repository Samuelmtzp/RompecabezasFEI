using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioJuegoCallback))]
    public interface IServicioJuego
    {
        [OperationContract]
        void CrearNuevaSala(string nombreAnfitrion, string codigoSala);

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
        void MostrarMensajeDeSala(string mensaje);
    }
}