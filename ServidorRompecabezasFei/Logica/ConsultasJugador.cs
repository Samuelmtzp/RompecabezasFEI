using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
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
                //numeroPartidasGanadas = (from jugador in contexto.Jugador
                //                         from partidasGanadas in contexto.Jugador_Partida
                //                         where partidasGanadas.Puntaje
                //                         jugador == partidasJugadas.Jugador
                //                         && partidasJugadas.Puntaje
                //                         && jugador.NombreJugador == nombreJugador
                //                         select jugador).Count();
            }
            return numeroPartidasGanadas = 1;
        }

    }
}
