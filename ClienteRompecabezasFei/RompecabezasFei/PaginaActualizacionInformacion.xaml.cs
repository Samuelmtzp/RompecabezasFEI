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
        public Dominio.CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; }
            set { jugadorRegistro = value; }
        }

        string nombre= Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
        bool mismoNombre,mismosDatos;

        public PaginaActualizacionInformacion()
        {
            InitializeComponent();
            CargarImagenJugador();
            CargarNombreJugador();
            jugadorRegistro = new Dominio.CuentaJugador();
        }

        private void AccionCambiarAvatar(object remitente, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = ImagenAvatarActual.Source;
            GuardarDatosEdicion();
            paginaSeleccionAvatar.JugadorRegistro = jugadorRegistro;
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
        }

        private void CargarImagenJugador()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();
            rutaImagen += Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar + ".png";
            ImagenUsuarioMapaBits.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            ImagenUsuarioMapaBits.EndInit();
            ImagenAvatarActual.Source = ImagenUsuarioMapaBits;
        }

        private void CargarNombreJugador()
        {
            CuadroTextoNombreUsuario.Text = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
        }

        public void CargarDatosEdicion() 
        {
            CuadroTextoNombreUsuario.Text = jugadorRegistro.NombreJugador;
        }

        private void GuardarDatosEdicion()
        {
            jugadorRegistro = new Dominio.CuentaJugador()
            {
                NombreJugador = CuadroTextoNombreUsuario.Text
             };
        }

        private void AccionGuardarCambios(object remitente, RoutedEventArgs evento)
        {
            jugadorRegistro.NombreJugador = CuadroTextoNombreUsuario.Text.Trim();
            jugadorRegistro.NumeroAvatar = Convert.ToInt16(ImagenAvatarActual.Tag);

            if (jugadorRegistro.NumeroAvatar == 0 && jugadorRegistro.NombreJugador.Equals(nombre))
            {
                mismosDatos = true;
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }
            else
            {
                if (jugadorRegistro.NumeroAvatar == 0)
                {
                    jugadorRegistro.NumeroAvatar = Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar;
                }
                if (jugadorRegistro.NombreJugador.Equals(nombre))
                {
                    mismoNombre = true;
                }
            }

            CuentaJugador datosJugador = new CuentaJugador
            {
                IdJugador = Dominio.CuentaJugador.CuentaJugadorActual.IdJugador,
                NombreJugador = jugadorRegistro.NombreJugador,
                NumeroAvatar = jugadorRegistro.NumeroAvatar,
            };

            if (!(mismosDatos))
            {
                ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                if (!ExistenCamposInvalidos())
                {
                    if (mismoNombre)
                    {
                        bool resultadoRegistro = cliente.ActualizarInformacion(datosJugador);
                        if (resultadoRegistro)
                        {
                            MessageBox.Show("La actualización de la información se ha realizado correctamente",
                                "Actualización realizada correctamente", MessageBoxButton.OK);
                            cliente.Abort();
                            Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar = datosJugador.NumeroAvatar;
                            Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador = datosJugador.NombreJugador;
                            PaginaInformacionJugador paginaInformacionJugador = new PaginaInformacionJugador();
                            paginaInformacionJugador.InitializeComponent();
                            paginaInformacionJugador.CargarDatosJugador();
                            VentanaPrincipal.CambiarPagina(paginaInformacionJugador);
                        }
                        else
                        {
                            MessageBox.Show("La actualización de la información no se ha realizado",
                                "Error al actualizar información", MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        if (!(cliente.ExisteNombreJugador(jugadorRegistro.NombreJugador)))
                        {
                            bool resultadoRegistro = cliente.ActualizarInformacion(datosJugador);
                            if (resultadoRegistro)
                            {
                                MessageBox.Show("La actualización de la información se ha realizado correctamente",
                                    "Actualización realizada correctamente", MessageBoxButton.OK);
                                cliente.Abort();
                                Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar = datosJugador.NumeroAvatar;
                                Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador = datosJugador.NombreJugador;
                                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                            }
                            else
                            {
                                MessageBox.Show("La actualización de la información no se ha realizado",
                                    "Error al actualizar información", MessageBoxButton.OK);
                            }
                        }
                    }
                }
            }
        }
               
        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        #region Validaciones

        private bool ExistenCamposInvalidos()
        {
            bool camposInvalidos = false;
            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || ExistenLongitudesExcedidas())
            {
                camposInvalidos = true;
            }
            return camposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool camposVacios = false;
            if (String.IsNullOrWhiteSpace(jugadorRegistro.NombreJugador))
            {
                camposVacios = true;
                MessageBox.Show("No puedes dejar campos vacíos",
                    "Campos vacíos", MessageBoxButton.OK);
            }
            return camposVacios;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool camposExcedidos = false;
            if (jugadorRegistro.NombreJugador.Length > 15)
            {
                camposExcedidos = true;
                MessageBox.Show("Corrige los campos excedidos",
                    "Campos excedidos", MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool cadenasInvalidas = false;
            if (ExistenCaracteresInvalidos(CuadroTextoNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario que has ingresado es inválido",
                    "Nombre de usuario inválido", MessageBoxButton.OK);
                cadenasInvalidas = true;
            }
            return cadenasInvalidas;
        }

        private bool ExistenCaracteresInvalidos(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[A-Za-zÁÉÍÓÚáéíóúñÑ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúñÑ]+)?$") == false) // "^[A-Za-zÁÉÍÓÚáéíóúñÑ\\s]+$")
            {
                caracteresInvalidos = true;
            }
            return caracteresInvalidos;
        }

        #endregion

    }
}
