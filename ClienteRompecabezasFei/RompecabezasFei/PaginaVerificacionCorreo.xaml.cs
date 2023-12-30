using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using Security;
using Seguridad;

namespace RompecabezasFei
{
    public partial class PaginaVerificacionCorreo : Page
    {
        private readonly Dominio.CuentaJugador jugadorRegistro;

        private Temporizador temporizador;

        public PaginaVerificacionCorreo(Dominio.CuentaJugador jugadorRegistro)
        {
            InitializeComponent();
            this.jugadorRegistro = jugadorRegistro;
            GestionadorCodigoCorreo.EnviarNuevoCodigoDeVerificacionACorreo(
                jugadorRegistro.Correo, Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO,
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " + 
                GestionadorCodigoCorreo.CodigoGenerado);
            ComenzarTemporizador();
        }

        private void ComenzarTemporizador()
        {
            DeshabilitarBotonEnvioCodigo();
            temporizador = new Temporizador();
            temporizador.IniciarTemporizador(Temporizador.DuracionSegundosMaximaReenvioDeCorreo);
            temporizador.DespachadorDeTiempo.Tick += ActualizarTiempoRestante;
        }


        public void ActualizarTiempoRestante(object objetoOrigen, EventArgs evento)
        {
            if (temporizador.SegundosRestantes > Temporizador.MinimoSegundosRestantes)
            {
                temporizador.SegundosRestantes--;
                TimeSpan tiempoRestante = TimeSpan.FromSeconds(temporizador.SegundosRestantes);
                etiquetaTiempoRestante.Content = $"{tiempoRestante.Minutes:00}:" +
                    $"{tiempoRestante.Seconds:00}";
            }
            else
            {
                temporizador.DetenerTemporizador();
                etiquetaTiempoRestante.Content = "01:00";
                HabilitarBotonEnvioCodigo();
            }
        }

        private void ConcluirRegistroDeNuevoJugador(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            string codigoVerificacion = cuadroTextoCodigoVerificacion.Text;

            if (!ValidadorDatos.EsCadenaVacia(codigoVerificacion))
            {
                bool esElMismoCodigoDeVerificacion = ValidadorDatos.
                    ExisteCoincidenciaEnCadenas(codigoVerificacion, 
                    GestionadorCodigoCorreo.CodigoGenerado);

                if (esElMismoCodigoDeVerificacion)
                {
                    string contrasenaCifrada = EncriptadorContrasena.CalcularHashSha512(
                        jugadorRegistro.Contrasena);
                    CuentaJugador nuevoJugador = new CuentaJugador
                    {
                        NombreJugador = jugadorRegistro.NombreJugador,
                        NumeroAvatar = jugadorRegistro.NumeroAvatar,
                        Contrasena = contrasenaCifrada,
                        Correo = jugadorRegistro.Correo
                    };
                    bool registroRealizado = Servicios.ServicioJugador.RegistrarJugador(
                        nuevoJugador);

                    if (registroRealizado)
                    {
                        temporizador.DetenerTemporizador();
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_VERIFICACIONCORREO_MENSAJEUSUARIOREGISTRADO, Properties.
                            Resources.ETIQUETA_VERIFICACIONCORREO_REGISTROREALIZADO,
                            MessageBoxButton.OK);
                        VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_VERIFICACIONCORREO_MENSAJEREGISTRONOREALIZADO,
                            Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ERRORREGISTRO,
                            MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_VERIFICACIONCORREO_MENSAJECODIGOINCORRECTO,
                        Properties.Resources.ETIQUETA_VERIFICACIONCORREO_CODIGOINCORRECTO,
                        MessageBoxButton.OK);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object objetoOrigen,
            TextChangedEventArgs evento)
        {
            TextBox cuadroTexto = objetoOrigen as TextBox;

            if (cuadroTexto != null)
            {
                string texto = cuadroTexto.Text = new string(cuadroTexto.Text.Where(
                    char.IsDigit).ToArray());
                cuadroTexto.CaretIndex = cuadroTexto.Text.Length;
                cuadroTexto.Text = texto;
            }
        }        

        public void EnviarNuevoCodigoDeConfirmacionACorreo(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            GestionadorCodigoCorreo.EnviarNuevoCodigoDeVerificacionACorreo(
                jugadorRegistro.Correo, Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO,
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " +
                GestionadorCodigoCorreo.CodigoGenerado);
            ComenzarTemporizador();
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