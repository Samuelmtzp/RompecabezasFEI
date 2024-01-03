using Datos;
using System.Linq;

namespace Logica.AccesoDatos
{
    public static class AccesoResultadoPartida
    {
        public static bool AgregarResultadoPartida(string codigoSala,
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
    }
}
