using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using Seguridad;

namespace RompecabezasFei
{
    public partial class PaginaRecuperacionContrasena : Page
    {
        public PaginaRecuperacionContrasena()
        {
            InitializeComponent();
        }

        private void IrAPaginaRestablecimientoContrasena(object objetoOrigen,
            RoutedEventArgs evento)
        {
            string correo = cuadroTextoCorreo.Text;

            if (!ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(correo))
            {
                var servicioCorreo = new ServicioCorreo();

                if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    bool existeCorreo = servicioCorreo.ExisteCorreoRegistrado(correo);
                    servicioCorreo.CerrarConexion();

                    if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
                    {
                        if (existeCorreo)
                        {
                            VentanaPrincipal.CambiarPagina(
                                new PaginaCodigoRestablecimientoContrasena(correo));
                        }
                        else
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                                ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE, 
                                Properties.Resources.
                                ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE);
                        }
                    }
                }
            }
            else
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO);
            }
        }

        private void IrAPaginaInicioSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }
    }
}
