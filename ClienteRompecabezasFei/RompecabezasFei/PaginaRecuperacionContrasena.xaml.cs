using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RompecabezasFei.ServicioRompecabezasFei;

namespace RompecabezasFei
{
    public partial class PaginaRecuperacionContrasena : Page
    {
        string correo;

        public PaginaRecuperacionContrasena()
        {
            InitializeComponent();
        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            correo = CuadroCorreo.Text;
            
            if (!ExistenCaracteresInvalidosParaCorreo(correo))
            {
                if (VentanaPrincipal.ClienteServicioGestionJugador.
                    ExisteCorreoElectronico(correo))
                {
                    PaginaCodigoRestablecimientoContrasena paginaCodigoRestablecimientoContrasena =
                        new PaginaCodigoRestablecimientoContrasena(correo);
                    VentanaPrincipal.CambiarPagina(paginaCodigoRestablecimientoContrasena);
                }
                else
                {
                    MessageBox.Show("El correo ingresado no existe", "Correo inexistente", 
                        MessageBoxButton.OK);
                }
            }
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private bool ExistenCaracteresInvalidosParaCorreo(string textoValido)
        {
            bool caracteresInvalidos = false;

            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
                MessageBox.Show("El correo ingresado no es válido", 
                    "Correo inválido", MessageBoxButton.OK);
            }
            return caracteresInvalidos;
        }
    }
}
