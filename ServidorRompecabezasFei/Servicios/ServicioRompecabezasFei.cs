using Contratos;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;

namespace Servicios
{
    #region IServicioGestionJugador
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioRompecabezasFei : IServicioGestionJugador
    {
        public bool Registrar(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool resultado;

            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                    Contrasena = cuentaJugador.Contrasena,
                    Correo = cuentaJugador.Correo,
                };
                resultado = registro.Registrar(cuentaJugadorRegistro);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ActualizarInformacion(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool resultado;

            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    IdJugador = cuentaJugador.IdJugador,
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                };
                resultado = registro.ActualizarInformacion(cuentaJugadorRegistro);
            }
            catch(EntityException)
            {
                resultado = false;
            }
            
            return resultado;
        }

        public bool ActualizarContrasena(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool resultado;
            
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    IdCuenta = cuentaJugador.IdCuenta,
                    Contrasena = cuentaJugador.Contrasena,
                };
                resultado = registro.ActualizarContrasena(cuentaJugadorRegistro);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool RestablecerContrasena(string correo, string contrasena)
        {
            Registro registro = new Registro();
            bool resultado;
            
            try
            {
                resultado = registro.RestablecerContrasena(correo, contrasena);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool resultado;
            
            try
            {
                resultado = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }     
        
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool resultado;
            
            try
            {
                resultado = consultasJugador.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public CuentaJugador IniciarSesion(string nombreUsuario, string contrasena)
        {
            CuentaJugador cuentaJugador = new CuentaJugador();
            
            try
            {
                Autenticacion autenticacion = new Autenticacion();
                cuentaJugador = autenticacion.IniciarSesion(nombreUsuario, contrasena);
            }
            catch (EntityException)
            {

            }

            return cuentaJugador;
        }

        public bool EnviarMensajeCorreo(string encabezado, string correoDestino, 
            string asunto, string mensaje)
        {
            GeneradorMensajesCorreo generadorMensajesCorreo = new GeneradorMensajesCorreo();
            bool resultado;
            
            try
            {
                resultado = generadorMensajesCorreo.EnviarMensaje(
                    encabezado, correoDestino, asunto, mensaje);
            }
            catch (EntityException)
            {
                resultado = false;
            }
            
            return resultado;
        }

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasJugadas;

            try
            {
                numeroPartidasJugadas = consultasJugador.
                    ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            }
            catch (EntityException)
            {
                numeroPartidasJugadas = 0;
            }
            
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasGanadas;

            try
            {
                numeroPartidasGanadas = consultasJugador.
                    ObtenerNumeroPartidasGanadas(nombreJugador);
            }
            catch (EntityException)
            {
                numeroPartidasGanadas = 0;
            }
            
            return numeroPartidasGanadas;
        }        
    }
    #endregion

    #region IServicioJuego
    public partial class ServicioRompecabezasFei : IServicioJuego
    {
        private List<Sala> salasActivas = new List<Sala>();        

        public void NuevaSala(string nombreAnfitrion, string idSala)
        {
            Sala nuevaSala = new Sala()
            {
                IdSala = idSala,
                NombreAnfitrion = nombreAnfitrion,
                ContadorJugadoresActuales = 0,
                Jugadores = new List<CuentaJugador>()
            };
            salasActivas.Add(nuevaSala);
        }

        public bool ExisteSalaDisponible(string idSala)
        {
            bool resultado = false;
            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.IdSala.Equals(idSala));
            
            if (salaEncontrada != null)
            {
                if (salaEncontrada.ExisteCupoJugadores())
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public void ConectarCuentaJugadorASala(string nombreJugador, string idSala, 
            string mensajeBienvenida)
        {
            CuentaJugador cuentaJugador = new CuentaJugador()
            {
                NombreJugador = nombreJugador,
                ContextoOperacion = OperationContext.Current,
            };

            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.IdSala.Equals(idSala));
            
            if (salaEncontrada.ExisteCupoJugadores())
            {
                EnviarMensajeDeSala(nombreJugador, idSala, mensajeBienvenida);
            }

            salaEncontrada.Jugadores.Add(cuentaJugador);
            salaEncontrada.ContadorJugadoresActuales++;
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala, 
            string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.IdSala.Equals(idSala));

            if (salaEncontrada != null)
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    FirstOrDefault(cuentaJugador => cuentaJugador.NombreJugador.
                    Equals(nombreJugador));
            }

            if (cuentaJugadorEncontrada != null)
            {
                salaEncontrada.Jugadores.Remove(cuentaJugadorEncontrada);
                salaEncontrada.ContadorJugadoresActuales--;
                
                if (salaEncontrada.EstaVacia())
                {
                    salasActivas.Remove(salaEncontrada);
                }
                else
                {
                    EnviarMensajeDeSala(nombreJugador, idSala, mensajeDespedida);
                }
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string idSala, string mensaje)
        {
            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.IdSala.Equals(idSala));
            
            foreach (CuentaJugador cuentaJugador in salaEncontrada.Jugadores)
            {
                string horaActual = DateTime.Now.ToShortTimeString();
                string mensajeFinal = horaActual + $" {nombreJugador}: {mensaje}";
                cuentaJugador.ContextoOperacion.GetCallbackChannel<IServicioJuegoCallback>().
                    MensajeDeSalaCallBack(mensajeFinal);
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            return Guid.NewGuid().ToString();
        }        
    }
    #endregion

    #region IServicioAmistades
    public partial class ServicioRompecabezasFei : IServicioAmistades
    {
        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            List<CuentaJugador> cuentasJugador;

            try
            {
                cuentasJugador = gestionAmigosJugador.
                    ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException)
            {
                cuentasJugador = null;
            }

            return cuentasJugador;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
            string nombreJugador)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            List<CuentaJugador> cuentasJugador;

            try
            {
                cuentasJugador = gestionAmigosJugador.
                    ObtenerJugadoresConSolicitudDeAmistadSinAceptar(nombreJugador);
            }
            catch (EntityException)
            {
                cuentasJugador = null;
            }

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.EnviarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.ExisteSolicitudDeAmistadSinAceptar(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.ExisteAmistadConJugador(
                    nombreJugador1, nombreJugador2);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, 
            string nombreJugador2)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.RegistrarNuevaAmistadEntreJugadores(
                    nombreJugador1, nombreJugador2);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugador1, 
            string nombreJugador2)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado;

            try
            {
                resultado = gestionAmigosJugador.EliminarAmistadEntreJugadores(
                    nombreJugador1, nombreJugador2);
            }
            catch (EntityException)
            {
                resultado = false;
            }

            return resultado;
        }
    }
    #endregion
}