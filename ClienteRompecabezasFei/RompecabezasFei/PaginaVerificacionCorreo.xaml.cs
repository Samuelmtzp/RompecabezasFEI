﻿using System;
using System.Linq;
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
        private int segundosRestantes;
        private DispatcherTimer temporizador;
        private Dominio.CuentaJugador jugadorRegistro;

        public PaginaVerificacionCorreo(Dominio.CuentaJugador jugadorRegistro)
        {
            InitializeComponent();
            this.jugadorRegistro = jugadorRegistro;
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
            codigoGenerado = GenerarCodigo();
            cliente.EnviarMensajeCorreo(Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, 
                jugadorRegistro.Correo, Properties.Resources.ETIQUETA_VERIFICACIONCORREO_ASUNTO, 
                Properties.Resources.ETIQUETA_VERIFICACIONCORREO_MENSAJE + " " + codigoGenerado);
            DeshabilitarBotonEnvioCodigo();
            InicializarTemporizador();
        }

        private string GenerarCodigo()
        {
            Random generadorNumeroAleatorio = new Random();
            return generadorNumeroAleatorio.Next(100000, 1000000).ToString();
        }

        private void AccionRegistrar(object remitente, RoutedEventArgs evento)
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
                        VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
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
                        "El código de verificacion es incorrecto" , MessageBoxButton.OK);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object remitente, 
            TextChangedEventArgs evento)
        {
            if (remitente is TextBox CuadroTextoCodigoVerificacion)
            {
                string texto = 
                  CuadroTextoCodigoVerificacion.Text = new string(CuadroTextoCodigoVerificacion.Text.Where(char.IsDigit).ToArray());
                CuadroTextoCodigoVerificacion.CaretIndex = CuadroTextoCodigoVerificacion.Text.Length;
                CuadroTextoCodigoVerificacion.Text = texto;
            }
        }

        private void ActualizarTiempo(object remitente, EventArgs evento)
        {
            segundosRestantes--;
            if (segundosRestantes > 0)
            {
                TimeSpan tiempoRestante = TimeSpan.FromSeconds(segundosRestantes);
                EtiquetaTiempoRestante.Content = 
                    $"{tiempoRestante.Minutes:00}:{tiempoRestante.Seconds:00}";
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