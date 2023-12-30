using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
                var servicioCorreo = new Servicios.ServicioCorreo();
                bool existeCorreo = servicioCorreo.ExisteCorreoRegistrado(correo);

                switch (servicioCorreo.EstadoOperacion)
                {
                    case Servicios.EstadoOperacion.Correcto:
                        
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
                        
                        break;
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
