using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica.AccesoDatos
{
    public static class AccesoSolicitudAmistad
    {
        public static bool CrearNuevaSolicitudDeAmistad(string nombreJugadorOrigen,
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

        public static List<CuentaJugador> ObtenerJugadoresOrigenSolicitudAmistadPendiente(
            string nombreJugadorDestino)
        {
            List<CuentaJugador> jugadoresConSolicitudPendiente =
                new List<CuentaJugador>();

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadores = (from solicitud in contexto.SolicitudAmistad
                                 where solicitud.JugadorDestino.NombreJugador.
                                 Equals(nombreJugadorDestino)
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

        public static bool EliminarSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var solicitudAmistadObtenida = contexto.SolicitudAmistad.
                    FirstOrDefault(solicitud =>
                    solicitud.JugadorOrigen.NombreJugador.
                    Equals(nombreJugadorOrigen) &&
                    solicitud.JugadorDestino.NombreJugador.
                    Equals(nombreJugadorDestino));

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
                resultado = (from solicitud in contexto.SolicitudAmistad
                             where solicitud.JugadorOrigen.NombreJugador.
                             Equals(nombreJugadorOrigen) &&
                             solicitud.JugadorDestino.NombreJugador.
                             Equals(nombreJugadorDestino)
                             select solicitud).Any();
            }

            return resultado;
        }
    }
}
