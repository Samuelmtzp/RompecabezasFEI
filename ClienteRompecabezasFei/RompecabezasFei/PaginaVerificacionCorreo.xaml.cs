using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
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
            GestorCodigoCorreo.EnviarNuevoCodigoDeVerificacionACorreo(
                jugadorRegistro.Correo, 
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO,
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " + 
                GestorCodigoCorreo.CodigoGenerado);
            ComenzarTemporizador();
        }

        private void ComenzarTemporizador()
        {
            DeshabilitarBotonEnvioCodigo();
            temporizador = new Temporizador();
            temporizador.DespachadorDeTiempo.Tick += ActualizarTiempoRestante;
            temporizador.IniciarTemporizador(Temporizador.
                DuracionSegundosMaximaReenvioDeCorreo);
        }


        public void ActualizarTiempoRestante(object objetoOrigen, EventArgs evento)
        {
            if (temporizador.SegundosRestantes > Temporizador.MinimoSegundosRestantes)
            {
                temporizador.SegundosRestantes--;
                TimeSpan tiempoRestante = TimeSpan.
                    FromSeconds(temporizador.SegundosRestantes);
                etiquetaTiempoRestante.Content = 
                    $"{tiempoRestante.Minutes:00}:" +
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
                bool coincideCodigoVerificacion = codigoVerificacion.
                    Equals(GestorCodigoCorreo.CodigoGenerado);

                if (coincideCodigoVerificacion)
                {
                    CuentaJugador nuevoJugador = new CuentaJugador
                    {
                        NombreJugador = jugadorRegistro.NombreJugador,
                        NumeroAvatar = jugadorRegistro.NumeroAvatar,
                        Contrasena = EncriptadorContrasena.
                            CalcularHashSha512(jugadorRegistro.Contrasena),
                        Correo = jugadorRegistro.Correo
                    };
                    var servicio = new ServicioJugador();
                    servicio.AbrirNuevaConexion();
                    bool registroRealizado = servicio.RegistrarJugador(nuevoJugador);
                    servicio.CerrarConexion();

                    switch (servicio.EstadoOperacion)
                    {
                        case EstadoOperacion.Correcto:
                            
                            if (registroRealizado)
                            {
                                temporizador.DetenerTemporizador();
                                GestorCuadroDialogo.MostrarInformacion(Properties.Resources.
                                    ETIQUETA_VERIFICACIONCORREO_MENSAJEUSUARIOREGISTRADO, 
                                    Properties.Resources.ETIQUETA_VERIFICACIONCORREO_REGISTROREALIZADO);
                                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                            }
                            else
                            {
                                GestorCuadroDialogo.MostrarError(Properties.Resources.
                                    ETIQUETA_VERIFICACIONCORREO_MENSAJEREGISTRONOREALIZADO,
                                    Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ERRORREGISTRO);
                            }

                            break;
                    }

                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                        ETIQUETA_VERIFICACIONCORREO_MENSAJECODIGOINCORRECTO,
                        Properties.Resources.ETIQUETA_VERIFICACIONCORREO_CODIGOINCORRECTO);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object objetoOrigen,
            TextChangedEventArgs evento)
        {
            if (objetoOrigen is TextBox cuadroTexto)
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
            GestorCodigoCorreo.EnviarNuevoCodigoDeVerificacionACorreo(
                jugadorRegistro.Correo, 
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO,
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " +
                GestorCodigoCorreo.CodigoGenerado);
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