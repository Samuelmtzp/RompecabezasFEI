using Datos;
using System.Linq;

namespace Logica
{
    public class GestionSala
    {
        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Jugador jugadorAnfitrion = contexto.Jugador.Where(jugador =>
                    jugador.NombreJugador == nombreAnfitrion).FirstOrDefault();

                if (jugadorAnfitrion != null)
                {
                    Datos.Sala nuevaSala = new Datos.Sala
                    {
                        Codigo = codigoSala,
                        IdAnfitrion = jugadorAnfitrion.IdJugador,
                        MaximoJugadores = Sala.MaximoJugadores,
                        MinimoJugadores = Sala.MinimoJugadores,
                    };
                    contexto.Sala.Add(nuevaSala);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }
    }
}