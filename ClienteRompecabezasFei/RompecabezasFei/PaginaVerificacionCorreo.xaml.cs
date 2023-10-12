using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dominio;
using RompecabezasFei.ServicioGestionJugador;
using Security;

namespace RompecabezasFei
{
    /// <summary>
    /// Lógica de interacción para PaginaVerificacionCorreo.xaml
    /// </summary>
    public partial class PaginaVerificacionCorreo : Page
    {
        private Dominio.Jugador jugadorRegistro;
        public Dominio.Jugador JugadorRegistro
        {
            get { return jugadorRegistro; } 
            set {  jugadorRegistro = value; }
        }

        string codigoGenerado;

        public PaginaVerificacionCorreo()
        {
            InitializeComponent();
        }

        public void AccionEnviarCodigo(object remitente, RoutedEventArgs evento)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Random numeroAleatorio = new Random();
            var codigo = numeroAleatorio.Next(100000, 1000000);
            cliente.EnviarValidacionCorreo(jugadorRegistro.Correo, "Código de verificación", codigo);
            codigoGenerado = codigoGenerado.ToString();
        }

        private void AccionRegistrar(object remitente, RoutedEventArgs evento)
        {
            string codigoVerificacion = CuadroTextoCodigoVerificacion.Text;

            if (!string.IsNullOrEmpty(codigoGenerado))
            {
                bool codigoVerificacionCoincide = codigoVerificacion.Equals(codigoGenerado);
                if (codigoVerificacionCoincide)
                {
                    string contrasenaCifrada = EncriptadorContrasena.CalcularHashSha512(jugadorRegistro.Contrasena);
                    ServicioGestionJugador.Jugador nuevoJugador = new ServicioGestionJugador.Jugador
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
                        MessageBox.Show("El registro de usuario se ha realizado correctamente",
                            "Registro realizado correctamente", MessageBoxButton.OK);
                        cliente.Abort();
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
                        "El código de verificacion es incorrecto" ,MessageBoxButton.OK);
                }
            }
        }

        private void Regresar()
        {
            PaginaRegistroUsuario paginaRegistroUsuario = new PaginaRegistroUsuario();
            paginaRegistroUsuario.JugadorRegistro = jugadorRegistro;
            paginaRegistroUsuario.CargarDatosEdicion();
            VentanaPrincipal.CambiarPagina(this, paginaRegistroUsuario);
        }

        private void AccionRegresar(object sender, MouseButtonEventArgs e)
        {
            Regresar();
        }

        private void CuadroTextoCodigoVerificacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           if (System.Text.RegularExpressions.Regex.IsMatch(CuadroTextoCodigoVerificacion.Text, "  ^ [0-9]"))
              {
                  CuadroTextoCodigoVerificacion.Text = "";
              }
            
        }
    }
}
