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
            bool resultado = false;

            try
            {                
                resultado = registro.Registrar(cuentaJugador);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }

        public bool ActualizarInformacion(string nombreAnterior,
            string nuevoNombre, int nuevoNumeroAvatar)
        {
            Registro registro = new Registro();
            bool resultado = false;

            try
            {
                resultado = registro.ActualizarInformacion(nombreAnterior, 
                    nuevoNombre, nuevoNumeroAvatar);
            }
            catch (EntityException)
            {

            }
            
            return resultado;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            Registro registro = new Registro();
            bool resultado = false;
            
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

            }

            return resultado;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool resultado = false;
            
            try
            {
                resultado = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }               

        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaRecuperada = null;
            
            if (ExisteNombreJugador(nombreJugador) && 
                !jugadoresConectados.ContainsKey(nombreJugador))
            {
                try
                {
                    Autenticacion autenticacion = new Autenticacion();
                    cuentaRecuperada = autenticacion.IniciarSesion(nombreJugador, contrasena);

                    if (cuentaRecuperada != null)
                    {
                        cuentaRecuperada.EstadoConectividad = EstadoConectividadJugador.Conectado;
                        cuentaRecuperada.OperacionesContexto = new GestionContexto();
                        CuentaJugador cuentaAutenticada = new CuentaJugador
                        {
                            IdJugador = cuentaRecuperada.IdJugador,
                            NombreJugador = cuentaRecuperada.NombreJugador,
                            NumeroAvatar = cuentaRecuperada.NumeroAvatar,
                            EstadoConectividad = cuentaRecuperada.EstadoConectividad,
                            OperacionesContexto = cuentaRecuperada.OperacionesContexto,
                        };
                        jugadoresConectados[cuentaRecuperada.NombreJugador] = cuentaAutenticada;
                        NotificarConexionJugadorAOtrosJugadores(cuentaRecuperada.NombreJugador,
                            cuentaRecuperada.EstadoConectividad);
                    }
                }
                catch (EntityException)
                {

                }
            }

            return cuentaRecuperada;
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
    }
    #endregion

    public partial class ServicioRompecabezasFei : IServicioCorreo
    {
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool resultado = false;

            try
            {
                resultado = consultasJugador.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }

        public bool EnviarMensajeCorreo(string encabezado, string correoDestino,
            string asunto, string mensaje)
        {
            GeneradorMensajesCorreo generadorMensajesCorreo = new GeneradorMensajesCorreo();
            bool resultado = false;

            try
            {
                resultado = generadorMensajesCorreo.EnviarMensaje(
                    encabezado, correoDestino, asunto, mensaje);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }
    }


    #region IServicioJuego
    public partial class ServicioRompecabezasFei : IServicioSala
    {
        private readonly List<Sala> salasActivas = new List<Sala>();

        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            GestionSala gestionSala = new GestionSala();
            bool registroSalaRealizado = false;

            try
            {
                registroSalaRealizado = gestionSala.CrearNuevaSala(
                    nombreAnfitrion, codigoSala);
            }
            catch (EntityException)
            {

            }

            if (registroSalaRealizado)
            {
                Sala salaConectada = new Sala()
                {
                    CodigoSala = codigoSala,
                    NombreAnfitrion = nombreAnfitrion,
                    ContadorJugadoresActuales = 0,
                    Jugadores = new List<CuentaJugador>()
                };
                salasActivas.Add(salaConectada);
            }

            return registroSalaRealizado;
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
            if (jugadoresConectados.ContainsKey(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioSala = OperationContext.Current;
                Sala salaEncontrada = salasActivas.FirstOrDefault(
                    sala => sala.CodigoSala.Equals(codigoSala));

                if (salaEncontrada.ExisteCupoJugadores())
                {
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeBienvenida);
                    NotificarNuevoJugadorConectadoASala(
                        jugadoresConectados[nombreJugador], codigoSala);
                }

                salaEncontrada.Jugadores.Add(jugadoresConectados[nombreJugador]);
                salaEncontrada.ContadorJugadoresActuales++;
            }
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, 
            string codigoSala, string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));

            if (salaEncontrada != null)
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    FirstOrDefault(cuentaJugador =>
                    cuentaJugador.NombreJugador == nombreJugador);                
            }

            if (cuentaJugadorEncontrada != null)
            {
                if (jugadoresConectados.ContainsKey(nombreJugador))
                {
                    jugadoresConectados[nombreJugador].OperacionesContexto.
                        ContextoIServicioSala = null;
                }

                salaEncontrada.Jugadores.Remove(cuentaJugadorEncontrada);
                salaEncontrada.ContadorJugadoresActuales--;
                
                if (salaEncontrada.EstaVacia())
                {
                    salasActivas.Remove(salaEncontrada);
                }
                else
                {
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeDespedida);
                    NotificarJugadorDesconectadoDeSala(nombreJugador, codigoSala);                    
                }
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, 
            string mensaje)
        {
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.CodigoSala.Equals(codigoSala));
            
            foreach (CuentaJugador cuentaJugador in salaEncontrada.Jugadores)
            {
                string horaActual = DateTime.Now.ToShortTimeString();
                string mensajeFinal = horaActual + $" {nombreJugador}: {mensaje}";
                
                if (cuentaJugador.OperacionesContexto.ContextoIServicioSala != null)
                {
                    cuentaJugador.OperacionesContexto.ContextoIServicioSala.
                        GetCallbackChannel<IServicioJuegoCallback>().
                        MostrarMensajeDeSala(mensajeFinal);
                }
            }
        }

        private void NotificarNuevoJugadorConectadoASala(CuentaJugador nuevoJugador, 
            string codigoSala)
        {
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala =>
                sala.CodigoSala.Equals(codigoSala));

            foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
            {
                jugador.OperacionesContexto.ContextoIServicioSala.GetCallbackChannel<
                    IServicioJuegoCallback>().NotificarNuevoJugadorConectadoEnSala(
                    nuevoJugador);
            }
        }

        private void NotificarJugadorDesconectadoDeSala(string nombreJugador, 
            string codigoSala)
        {
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala =>
                sala.CodigoSala.Equals(codigoSala));

            foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
            {
                jugador.OperacionesContexto.ContextoIServicioSala.GetCallbackChannel<
                    IServicioJuegoCallback>().NotificarJugadorDesconectadoDeSala(
                    nombreJugador);
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            return Guid.NewGuid().ToString();
        }

        public List<CuentaJugador> ObtenerJugadoresConectadosEnSala(string codigoSala)
        {
            List<CuentaJugador> jugadoresEnSala = new List<CuentaJugador>();
            Sala salaEncontrada = salasActivas.FirstOrDefault(sala =>
                sala.CodigoSala.Equals(codigoSala));

            if (salaEncontrada != null)
            {
                jugadoresEnSala = salaEncontrada.Jugadores;
            }

            return jugadoresEnSala;
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
            GestionAmistades gestionAmistades = new GestionAmistades();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmistades.ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException)
            {

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
            GestionAmistades gestionAmistades = new GestionAmistades();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmistades.
                    ObtenerJugadoresConSolicitudPendiente(nombreJugador);
            }
            catch (EntityException)
            {

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
            GestionAmistades gestionAmistades = new GestionAmistades();

            try
            {
                esSolicitudEnviada = gestionAmistades.EnviarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

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
            GestionAmistades gestionAmistades = new GestionAmistades();
                
            try
            {
                esSolicitudAceptada = gestionAmistades.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

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
            GestionAmistades gestionAmistades = new GestionAmistades();

            try
            {
                esAmistadEliminada = gestionAmistades.EliminarAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {

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
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool resultado = false;

            try
            {
                resultado = gestionAmistades.EliminarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }

        public bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool resultado = false;

            try
            {
                resultado = gestionAmistades.ExisteSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool resultado = false;

            try
            {
                resultado = gestionAmistades.ExisteAmistadConJugador(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {

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

    #region IServicioPartida
    public partial class ServicioRompecabezasFei : IServicioPartida
    {        
        public bool CrearNuevaPartida(string codigoSala)
        {
            GestionPartida gestionPartida = new GestionPartida();
            bool resultado = false;
            
            try
            {
                resultado = gestionPartida.CrearNuevaPartida(codigoSala);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }        

        public bool FinalizarPartida(string codigoSala, 
            CuentaJugador cuentaJugador, bool esGanador)
        {
            GestionPartida gestionPartida = new GestionPartida();
            bool resultado = false;

            try
            {
                resultado = gestionPartida.FinalizarPartida(
                    codigoSala, cuentaJugador, esGanador);
            }
            catch (EntityException)
            {

            }

            return resultado;
        }

        public bool ExpulsarJugadorPartida(string codigoSala, string nombreJugador)
        {
            throw new NotImplementedException();
        }

        public bool GenerarTablero(string codigoSala)
        {
            throw new NotImplementedException();
        }

        public bool IniciarPartida(string codigoSala)
        {
            throw new NotImplementedException();
        }

        public void MoverPiezaPosicionX(double posicionX)
        {
            throw new NotImplementedException();
        }

        public void MoverPiezaPosicionY(bool posicionY)
        {
            throw new NotImplementedException();
        }

        public bool NotificarJugadorPreparado(string codigoSala, 
            string nombreJugador)
        {
            throw new NotImplementedException();
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

            }

            return numeroPartidasGanadas;
        }
    }
    #endregion
}