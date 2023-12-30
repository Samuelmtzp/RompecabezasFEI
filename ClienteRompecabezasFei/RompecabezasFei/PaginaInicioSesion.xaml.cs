﻿using Security;
using Seguridad;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Dominio;
using RompecabezasFei.Utilidades;
using RompecabezasFei.Servicios;

namespace RompecabezasFei
{
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesionComoInvitado(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreInvitado = Properties.Resources.
                ETIQUETA_GENERAL_INVITADO + new Random().Next();
            var servicio = new ServicioJugador();
            var cuentaInvitado = servicio.IniciarSesionComoInvitado(nombreInvitado);
            
            switch (servicio.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    
                    if (cuentaInvitado != null)
                    {
                        CuentaJugador.Actual = new CuentaJugador()
                        {
                            NombreJugador = nombreInvitado,
                            EsInvitado = true,
                            NumeroAvatar = cuentaInvitado.NumeroAvatar,
                            FuenteImagenAvatar = GeneradorImagenes.
                                GenerarFuenteImagenAvatar(cuentaInvitado.NumeroAvatar)
                        };
                        VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            Properties.Resources.ETIQUETA_INICIOSESION_MENSAJEINICIOSESIONERROR,
                            Properties.Resources.ETIQUETA_INICIOSESION_INICIOSESIONCANCELADO);
                    }
                    
                    break;
            }
        }

        private void IniciarSesionComoJugador(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreJugador = cuadroTextoNombreUsuario.Text;
            string contrasena = cuadroContrasenaContrasena.Password;

            if (!ValidadorDatos.EsCadenaVacia(nombreJugador) &&
                !ValidadorDatos.EsCadenaVacia(contrasena))
            {
                if (!ExistenDatosInvalidos(nombreJugador, contrasena))
                {
                    var servicio = new ServicioJugador();
                    var cuentaJugador = servicio.IniciarSesionComoJugador(nombreJugador,
                        EncriptadorContrasena.CalcularHashSha512(contrasena));

                    switch (servicio.EstadoOperacion)
                    {
                        case EstadoOperacion.Correcto:
                    
                            if (cuentaJugador != null)
                            {
                                CuentaJugador.Actual = new CuentaJugador
                                {
                                    Correo = cuentaJugador.Correo,
                                    NombreJugador = cuentaJugador.NombreJugador,
                                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                                    EsInvitado = false,
                                    FuenteImagenAvatar = GeneradorImagenes.
                                        GenerarFuenteImagenAvatar(cuentaJugador.NumeroAvatar)
                                };
                                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
                            }
                            else
                            {
                                GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                                    ETIQUETA_INICIOSESION_MENSAJEINICIOSESIONERROR,
                                    Properties.Resources.ETIQUETA_INICIOSESION_INICIOSESIONCANCELADO);
                            }
                            
                            break;
                    }
                }
            }
            else
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_GENERAL_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS);
            }
        }

        private void IrAPaginaRecuperacionContrasena(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRecuperacionContrasena());
        }

        private void IrAPaginaRegistroJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRegistroJugador());
        }

        private void IrAPaginaAjustes(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }

        private bool ExistenDatosInvalidos(string nombreJugador, string contrasena)
        {
            bool hayCamposInvalidos = false;

            if (ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(contrasena))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, 
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA);
                hayCamposInvalidos = true;
            }
            
            if (!hayCamposInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaNombreJugador(nombreJugador))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO, 
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO);
                hayCamposInvalidos = true;
            } 
            
            if (!hayCamposInvalidos && ExistenLongitudesExcedidas(nombreJugador, contrasena))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA,
                   Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS);
                hayCamposInvalidos = true;
            }

            if (!hayCamposInvalidos)
            {
                var servicio = new ServicioJugador();
                bool existeNombreJugador = servicio.
                    ExisteNombreJugador(nombreJugador);

                switch (servicio.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:

                        if (!existeNombreJugador)
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(
                                "El nombre de jugador ingresado no existe",
                                "No se pudo iniciar sesión");
                            hayCamposInvalidos = true;
                        }

                        break;
                }
            }

            if (!hayCamposInvalidos)
            {
                var servicio = new ServicioJugador();
                bool esMismaContrasena = servicio.
                    EsLaMismaContrasenaDeJugador(nombreJugador, 
                    EncriptadorContrasena.CalcularHashSha512(contrasena));

                switch (servicio.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:
                        
                        if (!esMismaContrasena)
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(
                                "La contraseña no coincide",
                                "Contraseña incorrecta");
                            hayCamposInvalidos = true;
                        }

                        break;
                }
            }

            return hayCamposInvalidos;
        }

        private bool ExistenLongitudesExcedidas(string nombreJugador, string contrasena)
        {
            bool resultado = false;

            if (ValidadorDatos.ExisteLongitudExcedidaEnNombreJugador(nombreJugador) ||
                ValidadorDatos.ExisteLongitudExcedidaEnContrasena(contrasena))
            {
                resultado = true;
            }

            return resultado;
        }
    }
}