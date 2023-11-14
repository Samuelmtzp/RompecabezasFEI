﻿using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaSala : Page, IServicioJuegoCallback
    {
        #region Atributos
        private string codigoSala;
        private bool esNuevaSala;
        private bool esAnfitrion;
        private bool hayConexionEstablecida;
        private ServicioJuegoClient clienteServicioJuego;
        #endregion

        #region Propiedades
        public string CodigoSala 
        {
            get { return codigoSala; }
            set { codigoSala = value; }
        }
        public bool EsNuevaSala
        {
            get { return esNuevaSala; }
            set { esNuevaSala = value; }
        }
        #endregion

        public PaginaSala()
        {
            InitializeComponent();            
        }        

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            FinalizarConexionConSala();
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void EventoOpcionesSala(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustesPartida());
        }

        private void AccionCopiarCodigoSala(object remitente, RoutedEventArgs evento)
        {
            Clipboard.SetText(codigoSala);
        }

        private void AccionEnviarMensaje(object remitente, RoutedEventArgs evento)
        {
            if (!string.IsNullOrEmpty(CuadroTextoMensajeUsuario.Text))
            {
                clienteServicioJuego.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, CuadroTextoMensajeUsuario.Text);
                CuadroTextoMensajeUsuario.Clear();
            }
        }

        private void EventoClickNuevaPartida(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaPartida());
        }

        public void IniciarConexionConSala(bool esNuevaSala)
        {
            this.esNuevaSala = esNuevaSala;

            if (!hayConexionEstablecida)
            {
                clienteServicioJuego = new ServicioJuegoClient(new InstanceContext(this));

                if (esNuevaSala)
                {
                    esAnfitrion = true; 
                    BotonIniciarPartida.Visibility = Visibility.Visible;
                    CrearNuevaSala();
                }
                else
                {
                    esAnfitrion = false;
                    BotonIniciarPartida.Visibility = Visibility.Hidden;
                }

                EtiquetaCodigoSala.Content = codigoSala;
                clienteServicioJuego.ConectarCuentaJugadorASala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, 
                    Properties.Resources.ETIQUETA_MENSAJESALA_BIENVENIDA);
                hayConexionEstablecida = true;
            }
        }

        public void CargarDatosSala(bool esAnfitrion, string codigoSala)
        {
            this.esAnfitrion = esAnfitrion;
            EtiquetaCodigoSala.Content = codigoSala;
        }

        private void CrearNuevaSala()
        {
            try
            {
                codigoSala = clienteServicioJuego.GenerarCodigoParaNuevaSala();
                clienteServicioJuego.CrearNuevaSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
        }

        private void FinalizarConexionConSala()
        {
            if (hayConexionEstablecida)
            {
                try
                {
                    clienteServicioJuego.DesconectarCuentaJugadorDeSala(Dominio.
                        CuentaJugador.Actual.NombreJugador, codigoSala,
                        Properties.Resources.ETIQUETA_MENSAJESALA_DESPEDIDA);
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
                finally
                {
                    clienteServicioJuego.Abort();                    
                }

                clienteServicioJuego = null;
                hayConexionEstablecida = false;
            }
        }

        public bool VerificarDisponibilidadSala(string idSala)
        {
            bool disponibilidadSala = false;

            try
            {
                disponibilidadSala = clienteServicioJuego.ExisteSalaDisponible(idSala);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }

            return disponibilidadSala;
        }

        #region Callbacks
        public void MostrarMensajeDeSala(string mensaje)
        {
            CuadroTextoMensajes.AppendText(mensaje + "\n");
        }
        #endregion
    }
}