using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador
    {
        #region Atributos
        private int idJugador;
        private string nombreJugador;
        private short numeroAvatar;
        private int idUsuario;
        private string correo;
        private string contrasena;
        private bool esInvitado;
        #endregion

        #region Singletone
        private static Jugador jugadorActual;
        public static Jugador JugadorActual 
        { 
            get { return jugadorActual; } 
            set { jugadorActual = value; } 
        }
        #endregion

        #region Propiedades
        public int IdJugador 
        { 
            get { return idJugador; } 
            set { idJugador = value; } 
        }
        public string NombreJugador 
        { 
            get { return nombreJugador; } 
            set { nombreJugador = value; } 
        }
        public short NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public bool EsInvitado
        {
            get { return esInvitado; }
            set { esInvitado = value; }
        }
        #endregion
    }
}
