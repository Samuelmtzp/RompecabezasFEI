using Contratos;
using Datos;
using Logica;
using Logica.AccesoDatos;
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
                        operacionRealizada = AccesoCuentaJugador.
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

        public bool ActualizarNombreJugador(string nombreAnterior, 
            string nuevoNombre)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaActualizarNombreJugador)
            {
                if (!ExisteNombreJugadorRegistrado(nuevoNombre))
                {
                    try
                    {
                        operacionRealizada = AccesoCuentaJugador.
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

        public bool ActualizarNumeroAvatar(string nombreJugador, 
            int nuevoNumeroAvatar)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = AccesoCuentaJugador.
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
                operacionRealizada = AccesoCuentaJugador.
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
                hayCoincidencias = AccesoCuentaJugador.
                    HayCoincidenciasEnContrasenaDeJugador(
                    nombreJugador, contrasena);
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
                hayExistencias = AccesoCuentaJugador.
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
                        cuentaRecuperada = AccesoCuentaJugador.
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
                    cuentaRecuperada.TipoInterfazCallback = 
                        typeof(IServicioJugadorCallback);
                    cuentaRecuperada.ContextoOperacionConexion.Channel.Faulted += 
                        (objetoOrigen, evento) => 
                        CerrarSesion(cuentaRecuperada.NombreJugador);
                    jugadoresActivos.TryAdd(cuentaRecuperada.
                        NombreJugador, cuentaRecuperada);
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
                        TipoInterfazCallback = typeof(IServicioJugadorCallback)
                    };
                    cuentaInvitado.ContextoOperacionConexion.
                        Channel.Faulted +=(objetoOrigen, evento) =>
                        CerrarSesion(cuentaInvitado.NombreJugador);
                    jugadoresActivos.TryAdd(cuentaInvitado.NombreJugador, 
                        cuentaInvitado);
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
                operacionRealizada = AccesoCuentaJugador.
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
                cuentasJugador = AccesoAmistad.
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
                cuentasJugador = AccesoSolicitudAmistad.
                    ObtenerJugadoresOrigenSolicitudAmistadPendiente(nombreJugador);
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
                operacionRealizada = AccesoSolicitudAmistad.
                    CrearNuevaSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorDestino].
                TipoInterfazCallback == typeof(IServicioAmistadesCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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
                if (!ExisteAmistadConJugador(nombreJugadorOrigen, nombreJugadorDestino))
                {
                    operacionRealizada = AccesoAmistad.
                        RegistrarNuevaAmistad(nombreJugadorOrigen, nombreJugadorDestino);
                }

                if (ExisteSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino))
                {
                    try
                    {
                        AccesoSolicitudAmistad.EliminarSolicitudDeAmistad(
                            nombreJugadorOrigen, nombreJugadorDestino);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                if (ExisteSolicitudDeAmistad(nombreJugadorDestino, nombreJugadorOrigen))
                {
                    try
                    {
                        AccesoSolicitudAmistad.EliminarSolicitudDeAmistad(
                            nombreJugadorDestino, nombreJugadorOrigen);
                    }
                    catch (EntityException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorOrigen].
                TipoInterfazCallback == typeof(IServicioAmistadesCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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
                operacionRealizada = AccesoAmistad.
                    EliminarAmistad(nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada && jugadoresActivos[nombreJugadorB].
                TipoInterfazCallback == typeof(IServicioAmistadesCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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
                operacionRealizada = AccesoSolicitudAmistad.
                    EliminarSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
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
                hayExistencias = AccesoSolicitudAmistad.
                    ExisteSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool hayExistencias = false;

            try
            {
                hayExistencias = AccesoAmistad.
                    ExisteAmistad(nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public void ActivarNotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
            jugadoresActivos[nombreJugador].TipoInterfazCallback = 
                typeof(IServicioAmistadesCallback);
        }

        public void DesactivarNotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
            jugadoresActivos[nombreJugador].TipoInterfazCallback = 
                typeof(IServicioJugadorCallback);
        }
    }
    #endregion

    #region IServicioInvitaciones
    public partial class ServicioRompecabezasFei : IServicioInvitaciones
    {
        public void ActivarInvitacionesDeSala(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
            jugadoresActivos[nombreJugador].TipoInterfazCallback =
                typeof(IServicioInvitacionesCallback);
            CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
        }
        
        public void DesactivarInvitacionesDeSala(string nombreJugador, 
            EstadoJugador nuevoEstado)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
            jugadoresActivos[nombreJugador].TipoInterfazCallback =
                typeof(IServicioJugador);
            CambiarEstadoJugador(nombreJugador, nuevoEstado);
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
                operacionRealizada = AccesoSala.
                    CrearNuevaSala(codigoSala);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                Logica.Sala nuevaSala = new Logica.Sala()
                {
                    Partida = null,
                    HayPartidaCreada = false,
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
            return salas.ContainsKey(codigoSala) && salas[codigoSala].
                ContadorJugadores < Logica.Sala.CantidadMaximaJugadores && 
                !salas[codigoSala].HayPartidaCreada;
        }

        public List<CuentaJugador> ObtenerJugadoresEnSala(string codigoSala)
        {
            return jugadoresActivos.Values.Where(jugador => 
                salas[codigoSala].NombresDeJugadores.
                ContainsKey(jugador.NombreJugador) && jugador.
                TipoInterfazCallback == typeof(IServicioSalaCallback)).ToList();
        }

        public bool UnirseASala(string nombreJugador, string codigoSala)
        {
            bool operacionRealizada = false;

            lock (Bloqueador.BloqueoParaUnirseASala)
            {
                if (salas.ContainsKey(codigoSala))
                {
                    if (salas[codigoSala].HayPartidaCreada && 
                        salas[codigoSala].Partida.Estado == EstadoPartida.Finalizada &&
                        salas[codigoSala].NombreAnfitrion == nombreJugador)
                    {
                        foreach (var jugadorEnPartida in 
                            ObtenerJugadoresEnPartida(codigoSala))
                        {
                            try
                            {
                                jugadorEnPartida.ContextoOperacion?.
                                    GetCallbackChannel<IServicioPartidaCallback>().
                                    HabilitarOpcionDeRegresoASala();
                            }
                            catch (CommunicationObjectAbortedException excepcion)
                            {
                                Registros.Registrador.EscribirRegistro(excepcion);
                            }
                            catch (InvalidCastException excepcion)
                            {
                                Registros.Registrador.EscribirRegistro(excepcion);
                            }
                        }

                        salas[codigoSala].Partida = null;
                        salas[codigoSala].HayPartidaCreada = false;
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
                            }
                            catch (InvalidCastException excepcion)
                            {
                                Registros.Registrador.EscribirRegistro(excepcion);
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
            jugadoresActivos[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
            jugadoresActivos[nombreJugador].TipoInterfazCallback = 
                typeof(IServicioSalaCallback);
        }

        public void DesactivarNotificacionesDeSala(string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = null;
            jugadoresActivos[nombreJugador].TipoInterfazCallback =
                typeof(IServicioJugadorCallback);
        }

        public void AbandonarSala(string nombreJugador, string codigoSala)
        {
            if (RemoverJugadorDeSala(nombreJugador, codigoSala))
            {
                CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
                DesactivarNotificacionesDeSala(nombreJugador);
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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
            if (jugadoresActivos[nombreJugador].
                TipoInterfazCallback == typeof(IServicioSalaCallback))
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
                    ElegirNuevoAnfitrion(codigoSala);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }

                salas[codigoSala].NombreAnfitrion = nombreJugador;
            }
        }

        public void InvitarJugador(string nombreJugador, 
            string nombreAnfitrion, string codigoSala)
        {
            if (jugadoresActivos[nombreJugador].
                TipoInterfazCallback == typeof(IServicioInvitacionesCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }

        public void ExpulsarJugadorEnSala(string nombreJugadorExpulsion, 
            string codigoSala)
        {
            if (jugadoresActivos[nombreJugadorExpulsion].
                TipoInterfazCallback == typeof(IServicioSalaCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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
                operacionRealizada = AccesoPartida.
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
                salas[codigoSala].HayPartidaCreada = true;
                salas[codigoSala].Partida.Tablero.
                    NumeroImagenRompecabezas = numeroImagen;
                NotificarCreacionDePartidaAJugadores(codigoSala);
            }

            return operacionRealizada;
        }

        public void UnirseAPartida(string codigoSala, string nombreJugador)
        {
            jugadoresActivos[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
            jugadoresActivos[nombreJugador].TipoInterfazCallback = 
                typeof(IServicioPartidaCallback);
            bool operacionRealizada = salas[codigoSala].
                RemoverNombreDeJugador(nombreJugador) &&
                salas[codigoSala].Partida.AgregarNombreDeJugador(nombreJugador);

            if (operacionRealizada)
            {
                CambiarEstadoJugador(nombreJugador, EstadoJugador.EnPartida);
            }
        }

        public List<CuentaJugador> ObtenerJugadoresEnPartida(string codigoSala)
        {            
            return jugadoresActivos.Values.Where(jugador =>
                salas[codigoSala].HayPartidaCreada && salas[codigoSala].
                Partida.PuntajesDeJugadores.ContainsKey(jugador.NombreJugador) && 
                jugador.TipoInterfazCallback == 
                typeof(IServicioPartidaCallback)).ToList();
        }

        public void AbandonarPartida(string codigoSala, string nombreJugador)
        {
            RemoverJugadorDePartida(nombreJugador, codigoSala);
            CambiarEstadoJugador(nombreJugador, EstadoJugador.Disponible);
            jugadoresActivos[nombreJugador].TipoInterfazCallback = 
                typeof(IServicioJugador);
        }

        public void IniciarPartida(string codigoSala)
        {
            var jugadoresEnPartida = ObtenerJugadoresEnPartida(codigoSala);

            if (jugadoresEnPartida.Count() >= 
                Logica.Sala.CantidadMinimaJugadoresParaPartida)
            {
                salas[codigoSala].Partida.Estado = EstadoPartida.EnCurso;

                foreach (var jugador in jugadoresEnPartida)
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }
            else
            {
                foreach (var jugador in jugadoresEnPartida)
                {
                    try
                    {
                        jugador.ContextoOperacion?.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarMensajePartidaCancelada();
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }
        }

        private void FinalizarPartida(string codigoSala)
        {
            var nombresDeJugadoresConPuntajeMaximo = 
                salas[codigoSala].Partida.PuntajesDeJugadores.
                Where(puntaje => puntaje.Value == salas[codigoSala].
                Partida.PuntajesDeJugadores.Values.Max()).
                Select(puntaje => puntaje.Key).ToList();
            bool hayGanador = nombresDeJugadoresConPuntajeMaximo.Count ==
                Logica.Partida.CantidadGanadoresPorPartidaPermitidos;
            salas[codigoSala].Partida.Estado = EstadoPartida.Finalizada;

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
                        AccesoResultadoPartida.
                            AgregarResultadoPartida(codigoSala, jugador, esGanador);
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
                if (!salas[codigoSala].Partida.Tablero.
                    Piezas[numeroPieza].EstaBloqueada)
                {
                    salas[codigoSala].Partida.Tablero.
                        Piezas[numeroPieza].EstaBloqueada = true;

                    foreach (var jugadorEnPartida in 
                        ObtenerJugadoresEnPartida(codigoSala))
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
                        }
                        catch (InvalidCastException excepcion)
                        {
                            Registros.Registrador.EscribirRegistro(excepcion);
                        }
                    }
                }
            }
        }

        public void DesbloquearPieza(string codigoSala, int numeroPieza, 
            string nombreJugador)
        {
            salas[codigoSala].Partida.Tablero.
                Piezas[numeroPieza].EstaBloqueada = false;

            foreach (var jugadorEnPartida in 
                ObtenerJugadoresEnPartida(codigoSala))
            {
                try
                {
                    jugadorEnPartida.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarDesbloqueoDePieza(numeroPieza, nombreJugador);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }

        public void ColocarPieza(string codigoSala, int numeroPieza, 
            string nombreJugador, Posicion posicion)
        {
            lock (Bloqueador.BloqueoParaColocarPieza)
            {
                int puntaje = salas[codigoSala].Partida.
                    Tablero.Piezas[numeroPieza].Puntaje;
                salas[codigoSala].Partida.
                    PuntajesDeJugadores[nombreJugador] += puntaje;
                salas[codigoSala].Partida.Tablero.
                    Piezas[numeroPieza].EstaDentroDeCelda = true;
            
                foreach (var jugadorEnPartida in 
                    ObtenerJugadoresEnPartida(codigoSala))
                {
                    try
                    {
                        jugadorEnPartida.ContextoOperacion?.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarColocacionDePieza(numeroPieza, nombreJugador, 
                            puntaje, posicion);
                    }
                    catch (CommunicationObjectAbortedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                if (salas[codigoSala].Partida.
                    Tablero.EsRompecabezasCompletado())
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
                numeroPartidasJugadas = AccesoPartida.
                    ObtenerNumeroPartidasJugadas(nombreJugador);
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
                numeroPartidasGanadas = AccesoPartida.
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
            if (jugadoresActivos[nombreJugadorExpulsion].
                TipoInterfazCallback == typeof(IServicioPartidaCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }

            salas[codigoSala].Partida.
                RemoverNombreDeJugador(nombreJugadorExpulsion);            
            var jugadoresEnPartida = ObtenerJugadoresEnPartida(codigoSala);

            foreach (var jugadorEnPartida in jugadoresEnPartida)
            {
                try
                {
                    jugadorEnPartida.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarDesconexionDeJugadorEnPartida(
                        nombreJugadorExpulsion);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
            
            if (!salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
            {
                foreach (var jugadorEnPartida in jugadoresEnPartida.
                    Where(jugador => jugador.TipoInterfazCallback ==
                    typeof(IServicioPartidaCallback)))
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }

            CambiarEstadoJugador(nombreJugadorExpulsion, EstadoJugador.Disponible);            
        }

        public void ConvertirJugadorEnAnfitrionDesdePartida(string nombreJugador, 
            string codigoSala)
        {
            if (jugadoresActivos[nombreJugador].
                TipoInterfazCallback == typeof(IServicioPartidaCallback))
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
                    ElegirNuevoAnfitrion(codigoSala);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }

            salas[codigoSala].NombreAnfitrion = nombreJugador;
        }
    }
    #endregion

    #region Métodos privados
    public partial class ServicioRompecabezasFei
    {
        private void CambiarEstadoJugador(string nombreJugador, 
            EstadoJugador nuevoEstado)
        {
            EstadoJugador estadoAnterior = jugadoresActivos[nombreJugador].Estado;

            switch (nuevoEstado)
            {
                case EstadoJugador.Conectado:
                case EstadoJugador.EnSala:
                case EstadoJugador.EnPartida:

                    if (estadoAnterior == EstadoJugador.Disponible)
                    {
                        NotificarAnfitrionesSobreAmigoNoDisponible(nombreJugador);
                    }
                    else
                    {
                        NotificarAmigosSobreCambioEstadoJugador(nombreJugador, nuevoEstado);
                    }

                    break;

                case EstadoJugador.Desconectado:
                    jugadoresActivos.TryRemove(nombreJugador, out _);
                    NotificarAmigosSobreCambioEstadoJugador(nombreJugador, nuevoEstado);
                    break;

                case EstadoJugador.Disponible:
                    NotificarAnfitrionesSobreAmigoDisponible(nombreJugador);
                    NotificarAmigosSobreCambioEstadoJugador(nombreJugador, nuevoEstado);

                    break;
            }

            if (nuevoEstado != EstadoJugador.Desconectado)
            {
                jugadoresActivos[nombreJugador].Estado = nuevoEstado;
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
            return jugadoresActivos.Values.Where(jugador => 
                !jugador.EsInvitado && ExisteAmistadConJugador(nombreJugador, 
                jugador.NombreJugador)).ToList();
        }

        private bool RemoverJugadorDeSala(string nombreJugador, 
            string codigoSala)
        {
            bool operacionRealizada = false;

            if (salas.ContainsKey(codigoSala) && salas[codigoSala].
                RemoverNombreDeJugador(nombreJugador))
            {
                operacionRealizada = true;

                foreach (var jugadorEnSala in 
                    ObtenerJugadoresEnSala(codigoSala))
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                if (!salas[codigoSala].EstaVacia())
                {
                    if (EsJugadorAnfitrion(nombreJugador, codigoSala))
                    {
                        ElegirNuevoAnfitrion(codigoSala);
                    }
                    
                    if (!salas[codigoSala].HayCantidadJugadoresMinimaParaPartida())
                    {
                        DeshabilitarInicioDePartida(codigoSala);
                    }
                }
                else
                {
                    salas.TryRemove(codigoSala, out _);
                }
            }

            return operacionRealizada;
        }

        private void RemoverJugadorDePartida(string nombreJugador, 
            string codigoSala)
        {
            if (salas.ContainsKey(codigoSala) && salas[codigoSala].
                Partida.RemoverNombreDeJugador(nombreJugador))
            {
                foreach (var jugadorEnPartida in 
                    ObtenerJugadoresEnPartida(codigoSala))
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }

                if (!salas[codigoSala].Partida.
                    HayCantidadMinimaJugadoresParaPartida())
                {
                    CancelarPartidaEnCurso(codigoSala);
                }
                else if (EsJugadorAnfitrion(nombreJugador, codigoSala))
                {
                    ElegirNuevoAnfitrion(codigoSala);
                }
            }
        }

        private void NotificarCreacionDePartidaAJugadores(string codigoSala)
        {
            salas[codigoSala].Partida.Estado = EstadoPartida.EnCurso;

            foreach (var jugadorEnSala in 
                ObtenerJugadoresEnSala(codigoSala).Where(jugador => 
                jugador.NombreJugador != salas[codigoSala].NombreAnfitrion))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }

        private void CancelarPartidaEnCurso(string codigoSala)
        {
            foreach (var jugadorEnPartida in 
                ObtenerJugadoresEnPartida(codigoSala))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }

            salas[codigoSala].Partida.Estado = EstadoPartida.Cancelada;
        }

        private void HabilitarInicioDePartida(string codigoSala)
        {
            if (jugadoresActivos[salas[codigoSala].NombreAnfitrion].
                TipoInterfazCallback == typeof(IServicioSalaCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }

        private void DeshabilitarInicioDePartida(string codigoSala)
        {
            if (jugadoresActivos[salas[codigoSala].NombreAnfitrion].
                TipoInterfazCallback == typeof(IServicioSalaCallback))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }
        
        private void ElegirNuevoAnfitrion(string codigoSala)
        {
            if (salas[codigoSala].HayPartidaCreada)
            {
                var nuevoAnfitrionEnPartida = ObtenerJugadoresEnPartida(
                    codigoSala).FirstOrDefault();
                
                try
                {
                    nuevoAnfitrionEnPartida?.ContextoOperacion?.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        MostrarFuncionesDeAnfitrionEnPartida();
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    ElegirNuevoAnfitrion(codigoSala);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }

                salas[codigoSala].NombreAnfitrion =
                    nuevoAnfitrionEnPartida.NombreJugador;
            }
            else
            {
                var nuevoAnfitrionEnSala = ObtenerJugadoresEnSala(
                    codigoSala).FirstOrDefault();

                try
                {
                    nuevoAnfitrionEnSala?.ContextoOperacion?.
                        GetCallbackChannel<IServicioSalaCallback>().
                        MostrarFuncionesDeAnfitrionEnSala();
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    ElegirNuevoAnfitrion(codigoSala);
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }

                salas[codigoSala].NombreAnfitrion = 
                    nuevoAnfitrionEnSala.NombreJugador;
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
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

            foreach (var sala in salas.Values.Where(sala => 
                sala.Partida?.Estado == EstadoPartida.SinIniciar))
            {
                nombresDeAnfitriones.Add(sala.NombreAnfitrion);
            }

            return nombresDeAnfitriones;
        }

        private string ObtenerCodigoSalaDeJugador(string nombreJugador)
        {
            string codigoSala = "";

            if (jugadoresActivos[nombreJugador].Estado == EstadoJugador.EnSala || 
                jugadoresActivos[nombreJugador].Estado == EstadoJugador.EnPartida)
            {
                try
                {
                    codigoSala = salas.Values.First(sala => sala.
                        NombresDeJugadores.Keys.Any(nombre => nombre == nombreJugador) ||
                        (string.IsNullOrEmpty(codigoSala) &&
                        sala.Partida.PuntajesDeJugadores.Keys.Any(
                        nombre => nombre == nombreJugador)))?.CodigoSala;
                }
                catch (InvalidOperationException excepcion) 
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }

            return codigoSala;
        }

        private void NotificarAnfitrionesSobreAmigoDisponible(
            string nombreJugador)
        {
            foreach (var nombreAnfitrion in ObtenerNombresDeAnfitrionesEnSala().
                Where(nombreAnfitrion => jugadoresActivos[nombreAnfitrion].
                TipoInterfazCallback == typeof(IServicioSalaCallback)))
            {
                if (ExisteAmistadConJugador(nombreJugador, nombreAnfitrion))
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }
        }

        private void NotificarAnfitrionesSobreAmigoNoDisponible(
            string nombreJugador)
        {
            foreach (var nombreAnfitrion in ObtenerNombresDeAnfitrionesEnSala().
                Where(nombreAnfitrion => jugadoresActivos[nombreAnfitrion].
                TipoInterfazCallback == typeof(IServicioSalaCallback)))
            {
                if (ExisteAmistadConJugador(nombreJugador, nombreAnfitrion))
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
                    }
                    catch (InvalidCastException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                    }
                }
            }
        }

        private void NotificarAmigosSobreCambioEstadoJugador(string nombreJugador, 
            EstadoJugador estado)
        {
            foreach (var jugador in ObtenerAmigosConectados(nombreJugador).
                Where(jugador => jugador.TipoInterfazCallback == 
                typeof(IServicioAmistadesCallback)))
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
                }
                catch (InvalidCastException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                }
            }
        }
    }
    #endregion
}