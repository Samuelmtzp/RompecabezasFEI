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
    public partial class PaginaAmistades : Page
    {
        private ObservableCollection<Dominio.CuentaJugador> cuentasAmigo;
        private ObservableCollection<Dominio.CuentaJugador> cuentasSolicitud;
        private ServicioAmistadesClient cliente;

        public ObservableCollection<Dominio.CuentaJugador> CuentasAmigo
        {
            get { return cuentasAmigo; } 
            set { cuentasAmigo = value; } 
        }
        
        public ObservableCollection<Dominio.CuentaJugador> CuentasSolicitud
        {
            get { return cuentasSolicitud; }
            set { cuentasSolicitud = value; }
        }

        public PaginaAmistades()
        {
            InitializeComponent();
            listaAmigos.DataContext = this;
            listaSolicitudes.DataContext = this;
            cliente = new ServicioAmistadesClient(new InstanceContext(
                ServicioAmistadesCallback.Actual));
            CargarAmigosJugador();
            CargarJugadoresConSolicitudPendiente();
            SuscribirJugadorANotificaciones();
        }

        #region Métodos privados        
        private void CargarAmigosJugador()
        {
            cuentasAmigo = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] amigosObtenidos = null;
            
            try
            {
                amigosObtenidos = cliente.ObtenerAmigosDeJugador(Dominio.CuentaJugador.
                    Actual.NombreJugador);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

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
                        ColorEstadoConectividad = ObtenerColorEstadoConectividadJugador(
                            amigo.EstadoConectividad),
                    };
                    cuentasAmigo.Add(cuentaAmigo);
                }
            }
        }

        private void CargarJugadoresConSolicitudPendiente()
        {
            cuentasSolicitud = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] jugadoresObtenidos = null;

            try
            {
                jugadoresObtenidos = cliente.ObtenerJugadoresConSolicitudPendiente(
                    Dominio.CuentaJugador.Actual.NombreJugador);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            if (jugadoresObtenidos != null && jugadoresObtenidos.Count() > 0)
            {                
                foreach (CuentaJugador jugador in jugadoresObtenidos)
                {
                    cuentasSolicitud.Add(new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(jugador.NumeroAvatar),
                        ColorEstadoConectividad = ObtenerColorEstadoConectividadJugador(
                            jugador.EstadoConectividad),
                    });
                }
            } 
        }

        private void SuscribirJugadorANotificaciones()
        {
            ServicioGestionJugadorCallback.Actual.PaginaAmistades = this;
            ServicioAmistadesCallback.Actual.PaginaAmistades = this;

            try
            {
                cliente.SuscribirJugadorANotificacionesAmistades(
                   Dominio.CuentaJugador.Actual.NombreJugador);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
        }

        private SolidColorBrush ObtenerColorEstadoConectividadJugador(
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

        private bool EnviarSolicitudDeAmistad()
        {
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool resultado = false;

            try 
            {
                resultado = cliente.EnviarSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            return resultado;
        }

        private bool EliminarAmigo()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaAmigos.SelectedItem;
            string nombreJugadorA = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorB = jugadorSeleccionado.NombreJugador;
            bool resultado = false;

            try
            {
                resultado = cliente.EliminarAmistadEntreJugadores(nombreJugadorA, 
                    nombreJugadorB);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            if (resultado)
            {
                cuentasAmigo.Remove(jugadorSeleccionado);
            }

            return resultado;
        }

        private bool AceptarSolicitudDeAmistad()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaSolicitudes.SelectedItem;
            bool resultado = false;

            if (jugadorSeleccionado != null)
            {
                string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
                string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;
                
                try
                {
                    resultado = cliente.AceptarSolicitudDeAmistad(nombreJugadorOrigen, 
                        nombreJugadorDestino);
                }
                catch (CommunicationException)
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    cliente.Abort();
                }
                catch (TimeoutException)
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    cliente.Abort();
                }
            }

            if (resultado)
            {
                cuentasSolicitud.Remove(jugadorSeleccionado);
                cuentasAmigo.Add(jugadorSeleccionado);
            }

            return resultado;
        }

        private bool RechazarSolicitudDeAmistad()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaSolicitudes.SelectedItem;
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.
                Actual.NombreJugador;
            bool resultado = false;
            
            try
            {
                resultado = cliente.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            if (resultado)
            {
                cuentasSolicitud.Remove(jugadorSeleccionado);
            }

            return resultado;
        }
        #endregion

        #region Validaciones
        private bool ExisteNombreJugador()
        {            
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;            
            bool existeNombreJugador = false;

            try
            {
                existeNombreJugador = VentanaPrincipal.ClienteServicioGestionJugador.ExisteNombreJugador(
                    nombreJugadorDestino);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            if (!existeNombreJugador)
            {
                MessageBox.Show("No se encontró el nombre de jugador", 
                    "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return existeNombreJugador;
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
            bool existeSolicitudSinAceptar = false;

            try
            {
                existeSolicitudSinAceptar = cliente.ExisteSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

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
            bool existeAmistad = false;

            try
            {
                existeAmistad = cliente.ExisteAmistadConJugador(nombreJugadorOrigen, 
                    nombreJugadorDestino);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            if (existeAmistad)
            {
                MessageBox.Show("No se envió la solicitud de amistad debido a que " +
                    "ya eres amigo del jugador", "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return existeAmistad;
        }
        #endregion

        #region Eventos
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void EventoClickEnviarSolicitud(object controlOrigen, RoutedEventArgs evento)
        {
            if (!EsElNombreDelJugadorActual() && ExisteNombreJugador() && 
                !ExisteSolicitudDeAmistad() && !ExisteAmistadConJugador())
            {
                if (EnviarSolicitudDeAmistad())
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

        private void EventoClickEliminarAmigo(object controlOrigen, RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaAmigos.ContainerFromElement(
                (Button)controlOrigen);
            filaActual.IsSelected = true;

            if (!EliminarAmigo())
            {
                MessageBox.Show("No se ha podido eliminar al amigo de la lsita de amigos",
                    "Error al eliminar amigo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EventoClickAceptarSolicitudAmistad(object controlOrigen,
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)controlOrigen);
            filaActual.IsSelected = true;

            if (!AceptarSolicitudDeAmistad())
            {
                MessageBox.Show("No se ha podido marcar como aceptada la solicitud de amistad",
                        "Error al aceptar solicitud de amistad",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EventoClickRechazarSolicitudAmistad(object controlOrigen,
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)controlOrigen);
            filaActual.IsSelected = true;

            if (!RechazarSolicitudDeAmistad())
            {
                MessageBox.Show("No se ha podido marcar como rechazada la solicitud de amistad",
                    "Error al rechazar solicitud de amistad",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ModificarEstadoConectividadDeJugador(string nombreJugador, 
            EstadoConectividadJugador estado)
        {
            if (cuentasAmigo != null)
            {
                var cuentaAmigoModificacion = cuentasAmigo.Where(amigo =>
                    amigo.NombreJugador == nombreJugador).FirstOrDefault();
                cuentasAmigo.Remove(cuentaAmigoModificacion);
                
                if (cuentaAmigoModificacion != null)
                {
                    switch (estado)
                    {
                        case EstadoConectividadJugador.Desconectado:
                            cuentaAmigoModificacion.ColorEstadoConectividad = Brushes.Gray;
                            break;
                        case EstadoConectividadJugador.Conectado:
                            cuentaAmigoModificacion.ColorEstadoConectividad = Brushes.Green;
                            break;
                        case EstadoConectividadJugador.EnPartida:
                            cuentaAmigoModificacion.ColorEstadoConectividad = Brushes.Red;
                            break;
                    }
                }
                
                cuentasAmigo.Insert(0, cuentaAmigoModificacion);
            }
        }

        public void NotificarSolicitudAmistadEnviada(CuentaJugador cuentaNuevaSolicitud)
        {
            if (cuentasSolicitud != null)
            {
                cuentasSolicitud.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = cuentaNuevaSolicitud.NombreJugador,
                    NumeroAvatar = cuentaNuevaSolicitud.NumeroAvatar,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(cuentaNuevaSolicitud.NumeroAvatar),
                    ColorEstadoConectividad = ObtenerColorEstadoConectividadJugador(
                        cuentaNuevaSolicitud.EstadoConectividad)
                });
            }
        }

        public void NotificarSolicitudAmistadAceptada(CuentaJugador cuentaNuevoAmigo)
        {
            if (cuentasAmigo != null)
            {
                cuentasAmigo.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = cuentaNuevoAmigo.NombreJugador,
                    NumeroAvatar = cuentaNuevoAmigo.NumeroAvatar,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(cuentaNuevoAmigo.NumeroAvatar),
                    ColorEstadoConectividad = ObtenerColorEstadoConectividadJugador(
                        cuentaNuevoAmigo.EstadoConectividad)
                });
            }
        }

        public void NotificarAmistadEliminada(string nombreAmigoEliminacion)
        {
            if (cuentasAmigo != null)
            {
                var cuentaAmigoEliminacion = cuentasAmigo.Where(amigo =>
                    amigo.NombreJugador == nombreAmigoEliminacion).FirstOrDefault();
                
                if (cuentaAmigoEliminacion != null)
                {
                    cuentasAmigo.Remove(cuentaAmigoEliminacion);
                }                
            }
        }

        private void EventoPaginaCerrada(object objetoOrigen, RoutedEventArgs evento)
        {            
            ServicioGestionJugadorCallback.Actual.PaginaAmistades = null;
            ServicioAmistadesCallback.Actual.PaginaAmistades = null;
            
            try
            {
                cliente.DesuscribirJugadorDeNotificacionesAmistades(Dominio.CuentaJugador.
                    Actual.NombreJugador);                
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                cliente.Abort();
            }
        }
        #endregion
    }

    public class ServicioGestionJugadorCallback : IServicioGestionJugadorCallback
    {
        private PaginaAmistades paginaAmistades;
        private static ServicioGestionJugadorCallback actual;

        public PaginaAmistades PaginaAmistades
        {
            get { return paginaAmistades; } 
            set { paginaAmistades = value; }
        }

        public static ServicioGestionJugadorCallback Actual
        {
            get 
            { 
                if (actual == null)
                {
                    actual = new ServicioGestionJugadorCallback();
                }

                return actual; 
            }
        }

        public void NotificarEstadoConectividadDeJugador(string nombreJugador, 
            EstadoConectividadJugador estado)
        {
            paginaAmistades?.ModificarEstadoConectividadDeJugador(nombreJugador, estado);
        }
    }

    public class ServicioAmistadesCallback : IServicioAmistadesCallback
    {
        private PaginaAmistades paginaAmistades;
        private static ServicioAmistadesCallback actual;

        public PaginaAmistades PaginaAmistades
        {
            get { return paginaAmistades; }
            set { paginaAmistades = value; }
        }

        public static ServicioAmistadesCallback Actual
        {
            get
            {
                if (actual == null)
                {
                    actual = new ServicioAmistadesCallback();
                }

                return actual;
            }
        }

        public void NotificarSolicitudAmistadEnviada(CuentaJugador cuentaNuevaSolicitud)
        {
            paginaAmistades?.NotificarSolicitudAmistadEnviada(cuentaNuevaSolicitud);
        }

        public void NotificarSolicitudAmistadAceptada(CuentaJugador cuentaNuevoAmigo)
        {
            paginaAmistades?.NotificarSolicitudAmistadAceptada(cuentaNuevoAmigo);
        }

        public void NotificarAmistadEliminada(string nombreAmigoEliminacion)
        {
            paginaAmistades?.NotificarAmistadEliminada(nombreAmigoEliminacion);
        }
    }
}