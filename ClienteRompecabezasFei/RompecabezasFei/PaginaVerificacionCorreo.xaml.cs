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
        private Dominio.Jugador jugadorRegistro;
        public Dominio.Jugador JugadorRegistro
        {
            get { return jugadorRegistro; } 
            set {  jugadorRegistro = value; }
        }

        string codigo;

        public PaginaVerificacionCorreo()
        {
            InitializeComponent();
        }

      

        public void EnviarCorreo_Clic(object sender, RoutedEventArgs e)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Random randomNumber = new Random();
            var codigoVerificacion = randomNumber.Next(100000, 1000000);
            cliente.EnviarValidacionCorreo(jugadorRegistro.Correo, "Código de verificación", codigoVerificacion);
            codigo=codigoVerificacion.ToString();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string validacion= CuadroTextoCodigoVerificacion.Text;
            if (!string.IsNullOrEmpty(codigo))
            {
                if (validacion.Equals(codigo))
                {
                    ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                    cliente.Registrar(JugadorRegistro);
                }
            }
        }

        private void ImagenFlechaRegreso_Click(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroUsuario());
        }
    
    }
}
