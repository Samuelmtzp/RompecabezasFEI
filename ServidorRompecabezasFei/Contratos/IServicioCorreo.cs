using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioCorreo
    {
        [OperationContract]
        bool ExisteCorreoRegistrado(string correo);

        [OperationContract]
        bool EnviarMensajeACorreo(string encabezado, string correo, string asunto, string mensaje);
    }
}