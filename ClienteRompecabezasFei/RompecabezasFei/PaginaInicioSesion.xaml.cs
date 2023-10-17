﻿using RompecabezasFei.ServicioRompecabezasFei;
using Dominio;
using Security;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaInicioSesion.xaml
    /// </summary>
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private void AccionModoInvitado(object remitente, RoutedEventArgs evento)
        {
            
            Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador()
            {
                NombreJugador = $"Invitado{new Random().Next()}",
                EsInvitado = true
            };

            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionRecuperarContrasena(object remitente, 
            MouseButtonEventArgs evento)
        {
            MessageBox.Show("Click en opción recuperar contraseña");
        }

        private void AccionRegistro(object remitente, MouseButtonEventArgs evento)
        {            
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroJugador());
        }

        
        private void AccionAjustes(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(this, new PaginaAjustes());
        }

        private void AccionInicioSesion(object remitente, RoutedEventArgs evento)
        {
            var nombreUsuario = CuadroTextoNombreUsuario.Text;
            var contrasena = CuadroContrasena.Password;
            if (!String.IsNullOrWhiteSpace(nombreUsuario) && !String.IsNullOrWhiteSpace(
                contrasena))
            {
                if (ExistenCadenasValidas(nombreUsuario, contrasena) && 
                    !ExistenLongitudesExcedidas(nombreUsuario, contrasena))
                {
                    try
                    {
                        IniciarSesion(nombreUsuario, contrasena);
                    }
                    catch (EndpointNotFoundException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (TimeoutException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alguno de los campos es inválido", 
                        "Campos inválidos", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Alguno de los campos está vacío", "Campos vacíos",
                            MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void IniciarSesion(string nombreJugador, string contrasena)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            ServicioRompecabezasFei.CuentaJugador cuentaJugadorAutenticada = cliente.IniciarSesion(nombreJugador, 
                contrasena);

            if (cuentaJugadorAutenticada.IdJugador != 0)
            {
                Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador
                {
                    Contrasena = cuentaJugadorAutenticada.Contrasena,
                    Correo = cuentaJugadorAutenticada.Correo,
                    IdJugador = cuentaJugadorAutenticada.IdJugador,
                    IdCuenta = cuentaJugadorAutenticada.IdCuenta,
                    NombreJugador = cuentaJugadorAutenticada.NombreJugador,
                    NumeroAvatar = cuentaJugadorAutenticada.NumeroAvatar,
                    EsInvitado = false
                };

                VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión", "Inicio de sesión cancelado", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ExistenCadenasValidas(string nombreJugador, string contrasena)
        {
            var esValido = false;
            if (Regex.IsMatch(nombreJugador, "^[a-zA-Z0-9]*$") && Regex.IsMatch(contrasena, 
                "^[a-zA-Z0-9]*$"))
            {
                esValido = true;
            }
            return esValido;
        }

        private bool ExistenLongitudesExcedidas(string nombreJugador, string contrasena)
        {
            var camposExcedidos = true;
            if (nombreJugador.Length > 15 || contrasena.Length > 45)
            {
                camposExcedidos = false;
            }
            return camposExcedidos;
        }
    }
}
