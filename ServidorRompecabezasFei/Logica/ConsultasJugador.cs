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
                var cantidadJugadoresEncontrados = (from jugadores in contexto.Jugador 
                                                    where jugadores.NombreJugador == nombreJugador
                                                    select jugadores).Count();
                if (cantidadJugadoresEncontrados > 0)
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
                var cantidadCorreosEncontrados = (from cuentas in contexto.Cuenta 
                                                  where cuentas.Correo == correoElectronico 
                                                  select cuentas).Count();
                if (cantidadCorreosEncontrados > 0)
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
                                   from partidaJugada in contexto.Jugador_Partida 
                                   where jugador == partidaJugada.Jugador &&
                                   jugador.NombreJugador == nombreJugador 
                                   select jugador).Count();
            }

            return partidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int partidasGanadas;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                partidasGanadas = contexto.Jugador_Partida.
                    GroupBy(jugadorEnPartida => 
                    jugadorEnPartida.Jugador.NombreJugador).
                    Select(jugadoresPartida => new
                    {
                        NombreJugador = jugadoresPartida.Key,
                        PuntajeMaximo = jugadoresPartida.
                            Max(jugadorEnPartida => jugadorEnPartida.Puntaje)
                    }).
                    Where(jugadoresPartida => jugadoresPartida.PuntajeMaximo == 
                    contexto.Jugador_Partida.
                    Where(jugadorEnPartida => jugadoresPartida.NombreJugador == nombreJugador).
                    Max(jugadorEnPartida => jugadorEnPartida.Puntaje)).Count();
            }

            return partidasGanadas;
        }        
    }
}