using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RompecabezasFei.Servicios;

namespace RompecabezasFei
{
    public partial class PaginaInformacionJugador : Page
    {
        private ServicioPartida servicioPartida;

        public PaginaInformacionJugador()
        {
            InitializeComponent();
            CargarDatosJugador();
        }

        public void CargarDatosJugador()
        {
            etiquetaNombreJugador.Content = Dominio.
                CuentaJugador.Actual.NombreJugador;
            imagenAvatarJugador.Source = Dominio.
                CuentaJugador.Actual.FuenteImagenAvatar;
            CargarNumeroDePartidasJugadas();
        }

        public void CargarNumeroDePartidasJugadas()
        {
            servicioPartida = new ServicioPartida();
            int numeroPartidasJugadas = servicioPartida.
                ObtenerNumeroPartidasJugadas(Dominio.
                CuentaJugador.Actual.NombreJugador);

            switch (servicioPartida.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    cuadroTextoPartidasJugadas.Text = 
                        Convert.ToString(numeroPartidasJugadas);
                    CargarNumeroDePartidasGanadas();
                    break;
            }

        }

        public void CargarNumeroDePartidasGanadas()
        {
            int numeroPartidasGanadas = servicioPartida.
                ObtenerNumeroPartidasGanadas(Dominio.
                CuentaJugador.Actual.NombreJugador);

            switch (servicioPartida.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    cuadroTextoPartidasGanadas.Text = 
                        Convert.ToString(numeroPartidasGanadas);
                    servicioPartida.CerrarConexion();
                    break;
            }
        }

        private void IrAPaginaActualizacionContrasena(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionContrasena());
        }

        private void IrAPaginaActualizacionInformacion(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionInformacion(
                Dominio.CuentaJugador.Actual.NombreJugador,
                Dominio.CuentaJugador.Actual.NumeroAvatar));
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}