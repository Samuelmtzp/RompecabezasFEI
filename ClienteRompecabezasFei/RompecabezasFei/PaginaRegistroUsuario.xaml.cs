using RompecabezasFei.ServicioGestionJugador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaRegistroUsuario.xaml
    /// </summary>
    public partial class PaginaRegistroUsuario : Page
    {
        private readonly ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

        public PaginaRegistroUsuario()
        {
            InitializeComponent();
        }

        private void ImagenFlechaRegreso_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.MarcoPaginaActual.Navigate(new PaginaInicioSesion());
        }

        private void BotonSeleccionarAvatar_Click(object sender, RoutedEventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = this.ImagenAvatarActual.Source;
            ventanaPrincipal.MarcoPaginaActual.Navigate(paginaSeleccionAvatar);
        }

        private void BotonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            RestablecerEstiloComponentes();
            ValidarDatos();
        }

        private void RestablecerEstiloComponentes()
        {
            CuadroTextoNombreUsuario.BorderBrush = null;
            CuadroTextoNombreUsuario.BorderThickness = new Thickness(0);
        }

        private void ValidarDatos()
        {
            bool datosValidos = true;
            String nombreUsuario = CuadroTextoNombreUsuario.Text;
            String correoElectronico = CuadroTextoCorreoElectronico.Text;
            String contrasena = CuadroContrasena.Password;
            String confirmacionContrasena = CuadroConfirmacionContrasena.Password;

            if (nombreUsuario.Trim().Length > 15)
            {
                datosValidos = false;
                CuadroTextoNombreUsuario.BorderBrush = Brushes.Red;
                CuadroTextoNombreUsuario.BorderThickness = new Thickness(3);
            }

            if (contrasena.Equals(confirmacionContrasena))
            {
                MessageBox.Show("Las contraseñas coinciden");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

            if (datosValidos)
            {
                Usuario usuario = new Usuario();
                usuario.Correo = correoElectronico;
                usuario.Contrasena = contrasena;

                Jugador jugador = new Jugador();
                jugador.NombreJugador = nombreUsuario;
                jugador.NumeroAvatar = Convert.ToInt16(ImagenAvatarActual.Tag);

                bool resultado = cliente.Registrar(usuario, jugador);
                MessageBox.Show("Registro realizado? = " + resultado);
            }
        }
    }
}
