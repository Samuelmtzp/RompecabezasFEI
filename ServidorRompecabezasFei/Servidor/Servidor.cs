using System;
using Servicios;
using System.ServiceModel;

namespace Servidor
{
    public static class Servidor
    {
        public static void Main(string[] args)
        {
            using (ServiceHost servidorRompecabezasFei = 
                new ServiceHost(typeof(ServicioRompecabezasFei)))
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
