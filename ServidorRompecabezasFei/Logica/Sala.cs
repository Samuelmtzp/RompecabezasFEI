using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Sala
    {
        #region Atributos
        private string codigoSala;
        private string nombreAnfitrion;
        private int contadorJugadoresActuales = 0;        
        public const int MaximoJugadores = 4;
        public const int MinimoJugadores = 2;
        private List<CuentaJugador> jugadores;
        #endregion

        #region Propiedades
        [DataMember]
        public string CodigoSala 
        { 
            get { return codigoSala; } 
            set { codigoSala = value; } 
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