using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    [DataContract]
    public class Sala
    {
        #region Atributos
        private string idSala;
        private string nombreAnfitrion;
        private const int MaximoJugadores = 4;
        private const int MinimoJugadores = 2;
        private int contadorJugadoresActuales = 0;
        private List<Logica.CuentaJugador> jugadores;
        #endregion
        
        #region Properties
        [DataMember]
        public string IdSala 
        { 
            get { return idSala; } 
            set { idSala = value; } 
        }
        [DataMember]
        public string NombreAnfitrion
        { 
            get { return nombreAnfitrion; } 
            set { nombreAnfitrion = value; } 
        }
        [DataMember]
        public int MAXIMO_JUGADORES 
        { 
            get { return MaximoJugadores; }
        }
        [DataMember]
        public int MINIMO_JUGADORES
        {
            get { return MinimoJugadores; }
        }
        [DataMember]
        public int ContadorJugadoresActuales 
        { 
            get { return contadorJugadoresActuales; } 
            set { contadorJugadoresActuales = value; } 
        }
        [DataMember]
        public List<Logica.CuentaJugador> Jugadores 
        { 
            get { return jugadores; } 
            set { jugadores = value; } 
        }
        #endregion
        
        #region Métodos
        public bool ExisteDisponibilidadCupoJugadores()
        {
            return contadorJugadoresActuales < MaximoJugadores;
        }
        #endregion
    }
}
