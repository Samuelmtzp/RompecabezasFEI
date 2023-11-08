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
                                       where amigo.NombreJugadorA.Equals(jugador.NombreJugador) &&
                                       jugador.NombreJugador.Equals(nombreJugador) 
                                       select amigo.JugadorB).Concat(
                                       from jugador in contexto.Jugador
                                       from amigo in contexto.Amigo
                                       where amigo.NombreJugadorB.Equals(jugador.NombreJugador) &&
                                       jugador.NombreJugador.Equals(nombreJugador)
                                       select amigo.JugadorA).ToList();

                foreach (Jugador jugador in amigosObtenidos)
                {
                    amigos.Add(new CuentaJugador
                    {
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
                                 where solicitud.JugadorDestino.NombreJugador.
                                 Equals(nombreJugador) &&
                                 solicitud.Estado.Equals(EstadoSolicitudAmistad.SinAceptar)
                                 select solicitud.JugadorOrigen).ToList();

                foreach (Jugador jugador in jugadores)
                {
                    jugadoresOrigenSolicitud.Add(new CuentaJugador
                    {
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
                ConsultasJugador consultasJugador = new ConsultasJugador();
                bool existenAmbosJugadores = false;

                if (consultasJugador.ExisteNombreJugador(nombreJugadorOrigen) && 
                    consultasJugador.ExisteNombreJugador(nombreJugadorDestino))
                {
                    existenAmbosJugadores = true;
                }

                if (existenAmbosJugadores)
                {
                    SolicitudAmistad solicitud = new SolicitudAmistad
                    {
                        NombreJugadorOrigen = nombreJugadorOrigen,
                        NombreJugadorDestino = nombreJugadorDestino,
                        FechaEnvioSolicitud = DateTime.Today,
                        Estado = (int)EstadoSolicitudAmistad.SinAceptar
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
                var solicitudAmistadObtenida = contexto.SolicitudAmistad.
                    FirstOrDefault(solicitud => 
                    solicitud.JugadorOrigen.NombreJugador.Equals(nombreJugadorOrigen) &&
                    solicitud.JugadorDestino.NombreJugador.Equals(nombreJugadorDestino) &&
                    solicitud.Estado.Equals(EstadoSolicitudAmistad.SinAceptar));

                if (solicitudAmistadObtenida != null)
                {
                    solicitudAmistadObtenida.Estado = EstadoSolicitudAmistad.Aceptada;
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

        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                ConsultasJugador consultasJugador = new ConsultasJugador();
                bool existenAmbosJugadores = false;

                if (consultasJugador.ExisteNombreJugador(nombreJugadorA) &&
                    consultasJugador.ExisteNombreJugador(nombreJugadorB))
                {
                    existenAmbosJugadores = true;
                }

                if (existenAmbosJugadores)
                {
                    Amigo amigo = new Amigo
                    {
                        NombreJugadorA = nombreJugadorA,
                        NombreJugadorB = nombreJugadorB
                    };

                    contexto.Amigo.Add(amigo);
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA, string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var amistadObtenida = contexto.Amigo.FirstOrDefault(amistad => 
                    amistad.JugadorA.NombreJugador.Equals(nombreJugadorA) &&
                    amistad.JugadorB.NombreJugador.Equals(nombreJugadorB) ||
                    amistad.JugadorA.NombreJugador.Equals(nombreJugadorB) &&
                    amistad.JugadorB.NombreJugador.Equals(nombreJugadorA));

                if (amistadObtenida != null)
                {
                    contexto.Amigo.Remove(amistadObtenida);
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
                var solicitudAmistadObtenida = contexto.SolicitudAmistad.
                    FirstOrDefault(solicitud => 
                    solicitud.JugadorOrigen.NombreJugador.Equals(nombreJugadorOrigen) &&
                    solicitud.JugadorDestino.NombreJugador.Equals(nombreJugadorDestino));

                if (solicitudAmistadObtenida != null)
                {
                    solicitudAmistadObtenida.Estado = EstadoSolicitudAmistad.Rechazada;                    
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
                int coincidencias = (from solicitud in contexto.SolicitudAmistad
                                    where solicitud.JugadorOrigen.NombreJugador.
                                    Equals(nombreJugadorOrigen) &&
                                    solicitud.JugadorDestino.NombreJugador.
                                    Equals(nombreJugadorDestino) &&
                                    solicitud.Estado == EstadoSolicitudAmistad.SinAceptar
                                    select solicitud).Count();

                if (coincidencias > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                int coincidencias = (from amigo in contexto.Amigo
                                    where amigo.JugadorA.NombreJugador.Equals(nombreJugadorA) &&
                                    amigo.JugadorB.NombreJugador.Equals(nombreJugadorB) ||
                                    amigo.JugadorA.NombreJugador.Equals(nombreJugadorB) &&
                                    amigo.JugadorB.NombreJugador.Equals(nombreJugadorA)
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