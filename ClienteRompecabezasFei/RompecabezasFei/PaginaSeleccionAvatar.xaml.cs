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
        public PaginaSeleccionAvatar()
        {
            InitializeComponent();
        }

        private void ImagenFlechaRegreso_Click(object sender, MouseButtonEventArgs e)
        {
            regresarPaginaRegistroUsuario();
        }

        private void ImagenSeleccionada_Click(object sender, MouseButtonEventArgs e)
        {
            Image imagenSeleccionada = sender as Image;
            ImagenAvatarActual.Source = imagenSeleccionada.Source;
            ImagenAvatarActual.Tag = imagenSeleccionada.Tag;
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            regresarPaginaRegistroUsuario();
        }

        private void regresarPaginaRegistroUsuario()
        {
            PaginaRegistroUsuario paginaRegistroUsuario = new PaginaRegistroUsuario();
            paginaRegistroUsuario.ImagenAvatarActual.Source = this.ImagenAvatarActual.Source;
            paginaRegistroUsuario.ImagenAvatarActual.Tag = this.ImagenAvatarActual.Tag;
            VentanaPrincipal.CambiarPagina(this, paginaRegistroUsuario);
        }
    }
}
