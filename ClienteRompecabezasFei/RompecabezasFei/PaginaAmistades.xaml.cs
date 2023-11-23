using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaAmistades : Page, IServicioAmistadesCallback
    {
        private ServicioAmistadesClient clienteServicioAmistades;

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeAmigos { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeSolicitudes { get; set; }

        public PaginaAmistades(bool inicializarDatos)
        {
            if (inicializarDatos)
            {
                InitializeComponent();
                listaAmigos.DataContext = this;
                listaSolicitudes.DataContext = this;
                clienteServicioAmistades = new ServicioAmistadesClient(new InstanceContext(this));
                CargarAmigosJugador();
                CargarJugadoresConSolicitudPendiente();
                SuscribirJugadorANotificaciones();
            }
        }

        private void CargarAmigosJugador()
        {
            CuentasDeAmigos = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] amigosObtenidos = Servicios.ServicioAmistades.
                ObtenerAmigosDeJugador(Dominio.CuentaJugador.Actual.NombreJugador);

            if (amigosObtenidos != null && amigosObtenidos.Any())
            {
                foreach (CuentaJugador amigo in amigosObtenidos)
                {
                    Dominio.CuentaJugador cuentaAmigo = new Dominio.CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(amigo.NumeroAvatar),
                        ColorEstadoConectividad = ObtenerColorSegunEstadoConectividad(
                            amigo.EstadoConectividad),
                    };
                    CuentasDeAmigos.Add(cuentaAmigo);
                }
            }
        }

        private void CargarJugadoresConSolicitudPendiente()
        {
            CuentasDeSolicitudes = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] jugadoresObtenidos = Servicios.ServicioAmistades.
                ObtenerJugadoresConSolicitudPendiente(Dominio.CuentaJugador.Actual.NombreJugador);

            if (jugadoresObtenidos != null && jugadoresObtenidos.Any())
            {
                foreach (CuentaJugador jugador in jugadoresObtenidos)
                {
                    Dominio.CuentaJugador cuentaSolicitud = new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(jugador.NumeroAvatar),
                        ColorEstadoConectividad = ObtenerColorSegunEstadoConectividad(
                            jugador.EstadoConectividad),
                    };
                    CuentasDeSolicitudes.Add(cuentaSolicitud);
                }
            }
        }

        private void SuscribirJugadorANotificaciones()
        {
            try
            {
                clienteServicioAmistades.SuscribirJugadorANotificacionesAmistades(
                   Dominio.CuentaJugador.Actual.NombreJugador);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
        }

        private SolidColorBrush ObtenerColorSegunEstadoConectividad(
            EstadoConectividadJugador estado)
        {
            SolidColorBrush color;

            switch (estado)
            {
                case EstadoConectividadJugador.Conectado:
                    color = Brushes.Green;
                    break;
                case EstadoConectividadJugador.EnPartida:
                    color = Brushes.Red;
                    break;
                default:
                    color = Brushes.Gray;
                    break;
            }

            return color;
        }

        private bool EsElNombreDelJugadorActual()
        {
            bool resultado = false;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;

            if (Dominio.CuentaJugador.Actual.NombreJugador.Equals(nombreJugadorDestino))
            {
                resultado = true;
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_SOLICITUDNOENVIADAMISMONOMBRE,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return resultado;
        }

        private bool ExisteSolicitudDeAmistad()
        {
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool existeSolicitudSinAceptar = Servicios.ServicioAmistades.
                ExisteSolicitudAmistad(nombreJugadorOrigen, nombreJugadorDestino);

            if (existeSolicitudSinAceptar)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_MENSAJESOLICITUDNOENVIADA,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return existeSolicitudSinAceptar;
        }

        private bool ExisteAmistadConJugador()
        {
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool existeAmistad = Servicios.ServicioAmistades.ExisteAmistadConJugador(
                nombreJugadorOrigen, nombreJugadorDestino);

            if (existeAmistad)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_SOLICITUDNOENVIADAYAESAMIGO,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return existeAmistad;
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void EnviarSolicitudDeAmistad(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!EsElNombreDelJugadorActual() && Servicios.ServicioJugador.
                ExisteNombreJugador(cuadroTextoNombreUsuarioInvitacion.Text) &&
                !ExisteSolicitudDeAmistad() && !ExisteAmistadConJugador())
            {
                string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
                string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
                bool envioSolicitudRealizado = false;

                try
                {
                    envioSolicitudRealizado = clienteServicioAmistades.
                        EnviarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
                }
                catch (EndpointNotFoundException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }

                if (envioSolicitudRealizado)
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_AMISTADES_MENSAJESOLICTUDENVIADA,Properties.Resources.
                        ETIQUETA_AMISTADES_SOLICITUDENVIADA,
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_AMISTADES_SOLICITUDNOENVIADA,Properties.Resources.
                        ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void EliminarAmigo(object objetoOrigen, RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaAmigos.ContainerFromElement(
                (Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaAmigos.SelectedItem;
            string nombreJugadorA = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorB = jugadorSeleccionado.NombreJugador;
            bool eliminacionRealizada = false;

            try
            {
                eliminacionRealizada = clienteServicioAmistades.
                    EliminarAmistadEntreJugadores(nombreJugadorA, nombreJugadorB);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }

            if (eliminacionRealizada)
            {
                CuentasDeAmigos.Remove(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_MENSAJEERRORELIMINARAMIGO,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORELIMINARAMIGO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AceptarSolicitudDeAmistad(object objetoOrigen,
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaSolicitudes.SelectedItem;
            bool solicitudAceptada = false;

            if (jugadorSeleccionado != null)
            {
                string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
                string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;

                try
                {
                    solicitudAceptada = clienteServicioAmistades.AceptarSolicitudDeAmistad(
                        nombreJugadorOrigen, nombreJugadorDestino);
                }
                catch (EndpointNotFoundException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioAmistades.Abort();
                }
            }

            if (solicitudAceptada)
            {
                CuentasDeSolicitudes.Remove(jugadorSeleccionado);
                CuentasDeAmigos.Add(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_MENSAJEERRORACEPTARSOLICITUD,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORACEPTARSOLICITUD,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RechazarSolicitudDeAmistad(object objetoOrigen, RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaSolicitudes.SelectedItem;
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;
            bool solicitudRechazada = false;

            try
            {
                solicitudRechazada = clienteServicioAmistades.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }

            if (solicitudRechazada)
            {
                CuentasDeSolicitudes.Remove(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_AMISTADES_MENSAJEERRORRECHAZARSOLICITUD,Properties.Resources.
                    ETIQUETA_AMISTADES_ERRORRECHAZARSOLICITUD,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void NotificarEstadoConectividadDeJugador(string nombreJugador,
            EstadoConectividadJugador estado)
        {
            if (CuentasDeAmigos != null)
            {
                var cuentaAmigoModificacion = CuentasDeAmigos.FirstOrDefault(amigo =>
                    amigo.NombreJugador == nombreJugador);
                CuentasDeAmigos.Remove(cuentaAmigoModificacion);

                if (cuentaAmigoModificacion != null)
                {
                    cuentaAmigoModificacion.ColorEstadoConectividad =
                        ObtenerColorSegunEstadoConectividad(estado);
                }

                CuentasDeAmigos.Insert(0, cuentaAmigoModificacion);
            }
        }

        public void NotificarSolicitudAmistadEnviada(CuentaJugador cuentaNuevaSolicitud)
        {
            if (CuentasDeSolicitudes != null)
            {
                CuentasDeSolicitudes.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = cuentaNuevaSolicitud.NombreJugador,
                    NumeroAvatar = cuentaNuevaSolicitud.NumeroAvatar,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(cuentaNuevaSolicitud.NumeroAvatar),
                    ColorEstadoConectividad = ObtenerColorSegunEstadoConectividad(
                        cuentaNuevaSolicitud.EstadoConectividad)
                });
            }
        }

        public void NotificarSolicitudAmistadAceptada(CuentaJugador cuentaNuevoAmigo)
        {
            if (CuentasDeAmigos != null)
            {
                var solicitudAmistadResidual = CuentasDeSolicitudes.FirstOrDefault(cuentaSolicitud =>
                    cuentaSolicitud.NombreJugador ==
                    cuentaNuevoAmigo.NombreJugador);

                if (solicitudAmistadResidual != null)
                {
                    CuentasDeSolicitudes.Remove(solicitudAmistadResidual);
                }

                CuentasDeAmigos.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = cuentaNuevoAmigo.NombreJugador,
                    NumeroAvatar = cuentaNuevoAmigo.NumeroAvatar,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(cuentaNuevoAmigo.NumeroAvatar),
                    ColorEstadoConectividad = ObtenerColorSegunEstadoConectividad(
                        cuentaNuevoAmigo.EstadoConectividad)
                });
            }
        }

        public void NotificarAmistadEliminada(string nombreAmigoEliminacion)
        {
            if (CuentasDeAmigos != null)
            {
                var cuentaAmigoEliminacion = CuentasDeAmigos.FirstOrDefault(amigo =>
                    amigo.NombreJugador == nombreAmigoEliminacion);

                if (cuentaAmigoEliminacion != null)
                {
                    CuentasDeAmigos.Remove(cuentaAmigoEliminacion);
                }
            }
        }

        private void DesuscribirJugadorDeNotificaciones(object objetoOrigen,
            RoutedEventArgs evento)
        {
            try
            {
                clienteServicioAmistades.DesuscribirJugadorDeNotificacionesAmistades(
                    Dominio.CuentaJugador.Actual.NombreJugador);
                clienteServicioAmistades.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioAmistades.Abort();
            }
        }
    }
}