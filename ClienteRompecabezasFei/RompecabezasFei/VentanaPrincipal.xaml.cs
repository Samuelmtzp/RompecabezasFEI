using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class VentanaPrincipal : Window
    {
        private static Page PaginaActual { get; set; }

        public static Page PaginaAnterior { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();
            Closing += CerrarSesionActual;
            PaginaActual = new PaginaInicioSesion();
            marcoPaginaActual.Navigate(PaginaActual);
        }

        public static void CambiarPagina(Page nuevaPagina)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)GetWindow(PaginaActual);
            PaginaActual = nuevaPagina;
            ventanaPrincipal.marcoPaginaActual.Navigate(nuevaPagina);
        }

        public static void CambiarPaginaGuardandoAnterior(Page nuevaPagina)
        {
            PaginaAnterior = PaginaActual;
            CambiarPagina(nuevaPagina);
        }

        private void CerrarSesionActual(object objetoOrigen, CancelEventArgs evento)
        {
            if (Dominio.CuentaJugador.Actual != null && 
                !Dominio.CuentaJugador.Actual.EsInvitado)
            {
                Servicios.ServicioJugador.CerrarSesion(Dominio.CuentaJugador.
                    Actual.NombreJugador);
            }
        }
    }
}