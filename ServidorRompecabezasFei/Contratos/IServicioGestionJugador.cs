using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioGestionJugador
    {

        [OperationContract]
        bool Registrar(Datos.Usuario usuario, Datos.Jugador jugador);
        [OperationContract]
        bool ExisteCorreoElectronico(string correoElectronico);
        [OperationContract]
        bool ExisteNombreUsuario(string nombreUsuario);

    }

    [DataContract]
    public class Jugador
    {
        [DataMember]
        public int IdJugador { get; set; }
        [DataMember]
        public string NombreJugador { get; set; }
        [DataMember]
        public short NumeroAvatar { get; set; }
    }

    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Contrasena { get; set; }
    }
}
