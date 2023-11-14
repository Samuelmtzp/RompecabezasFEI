using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ComponentModel;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class VentanaPrincipal : Window
    {
        private static Page paginaActual;
        private static Page paginaAnterior;

        public static Page PaginaAnterior
        {
            get { return paginaAnterior; }
            set { paginaAnterior = value; }
        }

        public VentanaPrincipal()
        {
            InitializeComponent();
            Closing += AlCerrarVentana;
            paginaActual = new PaginaInicioSesion();
            MarcoPaginaActual.Navigate(paginaActual);
        }

        public static void CambiarPagina(Page nuevaPagina)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)GetWindow(paginaActual);
            paginaActual = nuevaPagina;
            ventanaPrincipal.MarcoPaginaActual.Navigate(nuevaPagina);
        }

        public static void CambiarPaginaGuardandoAnterior(Page nuevaPagina)
        {
            PaginaAnterior = paginaActual; 
            CambiarPagina(nuevaPagina);
        }

        private void AlCerrarVentana(object objetoOrigen, CancelEventArgs evento)
        {
            if (Dominio.CuentaJugador.Actual != null)
            {
                try
                {
                    DesconectarUsuarioDeServidor();
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

        private void DesconectarUsuarioDeServidor()
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            cliente.CerrarSesion(Dominio.CuentaJugador.Actual.NombreJugador);
            cliente.Abort();
        }
    }
}