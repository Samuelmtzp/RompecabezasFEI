using Datos;
using System.Linq;

namespace Logica
{
    public class ConsultasJugador
    {
        public bool ExisteNombreJugador(string nombreJugador)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int coincidencias = (from jugador in contexto.Jugador 
                                    where jugador.NombreJugador == nombreJugador 
                                    select jugador).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            bool resultado = false;
            
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var coincidencias = (from cuenta in contexto.Cuenta 
                                    where cuenta.Correo == correoElectronico
                                    select cuenta).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public int ObtenerNumeroPartidasJugadasDeJugador(string nombreJugador)
        {
            int partidasJugadas;
            
            using (var contexto = new EntidadesRompecabezasFei())
            {
                partidasJugadas = (from jugador in contexto.Jugador 
                                   from partidaJugada in contexto.ResultadoPartida 
                                   where partidaJugada.Jugador.Equals(jugador) &&
                                   jugador.NombreJugador.Equals(nombreJugador) 
                                   select jugador).Count();
            }

            return partidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int partidasGanadas;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                partidasGanadas = (from partidaJugada in contexto.ResultadoPartida
                                   where partidaJugada.Jugador.NombreJugador.
                                   Equals(nombreJugador) && partidaJugada.EsGanador
                                   select partidaJugada).Count();
            }

            return partidasGanadas;
        }        
    }
}