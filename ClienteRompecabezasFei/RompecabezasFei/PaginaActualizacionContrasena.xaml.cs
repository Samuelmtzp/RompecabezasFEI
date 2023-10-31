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

        bool esCorrecta, mismaContrasena;
        string contrasena;
       
        public PaginaActualizacionContrasena()
        {
            InitializeComponent();
            jugadorRegistro = new Dominio.CuentaJugador();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void AccionGuardarCambios(object remitente, RoutedEventArgs evento)
        {
            jugadorRegistro.Contrasena = CuadroNuevaContrasena.Password;
            string contrasenaCifrada = EncriptadorContrasena.
                       CalcularHashSha512(jugadorRegistro.Contrasena);
            CuentaJugador datosJugador = new CuentaJugador
            {
                IdCuenta = Dominio.CuentaJugador.CuentaJugadorActual.IdCuenta,
                Contrasena = jugadorRegistro.Contrasena,
            };

            if(!MismaContraseña())
            {
                if (VerificarContraseña())
                {
                    if (!ExistenCamposInvalidos())
                    {
                        ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                        datosJugador.Contrasena = contrasenaCifrada;
                        bool resultadoActualizacion = cliente.ActualizarContrasena(datosJugador);
                        if (resultadoActualizacion)
                        {
                            MessageBox.Show("La actualización de la contraseña se ha realizado correctamente",
                                   "Actualización realizada correctamente", MessageBoxButton.OK);
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
                    MessageBox.Show("La contraseña es incorrecta", "Contraseña incorrecta", MessageBoxButton.OK);
                }
            }
        }

        private bool VerificarContraseña()
        {
            contrasena = CuadroContrasenaActual.Password.ToString();
            contrasena = EncriptadorContrasena.CalcularHashSha512(contrasena);
            if (Dominio.CuentaJugador.CuentaJugadorActual.Contrasena.Equals(contrasena))
            {
                esCorrecta = true;
            }
            return esCorrecta;
        }

        private bool MismaContraseña()
        {
            if (CuadroContrasenaActual.Password.Equals(CuadroNuevaContrasena.Password))
            {
                mismaContrasena = true;
                MessageBox.Show("La contraseña nueva es la misma que ya existe", "Misma contraseña", MessageBoxButton.OK);
            }
            return mismaContrasena; 
        }

        #region Validaciones

        private bool ExistenCamposInvalidos()
        {
            bool camposInvalidos = false;
            if (ExistenCamposVacios() || ContrasenaNuevaConfirmada() ||
                ExisteContrasenaInvalida() || ExistenLongitudesExcedidas())
            {
                camposInvalidos = true;
            }
            return camposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool camposVacios = false;
            if (String.IsNullOrWhiteSpace(jugadorRegistro.Contrasena))
            {
                camposVacios = true;
                MessageBox.Show("No puedes dejar campos vacíos",
                    "Campos vacíos", MessageBoxButton.OK);
            }
            return camposVacios;
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

        private bool ExistenLongitudesExcedidas()
        {
            var camposExcedidos = false;
            if (jugadorRegistro.Contrasena.Length > 45)
            {
                camposExcedidos = true;
                MessageBox.Show("Longitud excedida",
                   "La contraseña ingresada excede la longitud máxima", MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        private bool ContrasenaNuevaConfirmada()
        {
            var NoSonIguales=false;
            if (!CuadroNuevaContrasena.Password.Equals
                (CuadroConfirmacionContrasena.Password))
            {
                NoSonIguales = true;
                MessageBox.Show("La contraseña no coincide",
                    "Contraseña incorrecta", MessageBoxButton.OK);
            }
            return NoSonIguales;
        }
        #endregion  
    }
}
