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

        private void EnviarCodigo()
        {
            bool envioDeCodigoRealizado = GestorCodigoCorreo.
                EnviarNuevoCodigoDeVerificacionACorreo(correoDestino, 
                Properties.Resources.ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO, 
                Properties.Resources.ETIQUETA_RECUPERACION_MENSAJE + 
                $" {GestorCodigoCorreo.CodigoGenerado}");

            if (!envioDeCodigoRealizado)
            {
                GestorCuadroDialogo.MostrarError(
                    Properties.Resources.ETIQUETA_CODIGO_MENSAJENOENVIADO, 
                    Properties.Resources.ETIQUETA_CODIGO_CODIGONOENVIADO);
            }
        }

        private void IrAPaginaInicioSesion(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void IrAPaginaRestablecimientoContrasena(object objetoOrigen,
            RoutedEventArgs evento)
        {
            string codigoVerificacion = cuadroTextoCodigoRestablecimiento.Text;

            if (!ValidadorDatos.EsCadenaVacia(codigoVerificacion))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.
                    Equals(GestorCodigoCorreo.CodigoGenerado);

                if (codigoVerificacionCoincide)
                {
                    VentanaPrincipal.CambiarPagina(
                        new PaginaRestablecimientoContrasena(correoDestino));
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_CODIGO_MENSAJECODIGONOCOINCIDE,
                        Properties.Resources.ETIQUETA_CODIGO_CODIGONOCOINCIDE);
                }
            }
        }

        private void AceptarSoloCaracteresNumericos(object objetoOrigen,
            TextChangedEventArgs evento)
        {
            if (objetoOrigen is TextBox cuadroTexto)
            {
                string texto = cuadroTexto.Text = new string(
                    cuadroTexto.Text.Where(char.IsDigit).ToArray());
                cuadroTexto.CaretIndex = cuadroTexto.Text.Length;
                cuadroTexto.Text = texto;
            }
        }
    }
}