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
    /// Interaction logic for PaginaInicioSesion.xaml
    /// </summary>
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private void BotonInicioSesion_Click(object sender, RoutedEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void BotonModoInvitado_Click(object sender, RoutedEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void OpcionRegistro_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroUsuario());
        }

        private void OpcionRecuperarContrasena_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Click en opción recuperar contraseña");
        }
        private void ImagenAjustes_Click(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaAjustes());
        }
    }
}
