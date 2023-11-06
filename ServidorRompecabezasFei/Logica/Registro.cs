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

        public bool ActualizarInformacion(CuentaJugador cuentaJugadorModificacion)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var jugadoresObtenidos = from jugador in contexto.Jugador
                                       where jugador.IdJugador ==
                                       cuentaJugadorModificacion.IdJugador
                                       select jugador;

                if (jugadoresObtenidos.Any())
                {
                    jugadoresObtenidos.First().NombreJugador = cuentaJugadorModificacion.NombreJugador;
                    jugadoresObtenidos.First().NumeroAvatar = cuentaJugadorModificacion.NumeroAvatar;
                }

                //var Jugador = contexto.Jugador.Where(x => x.IdJugador == 
                //    cuentaJugadorModificacion.IdJugador).ToList();
                //Jugador[cuentaJugadorModificacion.IdJugador - 1].NombreJugador = 
                //    cuentaJugadorModificacion.NombreJugador;
                //Jugador[cuentaJugadorModificacion.IdJugador - 1].NumeroAvatar = 
                //    cuentaJugadorModificacion.NumeroAvatar;
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public bool ActualizarContrasena(CuentaJugador cuentaJugadorModificacion)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasObtenidas = from cuenta in contexto.Cuenta
                                       where cuenta.Jugador.IdJugador == 
                                       cuentaJugadorModificacion.IdJugador
                                       select cuenta;
                
                if (cuentasObtenidas.Any())
                {
                    cuentasObtenidas.First().Contrasena = cuentaJugadorModificacion.Contrasena;
                }

                //var Cuenta = contexto.Cuenta.Where(x => x.IdCuenta == cuentaJugadorModificacion.IdCuenta).ToList();
                //Cuenta[(cuentaJugadorModificacion.IdCuenta) - 1].Contrasena = cuentaJugadorModificacion.Contrasena;
                resultado = contexto.SaveChanges() > 0;
            }

            return resultado;
        }

        public bool RestablecerContrasena(string correo, string contrasena)
        {
            bool resultado = false;

            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuenta = contexto.Cuenta.SingleOrDefault(x => x.Correo == correo);

                if (cuenta != null)
                {
                    cuenta.Contrasena = contrasena;
                    resultado = contexto.SaveChanges() > 0;
                }
            }

            return resultado;
        }
    }
}
