﻿using RompecabezasFei.ServicioRompecabezasFei;
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
            codigoGenerado = generadorNumeroAleatorio.Next(100000, 1000000).ToString();
            bool codigoEnviado = false;
            
            try
            {
                codigoEnviado = VentanaPrincipal.ClienteServicioGestionJugador.
                    EnviarMensajeCorreo(Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, 
                    correo, Properties.Resources.ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO, 
                    Properties.Resources.ETIQUETA_RECUPERACION_MENSAJE + $" {codigoGenerado}");
            }
            catch (EndpointNotFoundException)
            {
                
            }

            if (!codigoEnviado)
            {
                MessageBox.Show("El código de confirmación no pudo enviarse", "Codigo no enviado",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
                    MessageBox.Show(Properties.Resources.ETIQUETA_CODIGO_MENSAJECODIGONOCOINCIDE, 
                        Properties.Resources.ETIQUETA_CODIGO_CODIGONOCOINCIDE,
                        MessageBoxButton.OK);
                }
            }
        }

        private void EventoAceptarSoloCaracteresNumericos(object controlOrigen,
            TextChangedEventArgs evento)
        {
            if (controlOrigen is TextBox cuadroTextoCodigoRestablecimiento)
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
