﻿using Dominio;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using Seguridad;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaRegistroJugador : Page
    {
        public PaginaRegistroJugador()
        {
            InitializeComponent();
        }

        public PaginaRegistroJugador(int numeroAvatar, string nombreJugador,
            string correo, string contrasena, string confirmacionContrasena)
        {
            InitializeComponent();
            CargarDatosEdicion(numeroAvatar, nombreJugador, correo,
                contrasena, confirmacionContrasena);
        }

        private void CargarDatosEdicion(int numeroAvatar, string nombreJugador,
            string correo, string contrasena, string confirmacionContrasena)
        {
            cuadroTextoNombreJugador.Text = nombreJugador;
            cuadroTextoCorreoElectronico.Text = correo;
            cuadroContrasenaContrasena.Password = contrasena;
            cuadroContrasenaConfirmacionContrasena.Password = confirmacionContrasena;
            imagenAvatarActual.Source = GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);
            imagenAvatarActual.Tag = Convert.ToInt16(numeroAvatar);
        }

        private void IrAPaginaInicioSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void IrAPaginaSeleccionAvatar(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(
                new PaginaSeleccionAvatar(
                Convert.ToInt32(imagenAvatarActual.Tag), 
                cuadroTextoNombreJugador.Text,
                cuadroTextoCorreoElectronico.Text, 
                cuadroContrasenaContrasena.Password,
                cuadroContrasenaConfirmacionContrasena.Password));
        }

        private void IniciarRegistro(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreJugador = cuadroTextoNombreJugador.Text;
            string correo = cuadroTextoCorreoElectronico.Text.ToLower();
            string contrasena = cuadroContrasenaContrasena.Password;
            int numeroAvatar = Convert.ToInt32(imagenAvatarActual.Tag);

            if (!ExistenCamposInvalidos())
            {                
                VentanaPrincipal.ServicioJugador.AbrirConexion();

                if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                    EstadoOperacion.Correcto)
                {
                    bool esNombreJugadorDisponible = !VentanaPrincipal.ServicioJugador.
                        ExisteNombreJugadorRegistrado(nombreJugador);
                    VentanaPrincipal.ServicioJugador.CerrarConexion();

                    if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                        EstadoOperacion.Correcto)
                    {
                        if (esNombreJugadorDisponible)
                        {
                            IrAPaginaVerificacionCorreo(nombreJugador,
                                correo, contrasena, numeroAvatar);
                        }
                        else
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(
                                Properties.Resources.
                                ETIQUETA_REGISTROJUGADOR_MENSAJENOMBRENODISPONIBLE,
                                Properties.Resources.
                                ETIQUETA_REGISTROJUGADOR_NOMBRENODISPONIBLE);
                        }
                    }
                }
            }
        }

        private void IrAPaginaVerificacionCorreo(string nombreJugador, 
            string correo, string contrasena, int numeroAvatar)
        {
            var servicioCorreo = new ServicioCorreo();

            if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
            {
                bool esCorreoDisponible = !servicioCorreo.
                    ExisteCorreoRegistrado(correo);
                servicioCorreo.CerrarConexion();

                if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    if (esCorreoDisponible)
                    {
                        var jugadorRegistro = new CuentaJugador
                        {
                            NombreJugador = nombreJugador,
                            Correo = correo,
                            Contrasena = contrasena,
                            NumeroAvatar = numeroAvatar,
                        };
                        VentanaPrincipal.CambiarPagina(
                            new PaginaVerificacionCorreo(jugadorRegistro));
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            Properties.Resources.
                            ETIQUETA_REGISTROJUGADOR_MENSAJECORREONODISPONIBLE,
                            Properties.Resources.ETIQUETA_REGISTROJUGADOR_CORREONODISPONIBLE);
                    }
                }
            }
        }

        private bool ExistenCamposInvalidos()
        {
            bool hayCamposInvalidos = false;

            if (ExistenCamposVacios())
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS, 
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS);
                hayCamposInvalidos = true;
            }

            if (!hayCamposInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaNombreJugador(cuadroTextoNombreJugador.Text))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO, 
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO);
                hayCamposInvalidos = true;
            }

            if (!hayCamposInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaCorreo(cuadroTextoCorreoElectronico.Text))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO, 
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO);
                hayCamposInvalidos = true;
            }

            if (!hayCamposInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaContrasena(cuadroContrasenaContrasena.Password))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, 
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA);
                hayCamposInvalidos = true;
            }

            if (!hayCamposInvalidos && !cuadroContrasenaContrasena.Password.
                Equals(cuadroContrasenaConfirmacionContrasena.Password))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE, 
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENADIFERENTE);
                hayCamposInvalidos = true;
            }

            return hayCamposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;

            if (ValidadorDatos.EsCadenaVacia(cuadroTextoNombreJugador.Text)
                || ValidadorDatos.EsCadenaVacia(cuadroTextoCorreoElectronico.Text)
                || ValidadorDatos.EsCadenaVacia(cuadroContrasenaContrasena.Password)
                || ValidadorDatos.EsCadenaVacia(cuadroContrasenaConfirmacionContrasena.Password))
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
