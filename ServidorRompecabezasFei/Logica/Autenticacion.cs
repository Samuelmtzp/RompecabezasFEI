using Datos;
using System.Linq;

namespace Logica
{
    public class Autenticacion
    {
        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaJugador = new CuentaJugador();
            using (EntidadesRompecabezasFei contexto = new EntidadesRompecabezasFei())
            {
                var cuentaJugadorConsulta = from jugador in contexto.Jugador join cuenta 
                    in contexto.Cuenta on jugador.Cuenta.IdCuenta equals cuenta.IdCuenta
                    where jugador.NombreJugador == nombreJugador && cuenta.Contrasena == contrasena
                    select new Logica.CuentaJugador
                    {
                        IdJugador = jugador.IdJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        NombreJugador = jugador.NombreJugador, 
                        IdCuenta = cuenta.IdCuenta,
                        Correo = cuenta.Correo,
                        Contrasena = cuenta.Contrasena
                    };
                if (cuentaJugadorConsulta.Any())
                {
                    cuentaJugador.IdJugador = cuentaJugadorConsulta.First().IdJugador; 
                    cuentaJugador.NumeroAvatar = cuentaJugadorConsulta.First().NumeroAvatar;
                    cuentaJugador.NombreJugador = cuentaJugadorConsulta.First().NombreJugador;
                    cuentaJugador.Correo = cuentaJugadorConsulta.First().Correo;
                    cuentaJugador.Contrasena = cuentaJugadorConsulta.First().Contrasena;
                    cuentaJugador.IdCuenta = cuentaJugadorConsulta.First().IdCuenta;
                }
            }
            return cuentaJugador;
        }
    }
}
