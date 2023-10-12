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
using RompecabezasFei.ServicioGestionJugador;

namespace RompecabezasFei
{
    /// <summary>
    /// Lógica de interacción para PaginaVerificacionCorreo.xaml
    /// </summary>
    public partial class PaginaVerificacionCorreo : Page
    {
        Jugador jugador = new Jugador();

        public PaginaVerificacionCorreo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            var resultado = false;
            Random randomNumber = new Random();
            var codigoVerificacion = randomNumber.Next(100000, 1000000);
            resultado = cliente.EnviarValidacionCorreo(correoElectronico, "Código de verificación", codigoVerificacion);
        }

        private void ImagenFlechaRegreso_Click(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.IrPaginaAnterior(this);
        }
    }
}
