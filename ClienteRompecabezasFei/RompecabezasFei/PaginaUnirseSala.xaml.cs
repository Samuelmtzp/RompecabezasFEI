using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaUnirseSala : Page
    {
        public PaginaUnirseSala()
        {
            InitializeComponent();
        }

        private void IntentarUnirJugadorASala(object objetoOrigen, RoutedEventArgs evento)
        {
            var servicioSala = new ServicioSala();

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                bool existeSalaDisponible = servicioSala.
                    ExisteSalaDisponible(cuadroTextoCodigoSala.Text);
                servicioSala.CerrarConexion();

                if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    if (existeSalaDisponible)
                    {
                        PaginaSala paginaSala = new PaginaSala(false, 
                            cuadroTextoCodigoSala.Text);
                        
                        if (paginaSala.HayConexionConSala)
                        {
                            VentanaPrincipal.CambiarPagina(paginaSala);
                        }
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            "No se ha podido conectar al jugador a la sala debido a que la sala no está disponible",
                            "Sala no disponible");
                    }
                }
            }
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}