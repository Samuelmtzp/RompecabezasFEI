﻿using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RompecabezasFei.ServicioRompecabezasFei;

namespace RompecabezasFei
{
    public partial class PaginaRecuperacionContrasena : Page
    {
        string correo;

        public PaginaRecuperacionContrasena()
        {
            InitializeComponent();
        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            correo = CuadroCorreo.Text;
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            if (!ExistenCaracteresInvalidosParaCorreo(correo))
            {
                if (cliente.ExisteCorreoElectronico(correo))
                {
                    PaginaCodigoRestablecimientoContrasena paginaCodigoRestablecimientoContrasena =
                        new PaginaCodigoRestablecimientoContrasena(correo);
                    VentanaPrincipal.CambiarPagina(this, paginaCodigoRestablecimientoContrasena);
                }
                else
                {
                    MessageBox.Show("El correo ingresado no existe", "Correo inexistente", MessageBoxButton.OK);
                }
            }
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
        }

        private bool ExistenCaracteresInvalidosParaCorreo(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
                MessageBox.Show("El correo ingresado no es válido", "Correo inválido", MessageBoxButton.OK);
            }
            return caracteresInvalidos;
        }
    }
}