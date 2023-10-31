using Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Logica
{
    public class Registro
    {
        int idCuenta;
        public bool Registrar(CuentaJugador cuentaJugadorRegistro)
        {
            bool estadoRegistro = false;
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
                estadoRegistro = contexto.SaveChanges() > 0;
            }
            return estadoRegistro;
        }

        public bool ActualizarInformacion(CuentaJugador cuentaJugadorRegistro)
        {
            bool informacionActualizada = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var Jugador = contexto.Jugador.Where(x => x.IdJugador ==
                        cuentaJugadorRegistro.IdJugador).ToList();
                Jugador[(cuentaJugadorRegistro.IdJugador) - 1].NombreJugador = cuentaJugadorRegistro.NombreJugador;
                Jugador[(cuentaJugadorRegistro.IdJugador) - 1].NumeroAvatar = cuentaJugadorRegistro.NumeroAvatar;
                informacionActualizada = contexto.SaveChanges() > 0;
            }
            return informacionActualizada;
        }

        public bool ActualizarContrasena(CuentaJugador cuentaJugadorRegistro)
        {
            bool informacionActualizada = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var Cuenta = contexto.Cuenta.Where(x => x.IdCuenta ==
                        cuentaJugadorRegistro.IdCuenta).ToList();
                Cuenta[(cuentaJugadorRegistro.IdCuenta) - 1].Contrasena = cuentaJugadorRegistro.Contrasena;
                informacionActualizada = contexto.SaveChanges() > 0;
            }
            return informacionActualizada;
        }

        public bool RestablecerContrasena(string correo, string contrasena)
        {
            bool informacionActualizada = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuenta = contexto.Cuenta.SingleOrDefault(x => x.Correo == correo);

                if (cuenta != null)
                {
                    cuenta.Contrasena = contrasena;
                    contexto.SaveChanges();
                    informacionActualizada = true;
                }
            }
            return informacionActualizada;
        }

    }
}
