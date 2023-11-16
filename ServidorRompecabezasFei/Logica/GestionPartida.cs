using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionPartida
    {
        public bool CrearNuevaPartida(string codigoSala)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Sala salaEncontrada = contexto.Sala.FirstOrDefault(
                    sala => sala.Codigo.Equals(codigoSala));

                if (salaEncontrada != null)
                {
                    Partida nuevaPartida = new Partida
                    {
                        Dificultad = DificultadPartida.Facil,
                        IdSala = salaEncontrada.IdSala,                        
                    };
                    contexto.Partida.Add(nuevaPartida);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public bool FinalizarPartida(string codigoSala, 
            CuentaJugador cuentaJugador, bool esGanador)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Partida partidaEncontrada = contexto.Partida.OrderByDescending(
                    partida => partida.IdPartida).Where(partida => 
                    partida.Sala.Codigo == codigoSala).FirstOrDefault();

                if (partidaEncontrada != null)
                {
                    ResultadoPartida resultadoPartida = new ResultadoPartida
                    {
                        IdPartida = partidaEncontrada.IdPartida,
                        IdJugador = cuentaJugador.IdJugador,
                        EsGanador = esGanador,
                        Puntaje = cuentaJugador.Puntaje,                        
                    };
                    contexto.ResultadoPartida.Add(resultadoPartida);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }
    }
}