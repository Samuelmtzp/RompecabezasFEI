using RompecabezasFei.ServicioRompecabezasFei;
using Security;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaActualizacionContrasena : Page
    {
        private Dominio.CuentaJugador jugadorRegistro;
        public Dominio.CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; }
            set { jugadorRegistro = value; }
        }

        public PaginaActualizacionContrasena()
        {
            InitializeComponent();
            jugadorRegistro = new Dominio.CuentaJugador();
        }

        #region Eventos
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickGuardarCambios(object controlOrigen, RoutedEventArgs evento)
        {
            jugadorRegistro.Contrasena = cuadroNuevaContrasena.Password;
            string contrasenaCifrada = EncriptadorContrasena.
                CalcularHashSha512(jugadorRegistro.Contrasena);
            CuentaJugador datosJugador = new CuentaJugador
            {
                IdCuenta = Dominio.CuentaJugador.CuentaJugadorActual.IdCuenta,
                Contrasena = jugadorRegistro.Contrasena,
            };

            if (!EsNuevaContrasenaLaMismaContrasenaActual())
            {
                if (EsContrasenaActualCorrecta())
                {
                    if (!ExistenCamposInvalidos())
                    {
                        ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                        datosJugador.Contrasena = contrasenaCifrada;
                        bool resultadoActualizacion = cliente.ActualizarContrasena(datosJugador);

                        if (resultadoActualizacion)
                        {
                            MessageBox.Show("La actualización de la contraseña " +
                                "se ha realizado correctamente",
                                "Actualización realizada correctamente",
                                MessageBoxButton.OK);
                            cliente.Abort();
                            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                        }
                        else
                        {
                            MessageBox.Show("La actualización de la contraseña no se ha realizado",
                                   "Error al actualizar información", MessageBoxButton.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña actual es incorrecta",
                        "Contraseña actual incorrecta", MessageBoxButton.OK);
                }
            }
        }
        #endregion

        #region Validaciones        
        private bool EsContrasenaActualCorrecta()
        {
            string contrasena = cuadroContrasenaActual.Password.ToString();
            contrasena = EncriptadorContrasena.CalcularHashSha512(contrasena);
            bool resultado = false;

            if (Dominio.CuentaJugador.CuentaJugadorActual.Contrasena.Equals(contrasena))
            {
                resultado = true;
            }

            return resultado;
        }

        private bool EsNuevaContrasenaLaMismaContrasenaActual()
        {
            bool resultado = false;

            if (cuadroContrasenaActual.Password.Equals(cuadroNuevaContrasena.Password))
            {
                resultado = true;
                MessageBox.Show("La contraseña nueva es la misma que ya existe", 
                    "Misma contraseña", MessageBoxButton.OK);
            }

            return resultado; 
        }

        private bool ExistenCamposInvalidos()
        {
            bool resultado = false;

            if (ExistenCamposVacios() || NoExisteCoincidenciaEnConfirmacionDeContrasena() ||
                ExisteContrasenaInvalida() || ExistenLongitudesExcedidas())
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;
            
            if (String.IsNullOrWhiteSpace(jugadorRegistro.Contrasena))
            {
                resultado = true;
                MessageBox.Show("No puedes dejar campos vacíos",
                    "Campos vacíos", MessageBoxButton.OK);
            }
            
            return resultado;
        }

        private bool ExisteContrasenaInvalida()
        {
            bool resultado = false;
            
            if (Regex.IsMatch(jugadorRegistro.Contrasena,
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") == false)
            {
                resultado = true; 
                MessageBox.Show("La contraseña que has ingresado es inválida",
                    "Contraseña inválida", MessageBoxButton.OK);                
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool resultado = false;
            
            if (jugadorRegistro.Contrasena.Length > 45)
            {
                resultado = true;
                MessageBox.Show("La contraseña ingresada excede la longitud máxima", 
                    "Longitud excedida", MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool NoExisteCoincidenciaEnConfirmacionDeContrasena()
        {
            bool resultado = false;

            if (!cuadroNuevaContrasena.Password.Equals
                (cuadroConfirmacionContrasena.Password))
            {
                resultado = true;
                MessageBox.Show("La contraseña no coincide",
                    "Contraseña incorrecta", MessageBoxButton.OK);
            }
            return resultado;
        }
        #endregion
    }
}