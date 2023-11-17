using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Linq;
using System.ServiceModel;
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
            Random generadorNumeroAleatorio = new Random();
            const int valorMinimoCodigo = 100000;
            const int valorMaximoCodigo = 1000000;
            codigoGenerado = generadorNumeroAleatorio.Next(valorMinimoCodigo, 
                valorMaximoCodigo).ToString();
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool codigoEnviado = false;            

            try
            {
                codigoEnviado = cliente.EnviarMensajeCorreo(Properties.Resources.
                    ETIQUETA_GENERAL_ROMPECABEZASFEI, correo, Properties.Resources.
                    ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO, Properties.Resources.
                    ETIQUETA_RECUPERACION_MENSAJE + $" {codigoGenerado}");
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                cliente.Abort();
            }

            if (!codigoEnviado)
            {
                MessageBox.Show(Properties.Resources.
                            ETIQUETA_CODIGO_MENSAJENOENVIADO, Properties.Resources.
                            ETIQUETA_CODIGO_CODIGONOENVIADO,
                            MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Eventos
        private void ClickCancelar(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void SiguientePaginaRestablecimientoContrasena(object objetoOrigen, 
            RoutedEventArgs evento)
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
                    MessageBox.Show(Properties.Resources.ETIQUETA_CODIGO_MENSAJECODIGONOCOINCIDE, 
                        Properties.Resources.ETIQUETA_CODIGO_CODIGONOCOINCIDE,
                        MessageBoxButton.OK);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object objetoOrigen,
            TextChangedEventArgs evento)
        {
            if (objetoOrigen is TextBox cuadroTextoCodigoRestablecimiento)
            {
                string texto = cuadroTextoCodigoRestablecimiento.Text = new string(
                    cuadroTextoCodigoRestablecimiento.Text.Where(char.IsDigit).ToArray());
                cuadroTextoCodigoRestablecimiento.CaretIndex = 
                    cuadroTextoCodigoRestablecimiento.Text.Length;
                cuadroTextoCodigoRestablecimiento.Text = texto;
            }
        }
        #endregion
    }
}