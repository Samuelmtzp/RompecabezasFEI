using Datos;
using System.Linq;

namespace Logica.AccesoDatos
{
    public static class AccesoCuentaJugador
    {
        public static CuentaJugador IniciarSesion(string nombreJugador, 
            string contrasena)
        {
            CuentaJugador cuentaJugador = null;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                cuentaJugador = (from jugador in contexto.Jugador
                                 join cuenta in contexto.Cuenta
                                 on jugador.Cuenta.Correo
                                 equals cuenta.Correo
                                 where jugador.NombreJugador == nombreJugador &&
                                 cuenta.Contrasena == contrasena
                                 select new CuentaJugador
                                 {
                                     IdJugador = jugador.IdJugador,
                                     NumeroAvatar = jugador.NumeroAvatar,
                                     NombreJugador = jugador.NombreJugador,
                                     Correo = cuenta.Correo,
                                     EsInvitado = false,
                                     Puntaje = Pieza.PuntajeVacio,
                                     Estado = Enumeraciones.EstadoJugador.Disponible,
                                 }).FirstOrDefault();
            }

            return cuentaJugador;
        }

        public static bool RegistrarJugador(CuentaJugador cuentaJugadorRegistro)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                Cuenta nuevaCuenta = new Cuenta()
                {
                    Correo = cuentaJugadorRegistro.Correo,
                    Contrasena = cuentaJugadorRegistro.Contrasena,
                };
                Jugador nuevoJugador = new Jugador()
                {
                    NombreJugador = cuentaJugadorRegistro.NombreJugador,
                    NumeroAvatar = cuentaJugadorRegistro.NumeroAvatar,
                };
                contexto.Jugador.Add(nuevoJugador);
                contexto.Cuenta.Add(nuevaCuenta);
                nuevoJugador.Cuenta = nuevaCuenta;
                nuevaCuenta.Jugador = nuevoJugador;
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public static bool ActualizarNombreJugador(string nombreAnterior, 
            string nuevoNombre)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadorActual = contexto.Jugador.
                    Where(jugador => jugador.NombreJugador == nombreAnterior).
                    FirstOrDefault();

                if (jugadorActual != null)
                {
                    jugadorActual.NombreJugador = nuevoNombre;
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool ActualizarNumeroAvatar(string nombreJugador, 
            int nuevoNumeroAvatar)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadorActual = contexto.Jugador.
                    Where(jugador => jugador.NombreJugador == nombreJugador).
                    FirstOrDefault();

                if (jugadorActual != null)
                {
                    jugadorActual.NumeroAvatar = nuevoNumeroAvatar;
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }

        public static bool ActualizacionContrasena(string contrasenaNueva, string correo)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentaObtenida = contexto.Cuenta.
                    FirstOrDefault(cuenta => cuenta.Correo == correo);

                if (cuentaObtenida != null)
                {
                    cuentaObtenida.Contrasena = contrasenaNueva;
                }

                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public static bool ExisteNombreJugadorRegistrado(string nombreJugador)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                resultado = (from jugador in contexto.Jugador 
                            where jugador.NombreJugador == nombreJugador 
                            select jugador).Any();
            }

            return resultado;
        }

        public static bool ExisteCorreoRegistrado(string correo)
        {
            bool resultado = false;
            
            using (var contexto = new EntidadesRompecabezasFei())
            {
                resultado = (from cuenta in contexto.Cuenta 
                            where cuenta.Correo == correo
                            select cuenta).Any();
            }

            return resultado;
        }

        public static bool HayCoincidenciasEnContrasenaDeJugador(
            string nombreJugador, string contrasena)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                resultado = (from cuenta in contexto.Cuenta
                            join jugador in contexto.Jugador
                            on cuenta.Jugador.NombreJugador 
                            equals jugador.NombreJugador
                            where cuenta.Contrasena == contrasena &&
                            jugador.NombreJugador == nombreJugador
                            select cuenta).Any();
            }

            return resultado;
        }        
    }
}