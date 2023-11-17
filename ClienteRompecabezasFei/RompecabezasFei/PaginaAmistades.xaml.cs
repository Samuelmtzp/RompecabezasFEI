using RompecabezasFei.ServicioRompecabezasFei;
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
        private ObservableCollection<Dominio.CuentaJugador> cuentasDeAmigos;
        private ObservableCollection<Dominio.CuentaJugador> cuentasDeSolicitudes;
        private ServicioAmistadesClient clienteServicioAmistades;

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeAmigos
        {
            get { return cuentasDeAmigos; }
            set { cuentasDeAmigos = value; }
        }

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeSolicitudes
        {
            get { return cuentasDeSolicitudes; }
            set { cuentasDeSolicitudes = value; }
        }

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
            cuentasDeAmigos = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] amigosObtenidos = Servicios.ServicioAmistades.
                ObtenerAmigosDeJugador(Dominio.CuentaJugador.Actual.NombreJugador);

            if (amigosObtenidos != null && amigosObtenidos.Count() > 0)
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
                    cuentasDeAmigos.Add(cuentaAmigo);
                }
            }
        }

        private void CargarJugadoresConSolicitudPendiente()
        {
            cuentasDeSolicitudes = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] jugadoresObtenidos = Servicios.ServicioAmistades.
                ObtenerJugadoresConSolicitudPendiente(Dominio.CuentaJugador.Actual.NombreJugador);

            if (jugadoresObtenidos != null && jugadoresObtenidos.Count() > 0)
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
                    cuentasDeSolicitudes.Add(cuentaSolicitud);
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
                MessageBox.Show("No se envió la solicitud de amistad debido a " +
                    "que el nombre del jugador es el mismo que tienes tú",
                    "Error al enviar solicitud de amistad",
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
                MessageBox.Show("No se envió la solicitud de amistad debido a que " +
                    "anteriormente ya le has enviado una solicitud de amistad al jugador",
                    "Error al enviar solicitud de amistad",
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
                MessageBox.Show("No se envió la solicitud de amistad debido a que " +
                    "ya eres amigo del jugador", "Error al enviar solicitud de amistad",
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
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }

                if (envioSolicitudRealizado)
                {
                    MessageBox.Show("Se ha enviado la solicitud de amistad correctamente",
                        "Solicitud de amistad enviada",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("No se ha enviado la solicitud de amistad al jugador",
                        "Error al enviar solicitud de amistad",
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }

            if (eliminacionRealizada)
            {
                cuentasDeAmigos.Remove(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar al amigo de la lsita de amigos",
                    "Error al eliminar amigo",
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
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    //Registros.Registros.escribirRegistro(excepcion.Message);
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    clienteServicioAmistades.Abort();
                }
            }

            if (solicitudAceptada)
            {
                cuentasDeSolicitudes.Remove(jugadorSeleccionado);
                cuentasDeAmigos.Add(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show("No se ha podido marcar como aceptada la solicitud de amistad",
                    "Error al aceptar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RechazarSolicitudDeAmistad(object controlOrigen, RoutedEventArgs evento)
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }

            if (solicitudRechazada)
            {
                cuentasDeSolicitudes.Remove(jugadorSeleccionado);
            }
            else
            {
                MessageBox.Show("No se ha podido marcar como rechazada la solicitud de amistad",
                    "Error al rechazar solicitud de amistad",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void NotificarEstadoConectividadDeJugador(string nombreJugador,
            EstadoConectividadJugador estado)
        {
            if (cuentasDeAmigos != null)
            {
                var cuentaAmigoModificacion = cuentasDeAmigos.Where(amigo =>
                    amigo.NombreJugador == nombreJugador).FirstOrDefault();
                cuentasDeAmigos.Remove(cuentaAmigoModificacion);

                if (cuentaAmigoModificacion != null)
                {
                    cuentaAmigoModificacion.ColorEstadoConectividad =
                        ObtenerColorSegunEstadoConectividad(estado);
                }

                cuentasDeAmigos.Insert(0, cuentaAmigoModificacion);
            }
        }

        public void NotificarSolicitudAmistadEnviada(CuentaJugador cuentaNuevaSolicitud)
        {
            if (cuentasDeSolicitudes != null)
            {
                cuentasDeSolicitudes.Add(new Dominio.CuentaJugador
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
            if (cuentasDeAmigos != null)
            {
                var solicitudAmistadResidual = cuentasDeSolicitudes.Where(cuentaSolicitud =>
                    cuentaSolicitud.NombreJugador ==
                    cuentaNuevoAmigo.NombreJugador).FirstOrDefault();

                if (solicitudAmistadResidual != null)
                {
                    cuentasDeSolicitudes.Remove(solicitudAmistadResidual);
                }

                cuentasDeAmigos.Add(new Dominio.CuentaJugador
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
            if (cuentasDeAmigos != null)
            {
                var cuentaAmigoEliminacion = cuentasDeAmigos.Where(amigo =>
                    amigo.NombreJugador == nombreAmigoEliminacion).FirstOrDefault();

                if (cuentaAmigoEliminacion != null)
                {
                    cuentasDeAmigos.Remove(cuentaAmigoEliminacion);
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioAmistades.Abort();
            }
        }
    }
}
