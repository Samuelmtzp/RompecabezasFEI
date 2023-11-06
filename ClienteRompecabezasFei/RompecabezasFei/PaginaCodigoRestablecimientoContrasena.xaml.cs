using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class PaginaCodigoRestablecimientoContrasena : Page
    {
        private readonly string correo;
        private string codigoGenerado;

        public PaginaCodigoRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;
            EnviarCodigo();
        }

        #region Métodos privados
        private void EnviarCodigo()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Random generadorNumeroAleatorio = new Random();
            codigoGenerado = generadorNumeroAleatorio.Next(100000, 1000000).ToString();
            cliente.EnviarMensajeCorreo(Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI,
                correo, Properties.Resources.ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO,
                Properties.Resources.ETIQUETA_RECUPERACION_MENSAJE + $" {codigoGenerado}");
        }
        #endregion

        #region Eventos
        private void EventoClickCancelar(object controlOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void EventoClickBotonSiguiente(object controlOrigen, RoutedEventArgs evento)
        {
            string codigoVerificacion = cuadroTextoCodigoRestablecimiento.Text;

            if (!string.IsNullOrEmpty(codigoGenerado))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.Equals(codigoGenerado);

                if (codigoVerificacionCoincide)
                {
                    VentanaPrincipal.CambiarPagina(new PaginaRestablecimientoContrasena(correo));
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no coincide", "Codigo no coincide",
                        MessageBoxButton.OK);
                }
            }
        }

        private void EventoAceptarSoloCaracteresNumericos(object controlOrigen,
            TextChangedEventArgs evento)
        {
            if (controlOrigen is TextBox cuadroTextoCodigoRestablecimiento)
            {
                string texto = cuadroTextoCodigoRestablecimiento.Text = new string(cuadroTextoCodigoRestablecimiento.Text.Where(char.IsDigit).ToArray());
                cuadroTextoCodigoRestablecimiento.CaretIndex = 
                    cuadroTextoCodigoRestablecimiento.Text.Length;
                cuadroTextoCodigoRestablecimiento.Text = texto;
            }
        }
        #endregion
    }
}
