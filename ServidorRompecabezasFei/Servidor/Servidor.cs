﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using System.ServiceModel;

namespace Servidor
{
    public class Servidor
    {
        public static void Main(string[] args)
        {
            using (ServiceHost servidorRompecabezasFei = new ServiceHost(typeof(ServicioRompecabezasFei)))
            {
                try
                {
                    servidorRompecabezasFei.Open();
                    Console.WriteLine("Servidor iniciado");
                }
                catch (AddressAccessDeniedException)
                {
                    Console.WriteLine("Servidor no iniciado");
                }
                Console.ReadLine();
            }
        }
    }
}
