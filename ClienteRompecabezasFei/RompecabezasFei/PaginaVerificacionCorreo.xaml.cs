using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;
using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using Security;

namespace RompecabezasFei
{
    /// <summary>
    /// Lógica de interacción para PaginaVerificacionCorreo.xaml
    /// </summary>
    public partial class PaginaVerificacionCorreo : Page
    {
        string codigoGenerado;
        private int segundosRestantes;
        DispatcherTimer temporizador; 
        private Dominio.CuentaJugador jugadorRegistro;
        public Dominio.CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; } 
            set {  jugadorRegistro = value; }
        }

        public PaginaVerificacionCorreo()
        {
            InitializeComponent();
            EnviarCodigo();
            InicializarTemporizador();
        }

        private void InicializarTemporizador()
        {
            segundosRestantes = 60;
            temporizador = new DispatcherTimer();
            temporizador.Interval = TimeSpan.FromSeconds(1);
            temporizador.Tick += ActualizarTiempo;
            temporizador.Start();
        }

        public void AccionEnviarCodigo(object remitente, RoutedEventArgs evento)
        {
            EnviarCodigo();
        }

        private void EnviarCodigo()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Random generadorNumeroAleatorio = new Random();
            int codigo = generadorNumeroAleatorio.Next(100000, 1000000);
            cliente.EnviarValidacionCorreo(jugadorRegistro.Correo,
                "Código de verificación para concluir registro", codigo);
            codigoGenerado = codigo.ToString();
            DeshabilitarBotonEnvioCodigo();
            InicializarTemporizador();
        }

        private void AccionRegistrar(object remitente, RoutedEventArgs evento)
        {
            string codigoVerificacion = CuadroTextoCodigoVerificacion.Text;

            if (!string.IsNullOrEmpty(codigoGenerado))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.Equals(codigoGenerado);
                if (codigoVerificacionCoincide)
                {
                    string contrasenaCifrada = EncriptadorContrasena.CalcularHashSha512(jugadorRegistro.Contrasena);
                    ServicioRompecabezasFei.CuentaJugador nuevoJugador = new ServicioRompecabezasFei.CuentaJugador
                    {
                        NombreJugador = jugadorRegistro.NombreJugador,
                        NumeroAvatar = jugadorRegistro.NumeroAvatar,
                        Contrasena = jugadorRegistro.Contrasena,
                        Correo = jugadorRegistro.Correo
                    };

                    nuevoJugador.Contrasena = contrasenaCifrada;
                    ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                    bool resultadoRegistro = cliente.Registrar(nuevoJugador);
                    if (resultadoRegistro)
                    {
                        temporizador.Stop();
                        MessageBox.Show("El registro de usuario se ha realizado correctamente",
                            "Registro realizado correctamente", MessageBoxButton.OK);
                        cliente.Abort();
                        VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show("El registro de usuario no se ha realizado",
                            "Error al realizar registro", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Código incorrecto", 
                        "El código de verificacion es incorrecto" ,MessageBoxButton.OK);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object remitente, TextChangedEventArgs evento)
        {
            string texto = new string(CuadroTextoCodigoVerificacion.Text.Where(char.IsDigit).ToArray());
            CuadroTextoCodigoVerificacion.Text = texto;
            CuadroTextoCodigoVerificacion.CaretIndex = texto.Length;
        }

        private void ActualizarTiempo(object remitente, EventArgs evento)
        {
            segundosRestantes--;
            if (segundosRestantes > 0)
            {
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
