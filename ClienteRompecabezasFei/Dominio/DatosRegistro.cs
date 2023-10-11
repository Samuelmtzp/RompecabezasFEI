using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DatosRegistro
    {
        private string nombreUsuario;
        private string correoElectronico;
        private string contrasena;
        private string confirmacionContrasena;
        private short numeroAvatar;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public string ConfirmacionContrasena
        {
            get { return confirmacionContrasena; }
            set { confirmacionContrasena = value; }
        }
        public short NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
        }
    }
}
