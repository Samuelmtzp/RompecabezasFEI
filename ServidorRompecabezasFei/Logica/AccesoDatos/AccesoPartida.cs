using Datos;
using System.Collections.Concurrent;
using System.Linq;

namespace Logica.AccesoDatos
{
    public static class AccesoPartida
    {
        public static bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad)
        {
            bool operacionRealizada = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Sala salaEncontrada = contexto.Sala.FirstOrDefault(
                    sala => sala.Codigo.Equals(codigoSala));

                if (salaEncontrada != null)
                {
                    Datos.Partida nuevaPartida = new Datos.Partida
                    {
                        Dificultad = dificultad,
                        IdSala = salaEncontrada.IdSala,      
                    };
                    contexto.Partida.Add(nuevaPartida);
                    operacionRealizada = contexto.SaveChanges() > 0;
                }
            }

            return operacionRealizada;
        }

        public static bool FinalizarPartida(string codigoSala, 
            CuentaJugador cuentaJugador, bool esGanador)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Partida partidaEncontrada = contexto.Partida.
                    OrderByDescending(partida => partida.IdPartida).
                    Where(partida => partida.Sala.Codigo == codigoSala).
                    FirstOrDefault();

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

        public static ConcurrentDictionary<int, Pieza> GenerarPiezasParaTablero(
            int numeroFilas, int numeroColumnas)
        {
            ConcurrentDictionary<int, Pieza> piezas = 
                new ConcurrentDictionary<int, Pieza>();
            int totalPiezas = numeroFilas * numeroColumnas;
           
            for (int numeroPieza = 1; numeroPieza <= totalPiezas; numeroPieza++)
            {
                Pieza pieza = new Pieza()
                {
                    NumeroPieza = numeroPieza,
                    EstaDentroDeCelda = false,
                    EstaBloqueada = false,
                    Puntaje = Pieza.PuntajeNormal,
                };
                piezas.TryAdd(numeroPieza, pieza);
            }

            return piezas;
        }
    }
}