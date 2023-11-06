using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class GestionAmigosJugador
    {
        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            List<CuentaJugador> amigos = new List<CuentaJugador>();

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var amigosObtenidos = (from jugador in contexto.Jugador
                                       from amigo in contexto.Amigo
                                       where jugador.IdJugador == amigo.IdJugador1 &&
                                       jugador.NombreJugador == nombreJugador
                                       select amigo.Jugador2).Concat(
                                       from jugador in contexto.Jugador
                                       from amigo in contexto.Amigo
                                       where jugador.IdJugador == amigo.IdJugador2 &&
                                       jugador.NombreJugador == nombreJugador
                                       select amigo.Jugador1).ToList();

                foreach (Jugador jugador in amigosObtenidos)
                {
                    amigos.Add(new CuentaJugador
                    {
                        IdJugador = jugador.IdJugador,
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar
                    });
                }
            }

            return amigos;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
            string nombreJugador)
        {
            List<CuentaJugador> jugadoresOrigenSolicitud = new List<CuentaJugador>();

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadores = (from solicitud in contexto.SolicitudAmistad
                                 where solicitud.JugadorDestino.NombreJugador == nombreJugador &&
                                 solicitud.Estado == (int)EstadosSolicitudAmistad.SinAceptar
                                 select solicitud.JugadorOrigen).ToList();

                foreach (Jugador jugador in jugadores)
                {
                    jugadoresOrigenSolicitud.Add(new CuentaJugador
                    {
                        IdJugador = jugador.IdJugador,
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar
                    });
                }
            }

            return jugadoresOrigenSolicitud;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int idJugadorOrigen = (from jugador in contexto.Jugador
                                      where jugador.NombreJugador == nombreJugadorOrigen
                                      select jugador.IdJugador).FirstOrDefault();
                int idJugadorDestino = (from jugador in contexto.Jugador
                                       where jugador.NombreJugador == nombreJugadorDestino
                                       select jugador.IdJugador).FirstOrDefault();
                string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");

                if (idJugadorOrigen != 0 && idJugadorDestino != 0)
                {
                    SolicitudAmistad solicitud = new SolicitudAmistad
                    {
                        IdJugadorOrigen = idJugadorOrigen,
                        IdJugadorDestino = idJugadorDestino,
                        FechaEnvioSolicitud = fechaActual,
                        Estado = (int)EstadosSolicitudAmistad.SinAceptar
                    };

                    contexto.SolicitudAmistad.Add(solicitud);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var solicitudesAmistad = from solicitud in contexto.SolicitudAmistad
                                         where solicitud.JugadorOrigen.NombreJugador ==
                                         nombreJugadorOrigen &&
                                         solicitud.JugadorDestino.NombreJugador ==
                                         nombreJugadorDestino &&
                                         solicitud.Estado == 
                                         (int)EstadosSolicitudAmistad.SinAceptar
                                         select solicitud;

                if (solicitudesAmistad.Any())
                {
                    solicitudesAmistad.First().Estado = (int)EstadosSolicitudAmistad.Aceptada;
                    resultado = contexto.SaveChanges() > 0;

                    if (ExisteSolicitudDeAmistadSinAceptar(nombreJugadorDestino, 
                        nombreJugadorOrigen))
                    {
                        AceptarSolicitudDeAmistad(nombreJugadorDestino, nombreJugadorOrigen);
                    }

                }
            }

            return resultado;
        }

        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, string nombreJugador2)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int idJugador1 = (from jugador in contexto.Jugador
                                 where jugador.NombreJugador == nombreJugador1
                                 select jugador.IdJugador).FirstOrDefault();
                int idJugador2 = (from jugador in contexto.Jugador
                                 where jugador.NombreJugador == nombreJugador2
                                 select jugador.IdJugador).FirstOrDefault();

                if (idJugador1 != 0 && idJugador2 != 0)
                {
                    Amigo amigo = new Amigo
                    {
                        IdJugador1 = idJugador1,
                        IdJugador2 = idJugador2
                    };

                    contexto.Amigo.Add(amigo);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugador1, string nombreJugador2)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var amistadesObtenidas = from amistad in contexto.Amigo
                                         where amistad.Jugador1.NombreJugador ==
                                         nombreJugador1 &&
                                         amistad.Jugador2.NombreJugador ==
                                         nombreJugador2 ||
                                         amistad.Jugador1.NombreJugador ==
                                         nombreJugador2 &&
                                         amistad.Jugador2.NombreJugador ==
                                         nombreJugador1
                                         select amistad;

                if (amistadesObtenidas.Any())
                {
                    contexto.Amigo.Remove(amistadesObtenidas.First());
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var solicitudesAmistad = from solicitud in contexto.SolicitudAmistad
                                       where solicitud.JugadorOrigen.NombreJugador ==
                                       nombreJugadorOrigen &&
                                       solicitud.JugadorDestino.NombreJugador ==
                                       nombreJugadorDestino
                                       select solicitud;

                if (solicitudesAmistad.Any())
                {
                    solicitudesAmistad.First().Estado = (int)EstadosSolicitudAmistad.Rechazada;                    
                }

                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int numeroCoincidencias = (from solicitud in contexto.SolicitudAmistad
                                               where solicitud.JugadorOrigen.NombreJugador ==
                                               nombreJugadorOrigen &&
                                               solicitud.JugadorDestino.NombreJugador ==
                                               nombreJugadorDestino &&
                                               solicitud.Estado == (int)EstadosSolicitudAmistad.SinAceptar
                                               select solicitud).Count();

                if (numeroCoincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int coincidencias = (from amigo in contexto.Amigo
                                    where amigo.Jugador1.NombreJugador == nombreJugador1 &&
                                    amigo.Jugador2.NombreJugador == nombreJugador2 ||
                                    amigo.Jugador1.NombreJugador == nombreJugador2 &&
                                    amigo.Jugador2.NombreJugador == nombreJugador1
                                    select amigo).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}