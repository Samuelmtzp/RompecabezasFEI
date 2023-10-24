using Datos;
using System.Linq;

namespace Logica
{
    public class ConsultasJugador
    {
        public bool ExisteNombreJugador(string nombreJugador)
        {
            bool existeNombreJugador = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cantidadJugadoresEncontrados = (from jugadores in contexto.Jugador 
                                                    where jugadores.NombreJugador == nombreJugador 
                                                    select jugadores).Count();
                if (cantidadJugadoresEncontrados > 0)
                {
                    existeNombreJugador = true;
                }
            }
            return existeNombreJugador;
        }

        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            bool existeCorreoElectronico = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cantidadCorreosEncontrados = (from cuentas in contexto.Cuenta 
                                                  where cuentas.Correo == correoElectronico 
                                                  select cuentas).Count();
                if (cantidadCorreosEncontrados > 0)
                {
                    existeCorreoElectronico = true;
                }
            }
            return existeCorreoElectronico;
        }

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            int numeroPartidasJugadas;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                numeroPartidasJugadas = (from jugador in contexto.Jugador 
                                         from partidasJugadas in contexto.Jugador_Partida 
                                         where jugador == partidasJugadas.Jugador &&
                                         jugador.NombreJugador == nombreJugador 
                                         select jugador).Count();
            }
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int numeroPartidasGanadas;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                numeroPartidasGanadas = contexto.Jugador_Partida.GroupBy(jugadorEnPartida => 
                    jugadorEnPartida.Jugador.NombreJugador).Select(jugadoresPartida => new
                    {
                        NombreJugador = jugadoresPartida.Key,
                        PuntajeMaximo = jugadoresPartida.Max(jugadorEnPartida => 
                        jugadorEnPartida.Puntaje)
                    }).
                    Where(jugadoresPartida => jugadoresPartida.PuntajeMaximo == 
                        contexto.Jugador_Partida.Where(jugadorEnPartida => 
                        jugadoresPartida.NombreJugador == nombreJugador).Max(jugadorEnPartida => 
                        jugadorEnPartida.Puntaje)).Count();
            }
            return numeroPartidasGanadas;
        }

    }
}
