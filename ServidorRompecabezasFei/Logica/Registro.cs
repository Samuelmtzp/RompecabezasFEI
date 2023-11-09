using Datos;
using System.Linq;

namespace Logica
{
    public class Registro
    {
        public bool Registrar(CuentaJugador cuentaJugadorRegistro)
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

        public bool ActualizarInformacion(string nombreAnterior, 
            string nuevoNombre, int nuevoNumeroAvatar)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadorObtenido = contexto.Jugador.FirstOrDefault(jugador =>
                    jugador.NombreJugador == nombreAnterior);

                if (jugadorObtenido != null)
                {
                    jugadorObtenido.NombreJugador = nuevoNombre;
                    jugadorObtenido.NumeroAvatar = nuevoNumeroAvatar;
                }
                
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentaObtenida = contexto.Cuenta.FirstOrDefault(cuenta => 
                    cuenta.Correo.Equals(correo));

                if (cuentaObtenida != null)
                {
                    cuentaObtenida.Contrasena = contrasena;
                }

                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }
    }
}