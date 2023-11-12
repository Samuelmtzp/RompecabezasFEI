﻿using RompecabezasFei.ServicioRompecabezasFei;
using Security;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaActualizacionContrasena : Page
    {
        public PaginaActualizacionContrasena()
        {
            InitializeComponent();
        }

        #region Eventos
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickGuardarCambios(object controlOrigen, RoutedEventArgs evento)
        {
            string contrasenaActual = Dominio.CuentaJugador.Actual.Contrasena;
            string contrasenaAnterior = cuadroContrasenaActual.Password;     
            string nuevaContrasena = cuadroNuevaContrasena.Password;
            string confirmacionContrasena = cuadroConfirmacionContrasena.Password;

            if (EsLaMismaContrasena(contrasenaAnterior, contrasenaActual))
            {
                if (!EsLaMismaContrasena(contrasenaAnterior, nuevaContrasena))
                {
                    if (!ExistenDatosInvalidos(nuevaContrasena, confirmacionContrasena))
                    {                        
                        string correoJugador = Dominio.CuentaJugador.Actual.Correo;
                        string nuevaContrasenaCifrada = EncriptadorContrasena.
                            CalcularHashSha512(nuevaContrasena);

                        try
                        {
                            ActualizarContrasena(correoJugador, nuevaContrasenaCifrada);
                        }
                        catch (CommunicationException)
                        {
                            MessageBox.Show(Properties.Resources.
                                ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                                ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                                MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        catch (TimeoutException)
                        {
                            MessageBox.Show(Properties.Resources.
                                ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                                ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                                MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }

        private void ActualizarContrasena(string correo, string nuevaContrasena)
        {            
            bool resultado = VentanaPrincipal.ClienteServicioGestionJugador.
                ActualizarContrasena(correo, nuevaContrasena);
            
            if (resultado)
            {
                MessageBox.Show("La actualización de la contraseña " +
                    "se ha realizado correctamente",
                    "Actualización realizada correctamente",
                    MessageBoxButton.OK);
                Dominio.CuentaJugador.Actual.Contrasena = nuevaContrasena;
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }
            else
            {
                MessageBox.Show("La actualización de la contraseña no se ha realizado",
                       "Error al actualizar información", MessageBoxButton.OK);
            }
        }
        #endregion

        #region Validaciones        
        private bool EsLaMismaContrasena(string contrasenaA, string contrasenaB)
        {
            bool resultado = false;

            if (contrasenaA.Equals(contrasenaB))
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenDatosInvalidos(string nuevaContrasena, 
            string confirmacionContrasena)
        {
            bool resultado = false;

            if (!EsLaMismaContrasena(nuevaContrasena, confirmacionContrasena))
            {
                if (ExistenCamposVacios() || ExisteNuevaContrasenaInvalida(nuevaContrasena) ||
                    ExistenLongitudesExcedidasEnNuevaContrasena())
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;
            
            if (string.IsNullOrWhiteSpace(cuadroContrasenaActual.Password) || 
                string.IsNullOrWhiteSpace(cuadroNuevaContrasena.Password) || 
                string.IsNullOrWhiteSpace(cuadroConfirmacionContrasena.Password))
            {
                resultado = true;
                MessageBox.Show("No puedes dejar campos vacíos",
                    "Campos vacíos", MessageBoxButton.OK);
            }
            
            return resultado;
        }

        private bool ExisteNuevaContrasenaInvalida(string contrasena)
        {
            bool resultado = false;
            
            if (Regex.IsMatch(contrasena,
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") == false)
            {
                resultado = true; 
                MessageBox.Show("La nueva contraseña que has ingresado es inválida",
                    "Contraseña inválida", MessageBoxButton.OK);                
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidasEnNuevaContrasena()
        {
            bool resultado = false;
            
            if (cuadroNuevaContrasena.Password.Length > 45)
            {
                resultado = true;
                MessageBox.Show("La contraseña ingresada excede la longitud máxima", 
                    "Longitud excedida", MessageBoxButton.OK);
            }

            return resultado;
        }        
        #endregion
    }
}