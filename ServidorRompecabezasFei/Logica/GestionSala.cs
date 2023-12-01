using Datos;

namespace Logica
{
    public static class GestionSala
    {
        public static bool CrearNuevaSala(string codigoSala)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Sala nuevaSala = new Datos.Sala
                {
                    Codigo = codigoSala,
                    MaximoJugadores = Sala.MaximoJugadoresPorSala,
                    MinimoJugadores = Sala.MinimoJugadoresParaIniciarPartida,
                };
                contexto.Sala.Add(nuevaSala);
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }
    }
}