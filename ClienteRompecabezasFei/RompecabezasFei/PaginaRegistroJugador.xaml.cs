﻿using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaRegistroJugador : Page
    {
        private Dominio.CuentaJugador jugadorRegistro;
        public Dominio.CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; }
            set { jugadorRegistro = value; }
        }

        public PaginaRegistroJugador()
        {
            InitializeComponent();
            jugadorRegistro = new Dominio.CuentaJugador();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void AccionSeleccionarAvatar(object remitente, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = ImagenAvatarActual.Source;
            GuardarDatosEdicion();
            paginaSeleccionAvatar.JugadorRegistro = jugadorRegistro;
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
        }

        public void CargarDatosEdicion()
        {
            CuadroTextoNombreUsuario.Text = jugadorRegistro.NombreJugador;
            CuadroTextoCorreoElectronico.Text = jugadorRegistro.Correo;
            CuadroContrasena.Password = jugadorRegistro.Contrasena;
            CuadroConfirmacionContrasena.Password = jugadorRegistro.ConfirmacionContrasena;
        }

        private void GuardarDatosEdicion()
        {
            jugadorRegistro = new Dominio.CuentaJugador()
            {
                NombreJugador = CuadroTextoNombreUsuario.Text,
                Correo = CuadroTextoCorreoElectronico.Text,
                Contrasena = CuadroContrasena.Password,
                ConfirmacionContrasena = CuadroConfirmacionContrasena.Password
            };
        }

        private void AccionSiguiente(object remitente, RoutedEventArgs evento)
        {
            jugadorRegistro.NombreJugador = CuadroTextoNombreUsuario.Text;
            jugadorRegistro.Correo = CuadroTextoCorreoElectronico.Text;
            jugadorRegistro.Contrasena = CuadroContrasena.Password;
            jugadorRegistro.ConfirmacionContrasena = CuadroConfirmacionContrasena.Password;
            jugadorRegistro.NumeroAvatar = Convert.ToInt16(ImagenAvatarActual.Tag); 

            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            if (!ExistenCamposInvalidos())
            {     
                try
                {
                    if (!(cliente.ExisteNombreJugador(jugadorRegistro.NombreJugador)) &&
                    !(cliente.ExisteCorreoElectronico(jugadorRegistro.Correo)))
                    {
                        PaginaVerificacionCorreo paginaVerificacionCorreo =
                            new PaginaVerificacionCorreo(jugadorRegistro);
                        VentanaPrincipal.CambiarPagina(paginaVerificacionCorreo);
                    }
                }
                catch (EndpointNotFoundException)
                {
                    // [...] Log
                }                
            }
        }

        #region Validaciones
        private bool ExistenCamposInvalidos()
        {
            bool camposInvalidos = false;
            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || ExistenLongitudesExcedidas()
                || ExisteContrasenaInvalida() || ExisteContrasenaIncorrecta())
            {
                camposInvalidos = true;
            }
            return camposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool camposVacios = false;
            if (String.IsNullOrWhiteSpace(jugadorRegistro.NombreJugador) 
                || String.IsNullOrWhiteSpace(jugadorRegistro.Correo) 
                || String.IsNullOrWhiteSpace(jugadorRegistro.Contrasena) 
                || String.IsNullOrWhiteSpace(jugadorRegistro.ConfirmacionContrasena))
            {
                camposVacios = true;
                MessageBox.Show("No puedes dejar campos vacíos", 
                    "Campos vacíos", MessageBoxButton.OK);
            }
            return camposVacios;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool camposExcedidos = false;
            if (jugadorRegistro.NombreJugador.Length > 15 || jugadorRegistro.Correo.Length > 65 
                || jugadorRegistro.Contrasena.Length > 45)
            {
                camposExcedidos = true;
                MessageBox.Show("Corrige los campos excedidos", 
                    "Campos excedidos", MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool cadenasInvalidas = false;
            if (ExistenCaracteresInvalidos(CuadroTextoNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario que has ingresado es inválido", 
                    "Nombre de usuario inválido", MessageBoxButton.OK);
                cadenasInvalidas = true;
            }

            if (ExistenCaracteresInvalidosParaCorreo(CuadroTextoCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico que has ingresado es inválido", 
                    "Correo electrónico inválido", MessageBoxButton.OK);
                cadenasInvalidas = true;
            }
            return cadenasInvalidas;
        }

        private bool ExisteContrasenaInvalida()
        {
            bool contrasenaInvalida = false;
            if (Regex.IsMatch(jugadorRegistro.Contrasena, 
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") 
                == false)
            {
                MessageBox.Show("La contraseña que has ingresado es inválida", 
                    "Contraseña inválida", MessageBoxButton.OK);
                contrasenaInvalida = true;
            }
            return contrasenaInvalida;
        }

        private bool ExistenCaracteresInvalidosParaCorreo(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
            }
            return caracteresInvalidos;
        }

        private bool ExistenCaracteresInvalidos(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[A-Za-zÁÉÍÓÚáéíóúñÑ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúñÑ]+)?$") == false)
            {
                caracteresInvalidos = true;
            }
            return caracteresInvalidos;
        }

        private bool ExisteContrasenaIncorrecta()
        {
            bool contrasenaInvalida;
            if (jugadorRegistro.Contrasena == jugadorRegistro.ConfirmacionContrasena)
            {
                contrasenaInvalida = false;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", 
                    "Contraseñas diferentes", MessageBoxButton.OK);
                contrasenaInvalida = true;
            }
            return contrasenaInvalida;
        }
        #endregion 
    }
}
