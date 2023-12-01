using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public static class GestionAmistades
    {
        public static List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
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

        public static List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(
            string nombreJugador)
        {
            List<CuentaJugador> jugadoresConSolicitudPendiente = new List<CuentaJugador>();

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadores = (from solicitud in contexto.SolicitudAmistad
                                 where solicitud.JugadorDestino.NombreJugador.
                                 Equals(nombreJugador)
                                 select solicitud.JugadorOrigen).ToList();

                foreach (Jugador jugador in jugadores)
                {
                    jugadoresConSolicitudPendiente.Add(new CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar
                    });
                }
            }

            return jugadoresConSolicitudPendiente;
        }

        public static bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadorOrigen = contexto.Jugador.Where(jugador => 
                    jugador.NombreJugador == nombreJugadorOrigen).FirstOrDefault();
                var jugadorDestino = contexto.Jugador.Where(jugador =>
                    jugador.NombreJugador == nombreJugadorDestino).FirstOrDefault();

                if (jugadorOrigen != null && jugadorDestino != null)
                {
                    SolicitudAmistad solicitud = new SolicitudAmistad
                    {
                        IdJugadorOrigen = jugadorOrigen.IdJugador,
                        IdJugadorDestino = jugadorDestino.IdJugador,
                    };
                    contexto.SolicitudAmistad.Add(solicitud);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            if (!ExisteAmistadConJugador(nombreJugadorOrigen, nombreJugadorDestino))
            {
                resultado = RegistrarNuevaAmistadEntreJugadores(nombreJugadorOrigen,
                    nombreJugadorDestino);
            }

            if (ExisteSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino))
            {
                EliminarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
            }

            if (ExisteSolicitudDeAmistad(nombreJugadorDestino, nombreJugadorOrigen))
            {
                EliminarSolicitudDeAmistad(nombreJugadorDestino, nombreJugadorOrigen);
            }

            return resultado;
        }        

        private static bool RegistrarNuevaAmistadEntreJugadores(string nombreJugadorA, 
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

        public static bool EliminarAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB)
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

        public static bool EliminarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var solicitudAmistadObtenida = contexto.SolicitudAmistad.
                    FirstOrDefault(solicitud => 
                    solicitud.JugadorOrigen.NombreJugador.Equals(nombreJugadorOrigen) &&
                    solicitud.JugadorDestino.NombreJugador.Equals(nombreJugadorDestino));

                if (solicitudAmistadObtenida != null)
                {
                    contexto.SolicitudAmistad.Remove(solicitudAmistadObtenida);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int coincidencias = (from solicitud in contexto.SolicitudAmistad
                                     where solicitud.JugadorOrigen.NombreJugador.
                                     Equals(nombreJugadorOrigen) &&
                                     solicitud.JugadorDestino.NombreJugador.
                                     Equals(nombreJugadorDestino)
                                     select solicitud).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int coincidencias = (from amistad in contexto.Amistad
                                    where amistad.JugadorA.NombreJugador.
                                    Equals(nombreJugadorA) &&
                                    amistad.JugadorB.NombreJugador.
                                    Equals(nombreJugadorB) ||
                                    amistad.JugadorA.NombreJugador.
                                    Equals(nombreJugadorB) &&
                                    amistad.JugadorB.NombreJugador.
                                    Equals(nombreJugadorA)
                                    select amistad).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}