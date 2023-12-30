using Datos;

namespace Logica.AccesoDatos
{
    public static class AccesoSala
    {
        public static bool CrearNuevaSala(string codigoSala)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Sala nuevaSala = new Datos.Sala
                {
                    Codigo = codigoSala,
                    MaximoJugadores = Sala.CantidadMaximaJugadores,
                    MinimoJugadores = Sala.CantidadMinimaJugadoresParaPartida,
                };
                contexto.Sala.Add(nuevaSala);
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }
    }
}