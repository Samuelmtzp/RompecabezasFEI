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
        private CuentaJugador cuentaJugadorSeleccion; 
        private ObservableCollection<Dominio.CuentaJugador> cuentasAmigo;
        private ObservableCollection<Dominio.CuentaJugador> cuentasSolicitud;
        
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
            CargarAmigosJugador();
            CargarJugadoresConSolicitudEnviada();
        }

        #region Métodos privados
        private void CargarAmigosJugador()
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            CuentaJugador[] amigosObtenidos = null;
            
            try
            {
                amigosObtenidos = cliente.ObtenerAmigosDeJugador(Dominio.CuentaJugador.
                    Actual.NombreJugador);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }            

            if (amigosObtenidos != null && amigosObtenidos.Count() > 0)
            {
                cuentasAmigo = new ObservableCollection<Dominio.CuentaJugador>();
                etiquetaSinAmigos.Visibility = Visibility.Hidden;

                foreach (CuentaJugador amigo in amigosObtenidos)
                {
                    cuentasAmigo.Add(new Dominio.CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(amigo.NumeroAvatar),
                        ColorEstadoConectividad = Brushes.Gray,
                    });
                }
            }
            else
            {
                etiquetaSinAmigos.Visibility = Visibility.Visible;
            }
        }

        private void CargarJugadoresConSolicitudEnviada()
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            CuentaJugador[] jugadoresObtenidos = null;

            try
            {
                jugadoresObtenidos = cliente.ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
                    Dominio.CuentaJugador.Actual.NombreJugador);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            if (jugadoresObtenidos != null && jugadoresObtenidos.Count() > 0)
            {
                cuentasSolicitud = new ObservableCollection<Dominio.CuentaJugador>();
                etiquetaSinSolicitudesAmistad.Visibility = Visibility.Hidden;

                foreach (CuentaJugador jugador in jugadoresObtenidos)
                {
                    cuentasSolicitud.Add(new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(jugador.NumeroAvatar),
                    });
                }
            } 
            else
            {
                etiquetaSinSolicitudesAmistad.Visibility = Visibility.Visible;
            }
        }

        private bool EnviarSolicitudDeAmistad()
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool resultado = false;

            try 
            {
                resultado = cliente.EnviarSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            return resultado;
        }

        private bool EliminarAmigo()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaAmigos.SelectedItem;
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorA = jugadorSeleccionado.NombreJugador;
            string nombreJugadorB = Dominio.CuentaJugador.Actual.NombreJugador;            
            bool resultado = false;

            try
            {
                resultado = cliente.EliminarAmistadEntreJugadores(nombreJugadorA, nombreJugadorB);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
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
                ServicioAmistadesClient cliente = new ServicioAmistadesClient();
                string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
                string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;
                
                try
                {
                    resultado = cliente.AceptarSolicitudDeAmistad(nombreJugadorOrigen, 
                        nombreJugadorDestino);
                    cliente.Close();
                }
                catch (EndpointNotFoundException)
                {
                    cliente.Abort();
                }
            }

            return resultado;
        }

        private bool AgregarAmistadEntreJugadores()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaSolicitudes.SelectedItem;
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;
            bool resultado = false;

            try
            {
                resultado = cliente.RegistrarNuevaAmistadEntreJugadores(nombreJugadorOrigen, 
                    nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            return resultado;
        }

        private bool RechazarSolicitudDeAmistad()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaSolicitudes.SelectedItem;
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.
                Actual.NombreJugador;
            bool resultado = false;
            
            try
            {
                resultado = cliente.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            return resultado;
        }
        #endregion

        #region Validaciones
        private bool ExisteNombreJugador()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient(); 
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;            
            bool existeNombreJugador = false;

            try
            {
                existeNombreJugador = cliente.ExisteNombreJugador(nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
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

            if (Dominio.CuentaJugador.Actual.NombreJugador.
                Equals(nombreJugadorDestino))
            {
                resultado = true;
                MessageBox.Show("No se envió la solicitud de amistad debido a que el nombre " +
                    "del jugador es el mismo que tienes tú",
                    "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return resultado;
        }

        private bool ExisteSolicitudDeAmistadSinAceptar()
        {            
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador; 
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;            
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            bool existeSolicitudSinAceptar = false;

            try
            {
                existeSolicitudSinAceptar = cliente.ExisteSolicitudDeAmistadSinAceptar(
                    nombreJugadorOrigen, nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
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
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            bool existeAmistad = false;

            try
            {
                existeAmistad = cliente.ExisteAmistadConJugador(nombreJugadorOrigen, 
                    nombreJugadorDestino);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
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
                !ExisteSolicitudDeAmistadSinAceptar() && !ExisteAmistadConJugador())
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

            if (EliminarAmigo())
            {
                CargarAmigosJugador();
                MessageBox.Show("Se ha eliminado al amigo de la lista de amigos",
                        "Amigo eliminado correctamente",
                        MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
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

            if (AceptarSolicitudDeAmistad())
            {
                CargarJugadoresConSolicitudEnviada();
                MessageBox.Show("La solicitud de amistad ha sido aceptada",
                        "Solicitud de amistad aceptada",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                if (AgregarAmistadEntreJugadores())
                {
                    // Agregar al jugador a la lista de amigos
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar como amigo al otro jugador",
                        "Error al agregar como amigo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha podido marcar como aceptada la solicitud de amistad",
                        "Error al aceptar solicitud de amistad",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }

            filaActual.IsSelected = false;
        }

        private void EventoClickRechazarSolicitudAmistad(object controlOrigen,
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)controlOrigen);
            filaActual.IsSelected = true;

            if (RechazarSolicitudDeAmistad())
            {
                //// CargarJugadoresConSolicitudEnviada();
                //amigosJugador.Remove();
                MessageBox.Show("La solicitud de amistad ha sido rechazada",
                        "Solicitud de amistad rechazada",
                        MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido marcar como rechazada la solicitud de amistad",
                        "Error al rechazar solicitud de amistad",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }

            filaActual.IsSelected = false;
        }
        #endregion
    }
}