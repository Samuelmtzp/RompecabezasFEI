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
    public partial class ServicioRompecabezasFei : IServicioJugador
    {
        public bool Registrar(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool resultado;

            try
            {                
                resultado = registro.Registrar(cuentaJugador);
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

        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaAutenticacion = null;
            
            if (ExisteNombreJugador(nombreJugador) && 
                !jugadoresConectados.ContainsKey(nombreJugador))
            {
                try
                {
                    Autenticacion autenticacion = new Autenticacion();
                    cuentaAutenticacion = autenticacion.IniciarSesion(nombreJugador, contrasena);
                    cuentaAutenticacion.EstadoConectividad = EstadoConectividadJugador.Conectado;
                    cuentaAutenticacion.OperacionesContexto = new GestionContexto();                    
                    CuentaJugador nuevaCuentaJugador = new CuentaJugador
                    {
                        NombreJugador = cuentaAutenticacion.NombreJugador,
                        NumeroAvatar = cuentaAutenticacion.NumeroAvatar,
                        EstadoConectividad = cuentaAutenticacion.EstadoConectividad,
                        OperacionesContexto = cuentaAutenticacion.OperacionesContexto,
                    };
                    jugadoresConectados[cuentaAutenticacion.NombreJugador] = nuevaCuentaJugador;
                    NotificarConexionJugadorAOtrosJugadores(cuentaAutenticacion.NombreJugador,
                        cuentaAutenticacion.EstadoConectividad);
                }
                catch (EntityException)
                {
                    // log
                }
            }

            return cuentaAutenticacion;
        }

        public bool CerrarSesion(string nombreJugador)
        {
            bool resultado = false;

            if (jugadoresConectados.ContainsKey(nombreJugador))
            {
                resultado = jugadoresConectados.Remove(nombreJugador); 
                NotificarConexionJugadorAOtrosJugadores(
                    nombreJugador, EstadoConectividadJugador.Desconectado);                
            }

            return resultado;
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
        private readonly List<Logica.Sala> salasActivas = new List<Logica.Sala>();

        public void CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            Logica.Sala nuevaSala = new Logica.Sala()
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
            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(
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
            bool existeJugador = jugadoresConectados.ContainsKey(nombreJugador);

            if (existeJugador)
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioJuego = OperationContext.Current;
                Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(
                sala => sala.CodigoSala.Equals(codigoSala));

                if (salaEncontrada.ExisteCupoJugadores())
                {
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeBienvenida);
                }

                salaEncontrada.Jugadores.Add(jugadoresConectados[nombreJugador]);
                salaEncontrada.ContadorJugadoresActuales++;
            }
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, 
            string codigoSala, string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));

            if (salaEncontrada != null)
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    FirstOrDefault(cuentaJugador =>
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

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, 
            string mensaje)
        {
            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));
            
            foreach (CuentaJugador cuentaJugador in salaEncontrada.Jugadores)
            {
                string horaActual = DateTime.Now.ToShortTimeString();
                string mensajeFinal = horaActual + $" {nombreJugador}: {mensaje}";
                
                if (cuentaJugador.OperacionesContexto.ContextoIServicioJuego != null)
                {
                    cuentaJugador.OperacionesContexto.ContextoIServicioJuego.
                    GetCallbackChannel<IServicioJuegoCallback>().
                    MostrarMensajeDeSala(mensajeFinal);
                }                
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
        private readonly Dictionary<string, CuentaJugador> jugadoresConectados =
            new Dictionary<string, CuentaJugador>();

        private void NotificarConexionJugadorAOtrosJugadores(string nombreJugador,
            EstadoConectividadJugador estado)
        {
            foreach (CuentaJugador cuenta in jugadoresConectados.Values)
            {
                if (ExisteAmistadConJugador(nombreJugador, cuenta.NombreJugador) &&
                    EsJugadorSuscritoANotififacionesDeAmistades(cuenta.NombreJugador))
                {
                    cuenta.OperacionesContexto.ContextoIServicioAmistades.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        NotificarEstadoConectividadDeJugador(nombreJugador, estado);
                }
            }
        }

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

            if (cuentasJugador != null)
            {
                cuentasJugador = AgregarEstadoConectividadACuentasDeJugador(cuentasJugador);
            }

            return cuentasJugador;
        }

        private List<CuentaJugador> AgregarEstadoConectividadACuentasDeJugador(
            List<CuentaJugador> cuentasJugador)
        {
            List<CuentaJugador> cuentasConEstadoConectividad = new List<CuentaJugador>();

            foreach (CuentaJugador cuenta in cuentasJugador)
            {
                if (jugadoresConectados.ContainsKey(cuenta.NombreJugador))
                {
                    cuenta.EstadoConectividad = jugadoresConectados[cuenta.NombreJugador].
                        EstadoConectividad;
                }
                else
                {
                    cuenta.EstadoConectividad = EstadoConectividadJugador.Desconectado;
                }

                cuentasConEstadoConectividad.Add(cuenta);
            }

            return cuentasConEstadoConectividad;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(string nombreJugador)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmigosJugador.
                    ObtenerJugadoresConSolicitudPendiente(nombreJugador);
            }
            catch (EntityException)
            {
                // log
            }

            if (cuentasJugador != null)
            {
                cuentasJugador = AgregarEstadoConectividadACuentasDeJugador(cuentasJugador);
            }

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool esSolicitudEnviada = false; 
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();

            try
            {
                esSolicitudEnviada = gestionAmigosJugador.EnviarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            if (esSolicitudEnviada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorDestino))
            {
                jugadoresConectados[nombreJugadorDestino].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarSolicitudAmistadEnviada(jugadoresConectados[nombreJugadorOrigen]);
            }

            return esSolicitudEnviada;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool esSolicitudAceptada = false;
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
                
            try
            {
                esSolicitudAceptada = gestionAmigosJugador.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            if (esSolicitudAceptada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorOrigen))
            {
                jugadoresConectados[nombreJugadorOrigen].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarSolicitudAmistadAceptada(jugadoresConectados[nombreJugadorDestino]);
            }

            return esSolicitudAceptada;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA,
            string nombreJugadorB)
        {
            bool esAmistadEliminada = false;
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();

            try
            {
                esAmistadEliminada = gestionAmigosJugador.EliminarAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {
                // log
            }

            if (esAmistadEliminada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorB))
            {
                jugadoresConectados[nombreJugadorB].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarAmistadEliminada(nombreJugadorA);
            }

            return esAmistadEliminada;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.EliminarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {
                // log
            }

            return resultado;
        }

        public bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmigosJugador gestionAmigosJugador = new GestionAmigosJugador();
            bool resultado = false;

            try
            {
                resultado = gestionAmigosJugador.ExisteSolicitudDeAmistad(
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

        public bool SuscribirJugadorANotificacionesAmistades(string nombreJugador)
        {
            bool resultado = false;

            if (!EsJugadorSuscritoANotififacionesDeAmistades(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioAmistades = OperationContext.Current;
                resultado = true;
            }

            return resultado;
        }        

        public bool DesuscribirJugadorDeNotificacionesAmistades(string nombreJugador)
        {
            bool resultado = false;

            if (EsJugadorSuscritoANotififacionesDeAmistades(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioAmistades = null;
                resultado = true;
            }

            return resultado;
        }

        public bool EsJugadorSuscritoANotififacionesDeAmistades(string nombreJugador)
        {
            bool resultado = false;

            if (jugadoresConectados.ContainsKey(nombreJugador) &&
                jugadoresConectados[nombreJugador].OperacionesContexto.
                ContextoIServicioAmistades != null)
            {
                resultado = true;
            }

            return resultado;
        }
    }
    #endregion
}