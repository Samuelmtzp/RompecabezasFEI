using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioJugador : Servicio
    {
        private static ServicioJugadorClient clienteServicioJugador;

        private static bool esConexionCerradaPorCliente = false;

        public override void AbrirConexion()
        {
            try
            {
                clienteServicioJugador = new ServicioJugadorClient(
                    new InstanceContext(VentanaPrincipal.ObtenerVentanaActual()));
                clienteServicioJugador.Open();
                clienteServicioJugador.InnerChannel.Closed +=
                    (objetoOrigen, evento) =>
                    ManejarConexionConServidorCerrada(); 
                clienteServicioJugador.InnerChannel.Faulted +=
                    (objetoOrigen, evento) =>
                    MostrarMensajeConexionPerdida();
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (InvalidOperationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
        }

        private void MostrarMensajeConexionPerdida()
        {
            EstadoOperacion = EstadoOperacion.Error;
            GestorPanelBloqueoVentana.MostrarPanelBloqueo();
            GestorCuadroDialogo.MostrarError(
                Properties.Resources.ETIQUETA_ERRORCONEXIONPERDIDASERVIDOR_MENSAJE,
                Properties.Resources.ETIQUETA_ERRORCONEXIONPERDIDASERVIDOR_TITULO);
            Dominio.CuentaJugador.Actual = null;
            GestorPanelBloqueoVentana.OcultarPanelBloqueo();
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }));
        }

        private void ManejarConexionConServidorCerrada()
        {
            if (!esConexionCerradaPorCliente)
            {
                MostrarMensajeConexionPerdida();
            }
        }

        public override void CerrarConexion()
        {
            if (clienteServicioJugador.State == CommunicationState.Opened)
            {
                try
                {
                    esConexionCerradaPorCliente = true;
                    clienteServicioJugador.Close();
                    EstadoOperacion = EstadoOperacion.Correcto;
                }
                catch (CommunicationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (TimeoutException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (InvalidOperationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
            }
        }

        public bool RegistrarJugador(CuentaJugador cuentaJugador)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    RegistrarJugador(cuentaJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public CuentaJugador IniciarSesionComoJugador(
            string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaJugador = null;

            try
            {
                cuentaJugador = clienteServicioJugador.
                    IniciarSesionComoJugador(nombreJugador, contrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return cuentaJugador;
        }

        public CuentaJugador IniciarSesionComoInvitado(string nombreJugador)
        {
            CuentaJugador cuentaInvitado = null;

            try
            {
                cuentaInvitado = clienteServicioJugador.
                    IniciarSesionComoInvitado(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return cuentaInvitado;
        }

        public void CerrarSesion(string nombreJugador)
        {
            if (clienteServicioJugador.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioJugador.CerrarSesion(nombreJugador);
                    EstadoOperacion = EstadoOperacion.Correcto;
                }
                catch (EndpointNotFoundException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (CommunicationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (ObjectDisposedException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (TimeoutException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                finally
                {
                    if (EstadoOperacion == EstadoOperacion.Error)
                    {
                        clienteServicioJugador.Abort();
                    }
                }
            }
        }

        public bool ActualizarNombreJugador(string nombreAnterior,
            string nuevoNombre)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    ActualizarNombreJugador(nombreAnterior, nuevoNombre);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarNumeroAvatar(string nombreJugador,
            int nuevoNumeroAvatar)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    ActualizarNumeroAvatar(nombreJugador, nuevoNumeroAvatar);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarContrasena(string correo, string nuevaContrasena)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    ActualizarContrasena(correo, nuevaContrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool EsLaMismaContrasenaDeJugador(string nombreJugador, string contrasena)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    EsLaMismaContrasenaDeJugador(nombreJugador, contrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ExisteNombreJugadorRegistrado(string nombreJugador)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioJugador.
                    ExisteNombreJugadorRegistrado(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (ObjectDisposedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioJugador.Abort();
                }
            }

            return resultado;
        }
    }
}