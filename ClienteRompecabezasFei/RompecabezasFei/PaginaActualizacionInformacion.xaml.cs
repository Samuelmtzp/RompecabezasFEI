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
        private bool mismoNombre;
        private bool sonLosMismosDatos;

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
        private void CargarImagenJugador()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();
            rutaImagen += Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar + ".png";
            ImagenUsuarioMapaBits.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            ImagenUsuarioMapaBits.EndInit();
            imagenAvatarActual.Source = ImagenUsuarioMapaBits;
        }

        private void CargarNombreJugador()
        {
            cuadroTextoNombreUsuario.Text = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
        }

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
        #endregion

        #region Eventos
        private void EventoPaginaActualizacionInformacionCargada(object controlOrigen,
            RoutedEventArgs evento)
        {
            CargarImagenJugador();
            CargarNombreJugador();
        }
        
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickGuardarCambios(object controlOrigen, RoutedEventArgs evento)
        {
            jugadorRegistro.NombreJugador = cuadroTextoNombreUsuario.Text.Trim();
            jugadorRegistro.NumeroAvatar = Convert.ToInt16(imagenAvatarActual.Tag);

            if (jugadorRegistro.NumeroAvatar == 0 &&
                jugadorRegistro.NombreJugador.Equals(nombreActual))
            {
                sonLosMismosDatos = true;
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }
            else
            {
                if (jugadorRegistro.NumeroAvatar == 0)
                {
                    jugadorRegistro.NumeroAvatar = Dominio.CuentaJugador.
                        CuentaJugadorActual.NumeroAvatar;
                }
                if (jugadorRegistro.NombreJugador.Equals(nombreActual))
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

            if (!sonLosMismosDatos)
            {
                ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

                if (!ExistenCamposInvalidos())
                {
                    if (mismoNombre)
                    {
                        bool resultadoRegistro = cliente.ActualizarInformacion(datosJugador);

                        if (resultadoRegistro)
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
                            PaginaInformacionJugador paginaInformacionJugador =
                                new PaginaInformacionJugador();
                            paginaInformacionJugador.InitializeComponent();
                            paginaInformacionJugador.CargarDatosJugador();
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
                        if (!cliente.ExisteNombreJugador(jugadorRegistro.NombreJugador))
                        {
                            bool resultadoRegistro = cliente.ActualizarInformacion(datosJugador);

                            if (resultadoRegistro)
                            {
                                MessageBox.Show("La actualización de la información " +
                                    "se ha realizado correctamente",
                                    "Actualización realizada correctamente",
                                    MessageBoxButton.OK);
                                cliente.Abort();
                                Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar =
                                    datosJugador.NumeroAvatar;
                                Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador =
                                    datosJugador.NombreJugador;
                                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                            }
                            else
                            {
                                MessageBox.Show("La actualización de la información " +
                                    "no se ha realizado",
                                    "Error al actualizar información",
                                    MessageBoxButton.OK);
                            }
                        }
                    }
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