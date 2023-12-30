using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaMenuPrincipal : Page, IServicioInvitacionesCallback
    {
        public PaginaMenuPrincipal()
        {
            InitializeComponent();

            if (!Dominio.CuentaJugador.Actual.EsInvitado)
            {
                MostrarOpcionesJugadorRegistrado();
            }
        }

        private void MostrarOpcionesJugadorRegistrado()
        {
            etiquetaMisAmigos.Visibility = Visibility.Visible;
            etiquetaMiPerfil.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Visibility = Visibility.Visible;
            imagenMisAmigos.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Source = Dominio.CuentaJugador.Actual.FuenteImagenAvatar;
        }

        private void CrearNuevaSala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala(true, null);

            if (paginaSala.HayConexionConSala)
            {
                VentanaPrincipal.CambiarPagina(paginaSala);
            }
        }

        private void IrAPaginaUnirseSala(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaUnirseSala());
        }

        private void IrAPaginaAmistades(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaAmistades(true));
        }

        private void CerrarSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            MessageBoxResult opcionSeleccionada = 
                GestorCuadroDialogo.MostrarPreguntaConAdvertencia(
                Properties.Resources.ETIQUETA_CERRARSESION_MENSAJE,
                Properties.Resources.ETIQUETA_CERRARSESION_TITULO);

            if (opcionSeleccionada == MessageBoxResult.Yes)
            {
                VentanaPrincipal.CerrarSesion(true);
            }
        }

        private void IrAPaginaInformacionJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void IrAPaginaAjustes(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }

        public void MostrarInvitacionDeSala(string nombreJugador, string codigoSala)
        {
            MessageBoxResult opcionSeleccionada =
                    GestorCuadroDialogo.MostrarPreguntaNormal(
                    $"{nombreJugador} te ha invitado a unirte a su sala, ¿Aceptas?", 
                    "Invitación de sala");

            if (opcionSeleccionada == MessageBoxResult.Yes)
            {
                var servicio = new ServicioSala();
                bool esSalaDisponible = servicio.ExisteSalaDisponible(codigoSala);

                switch (servicio.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:

                        if (esSalaDisponible)
                        {
                            PaginaSala paginaSala = new PaginaSala(false, codigoSala);
                            VentanaPrincipal.CambiarPagina(paginaSala);
                        }
                        else
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(
                                "No es posible unirse a la sala debido a que no está disponible", 
                                "Sala no disponible");
                        }

                        break;
                }
            }
        }
    }
}