using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class GestionPartida
    {
        public bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad)
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

        public bool FinalizarPartida(string codigoSala, 
            CuentaJugador cuentaJugador, bool esGanador)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Partida partidaEncontrada = contexto.Partida.OrderByDescending(
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

        public Tablero GenerarNuevoTablero(DificultadPartida dificultad, 
            int numeroImagenRompecabezas)
        {
            Tablero tablero = new Tablero
            {
                Dificultad = dificultad,
                NumeroImagenRompecabezas = numeroImagenRompecabezas
            };
            tablero.Piezas = GenerarPiezasParaTablero(tablero.TotalFilas, 
                tablero.TotalColumnas);

            return tablero;
        }

        public List<Pieza> GenerarPiezasParaTablero(int numeroFilas, int numeroColumnas)
        {
            List<Pieza> piezas = new List<Pieza>();
            int totalPiezas = numeroFilas * numeroColumnas;
            int numeroPieza = 0;
           
            while (numeroPieza < totalPiezas)
            {
                Pieza pieza = new Pieza()
                {
                    NumeroPieza = ++numeroPieza,
                    EstaDentroDeCelda = false
                };
                piezas.Add(pieza);
            }

            return piezas;
        }
    }
}