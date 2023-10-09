﻿using Contratos;
using Datos;
using Logica;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioGestionJugador : IServicioGestionJugador
    {
        public bool Registrar(Datos.Usuario usuario, Datos.Jugador jugador)
        {
            var estadoRegistro = false;
            try
            {
                Registro registro = new Registro();
                Datos.Jugador jugadorRegistro = new Datos.Jugador()
                {
                    NombreJugador = jugador.NombreJugador,
                    NumeroAvatar = jugador.NumeroAvatar,
                };

                Datos.Usuario usuarioRegistro = new Datos.Usuario()
                {
                    Contrasena = usuario.Contrasena,
                    Correo = usuario.Correo,
                };

                estadoRegistro = registro.Registrar(usuarioRegistro, jugadorRegistro);
            }
            catch (EntityException excepcionEntidad)
            {
                Console.WriteLine($"{excepcionEntidad.Message}");
            }
            return estadoRegistro;
        }

        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            Registro registro = new Registro();
            var estadoRegistro = false;

            try
            {
                estadoRegistro = registro.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException excepcionEntidad)
            {
                Console.WriteLine($"{excepcionEntidad.Message}");
            }
            return estadoRegistro;
        }

        public bool ExisteNombreUsuario(string nombreUsuario)
        {
            Registro registro = new Registro();
            var estadoRegistro = false;

            try
            {
                estadoRegistro = registro.ExisteNombreUsuario(nombreUsuario);
            }
            catch (EntityException excepcionEntidad)
            {
                Console.WriteLine($"{excepcionEntidad.Message}");
            }
            return estadoRegistro;
        }
    }
}
