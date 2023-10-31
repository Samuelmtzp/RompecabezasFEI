using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace RompecabezasFei
{
    public partial class PaginaCodigoRestablecimientoContrasena : Page
    {
        private string correo, codigoGenerado;
        public PaginaCodigoRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;
            EnviarCodigo();
        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            string codigoVerificacion = CuadroTextoCodigoRestablecimiento.Text;
            if (!string.IsNullOrEmpty(codigoGenerado))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.Equals(codigoGenerado);
                if (codigoVerificacionCoincide)
                {
                    VentanaPrincipal.CambiarPagina(new PaginaRestablecimientoContrasena(correo));
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no coincide", "Codigo no coincide", MessageBoxButton.OK);
                }
            }
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRecuperacionContrasena());
        }

        private void EnviarCodigo()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Random generadorNumeroAleatorio = new Random();
            codigoGenerado = generadorNumeroAleatorio.Next(100000, 1000000).ToString();
            cliente.EnviarMensajeCorreo(Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI,
                correo, Properties.Resources.ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO,
                Properties.Resources.ETIQUETA_RECUPERACION_MENSAJE + $" {codigoGenerado}");
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void AceptarSoloCaracteresNumericos(object remitente,
            TextChangedEventArgs evento)
        {
            if (remitente is TextBox CuadroTextoCodigoRestablecimiento)
            {
                string texto =
                  CuadroTextoCodigoRestablecimiento.Text = new string(CuadroTextoCodigoRestablecimiento.Text.Where(char.IsDigit).ToArray());
                CuadroTextoCodigoRestablecimiento.CaretIndex = CuadroTextoCodigoRestablecimiento.Text.Length;
                CuadroTextoCodigoRestablecimiento.Text = texto;
            }
        }

    }
}
