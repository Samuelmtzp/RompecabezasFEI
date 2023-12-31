using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class VentanaPrincipal : Window, IServicioJugadorCallback
    {
        private static Page PaginaActual { get; set; }

        public static Page PaginaAnterior { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();
            Closing += CerrarSesionAlCerrarVentana;
            PaginaActual = new PaginaInicioSesion();
            marcoPaginaActual.Navigate(PaginaActual);
        }

        public static void CambiarPagina(Page nuevaPagina)
        {
            VentanaPrincipal ventanaPrincipal = ObtenerVentanaActual();
            PaginaActual = nuevaPagina;
            ventanaPrincipal?.marcoPaginaActual.Navigate(nuevaPagina);
        }

        public static void CambiarPaginaGuardandoAnterior(Page nuevaPagina)
        {
            PaginaAnterior = PaginaActual;
            CambiarPagina(nuevaPagina);
        }

        public static VentanaPrincipal ObtenerVentanaActual()
        {
            return (VentanaPrincipal)GetWindow(PaginaActual);
        }

        public static void CerrarSesion(bool realizarDesconexion)
        {
            if (Dominio.CuentaJugador.Actual != null)
            {
                var servicioJugador = new ServicioJugador();
                
                if (realizarDesconexion)
                {
                    servicioJugador.CerrarSesion(
                        Dominio.CuentaJugador.Actual.NombreJugador);
                }

                if (servicioJugador.HayTemporizadorActivo())
                {
                    servicioJugador.DetenerTemporizador();
                }

                Dominio.CuentaJugador.Actual = null;
                CambiarPagina(new PaginaInicioSesion());
            }
        }

        private void CerrarSesionAlCerrarVentana(object objetoOrigen, 
            CancelEventArgs evento)
        {
            CerrarSesion(true);
        }

        public void ProbarConexionJugador()
        {
            // Método de callback no implementado debido a que es utilizado
            // únicamente para que el servidor verifique si el jugador sigue conectado
        }
    }
}