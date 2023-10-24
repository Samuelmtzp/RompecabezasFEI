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
        private int contadorJugadoresActuales = 0;
        private List<CuentaJugador> jugadores;
        [DataMember]
        public const int MaximoJugadores = 4;
        [DataMember]
        public const int MinimoJugadores = 2;
        #endregion

        #region Propiedades
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
        public int ContadorJugadoresActuales 
        { 
            get { return contadorJugadoresActuales; } 
            set { contadorJugadoresActuales = value; } 
        }
        [DataMember]
        public List<CuentaJugador> Jugadores 
        { 
            get { return jugadores; } 
            set { jugadores = value; } 
        }
        #endregion
        
        #region Métodos
        public bool ExisteCupoJugadores()
        {
            return contadorJugadoresActuales < MaximoJugadores;
        }
        public bool EstaVacia()
        {
            return contadorJugadoresActuales == 0;
        }
        #endregion
    }
}
