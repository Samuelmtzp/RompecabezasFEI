using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using RompecabezasFei.Servicios;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaAmistades : Page, IServicioAmistadesCallback
    {
        private ServicioAmistades servicioAmistades;

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeAmigos { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeSolicitudes { get; set; }

        public PaginaAmistades(bool inicializarDatos)
        {
            if (inicializarDatos)
            {
                InitializeComponent();
                ConfigurarDatosIniciales();
            }
        }

        private void ConfigurarDatosIniciales()
        {
            listaAmigos.DataContext = this;
            listaSolicitudes.DataContext = this;
            CuentasDeAmigos = new ObservableCollection<Dominio.CuentaJugador>();
            CuentasDeSolicitudes = new ObservableCollection<Dominio.CuentaJugador>();                        
            servicioAmistades = new ServicioAmistades(this);

            if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
            {
                CargarAmigosJugador();
            }
        }      

        private void CargarAmigosJugador()
        {
            var amigosDeJugador = servicioAmistades.ObtenerAmigosDeJugador(
                Dominio.CuentaJugador.Actual.NombreJugador);

            if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
            {
                foreach (var amigo in amigosDeJugador)
                {
                    Dominio.CuentaJugador cuentaDeAmigo = new Dominio.CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                        FuenteImagenAvatar = GeneradorImagenes.
                            GenerarFuenteImagenAvatar(amigo.NumeroAvatar),
                        ColorEstadoConectividad = ObtenerColorDeEstadoJugador(
                            amigo.Estado),
                    };
                    CuentasDeAmigos.Add(cuentaDeAmigo);
                }

                CargarJugadoresConSolicitudPendiente();
            }
        }

        private void CargarJugadoresConSolicitudPendiente()
        {
            var jugadoresObtenidos = servicioAmistades.
                ObtenerJugadoresConSolicitudPendiente(
                Dominio.CuentaJugador.Actual.NombreJugador);

            if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
            {
                foreach (var jugador in jugadoresObtenidos)
                {
                    var cuentaSolicitud = new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = GeneradorImagenes.
                            GenerarFuenteImagenAvatar(jugador.NumeroAvatar),
                        ColorEstadoConectividad = ObtenerColorDeEstadoJugador(
                            jugador.Estado),
                    };
                    CuentasDeSolicitudes.Add(cuentaSolicitud);
                }

                ActivarNotificaciones();
            }
        }

        private void ActivarNotificaciones()
        {
            servicioAmistades.ActivarNotificaciones(
                Dominio.CuentaJugador.Actual.NombreJugador);
        }

        private void DesactivarNotificaciones()
        {
            servicioAmistades.DesactivarNotificaciones(
                Dominio.CuentaJugador.Actual.NombreJugador);
            servicioAmistades.CerrarConexion();
        }

        private SolidColorBrush ObtenerColorDeEstadoJugador(EstadoJugador estado)
        {
            SolidColorBrush color = Brushes.Gray;

            switch (estado)
            {
                case EstadoJugador.Conectado:
                case EstadoJugador.Disponible:
                    color = Brushes.Green;
                    break;

                case EstadoJugador.EnSala:
                case EstadoJugador.EnPartida:
                    color = Brushes.Red;
                    break;
            }

            return color;
        }

        private bool EsElNombreDelJugadorActual()
        {
            bool resultado = false;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;

            if (Dominio.CuentaJugador.Actual.NombreJugador.
                Equals(nombreJugadorDestino))
            {
                resultado = true;
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_AMISTADES_SOLICITUDNOENVIADAMISMONOMBRE,
                    Properties.Resources.ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD);
            }

            return resultado;
        }

        private bool ExisteNombreJugadorRegistrado(string nombreJugador)
        {
            bool existeNombreJugador = VentanaPrincipal.ServicioJugador.
                ExisteNombreJugadorRegistrado(nombreJugador);

            if (VentanaPrincipal.ServicioJugador.
                EstadoOperacion == EstadoOperacion.Correcto && !existeNombreJugador)
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    "El nombre de jugador al que deseas enviar una solicitud de amistad no existe", 
                    "Solicitud no enviada");
            }

            return existeNombreJugador;
        }

        private bool ExisteSolicitudDeAmistad()
        {
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool existeSolicitud = servicioAmistades.ExisteSolicitudAmistad(
                nombreJugadorOrigen, nombreJugadorDestino);

            if (servicioAmistades.EstadoOperacion == 
                EstadoOperacion.Correcto && existeSolicitud)
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_AMISTADES_MENSAJESOLICITUDNOENVIADA,
                    Properties.Resources.ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD);
            }

            return existeSolicitud;
        }

        private bool ExisteAmistadConJugador()
        {
            string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
            string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
            bool existeAmistad = servicioAmistades.ExisteAmistadConJugador(
                nombreJugadorOrigen, nombreJugadorDestino);

            if (servicioAmistades.EstadoOperacion == 
                EstadoOperacion.Correcto && existeAmistad)
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_AMISTADES_SOLICITUDNOENVIADAYAESAMIGO,
                    Properties.Resources.ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD);
            }

            return existeAmistad;
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {            
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void EnviarSolicitudDeAmistad(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!EsElNombreDelJugadorActual() && ExisteNombreJugadorRegistrado(
                cuadroTextoNombreUsuarioInvitacion.Text) &&
                !ExisteSolicitudDeAmistad() && !ExisteAmistadConJugador())
            {
                string nombreJugadorOrigen = Dominio.CuentaJugador.Actual.NombreJugador;
                string nombreJugadorDestino = cuadroTextoNombreUsuarioInvitacion.Text;
                bool envioSolicitudRealizado = servicioAmistades.
                    EnviarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);

                if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    if (envioSolicitudRealizado)
                    {
                        GestorCuadroDialogo.MostrarInformacion(
                            Properties.Resources.ETIQUETA_AMISTADES_MENSAJESOLICTUDENVIADA, 
                            Properties.Resources.ETIQUETA_AMISTADES_SOLICITUDENVIADA);
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            Properties.Resources.ETIQUETA_AMISTADES_SOLICITUDNOENVIADA,
                            Properties.Resources.ETIQUETA_AMISTADES_ERRORENVIARSOLICITUD);
                    }
                }
            }
        }

        private void EliminarAmigo(object objetoOrigen, RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaAmigos.
                ContainerFromElement((Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaAmigos.SelectedItem;
            bool eliminacionRealizada = servicioAmistades.
                EliminarAmistadEntreJugadores(Dominio.CuentaJugador.
                Actual.NombreJugador, jugadorSeleccionado.NombreJugador);
            
            if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
            {
                if (eliminacionRealizada)
                {
                    CuentasDeAmigos.Remove(jugadorSeleccionado);
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_AMISTADES_MENSAJEERRORELIMINARAMIGO,
                        Properties.Resources.ETIQUETA_AMISTADES_ERRORELIMINARAMIGO);
                }
            }
        }

        private void AceptarSolicitudDeAmistad(object objetoOrigen,
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.
                ContainerFromElement((Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaSolicitudes.SelectedItem;

            if (jugadorSeleccionado != null)
            {
                bool solicitudAceptada = servicioAmistades.
                    AceptarSolicitudDeAmistad(jugadorSeleccionado.NombreJugador, 
                    Dominio.CuentaJugador.Actual.NombreJugador);

                if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    if (solicitudAceptada)
                    {
                        CuentasDeSolicitudes.Remove(jugadorSeleccionado);
                        CuentasDeAmigos.Add(jugadorSeleccionado);
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            Properties.Resources.ETIQUETA_AMISTADES_MENSAJEERRORACEPTARSOLICITUD,
                            Properties.Resources.ETIQUETA_AMISTADES_ERRORACEPTARSOLICITUD);
                    }
                }
            }
        }

        private void RechazarSolicitudDeAmistad(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            var filaActual = (ListBoxItem)listaSolicitudes.
                ContainerFromElement((Button)objetoOrigen);
            filaActual.IsSelected = true;
            var jugadorSeleccionado = (Dominio.CuentaJugador)listaSolicitudes.SelectedItem;
            string nombreJugadorOrigen = jugadorSeleccionado.NombreJugador;
            string nombreJugadorDestino = Dominio.CuentaJugador.Actual.NombreJugador;
            bool solicitudRechazada = servicioAmistades.
                RechazarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);

            if (servicioAmistades.EstadoOperacion == EstadoOperacion.Correcto)
            {
                if (solicitudRechazada)
                {
                    CuentasDeSolicitudes.Remove(jugadorSeleccionado);
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_AMISTADES_MENSAJEERRORRECHAZARSOLICITUD,
                        Properties.Resources.ETIQUETA_AMISTADES_ERRORRECHAZARSOLICITUD);
                }
            }
        }        

        public void ActualizarEstadoDeJugador(string nombreJugador,
            EstadoJugador estado)
        {
            var cuentaAmigoModificacion = CuentasDeAmigos.FirstOrDefault(amigo =>
                amigo.NombreJugador == nombreJugador);
            CuentasDeAmigos.Remove(cuentaAmigoModificacion);

            if (cuentaAmigoModificacion != null)
            {
                cuentaAmigoModificacion.ColorEstadoConectividad =
                    ObtenerColorDeEstadoJugador(estado);
            }

            CuentasDeAmigos.Insert(0, cuentaAmigoModificacion);
        }

        public void MostrarSolicitudDeAmistadRecibida(CuentaJugador cuentaNuevaSolicitud)
        {
            CuentasDeSolicitudes.Add(new Dominio.CuentaJugador
            {
                NombreJugador = cuentaNuevaSolicitud.NombreJugador,
                NumeroAvatar = cuentaNuevaSolicitud.NumeroAvatar,
                FuenteImagenAvatar = GeneradorImagenes.
                    GenerarFuenteImagenAvatar(cuentaNuevaSolicitud.NumeroAvatar),
                ColorEstadoConectividad = ObtenerColorDeEstadoJugador(
                    cuentaNuevaSolicitud.Estado)
            });
        }

        public void MostrarNuevoAmigo(CuentaJugador cuentaNuevoAmigo)
        {
            var solicitudAmistadResidual = CuentasDeSolicitudes.FirstOrDefault(
                cuentaSolicitud => cuentaSolicitud.NombreJugador ==
                cuentaNuevoAmigo.NombreJugador);

            if (solicitudAmistadResidual != null)
            {
                CuentasDeSolicitudes.Remove(solicitudAmistadResidual);
            }

            CuentasDeAmigos.Add(new Dominio.CuentaJugador
            {
                NombreJugador = cuentaNuevoAmigo.NombreJugador,
                NumeroAvatar = cuentaNuevoAmigo.NumeroAvatar,
                FuenteImagenAvatar = GeneradorImagenes.
                    GenerarFuenteImagenAvatar(cuentaNuevoAmigo.NumeroAvatar),
                ColorEstadoConectividad = ObtenerColorDeEstadoJugador(
                    cuentaNuevoAmigo.Estado)
            });
        }

        public void RemoverAmigoConAmistadCancelada(string nombreJugador)
        {
            var cuentaAmigoEliminacion = CuentasDeAmigos.
                FirstOrDefault(amigo => amigo.NombreJugador == nombreJugador);

            if (cuentaAmigoEliminacion != null)
            {
                CuentasDeAmigos.Remove(cuentaAmigoEliminacion);
            }
        }
    }
}