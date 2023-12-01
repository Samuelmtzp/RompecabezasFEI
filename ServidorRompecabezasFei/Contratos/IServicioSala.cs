using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioSalaCallback))]
    public interface IServicioSala
    {
        [OperationContract]
        bool CrearNuevaSala(string nombreAnfitrion, string codigoSala);

        [OperationContract]
        void ConectarJugadorASala(string nombreNuevoJugador, string codigoSala, 
            string mensajeBienvenida);

        [OperationContract]
        void RefrescarSesionEnSala(string nombreJugador, string codigoSala);

        [OperationContract]
        void DesconectarJugadorDeSala(string nombreJugadorDesconexion, string codigoSala, 
            string mensajeDespedida);

        [OperationContract]
        List<CuentaJugador> ObtenerJugadoresConectadosEnSala(string codigoSala);

        [OperationContract(IsOneWay = true)]
        void EnviarMensajeDeSala(string nombreJugador, string codigoSala, string mensaje);

        [OperationContract]
        string GenerarCodigoParaNuevaSala();
        
        [OperationContract]
        bool ExisteSalaDisponible(string codigoSala);

        [OperationContract]
        bool ConvertirAJugadorEnAnfitrionDeSala(string nombreAntiguoAnfitrion,
            string nombreNuevoAnfitrion, string codigoSala); 

        [OperationContract(IsOneWay = true)]
        void InvitarAJugadorASala(string nombreJugador, string nombreAnfitrion,
            string codigoSala);
    }

    [ServiceContract]
    public interface IServicioSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarCreacionDePartida();

        [OperationContract(IsOneWay = true)]
        void MostrarMensajeDeSala(string mensaje);

        [OperationContract(IsOneWay = true)]
        void NotificarNuevoJugadorConectadoEnSala(CuentaJugador nuevoJugador);

        [OperationContract(IsOneWay = true)]
        void NotificarJugadorDesconectadoDeSala(string nombreJugadorDesconectado);

        [OperationContract(IsOneWay = true)]
        void MostrarFuncionesDeAnfitrion();

    }
}