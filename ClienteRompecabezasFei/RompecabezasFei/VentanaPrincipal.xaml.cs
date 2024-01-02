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

        public static ServicioJugador ServicioJugador { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();
            Closing += (objetoOrigen, evento) => CerrarSesion();
            ServicioJugador = new ServicioJugador();
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

        public void DeshabilitarMarcoPaginaActual()
        {
            marcoPaginaActual.IsEnabled = false;
        }

        public void HabilitarMarcoPaginaActual()
        {
            marcoPaginaActual.IsEnabled = true;
            marcoPaginaActual.Navigate(PaginaActual);
        }

        public static void CerrarSesion()
        {
            if (Dominio.CuentaJugador.Actual != null)
            {
                ServicioJugador.CerrarSesion(Dominio.
                    CuentaJugador.Actual.NombreJugador);
                ServicioJugador.CerrarConexion();
                Dominio.CuentaJugador.Actual = null;
                CambiarPagina(new PaginaInicioSesion());
            }
        }

        // Este método no se implementó debido a que el servidor nunca lo utiliza
        public void ProbarConexionJugador()
        {
        }
    }
}