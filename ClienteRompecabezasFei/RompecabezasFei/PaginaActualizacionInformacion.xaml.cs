using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaActualizacionInformacion : Page
    {
        private Dominio.CuentaJugador jugadorRegistro;
        private readonly string nombreActual;

        public Dominio.CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; }
            set { jugadorRegistro = value; }
        }

        public PaginaActualizacionInformacion()
        {
            InitializeComponent();
            nombreActual = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
            jugadorRegistro = new Dominio.CuentaJugador();
        }

        #region Métodos privados
        public void CargarDatosEdicion()
        {
            cuadroTextoNombreUsuario.Text = jugadorRegistro.NombreJugador;
        }

        private void GuardarDatosEdicion()
        {
            jugadorRegistro = new Dominio.CuentaJugador()
            {
                NombreJugador = cuadroTextoNombreUsuario.Text
            };
        }

        private void ActualizarInformacion()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient(); 
            CuentaJugador datosJugador = new CuentaJugador
            {
                IdJugador = Dominio.CuentaJugador.CuentaJugadorActual.IdJugador,
                NombreJugador = jugadorRegistro.NombreJugador,
                NumeroAvatar = jugadorRegistro.NumeroAvatar,
            };            
            bool esNombreDisponible = !cliente.ExisteNombreJugador(
                jugadorRegistro.NombreJugador);

            if (esNombreDisponible)
            {
                bool registroRealizado = cliente.ActualizarInformacion(datosJugador);

                if (registroRealizado)
                {
                    MessageBox.Show("La actualización de la información se ha " +
                        "realizado correctamente",
                        "Actualización realizada correctamente",
                        MessageBoxButton.OK);
                    cliente.Abort();
                    Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar =
                        datosJugador.NumeroAvatar;
                    Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador =
                        datosJugador.NombreJugador;
                    Dominio.CuentaJugador.CuentaJugadorActual.FuenteImagenAvatar = 
                        GenerarFuenteImagenDeNumeroDeAvatar(datosJugador.NumeroAvatar);

                    PaginaInformacionJugador paginaInformacionJugador =
                        new PaginaInformacionJugador();
                    VentanaPrincipal.CambiarPagina(paginaInformacionJugador);
                }
                else
                {
                    MessageBox.Show("La actualización de la información " +
                        "no se ha realizado",
                        "Error al actualizar información",
                        MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("El nombre no se encuentra disponible",
                    "Error al actualizar información", MessageBoxButton.OK);
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
        #endregion

        #region Eventos
        private void EventoPaginaActualizacionInformacionCargada(object controlOrigen,
            RoutedEventArgs evento)
        {
            imagenAvatarActual.Source = Dominio.CuentaJugador.
                CuentaJugadorActual.FuenteImagenAvatar;
            cuadroTextoNombreUsuario.Text = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
        }
        
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickGuardarCambios(object controlOrigen, RoutedEventArgs evento)
        {
            jugadorRegistro.NombreJugador = cuadroTextoNombreUsuario.Text.Trim();
            jugadorRegistro.NumeroAvatar = Convert.ToInt16(imagenAvatarActual.Tag);
            bool esNombreDiferente = false;
            bool esAvatarDiferente = false;

            if (!ExistenModificacionesEnNombre() &&
                !ExistenModificacionesEnAvatar())
            {
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }
            else
            {
                if (ExistenModificacionesEnAvatar())
                {
                    jugadorRegistro.NumeroAvatar = Dominio.CuentaJugador.
                        CuentaJugadorActual.NumeroAvatar;
                    esAvatarDiferente = true; 
                }
                if (ExistenModificacionesEnNombre())
                {
                    esNombreDiferente = true;
                }
            }

            if (esNombreDiferente || esAvatarDiferente)
            {
                if (!ExistenCamposInvalidos())
                {
                    ActualizarInformacion();
                }
            }
        }

        private void EventoClickCambiarAvatar(object controlOrigen, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = imagenAvatarActual.Source;
            GuardarDatosEdicion();
            paginaSeleccionAvatar.JugadorRegistro = jugadorRegistro;
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
        }
        #endregion

        #region Validaciones
        private bool ExistenModificacionesEnAvatar()
        {
            bool resultado = true;

            if (jugadorRegistro.NumeroAvatar == 0)
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenModificacionesEnNombre()
        {
            bool resultado = true;

            if (jugadorRegistro.NombreJugador.Equals(nombreActual))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenCamposInvalidos()
        {
            bool resultado = false;

            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || 
                ExistenLongitudesExcedidas())
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;
            
            if (String.IsNullOrWhiteSpace(jugadorRegistro.NombreJugador))
            {
                resultado = true;
                MessageBox.Show("No puedes dejar campos vacíos",
                    "Campos vacíos", MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool resultado = false;
            
            if (jugadorRegistro.NombreJugador.Length > 15)
            {
                resultado = true;
                MessageBox.Show("Corrige los campos excedidos",
                    "Campos excedidos", MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool resultado = false;
            
            if (ExistenCaracteresInvalidos(cuadroTextoNombreUsuario.Text))
            {
                resultado = true; 
                MessageBox.Show("El nombre de usuario que has ingresado es inválido",
                    "Nombre de usuario inválido", MessageBoxButton.OK);                
            }

            return resultado;
        }

        private bool ExistenCaracteresInvalidos(String textoValido)
        {
            bool resultado = false;
            
            if (Regex.IsMatch(textoValido, 
                @"^[A-Za-zÁÉÍÓÚáéíóúñÑ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúñÑ]+)?$") == false)
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}