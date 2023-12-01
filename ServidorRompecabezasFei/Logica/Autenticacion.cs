using Datos;
using System.Linq;

namespace Logica
{
    public static class Autenticacion
    {
        public static CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
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
                                    Contrasena = cuenta.Contrasena,
                                    EsInvitado = false,
                                    Puntaje = 0,
                                    EstadoConectividad = ConectividadJugador.Disponible,                                    
                                }).FirstOrDefault();
            }

            return cuentaJugador;
        }
    }
}