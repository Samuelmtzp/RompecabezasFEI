using Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Logica
{
    public class Registro
    {
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
    }
}
