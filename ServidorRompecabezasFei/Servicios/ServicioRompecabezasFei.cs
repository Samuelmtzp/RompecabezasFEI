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
            bool estadoRegistro;
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                    Contrasena = cuentaJugador.Contrasena,
                    Correo = cuentaJugador.Correo,
                };
                estadoRegistro = registro.Registrar(cuentaJugadorRegistro);
            }
            catch (EntityException)
            {
                estadoRegistro = false;
            }
            return estadoRegistro;
        }

        public bool ActualizarInformacion(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool estadoActualizar;
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    IdJugador = cuentaJugador.IdJugador,
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                };
                estadoActualizar = registro.ActualizarInformacion(cuentaJugadorRegistro);
            }
            catch(EntityException)
            {
                estadoActualizar = false;
            }
            return estadoActualizar;
        }

        public bool ActualizarContrasena(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool estadoActualizar;
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    IdCuenta = cuentaJugador.IdCuenta,
                    Contrasena = cuentaJugador.Contrasena,
                };
                estadoActualizar = registro.ActualizarContrasena(cuentaJugadorRegistro);
            }
            catch (EntityException)
            {
                estadoActualizar = false;
            }
            return estadoActualizar;
        }

        public bool RestablecerContrasena(string correo, string contrasena)
        {
            Registro registro = new Registro();
            bool estadoActualizar;
            try
            {
                estadoActualizar = registro.RestablecerContrasena(correo, contrasena);
            }
            catch (EntityException)
            {
                estadoActualizar = false;
            }
            return estadoActualizar;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeNombreJugador;
            try
            {
                existeNombreJugador = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {
                existeNombreJugador = false;
            }
            return existeNombreJugador;
        }     
        
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeCorreo;
            try
            {
                existeCorreo = consultasJugador.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {
                existeCorreo = false;
            }
            return existeCorreo;
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
            bool resultado = generadorMensajesCorreo.EnviarMensaje(
                encabezado, correoDestino, asunto, mensaje);
            
            return resultado;
        }

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasJugadas = consultasJugador.
                ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasGanadas = consultasJugador.
                ObtenerNumeroPartidasGanadas(nombreJugador);
            
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
            List<CuentaJugador> cuentasJugador = gestionAmigosJugador.ObtenerAmigosDeJugador(
                nombreJugador);

            return cuentasJugador;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
            string nombreJugador)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            List<CuentaJugador> cuentasJugador = gestionAmigosJugador.
                ObtenerJugadoresConSolicitudDeAmistadSinAceptar(nombreJugador);

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.EnviarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);

            return resultado;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.AceptarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);

            return resultado;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.RechazarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);

            return resultado;
        }

        public bool ExisteSolicitudDeAmistadSinAceptar(string nombreJugadorOrigen, string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.ExisteSolicitudDeAmistadSinAceptar(
                nombreJugadorOrigen, nombreJugadorDestino);

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugador1, string nombreJugador2)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.ExisteAmistadConJugador(
                nombreJugador1, nombreJugador2);

            return resultado;
        }

        public bool RegistrarNuevaAmistadEntreJugadores(string nombreJugador1, string nombreJugador2)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = gestionAmigosJugador.RegistrarNuevaAmistadEntreJugadores(
                nombreJugador1, nombreJugador2);

            return resultado;
        }
    }
    #endregion
}