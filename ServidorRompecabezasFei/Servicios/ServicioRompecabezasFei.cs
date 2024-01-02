using Contratos;
using Datos;
using Logica;
using Logica.Enumeraciones;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;

namespace Servicios
{    
    #region IServicioJugador
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioRompecabezasFei : IServicioJugador
    {
        private readonly ConcurrentDictionary<string, CuentaJugador> jugadoresActivos = 
            new ConcurrentDictionary<string, CuentaJugador>();

        private readonly ConcurrentDictionary<string, Logica.Sala> salas = 
            new ConcurrentDictionary<string, Logica.Sala>();

        public bool RegistrarJugador(CuentaJugador cuentaJugador)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaRegistrarJugador)
            {
                if (!ExisteNombreJugadorRegistrado(cuentaJugador.NombreJugador))
                {
                    try
                    {
                        operacionRealizada = Logica.AccesoDatos.AccesoJugador.
                            RegistrarJugador(cuentaJugador);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }

            return operacionRealizada;
        }

        public bool ActualizarNombreJugador(string nombreAnterior, string nuevoNombre)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaActualizarNombreJugador)
            {
                if (!ExisteNombreJugadorRegistrado(nuevoNombre))
                {
                    try
                    {
                        operacionRealizada = Logica.AccesoDatos.AccesoJugador.
                            ActualizarNombreJugador(nombreAnterior, nuevoNombre);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }

            return operacionRealizada;
        }

        public bool ActualizarNumeroAvatar(string nombreJugador, int nuevoNumeroAvatar)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoJugador.
                    ActualizarNumeroAvatar(nombreJugador, nuevoNumeroAvatar);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoJugador.
                    ActualizarContrasena(correo, contrasena);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool EsLaMismaContrasenaDeJugador(string nombreJugador, 
            string contrasena)
        {
            bool hayCoincidencias = false;

            try
            {
                hayCoincidencias = Logica.AccesoDatos.AccesoJugador.
                    HayCoincidenciasEnContrasenaDeJugador(nombreJugador, contrasena);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayCoincidencias;
        }

        public bool ExisteNombreJugadorRegistrado(string nombreJugador)
        {
            bool hayExistencias = false;
            
            try
            {
                hayExistencias = Logica.AccesoDatos.AccesoJugador.
                    ExisteNombreJugadorRegistrado(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public CuentaJugador IniciarSesionComoJugador(string nombreJugador, 
            string contrasena)
        {            
            CuentaJugador cuentaRecuperada = null;
            
            lock (Bloqueador.BloqueoParaIniciarSesionComoJugador)
            {
                if (ExisteNombreJugadorRegistrado(nombreJugador) && 
                    !jugadoresActivos.ContainsKey(nombreJugador))
                {
                    try
                    {
                        cuentaRecuperada = Logica.AccesoDatos.AccesoJugador.
                            IniciarSesion(nombreJugador, contrasena);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                if (cuentaRecuperada != null)
                {
                    cuentaRecuperada.ContextoOperacionConexion = 
                        OperationContext.Current;
                    cuentaRecuperada.ContextoOperacionConexion.Channel.Faulted += 
                        (objetoOrigen, evento) => 
                        CerrarSesion(cuentaRecuperada.NombreJugador);
                    jugadoresActivos.TryAdd(cuentaRecuperada.
                        NombreJugador, cuentaRecuperada);
                    CambiarEstadoJugador(cuentaRecuperada.NombreJugador, 
                        EstadoJugador.Conectado);
                }
            }

            return cuentaRecuperada;
        }

        public CuentaJugador IniciarSesionComoInvitado(string nombreInvitado)
        {
            CuentaJugador cuentaInvitado = null;

            lock (Bloqueador.BloqueoParaIniciarSesionComoInvitado)
            {
                if (!jugadoresActivos.ContainsKey(nombreInvitado))
                {
                    cuentaInvitado = new CuentaJugador()
                    {
                        NombreJugador = nombreInvitado,
                        NumeroAvatar = (int)NumeroAvatar.Invitado,
                        EsInvitado = true,
                        Puntaje = Pieza.PuntajeVacio,
                        Estado = EstadoJugador.Conectado,
                        ContextoOperacionConexion = OperationContext.Current,
                    };
                    cuentaInvitado.ContextoOperacionConexion.
                        Channel.Faulted +=(objetoOrigen, evento) =>
                        CerrarSesion(cuentaInvitado.NombreJugador);
                    jugadoresActivos.TryAdd(cuentaInvitado.NombreJugador, cuentaInvitado);
                    CambiarEstadoJugador(cuentaInvitado.NombreJugador, 
                        EstadoJugador.Conectado);
                }
            }

            return cuentaInvitado;
        }

        public void CerrarSesion(string nombreJugador)
        {
            lock (Bloqueador.BloqueoParaCerrarSesion)
            {
                if (jugadoresActivos.ContainsKey(nombreJugador))
                {
                    string codigoSala = ObtenerCodigoSalaDeJugador(nombreJugador);

                    switch (jugadoresActivos[nombreJugador].Estado)
                    {
                        case EstadoJugador.EnSala:
                            RemoverJugadorDeSala(nombreJugador, codigoSala);
                            break;

                        case EstadoJugador.EnPartida:
                            RemoverJugadorDePartida(nombreJugador, codigoSala);
                            break;
                    }

                    CambiarEstadoJugador(nombreJugador, EstadoJugador.Desconectado);
                }
            }
        }        
    }
    #endregion

    #region IServicioCorreo 
    public partial class ServicioRompecabezasFei : IServicioCorreo
    {
        public bool ExisteCorreoRegistrado(string correo)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoJugador.
                    ExisteCorreoRegistrado(correo);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool EnviarMensajeACorreo(string encabezado, string correo,
            string asunto, string mensaje)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = GeneradorMensajeCorreo.EnviarMensaje(
                    encabezado, correo, asunto, mensaje);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }
    }
    #endregion

    #region IServicioAmistades
    public partial class ServicioRompecabezasFei : IServicioAmistades
    {
        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            List<CuentaJugador> cuentasJugador = new List<CuentaJugador>();

            try
            {
                cuentasJugador = Logica.AccesoDatos.AccesoAmistades.
                    ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (cuentasJugador.Any())
            {
                cuentasJugador = AgregarConectividadAJugadores(cuentasJugador);
            }

            return cuentasJugador;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(
            string nombreJugador)
        {
            List<CuentaJugador> cuentasJugador = new List<CuentaJugador>();

            try
            {
                cuentasJugador = Logica.AccesoDatos.AccesoAmistades.
                    ObtenerJugadoresConSolicitudPendiente(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (cuentasJugador.Any())
            {
                cuentasJugador = AgregarConectividadAJugadores(cuentasJugador);
            }

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoAmistades.
                    EnviarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorDestino].
                ContextoOperacion?.Channel is IServicioAmistades)
            {
                try
                {
                    jugadoresActivos[nombreJugadorDestino].ContextoOperacion?.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        MostrarSolicitudDeAmistadRecibida(
                        jugadoresActivos[nombreJugadorOrigen]);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugadorDestino);
                }
            }

            return operacionRealizada;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaAceptarSolicitudDeAmistad)
            {
                try
                {
                    operacionRealizada = Logica.AccesoDatos.AccesoAmistades.
                        AceptarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
                }
                catch (EntityException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorOrigen].
                ContextoOperacion?.Channel is IServicioAmistades)
            {
                try
                {
                    jugadoresActivos[nombreJugadorOrigen].ContextoOperacion?.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        MostrarNuevoAmigo(jugadoresActivos[nombreJugadorDestino]);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugadorOrigen);
                }
            }

            return operacionRealizada;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA,
            string nombreJugadorB)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoAmistades.
                    EliminarAmistadEntreJugadores(nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorB].
                ContextoOperacion?.Channel is IServicioAmistades)
            {
                try
                {
                    jugadoresActivos[nombreJugadorB].ContextoOperacion?.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        RemoverAmigoConAmistadCancelada(nombreJugadorA);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugadorB);
                }
            }

            return operacionRealizada;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoAmistades.
                    EliminarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen,
            string nombreJugadorDestino)
        {
            bool hayExistencias = false;

            try
            {
                hayExistencias = Logica.AccesoDatos.AccesoAmistades.
                    ExisteSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            bool hayExistencias = false;

            try
            {
                hayExistencias = Logica.AccesoDatos.AccesoAmistades.
                    ExisteAmistadConJugador(nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public void ActivarNotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = OperationContext.Current;
        }

        public void DesactivarNotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
        }
    }
    #endregion

    #region IServicioInvitaciones
    public partial class ServicioRompecabezasFei : IServicioInvitaciones
    {
        public void ActivarInvitacionesDeSala(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = OperationContext.Current;
            CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
        }
        
        public void DesactivarInvitacionesDeSala(string nombreJugador, EstadoJugador estado)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
            CambiarEstadoJugador(nombreJugador, estado);
        }

        public List<CuentaJugador> ObtenerAmigosDisponibles(string nombreAnfitrion)
        {
            return jugadoresActivos.Values.Where(jugador => !jugador.EsInvitado &&
                ExisteAmistadConJugador(nombreAnfitrion, jugador.NombreJugador) && 
                jugador.Estado == EstadoJugador.Disponible).ToList();
        }
    }
    #endregion

    #region IServicioSala
    public partial class ServicioRompecabezasFei : IServicioSala
    {
        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoSala.CrearNuevaSala(codigoSala);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                Logica.Sala nuevaSala = new Logica.Sala()
                {
                    Partida = new Logica.Partida(),
                    CodigoSala = codigoSala,
                    NombreAnfitrion = nombreAnfitrion,
                    ContadorJugadores = Logica.Sala.CantidadJugadoresVacia,
                    NombresDeJugadores = new ConcurrentDictionary<string, string>(),                    
                };
                operacionRealizada = salas.TryAdd(codigoSala, nuevaSala);
            }

            return operacionRealizada;
        }

        public bool ExisteSalaDisponible(string codigoSala)
        {
            return salas.ContainsKey(codigoSala) && 
                salas[codigoSala].ContadorJugadores < 
                Logica.Sala.CantidadMaximaJugadores && 
                salas[codigoSala].Partida.Estado == EstadoPartida.SinIniciar;
        }

        public List<CuentaJugador> ObtenerJugadoresEnSala(string codigoSala)
        {
            return jugadoresActivos.Where(jugador => 
                salas[codigoSala].NombresDeJugadores.ContainsKey(jugador.Key)).
                Select(jugador => jugador.Value).ToList();
        }

        public bool UnirseASala(string nombreJugador, string codigoSala)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaUnirseASala)
            {
                if (salas.ContainsKey(codigoSala))
                {
                    if (salas[codigoSala].Partida.Estado == 
                        EstadoPartida.Finalizada &&
                        salas[codigoSala].NombreAnfitrion == nombreJugador)
                    {
                        salas[codigoSala].Partida.Estado = 
                            EstadoPartida.SinIniciar;

                        foreach (var jugadorEnPartida in 
                            ObtenerJugadoresEnPartida(codigoSala))
                        {
                            jugadorEnPartida.ContextoOperacion?.
                                GetCallbackChannel<IServicioPartidaCallback>().
                                HabilitarOpcionDeRegresoASala();
                        }
                    }

                    if (ExisteSalaDisponible(codigoSala))
                    {
                        ActivarNotificacionesDeSala(nombreJugador);
                        CambiarEstadoJugador(nombreJugador, EstadoJugador.EnSala);

                        foreach (var jugadorEnSala in 
                            ObtenerJugadoresEnSala(codigoSala))
                        {
                            try
                            {
                                jugadorEnSala.ContextoOperacion?.
                                    GetCallbackChannel<IServicioSalaCallback>().
                                    MostrarNuevoJugadorEnSala(
                                    jugadoresActivos[nombreJugador]);
                            }
                            catch (CommunicationObjectAbortedException excepcion)
                            {
                                Registros.Registrador.EscribirRegistro(excepcion);
                                CerrarSesion(jugadorEnSala.NombreJugador);
                            }
                        }

                        operacionRealizada = salas[codigoSala].
                            AgregarNombreDeJugador(nombreJugador);

                        if (salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
                        {
                            HabilitarInicioDePartida(codigoSala);
                        }
                    }
                }
            }

            return operacionRealizada;
        }

        public void ActivarNotificacionesDeSala(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = OperationContext.Current;
        }

        public void DesactivarNotificacionesDeSala(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
        }

        public void AbandonarSala(string nombreJugador, string codigoSala)
        {
            if (RemoverJugadorDeSala(nombreJugador, codigoSala))
            {
                CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, 
            string mensaje)
        {
            foreach (var jugador in ObtenerJugadoresEnSala(codigoSala))
            {
                try
                {
                    jugador.ContextoOperacion?.
                        GetCallbackChannel<IServicioSalaCallback>().
                        MostrarMensajeDeSala(DateTime.Now.ToShortTimeString() + 
                        $" {nombreJugador}: {mensaje}");
                }
                catch(CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugador.NombreJugador);
                }
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            return Guid.NewGuid().ToString();
        }

        public void ConvertirJugadorEnAnfitrionDesdeSala(string nombreJugador, 
            string codigoSala)
        {
            try
            {
                jugadoresActivos[nombreJugador].ContextoOperacion?.
                    GetCallbackChannel<IServicioSalaCallback>().
                    MostrarFuncionesDeAnfitrionEnSala();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(nombreJugador);
                ElegirNuevoAnfitrion(codigoSala);
            }

            salas[codigoSala].NombreAnfitrion = nombreJugador;
        }

        public void InvitarJugador(string nombreJugador, 
            string nombreAnfitrion, string codigoSala)
        {
            if (jugadoresActivos[nombreJugador].ContextoOperacion?.Channel 
                is IServicioInvitaciones)
            {
                try
                {
                    jugadoresActivos[nombreJugador].ContextoOperacion?.
                        GetCallbackChannel<IServicioInvitacionesCallback>().
                        MostrarInvitacionDeSala(nombreAnfitrion, codigoSala);
                }
                catch (CommunicationObjectAbortedException excepcion) 
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugador);
                }
            }
        }

        public void ExpulsarJugadorEnSala(string nombreJugadorExpulsion, 
            string codigoSala)
        {
            try
            {
                jugadoresActivos[nombreJugadorExpulsion].ContextoOperacion?.
                    GetCallbackChannel<IServicioSalaCallback>().
                    MostrarMensajeExpulsionDeSala();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(nombreJugadorExpulsion);
            }

            salas[codigoSala].RemoverNombreDeJugador(nombreJugadorExpulsion);

            foreach (var jugadorEnSala in ObtenerJugadoresEnSala(codigoSala))
            {
                try
                {
                    jugadorEnSala.ContextoOperacion?.
                        GetCallbackChannel<IServicioSalaCallback>().
                        MostrarDesconexionDeJugadorEnSala(nombreJugadorExpulsion);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugadorEnSala.NombreJugador);
                }
            }
        }
    }
    #endregion

    #region IServicioPartida
    public partial class ServicioRompecabezasFei : IServicioPartida
    {
        public bool CrearNuevaPartida(string codigoSala, 
            DificultadPartida dificultad, int numeroImagen)
        {
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = Logica.AccesoDatos.AccesoPartida.
                    CrearNuevaPartida(codigoSala, dificultad);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                salas[codigoSala].Partida = new Logica.Partida
                {
                    PuntajesDeJugadores = new ConcurrentDictionary<string, int>(),
                    Dificultad = dificultad,
                    Estado = EstadoPartida.SinIniciar,
                };
                salas[codigoSala].Partida.Tablero.
                    NumeroImagenRompecabezas = numeroImagen;
                NotificarCreacionDePartidaAJugadores(codigoSala);
            }

            return operacionRealizada;
        }

        public bool UnirseAPartida(string codigoSala, string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = OperationContext.Current;

            foreach (var jugadorEnPartida in ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugadorEnPartida.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarNuevoJugadorEnPartida(jugadoresActivos[nombreJugador]);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugadorEnPartida.NombreJugador);
                }
            }

            bool operacionRealizada = salas[codigoSala].RemoverNombreDeJugador(nombreJugador) &&
                salas[codigoSala].Partida.AgregarNombreDeJugador(nombreJugador);

            if (operacionRealizada)
            {
                CambiarEstadoJugador(nombreJugador, EstadoJugador.EnPartida);
            }

            return operacionRealizada;
        }

        public List<CuentaJugador> ObtenerJugadoresEnPartida(string codigoSala)
        {
            return jugadoresActivos.Where(jugador =>
                salas[codigoSala].Partida.PuntajesDeJugadores.ContainsKey(jugador.Key)).
                Select(jugador => jugador.Value).ToList();
        }

        public void AbandonarPartida(string codigoSala, string nombreJugador)
        {
            RemoverJugadorDePartida(nombreJugador, codigoSala);
            CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
        }

        public void IniciarPartida(string codigoSala)
        {            
            salas[codigoSala].Partida.Estado = EstadoPartida.EnCurso;
            
            foreach (var jugador in ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugador.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarTableroDePartida(salas[codigoSala].Partida.Tablero);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugador.NombreJugador);
                }
            }
        }

        private void FinalizarPartida(string codigoSala)
        {
            var nombresDeJugadoresConPuntajeMaximo = salas[codigoSala].Partida.
                PuntajesDeJugadores.Where(puntaje => puntaje.Value == 
                salas[codigoSala].Partida.PuntajesDeJugadores.Values.Max()).
                Select(puntaje => puntaje.Key).ToList();
            bool hayGanador = nombresDeJugadoresConPuntajeMaximo.Count ==
                Logica.Partida.CantidadGanadoresPorPartidaPermitidos;

            foreach (var jugador in ObtenerJugadoresEnPartida(codigoSala))
            {
                if (!jugador.EsInvitado)
                {
                    bool esGanador = hayGanador && jugador.NombreJugador ==
                        nombresDeJugadoresConPuntajeMaximo[0];
                    jugador.Puntaje = salas[codigoSala].Partida.
                        PuntajesDeJugadores[jugador.NombreJugador];

                    try
                    {
                        Logica.AccesoDatos.AccesoPartida.
                            FinalizarPartida(codigoSala, jugador, esGanador);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                jugadoresActivos[jugador.NombreJugador].Puntaje = Pieza.PuntajeVacio;
            }            
        }

        public void BloquearPieza(string codigoSala, int numeroPieza, 
            string nombreJugador)
        {
            lock (Bloqueador.BloqueoParaBloquearPieza)
            {
                if (!salas[codigoSala].Partida.Tablero.Piezas[numeroPieza].EstaBloqueada)
                {
                    salas[codigoSala].Partida.Tablero.Piezas[numeroPieza].EstaBloqueada = true;

                    foreach (var jugadorEnPartida in ObtenerJugadoresEnPartida(codigoSala))
                    {
                        try
                        {
                            jugadorEnPartida.ContextoOperacion?.
                                GetCallbackChannel<IServicioPartidaCallback>().
                                MostrarBloqueoDePieza(numeroPieza, nombreJugador);
                        }
                        catch (CommunicationObjectAbortedException excepcion)
                        {
                            Registros.Registrador.EscribirRegistro(excepcion);
                            CerrarSesion(nombreJugador);
                        }
                    }
                }
            }
        }

        public void DesbloquearPieza(string codigoSala, int numeroPieza, 
            string nombreJugador)
        {
            salas[codigoSala].Partida.Tablero.Piezas[numeroPieza].EstaBloqueada = false;

            foreach (var jugador in ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugador.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarDesbloqueoDePieza(numeroPieza, nombreJugador);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugador);
                }
            }
        }

        public void ColocarPieza(string codigoSala, int numeroPieza, 
            string nombreJugador, Posicion posicion)
        {
            lock (Bloqueador.BloqueoParaColocarPieza)
            {
                int puntaje = salas[codigoSala].Partida.Tablero.Piezas[numeroPieza].Puntaje;
                salas[codigoSala].Partida.PuntajesDeJugadores[nombreJugador] += puntaje;
                salas[codigoSala].Partida.Tablero.Piezas[numeroPieza].EstaDentroDeCelda = true;            
            
                foreach (var jugador in ObtenerJugadoresEnPartida(codigoSala))
                {
                    try
                    {
                        jugador.ContextoOperacion?.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarColocacionDePieza(numeroPieza, nombreJugador, 
                            puntaje, posicion);
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(codigoSala);
                    }
                }

                if (salas[codigoSala].Partida.Tablero.EsRompecabezasCompletado())
                {
                    FinalizarPartida(codigoSala);
                    EnviarResultadosAJugadores(codigoSala);
                }
            }
        }        

        public int ObtenerNumeroDePartidasJugadas(string nombreJugador)
        {
            int numeroPartidasJugadas = 0;

            try
            {
                numeroPartidasJugadas = Logica.AccesoDatos.AccesoJugador.
                    ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroDePartidasGanadas(string nombreJugador)
        {
            int numeroPartidasGanadas = 0;

            try
            {
                numeroPartidasGanadas = Logica.AccesoDatos.AccesoJugador.
                    ObtenerNumeroPartidasGanadas(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return numeroPartidasGanadas;
        }

        public void ExpulsarJugadorEnPartida(string nombreJugadorExpulsion, 
            string codigoSala)
        {
            try
            {
                jugadoresActivos[nombreJugadorExpulsion].ContextoOperacion?.
                    GetCallbackChannel<IServicioPartidaCallback>().
                    MostrarMensajeExpulsionDePartida();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(nombreJugadorExpulsion);
            }

            salas[codigoSala].Partida.RemoverNombreDeJugador(nombreJugadorExpulsion);            
            var jugadoresEnPartida = ObtenerJugadoresEnPartida(codigoSala);

            foreach (var jugadorEnPartida in jugadoresEnPartida)
            {
                try
                {
                    jugadorEnPartida.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarDesconexionDeJugadorEnPartida(nombreJugadorExpulsion);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugadorEnPartida.NombreJugador);
                }
            }
            
            if (!salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
            {
                foreach (var jugadorEnPartida in jugadoresEnPartida)
                {
                    try
                    {
                        jugadorEnPartida.ContextoOperacion?.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarMensajePartidaCancelada();
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(nombreJugadorExpulsion);
                    }
                }
            }

            CambiarEstadoJugador(nombreJugadorExpulsion, EstadoJugador.Disponible);            
        }

        public void ConvertirJugadorEnAnfitrionDesdePartida(string nombreJugador, 
            string codigoSala)
        {
            try
            {
                jugadoresActivos[nombreJugador].ContextoOperacion?.
                    GetCallbackChannel<IServicioPartidaCallback>().
                    MostrarFuncionesDeAnfitrionEnPartida();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(nombreJugador);
                ElegirNuevoAnfitrion(codigoSala);
            }

            salas[codigoSala].NombreAnfitrion = nombreJugador;
        }
    }
    #endregion

    #region Métodos privados
    public partial class ServicioRompecabezasFei
    {
        private void CambiarEstadoJugador(string nombreJugador, EstadoJugador estado)
        {
            if (jugadoresActivos.ContainsKey(nombreJugador))
            {
                EstadoJugador estadoAnterior = jugadoresActivos[nombreJugador].Estado;

                switch (estado)
                {
                    case EstadoJugador.Conectado:
                    case EstadoJugador.EnSala:
                    case EstadoJugador.EnPartida:

                        if (estadoAnterior == EstadoJugador.Disponible)
                        {
                            NotificarAnfitrionesDeSalaSobreAmigoNoDisponible(nombreJugador);
                        }
                        else
                        {
                            NotificarAmigosSobreCambioEstadoDeJugador(nombreJugador, estado);
                        }

                        break;

                    case EstadoJugador.Desconectado:
                        jugadoresActivos.TryRemove(nombreJugador, out _);
                        break;

                    case EstadoJugador.Disponible:
                        NotificarAnfitrionesDeSalaSobreAmigoDisponible(nombreJugador);
                        break;
                }

                if (estado != EstadoJugador.Desconectado)
                {
                    jugadoresActivos[nombreJugador].Estado = estado;
                }
            }
        }

        private List<CuentaJugador> AgregarConectividadAJugadores(
            List<CuentaJugador> cuentasJugador)
        {
            var cuentasConEstadoConectividad = new List<CuentaJugador>();

            foreach (CuentaJugador cuenta in cuentasJugador)
            {
                if (jugadoresActivos.ContainsKey(cuenta.NombreJugador))
                {
                    cuenta.Estado = jugadoresActivos
                        [cuenta.NombreJugador].Estado;
                }
                else
                {
                    cuenta.Estado = EstadoJugador.Desconectado;
                }

                cuentasConEstadoConectividad.Add(cuenta);
            }

            return cuentasConEstadoConectividad;
        }

        private List<CuentaJugador> ObtenerAmigosConectados(string nombreJugador)
        {
            return jugadoresActivos.Values.Where(jugador => !jugador.EsInvitado &&
                ExisteAmistadConJugador(nombreJugador, jugador.NombreJugador)).ToList();
        }

        private bool RemoverJugadorDeSala(string nombreJugador, string codigoSala)
        {
            bool operacionRealizada = false;

            if (salas.ContainsKey(codigoSala) && salas[codigoSala].
                RemoverNombreDeJugador(nombreJugador))
            {
                operacionRealizada = true;

                foreach (var jugadorEnSala in ObtenerJugadoresEnSala(codigoSala))
                {
                    try
                    {
                        jugadorEnSala.ContextoOperacion?.
                            GetCallbackChannel<IServicioSalaCallback>().
                            MostrarDesconexionDeJugadorEnSala(nombreJugador);
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(jugadorEnSala.NombreJugador);
                    }
                }

                if (salas.ContainsKey(codigoSala))
                {
                    if (salas[codigoSala].EstaVacia())
                    {
                        salas.TryRemove(codigoSala, out _);
                    }
                    else if (EsJugadorAnfitrion(nombreJugador, codigoSala))
                    {
                        ElegirNuevoAnfitrion(codigoSala);
                    }
                    else if (!salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
                    {
                        DeshabilitarInicioDePartida(codigoSala);
                    }
                }
            }

            return operacionRealizada;
        }

        private void RemoverJugadorDePartida(string nombreJugador, string codigoSala)
        {
            if (salas.ContainsKey(codigoSala) && salas[codigoSala].
                Partida.RemoverNombreDeJugador(nombreJugador))
            {
                foreach (var jugadorEnPartida in ObtenerJugadoresEnPartida(codigoSala))
                {
                    try
                    {
                        jugadorEnPartida.ContextoOperacion?.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarDesconexionDeJugadorEnPartida(nombreJugador);
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(jugadorEnPartida.NombreJugador);
                    }
                }

                if (salas[codigoSala].EstaVacia())
                {
                    salas.TryRemove(codigoSala, out _);
                }
                else if (EsJugadorAnfitrion(nombreJugador, codigoSala))
                {
                    ElegirNuevoAnfitrion(codigoSala);
                }
                else if (!salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
                {
                    CancelarPartidaEnCurso(codigoSala);
                }
            }
        }

        private void NotificarCreacionDePartidaAJugadores(string codigoSala)
        {
            salas[codigoSala].Partida.Estado = EstadoPartida.EnCurso;

            foreach (var jugadorEnSala in ObtenerJugadoresEnSala(codigoSala))
            {
                if (jugadorEnSala.NombreJugador != salas[codigoSala].NombreAnfitrion)
                {
                    try
                    {
                        jugadorEnSala.ContextoOperacion?.
                            GetCallbackChannel<IServicioSalaCallback>().
                            MostrarNuevaPartida();
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(jugadorEnSala.NombreJugador);
                    }
                }
            }
        }

        private void CancelarPartidaEnCurso(string codigoSala)
        {
            foreach (var jugadorEnPartida in ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugadorEnPartida.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarMensajePartidaCancelada();
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugadorEnPartida.NombreJugador);
                }
            }

            salas[codigoSala].Partida.Estado = EstadoPartida.SinIniciar;
        }

        private void HabilitarInicioDePartida(string codigoSala)
        {
            try
            {
                jugadoresActivos[salas[codigoSala].
                    NombreAnfitrion].ContextoOperacion?.
                    GetCallbackChannel<IServicioSalaCallback>().
                    HabilitarInicioDePartida();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(salas[codigoSala].NombreAnfitrion);
            }
        }

        private void DeshabilitarInicioDePartida(string codigoSala)
        {
            try
            {
                jugadoresActivos[salas[codigoSala].
                    NombreAnfitrion].ContextoOperacion?.
                    GetCallbackChannel<IServicioSalaCallback>().
                    DeshabilitarInicioDePartida();
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                CerrarSesion(salas[codigoSala].NombreAnfitrion);
            }
        }
        
        private void ElegirNuevoAnfitrion(string codigoSala)
        {
            var nuevoAnfitrion = ObtenerJugadoresEnSala(codigoSala).FirstOrDefault();

            if (nuevoAnfitrion != null)
            {
                try
                {
                    switch (salas[codigoSala].Partida.Estado)
                    {
                        case EstadoPartida.SinIniciar:
                            nuevoAnfitrion.ContextoOperacion?.
                                GetCallbackChannel<IServicioSalaCallback>().
                                MostrarFuncionesDeAnfitrionEnSala();
                            break;

                        case EstadoPartida.EnCurso:
                            nuevoAnfitrion.ContextoOperacion?.
                                GetCallbackChannel<IServicioPartidaCallback>().
                                MostrarFuncionesDeAnfitrionEnPartida();                            
                            break;
                    }
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nuevoAnfitrion.NombreJugador);
                    ElegirNuevoAnfitrion(codigoSala);
                }

                salas[codigoSala].NombreAnfitrion = nuevoAnfitrion.NombreJugador;
            }
        }

        private void EnviarResultadosAJugadores(string codigoSala)
        {
            foreach (var jugador in ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugador.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarResultadosDePartida();
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(jugador.NombreJugador);
                }
            }
        }

        private bool EsJugadorAnfitrion(string nombreJugador, string codigoSala)
        {
            return salas.ContainsKey(codigoSala) && 
                salas[codigoSala].NombreAnfitrion == nombreJugador;
        }

        private List<string> ObtenerNombresDeAnfitrionesEnSala()
        {
            List<string> nombresDeAnfitriones = new List<string>();

            foreach (var sala in salas.Values)
            {
                if (sala.Partida.Estado == EstadoPartida.SinIniciar)
                {
                    nombresDeAnfitriones.Add(sala.NombreAnfitrion);
                }
            }

            return nombresDeAnfitriones;
        }

        private string ObtenerCodigoSalaDeJugador(string nombreJugador)
        {
            string codigoSala = "";

            if (jugadoresActivos[nombreJugador].Estado == EstadoJugador.EnSala || 
                jugadoresActivos[nombreJugador].Estado == EstadoJugador.EnPartida)
            {
                codigoSala = salas.Values.First(sala => sala.
                    NombresDeJugadores.Keys.Any(nombre => nombre == nombreJugador) || 
                    (string.IsNullOrEmpty(codigoSala) && 
                    sala.Partida.PuntajesDeJugadores.Keys.Any(
                    nombre => nombre == nombreJugador)))?.CodigoSala;
            }

            return codigoSala;
        }

        private void NotificarAnfitrionesDeSalaSobreAmigoDisponible(
            string nombreJugador)
        {
            foreach (var nombreAnfitrion in ObtenerNombresDeAnfitrionesEnSala())
            {
                if (ExisteAmistadConJugador(nombreJugador, nombreAnfitrion) &&
                    jugadoresActivos[nombreAnfitrion].
                    ContextoOperacion?.Channel is IServicioSala)
                {
                    try
                    {
                        jugadoresActivos[nombreAnfitrion].ContextoOperacion?.
                            GetCallbackChannel<IServicioSalaCallback>().
                            MostrarAmigoDisponible(jugadoresActivos[nombreJugador]);
                    }
                    catch (CommunicationObjectAbortedException excepcion) 
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(nombreAnfitrion);
                    }
                }
            }
        }

        private void NotificarAnfitrionesDeSalaSobreAmigoNoDisponible(
            string nombreJugador)
        {
            foreach (var nombreAnfitrion in ObtenerNombresDeAnfitrionesEnSala())
            {
                if (ExisteAmistadConJugador(nombreJugador, nombreAnfitrion) &&
                    jugadoresActivos[nombreAnfitrion].
                    ContextoOperacion?.Channel is IServicioSala)
                {
                    try
                    {
                        jugadoresActivos[nombreAnfitrion].ContextoOperacion?.
                            GetCallbackChannel<IServicioSalaCallback>().
                            OcultarAmigoNoDisponible(nombreJugador);
                    }
                    catch (CommunicationObjectAbortedException excepcion) 
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        CerrarSesion(nombreAnfitrion);
                    }
                }
            }
        }

        private void NotificarAmigosSobreCambioEstadoDeJugador(string nombreJugador, 
            EstadoJugador estado)
        {
            foreach (var jugador in ObtenerAmigosConectados(nombreJugador).
                Where(jugador => jugador.ContextoOperacion?.Channel 
                is IServicioAmistades))
            {
                try
                {
                    jugador.ContextoOperacion?.GetCallbackChannel
                        <IServicioAmistadesCallback>().
                        ActualizarEstadoDeJugador(nombreJugador, estado);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    CerrarSesion(nombreJugador);
                }
            }
        }
    }
    #endregion
}