using Datos;
using System.Linq;

namespace Logica
{
    public class Autenticacion
    {
        public Logica.CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            Logica.CuentaJugador cuentaJugador = new Logica.CuentaJugador();
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasJugador = (from jugadores in contexto.Jugador
                                join cuentas in contexto.Cuenta
                                on jugadores.Cuenta.IdCuenta equals cuentas.IdCuenta
                                where jugadores.NombreJugador == nombreJugador &&
                                cuentas.Contrasena == contrasena
                                select new Logica.CuentaJugador
                                {
                                    IdJugador = jugadores.IdJugador,
                                    NumeroAvatar = jugadores.NumeroAvatar,
                                    NombreJugador = jugadores.NombreJugador, 
                                    IdCuenta = cuentas.IdCuenta,
                                    Correo = cuentas.Correo,
                                    Contrasena = cuentas.Contrasena
                                });
                if (cuentasJugador.Any())
                {
                    cuentaJugador.IdJugador = cuentasJugador.First().IdJugador; 
                    cuentaJugador.NumeroAvatar = cuentasJugador.First().NumeroAvatar;
                    cuentaJugador.NombreJugador = cuentasJugador.First().NombreJugador;
                    cuentaJugador.Correo = cuentasJugador.First().Correo;
                    cuentaJugador.Contrasena = cuentasJugador.First().Contrasena;
                    cuentaJugador.IdCuenta = cuentasJugador.First().IdCuenta;
                }
            }
            return cuentaJugador;
        }
    }
}
