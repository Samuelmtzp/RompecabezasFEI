using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaAmistades : Page
    {
        private ObservableCollection<Dominio.CuentaJugador> amigosJugador;
        private ObservableCollection<Dominio.CuentaJugador> jugadoresConSolicitudEnviada;
        
        public ObservableCollection<Dominio.CuentaJugador> AmigosJugador
        {
            get { return amigosJugador; } 
            set { amigosJugador = value; } 
        }
        
        public ObservableCollection<Dominio.CuentaJugador> JugadoresConSolicitudEnviada
        {
            get { return jugadoresConSolicitudEnviada; }
            set { jugadoresConSolicitudEnviada = value; }
        }

        public PaginaAmistades()
        {
            InitializeComponent();
            listaAmigos.DataContext = this;
            listaSolicitudes.DataContext = this;
            CargarAmigosJugador();
            CargarJugadoresConSolicitudEnviada();
        }

        private void CargarAmigosJugador()
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            var amigosObtenidos = cliente.ObtenerAmigosDeJugador(Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador);            
            cliente.Abort();

            if (amigosObtenidos.Count() > 0)
            {
                amigosJugador = new ObservableCollection<Dominio.CuentaJugador>();
                etiquetaSinAmigos.Visibility = Visibility.Hidden;

                foreach (CuentaJugador amigo in amigosObtenidos)
                {
                    amigosJugador.Add(new Dominio.CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                        FuenteImagenAvatar = GenerarFuenteImagenDeNumeroDeAvatar(
                            amigo.NumeroAvatar),
                        ColorEstadoConectividad = Brushes.Green,
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
            var jugadoresObtenidos = cliente.ObtenerJugadoresConSolicitudDeAmistadSinAceptar(
                Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador);
            cliente.Abort();

            if (jugadoresObtenidos.Count() > 0)
            {
                jugadoresConSolicitudEnviada = new ObservableCollection<Dominio.CuentaJugador>();
                etiquetaSinSolicitudesAmistad.Visibility = Visibility.Hidden;

                foreach (CuentaJugador jugador in jugadoresObtenidos)
                {
                    jugadoresConSolicitudEnviada.Add(new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = GenerarFuenteImagenDeNumeroDeAvatar(
                            jugador.NumeroAvatar),
                    });
                }
            } 
            else
            {
                etiquetaSinSolicitudesAmistad.Visibility = Visibility.Visible;
            }
        }

        private BitmapImage GenerarFuenteImagenDeNumeroDeAvatar(int numeroAvatar)
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage fuenteImagenAvatar = new BitmapImage();
            fuenteImagenAvatar.BeginInit();
            rutaImagen += numeroAvatar + ".png";
            fuenteImagenAvatar.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            fuenteImagenAvatar.EndInit();

            return fuenteImagenAvatar;
        }

        private bool EnviarSolicitudDeAmistad()
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorOrigen = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool resultado = cliente.EnviarSolicitudDeAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);
            cliente.Abort();

            return resultado;
        }

        #region Validaciones
        private bool ExisteNombreJugador()
        {
            bool resultado = true;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            if (!cliente.ExisteNombreJugador(nombreJugadorDestino))
            {
                resultado = false;
                MessageBox.Show("No se encontró el nombre de jugador", 
                    "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            cliente.Abort();

            return resultado;
        }

        private bool EsElNombreDelJugadorActual()
        {
            bool resultado = false;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;

            if (Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador.
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
            bool resultado = false;
            string nombreJugadorOrigen = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador; 
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;            
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();

            if (cliente.ExisteSolicitudDeAmistadSinAceptar(nombreJugadorOrigen, 
                nombreJugadorDestino))
            {
                resultado = true;
                MessageBox.Show("No se envió la solicitud de amistad debido a que " +
                    "anteriormente ya le has enviado una solicitud de amistad al jugador", 
                    "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            cliente.Abort();

            return resultado;
        }

        private bool ExisteAmistadConJugador()
        {
            bool resultado = false;
            string nombreJugadorOrigen = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();

            if (cliente.ExisteAmistadConJugador(nombreJugadorOrigen, nombreJugadorDestino))
            {
                resultado = true;
                MessageBox.Show("No se envió la solicitud de amistad debido a que " +
                    "ya eres amigo del jugador", "Error al enviar solicitud de amistad",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            cliente.Abort();

            return resultado;
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

        }
        #endregion

        private void EventoClickAceptarSolicitudAmistad(object controlOrigen, 
            RoutedEventArgs evento)
        {
            var filaActual = ((ListBoxItem)listaSolicitudes.ContainerFromElement(
                (Button)controlOrigen));
            filaActual.IsSelected = true;

            if (AceptarSolicitudDeAmistad())
            {
                CargarJugadoresConSolicitudEnviada();
                MessageBox.Show("La solicitud de amistad ha sido aceptada",
                        "Solicitud de amistad aceptada",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                
                if (AgregarAmistadEntreJugadores())
                {
                    CargarAmigosJugador();                    
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
                string nombreJugadorDestino = Dominio.CuentaJugador.
                    CuentaJugadorActual.NombreJugador;
                resultado = cliente.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
                cliente.Abort();
            }

            return resultado;
        }

        private bool AgregarAmistadEntreJugadores()
        {
            Dominio.CuentaJugador jugadorSeleccionado = (Dominio.CuentaJugador)
                listaSolicitudes.SelectedItem;
            ServicioAmistadesClient cliente = new ServicioAmistadesClient();
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
            bool resultado = cliente.RegistrarNuevaAmistadEntreJugadores(
                nombreJugadorOrigen, nombreJugadorDestino);
            cliente.Abort();

            return resultado;
        }

        private void EventoClickRechazarSolicitudAmistad(object controlOrigen, 
            RoutedEventArgs evento)
        {

        }
    }
}