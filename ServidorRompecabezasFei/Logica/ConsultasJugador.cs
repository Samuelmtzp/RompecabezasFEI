using Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

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

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            int numeroPartidasJugadas;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                numeroPartidasJugadas = (from jugador in contexto.Jugador
                                         from partidasJugadas in contexto.Jugador_Partida
                                      where jugador == partidasJugadas.Jugador 
                                      && jugador.NombreJugador == nombreJugador
                                      select jugador).Count();
            }
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int numeroPartidasGanadas;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                numeroPartidasGanadas = contexto.Jugador_Partida
                    .GroupBy(jugadorEnPartida => jugadorEnPartida.Jugador.NombreJugador)
                    .Select(group => new
                    {
                        NombreJugador = group.Key,
                        PuntajeMaximo = group.Max(jugadorEnPartida => jugadorEnPartida.Puntaje)
                    })
                    .Where(group => group.PuntajeMaximo == contexto.Jugador_Partida
                        .Where(jugadorEnPartida => group.NombreJugador == nombreJugador)
                        .Max(jugadorEnPartida => jugadorEnPartida.Puntaje)).Count();
            }
            return numeroPartidasGanadas;
        }

    }
}
