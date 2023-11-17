﻿using RompecabezasFei.Utilidades;
using Seguridad;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class PaginaCodigoRestablecimientoContrasena : Page
    {
        private readonly string correoDestino;

        public PaginaCodigoRestablecimientoContrasena(string correoDestino)
        {
            InitializeComponent();
            this.correoDestino = correoDestino;
            EnviarCodigo();
        }

        #region Métodos privados
        private void EnviarCodigo()
        {
            bool envioDeCodigoRealizado = GestionadorCodigoCorreo.
                EnviarNuevoCodigoDeVerificacionACorreo(correoDestino, Properties.Resources.
                ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO, Properties.Resources.
                ETIQUETA_RECUPERACION_MENSAJE + $" {GestionadorCodigoCorreo.CodigoGenerado}");

            if (!envioDeCodigoRealizado)
            {
                MessageBox.Show(Properties.Resources.
                            ETIQUETA_CODIGO_MENSAJENOENVIADO, Properties.Resources.
                            ETIQUETA_CODIGO_CODIGONOENVIADO,
                            MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Eventos
        private void IrPaginaInicioSesion(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void IrPaginaRestablecimientoContrasena(object objetoOrigen,
            RoutedEventArgs evento)
        {
            string codigoVerificacion = cuadroTextoCodigoRestablecimiento.Text;

            if (!ValidadorDatos.EsCadenaVacia(codigoVerificacion))
            {
                bool codigoVerificacionCoincide = ValidadorDatos.ExisteCoincidenciaEnCadenas(
                    codigoVerificacion, GestionadorCodigoCorreo.CodigoGenerado);

                if (codigoVerificacionCoincide)
                {
                    VentanaPrincipal.CambiarPagina(new PaginaRestablecimientoContrasena(
                        correoDestino));
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
