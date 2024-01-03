using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica.AccesoDatos
{
    public static class AccesoAmistad
    {
        public static List<CuentaJugador> ObtenerAmigosDeJugador(
            string nombreJugador)
        {
            List<CuentaJugador> amigos = new List<CuentaJugador>();

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var amigosObtenidos = (from jugador in contexto.Jugador
                                      from amistad in contexto.Amistad
                                      where amistad.JugadorA.NombreJugador.
                                      Equals(jugador.NombreJugador) &&
                                      jugador.NombreJugador.Equals(nombreJugador) 
                                      select amistad.JugadorB).Concat(
                                      from jugador in contexto.Jugador
                                      from amistad in contexto.Amistad
                                      where amistad.JugadorB.NombreJugador.
                                      Equals(jugador.NombreJugador) &&
                                      jugador.NombreJugador.Equals(nombreJugador)
                                      select amistad.JugadorA).ToList();

                foreach (Jugador amigo in amigosObtenidos)
                {
                    amigos.Add(new CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                    });
                }
            }

            return amigos;
        }              

        public static bool RegistrarNuevaAmistad(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadorA = contexto.Jugador.Where(jugador =>
                    jugador.NombreJugador == nombreJugadorA).FirstOrDefault();
                var jugadorB = contexto.Jugador.Where(jugador =>
                    jugador.NombreJugador == nombreJugadorB).FirstOrDefault();

                if (jugadorA != null && jugadorB != null)
                {
                    Amistad amistad = new Amistad
                    {
                        IdJugadorA = jugadorA.IdJugador,
                        IdJugadorB = jugadorB.IdJugador
                    };
                    contexto.Amistad.Add(amistad);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool EliminarAmistad(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var amistadObtenida = contexto.Amistad.FirstOrDefault(amistad => 
                    amistad.JugadorA.NombreJugador.Equals(nombreJugadorA) &&
                    amistad.JugadorB.NombreJugador.Equals(nombreJugadorB) ||
                    amistad.JugadorA.NombreJugador.Equals(nombreJugadorB) &&
                    amistad.JugadorB.NombreJugador.Equals(nombreJugadorA));

                if (amistadObtenida != null)
                {
                    contexto.Amistad.Remove(amistadObtenida);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool ExisteAmistad(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                resultado = (from amistad in contexto.Amistad
                            where amistad.JugadorA.NombreJugador.
                            Equals(nombreJugadorA) &&
                            amistad.JugadorB.NombreJugador.
                            Equals(nombreJugadorB) ||
                            amistad.JugadorA.NombreJugador.
                            Equals(nombreJugadorB) &&
                            amistad.JugadorB.NombreJugador.
                            Equals(nombreJugadorA)
                            select amistad).Any();
            }

            return resultado;
        }
    }
}