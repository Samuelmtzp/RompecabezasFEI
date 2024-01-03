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
        private ServicioInvitaciones servicioInvitaciones;

        public PaginaMenuPrincipal()
        {
            InitializeComponent();
            servicioInvitaciones = new ServicioInvitaciones(this);

            if (servicioInvitaciones.EstadoOperacion == EstadoOperacion.Correcto)
            {
                ActivarInvitacionesDeSala();
            }

            if (!Dominio.CuentaJugador.Actual.EsInvitado)
            {
                MostrarOpcionesJugadorRegistrado();
            }
        }

        private void ActivarInvitacionesDeSala()
        {
            servicioInvitaciones.ActivarInvitacionesDeSala(
                Dominio.CuentaJugador.Actual.NombreJugador);
        }

        private void DesactivarInvitacionesDeSala(EstadoJugador nuevoEstado)
        {
            servicioInvitaciones.DesactivarInvitacionesDeSala(
                Dominio.CuentaJugador.Actual.NombreJugador, nuevoEstado);
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
            DesactivarInvitacionesDeSala(EstadoJugador.Conectado);
            VentanaPrincipal.CambiarPagina(new PaginaUnirseSala());
        }

        private void IrAPaginaAmistades(object objetoOrigen, MouseButtonEventArgs evento)
        {            
            VentanaPrincipal.CambiarPagina(new PaginaAmistades(true));
        }

        private void ConfirmarCierreDeSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            MessageBoxResult opcionSeleccionada = 
                GestorCuadroDialogo.MostrarPreguntaConAdvertencia(
                Properties.Resources.ETIQUETA_CERRARSESION_MENSAJE,
                Properties.Resources.ETIQUETA_CERRARSESION_TITULO);

            if (opcionSeleccionada == MessageBoxResult.Yes)
            {
                // No es necesario cerrar sesión explícitamente,
                // el servidor desconecta al jugador si pasa al estado desconectado
                DesactivarInvitacionesDeSala(EstadoJugador.Desconectado);
                Dominio.CuentaJugador.Actual = null;
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }
        }

        private void IrAPaginaInformacionJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            DesactivarInvitacionesDeSala(EstadoJugador.Conectado);
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void IrAPaginaAjustes(object objetoOrigen, MouseButtonEventArgs evento)
        {
            DesactivarInvitacionesDeSala(EstadoJugador.Conectado);
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
                UnirseASala(codigoSala);
            }
        }

        private void UnirseASala(string codigoSala)
        {
            var servicioSala = new ServicioSala();

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                bool esSalaDisponible = servicioSala.ExisteSalaDisponible(codigoSala);

                if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    if (esSalaDisponible)
                    {
                        PaginaSala paginaSala = new PaginaSala(false, codigoSala);

                        if (paginaSala.HayConexionConSala)
                        {                            
                            VentanaPrincipal.CambiarPagina(paginaSala);
                        }
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            "No es posible unirse a la sala debido a que está llena o hay una partida en curso",
                            "Sala no disponible");
                    }
                }
            }
        }
    }
}