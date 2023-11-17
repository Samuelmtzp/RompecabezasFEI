using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioCorreo
    {
        [OperationContract]
        bool ExisteCorreoElectronico(string correoElectronico);

        [OperationContract]
        bool EnviarMensajeCorreo(string encabezado, string correoDestino,
            string asunto, string mensaje);
    }
}