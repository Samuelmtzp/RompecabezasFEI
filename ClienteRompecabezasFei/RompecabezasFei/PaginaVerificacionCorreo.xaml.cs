using System;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using RompecabezasFei.ServicioRompecabezasFei;
using Security;

namespace RompecabezasFei
{
    public partial class PaginaVerificacionCorreo : Page
    {
        string codigoGenerado;
        private const int DuracionContadorSegundos = 60;
        private int segundosRestantes;
        private DispatcherTimer temporizador;
        private Dominio.CuentaJugador jugadorRegistro;

        public PaginaVerificacionCorreo(Dominio.CuentaJugador jugadorRegistro)
        {
            InitializeComponent();
            this.jugadorRegistro = jugadorRegistro;
            EnviarCodigo();
        }

        private void InicializarTemporizador()
        {
            segundosRestantes = DuracionContadorSegundos;
            temporizador = new DispatcherTimer();
            temporizador.Interval = TimeSpan.FromSeconds(1);
            temporizador.Tick += ActualizarTiempo;
            temporizador.Start();
        }

        public void EventoAccionEnviarCodigo(object controlOrigen, RoutedEventArgs evento)
        {
            EnviarCodigo();            
        }

        private void EnviarCodigo()
        {
            codigoGenerado = GenerarCodigo();
            DeshabilitarBotonEnvioCodigo(); 
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            
            try
            {
                cliente.EnviarMensajeCorreo(Properties.Resources.
                    ETIQUETA_GENERAL_ROMPECABEZASFEI, jugadorRegistro.Correo,
                    Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO,
                    Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " + 
                    codigoGenerado);
                EnviarCodigo();
            }
            catch(CommunicationException)
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
            
            InicializarTemporizador();
        }

        private string GenerarCodigo()
        {
            Random generadorNumeroAleatorio = new Random();
            return generadorNumeroAleatorio.Next(100000, 1000000).ToString();
        }

        private void EventoAccionRegistrar(object controlOrigen, RoutedEventArgs evento)
        {
            string codigoVerificacion = CuadroTextoCodigoVerificacion.Text;

            if (!string.IsNullOrEmpty(codigoGenerado))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.Equals(codigoGenerado);

                if (codigoVerificacionCoincide)
                {
                    string contrasenaCifrada = EncriptadorContrasena.
                        CalcularHashSha512(jugadorRegistro.Contrasena);
                    CuentaJugador nuevoJugador = new CuentaJugador
                    {
                        NombreJugador = jugadorRegistro.NombreJugador,
                        NumeroAvatar = jugadorRegistro.NumeroAvatar,
                        Contrasena = contrasenaCifrada,
                        Correo = jugadorRegistro.Correo
                    };
                    bool resultadoRegistro = Registrar(nuevoJugador);

                    if (resultadoRegistro)
                    {
                        temporizador.Stop();
                        MessageBox.Show(
                            Properties.Resources.
                            ETIQUETA_VERIFICACIONCORREO_MENSAJEUSUARIOREGISTRADO,
                            Properties.Resources.ETIQUETA_VERIFICACIONCORREO_REGISTROREALIZADO,
                            MessageBoxButton.OK);
                        VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show(
                            Properties.Resources.
                            ETIQUETA_VERIFICACIONCORREO_MENSAJEREGISTRONOREALIZADO,
                            Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ERRORREGISTRO,
                            MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show(
                        Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJECODIGOINCORRECTO,
                        Properties.Resources.ETIQUETA_VERIFICACIONCORREO_CODIGOINCORRECTO,
                        MessageBoxButton.OK);
                }
            }
        }

        private bool Registrar(CuentaJugador nuevoJugador)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.Registrar(nuevoJugador);
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

            return resultado;
        }

        private void EventoAceptarSoloCaracteresNumericos(object objetoOrigen,
            TextChangedEventArgs evento)
        {
            if (objetoOrigen is TextBox CuadroTextoCodigoVerificacion)
            {
                string texto = CuadroTextoCodigoVerificacion.Text = new string(
                  CuadroTextoCodigoVerificacion.Text.Where(char.IsDigit).ToArray());
                CuadroTextoCodigoVerificacion.CaretIndex =
                    CuadroTextoCodigoVerificacion.Text.Length;
                CuadroTextoCodigoVerificacion.Text = texto;
            }
        }

        private void ActualizarTiempo(object objetoOrigen, EventArgs evento)
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                TimeSpan time = TimeSpan.FromSeconds(segundosRestantes);
                EtiquetaTiempoRestante.Content = $"{time.Minutes:00}:{time.Seconds:00}";
            }
            else
            {
                temporizador.Stop();
                EtiquetaTiempoRestante.Content = "00:00";
                HabilitarBotonEnvioCodigo();
            }
        }

        private void HabilitarBotonEnvioCodigo()
        {
            BotonEnviarCodigo.IsEnabled = true;
            BotonEnviarCodigo.Foreground = Brushes.White;
        }

        private void DeshabilitarBotonEnvioCodigo()
        {
            BotonEnviarCodigo.IsEnabled = false;
            BotonEnviarCodigo.Foreground = Brushes.Black;
        }
    }
}
