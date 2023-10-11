using Dominio;
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
    /// Interaction logic for PaginaSeleccionAvatar.xaml
    /// </summary>
    public partial class PaginaSeleccionAvatar : Page
    {
        private DatosRegistro datosRegistro;
        public DatosRegistro DatosRegistro
        {
            get { return datosRegistro; }
            set { datosRegistro = value; }
        }

        public PaginaSeleccionAvatar()
        {
            InitializeComponent();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            Regresar();
        }

        private void AccionSeleccionAvatar(object remitente, MouseButtonEventArgs evento)
        {
            Image imagenSeleccionada = remitente as Image;
            ImagenAvatarActual.Source = imagenSeleccionada.Source;
            ImagenAvatarActual.Tag = imagenSeleccionada.Tag;
        }

        private void AccionAceptar(object remitente, RoutedEventArgs evento)
        {
            Regresar();
        }

        private void Regresar()
        {
            PaginaRegistroUsuario paginaRegistroUsuario = new PaginaRegistroUsuario();
            paginaRegistroUsuario.ImagenAvatarActual.Source = ImagenAvatarActual.Source;
            paginaRegistroUsuario.ImagenAvatarActual.Tag = ImagenAvatarActual.Tag;
            paginaRegistroUsuario.DatosRegistro = DatosRegistro;
            paginaRegistroUsuario.CargarDatosEdicion();
            VentanaPrincipal.CambiarPagina(this, paginaRegistroUsuario);
        }
    }
}
