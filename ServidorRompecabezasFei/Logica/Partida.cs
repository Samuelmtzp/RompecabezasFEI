using Datos;
using Logica.Enumeraciones;
using System.Collections.Concurrent;

namespace Logica
{
    public class Partida
    {
        public const int CantidadGanadoresPorPartidaPermitidos = 1;

        private DificultadPartida dificultad;

        public EstadoPartida Estado { get ; set;}

        public Tablero Tablero { get; private set; }

        public ConcurrentDictionary<string, int> PuntajesDeJugadores { get; set; }

        public ConcurrentDictionary<string, bool> ConfirmacionesJugadores { get; set; }

        public DificultadPartida Dificultad
        {
            get { return dificultad; }
            set
            {
                dificultad = value;
                Tablero = new Tablero(dificultad);                
            }
        }

        public Partida()
        {
            Estado = EstadoPartida.SinIniciar;
        }

        public bool HayCantidadMinimaJugadoresParaPartida()
        {
            return PuntajesDeJugadores.Count >= 
                Sala.CantidadMinimaJugadoresParaPartida;
        }

        public bool EsJugadorConPresenciaConfirmada(string nombreJugador)
        {
            return ConfirmacionesJugadores.ContainsKey(nombreJugador) && 
                ConfirmacionesJugadores[nombreJugador];
        }

        public bool ConfirmarPresenciaJugador(string nombreJugador)
        {
            return ConfirmacionesJugadores[nombreJugador] = true;
        }

        public bool AgregarNombreDeJugador(string nombreJugador)
        {
            return PuntajesDeJugadores.TryAdd(nombreJugador, Pieza.PuntajeVacio) &&
                ConfirmacionesJugadores.TryAdd(nombreJugador, false);
        }

        public bool RemoverNombreDeJugador(string nombreJugador)
        {
            return PuntajesDeJugadores.TryRemove(nombreJugador, out _) && 
                ConfirmacionesJugadores.TryRemove(nombreJugador, out _);
        }
    }
}