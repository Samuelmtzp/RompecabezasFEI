using System;
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

        private void EventoClickSiguiente(object controlOrigen, RoutedEventArgs evento)
        {
            correo = CuadroCorreo.Text;
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            if (!ExistenCaracteresInvalidosParaCorreo(correo))
            {
                if (cliente.ExisteCorreoElectronico(correo))
                {
                    PaginaCodigoRestablecimientoContrasena paginaCodigoRestablecimientoContrasena =
                        new PaginaCodigoRestablecimientoContrasena(correo);
                    VentanaPrincipal.CambiarPagina(paginaCodigoRestablecimientoContrasena);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE,
                        Properties.Resources.ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE, MessageBoxButton.OK);
                }
            }
        }

        private void EventoClickAccionRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private bool ExistenCaracteresInvalidosParaCorreo(string textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO, MessageBoxButton.OK);
            }
            return caracteresInvalidos;
        }
    }
}
