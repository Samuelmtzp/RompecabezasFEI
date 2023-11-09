using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using Registros;


namespace Registros
{
    public class Registros
    {
        private string rutaArchivo = ConfigurationManager.AppSettings["Registros"];
        public static ILog GetLogger([CallerFilePath] string nombreArchivo = "")
        {
            return LogManager.GetLogger(nombreArchivo);
        }

        public static void escribirRegistro(string mensaje)
        {
            string rutaArchivo = ConfigurationManager.AppSettings["Registros"];
            string path = ConfigurationManager.AppSettings["Directorio"];
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
                {
                    escritor.WriteLine($"{DateTime.Now} : {mensaje}");
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}    

