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
                // log
            }

            return resultado;
        }

        public bool ActualizarInformacion(string nombreAnterior,
            string nuevoNombre, int nuevoNumeroAvatar)
        {
            Registro registro = new Registro();
            bool resultado;

            try
            {
                resultado = registro.ActualizarInformacion(nombreAnterior, 
                    nuevoNombre, nuevoNumeroAvatar);
            }
            catch(EntityException)
            {
                resultado = false;
                // log
            }
            
            return resultado;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            Registro registro = new Registro();
            bool resultado;
            
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    Correo = correo,
                    Contrasena = contrasena,
                };
                resultado = registro.ActualizarContrasena(correo, contrasena);
            }
            catch (EntityException)
            {
                resultado = false;
                // log
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
                // log
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
                // log
            }

            return resultado;
        }

        public CuentaJugador IniciarSesion(string nombreUsuario, string contrasena)
        {
            CuentaJugador cuentaJugador = null;
            
            try
            {
                Autenticacion autenticacion = new Autenticacion();
                cuentaJugador = autenticacion.IniciarSesion(nombreUsuario, contrasena);
            }
            catch (EntityException)
            {
                // log
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
                // log
            }
            
            return resultado;
        }

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasJugadas = 0;

            try
            {
                numeroPartidasJugadas = consultasJugador.
                    ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            }
            catch (EntityException)
            {
                // log
            }
            
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasGanadas = 0;

            try
            {
                numeroPartidasGanadas = consultasJugador.
                    ObtenerNumeroPartidasGanadas(nombreJugador);
            }
            catch (EntityException)
            {
                // log
            }
            
            return numeroPartidasGanadas;
        }        
    }
    #endregion

    #region IServicioJuego
    public partial class ServicioRompecabezasFei : IServicioJuego
    {
        private readonly List<Sala> salasActivas = new List<Sala>();        

        public void NuevaSala(string nombreAnfitrion, string codigoSala)
        {
            Sala nuevaSala = new Sala()
            {
                CodigoSala = codigoSala,
                NombreAnfitrion = nombreAnfitrion,
                ContadorJugadoresActuales = 0,
                Jugadores = new List<CuentaJugador>()
            };
            salasActivas.Add(nuevaSala);
        }

        public bool ExisteSalaDisponible(string codigoSala)
        {
            bool resultado = false;
            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.CodigoSala.Equals(codigoSala));
            
            if (salaEncontrada != null && salaEncontrada.ExisteCupoJugadores())
            {
                resultado = true;
            }

            return resultado;
        }

        public void ConectarCuentaJugadorASala(string nombreJugador, string codigoSala, 
            string mensajeBienvenida)
        {
            CuentaJugador cuentaJugador = new CuentaJugador()
            {
                NombreJugador = nombreJugador,
                ContextoOperacion = OperationContext.Current,
            };

            Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.CodigoSala.Equals(codigoSala));
            
            if (salaEncontrada.ExisteCupoJugadores())
            {
                EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeBienvenida);
            }

            salaEncontrada.Jugadores.Add(cuentaJugador);
            salaEncontrada.ContadorJugadoresActuales++;
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, string codigoSala, 
            string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));

            if (salaEncontrada != null)
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.FirstOrDefault(cuentaJugador =>
                    cuentaJugador.NombreJugador == nombreJugador);
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
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeDespedida);
                }
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, string mensaje)
        {
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));
            
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
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmigosJugador.ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException)
            {
                // log
            }

            return cuentasJugador;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
            string nombreJugador)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmigosJugador.
                    ObtenerJugadoresConSolicitudDeAmistadSinAceptar(nombreJugador);
            }
            catch (EntityException)
            {
                // log
            }

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.EnviarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.ExisteSolicitudDeAmistadSinAceptar(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.ExisteAmistadConJugador(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugadorA, 
            string nombreJugadorB)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.RegistrarNuevaAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA, 
            string nombreJugadorB)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.EliminarAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }
    }
    #endregion
}