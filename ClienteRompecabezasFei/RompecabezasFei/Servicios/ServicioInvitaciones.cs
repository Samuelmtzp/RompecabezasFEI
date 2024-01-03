using RompecabezasFei.ServicioRompecabezasFei;
using System.Net.Sockets;
using System.ServiceModel;
using System;
using System.Collections.Generic;

namespace RompecabezasFei.Servicios
{
    public class ServicioInvitaciones : Servicio
    {
        private readonly ServicioInvitacionesClient clienteServicioInvitaciones;

        public ServicioInvitaciones()
        {
            clienteServicioInvitaciones = new ServicioInvitacionesClient(
                new InstanceContext(new PaginaMenuPrincipal()));
            AbrirConexion();
        }

        public ServicioInvitaciones(PaginaMenuPrincipal paginaMenuPrincipal)
        {
            clienteServicioInvitaciones = new ServicioInvitacionesClient(
                new InstanceContext(paginaMenuPrincipal));
            AbrirConexion();
        }

        public override void AbrirConexion()
        {
            try
            {
                clienteServicioInvitaciones.Open();
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

        public override void CerrarConexion()
        {
            if (clienteServicioInvitaciones.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioInvitaciones.Close();
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

        public void ActivarInvitacionesDeSala(string nombreJugador)
        {
            try
            {
                clienteServicioInvitaciones.
                    ActivarInvitacionesDeSala(nombreJugador);
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
                    clienteServicioInvitaciones.Abort();
                }
            }
        }

        public void DesactivarInvitacionesDeSala(string nombreJugador, 
            EstadoJugador nuevoEstado)
        {
            try
            {
                clienteServicioInvitaciones.
                    DesactivarInvitacionesDeSala(nombreJugador, nuevoEstado);
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
                    clienteServicioInvitaciones.Abort();
                }
            }
        }

        public List<CuentaJugador> ObtenerAmigosDisponibles(string nombreAnfitrion)
        {
            var amigosDisponibles = new List<CuentaJugador>();

            try
            {
                var amigosObtenidos = clienteServicioInvitaciones.
                    ObtenerAmigosDisponibles(nombreAnfitrion);

                foreach (var amigoObtenido in amigosObtenidos)
                {
                    amigosDisponibles.Add(amigoObtenido);
                }

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
                    clienteServicioInvitaciones.Abort();
                }
            }

            return amigosDisponibles;
        }
    }
}