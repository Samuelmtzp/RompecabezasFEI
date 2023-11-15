using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using log4net;

namespace Registros
{
    public class Registros
    {
        public static ILog GetLogger([CallerFilePath] string nombreArchivo = "")
        {
            return LogManager.GetLogger(nombreArchivo);
        }

        public static void escribirRegistro(Exception ex)
        {
            string rutaArchivo = ConfigurationManager.AppSettings["Registros"];
            string path = ConfigurationManager.AppSettings["Directorio"];
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                // Obtener la información de la llamada actual en la pila de llamadas
                StackTrace stackTrace = new StackTrace();
                StackFrame frame = stackTrace.GetFrame(1); // Obtener el marco de la llamada anterior (quien llamó a escribirRegistro)

                // Obtener información sobre el método y la clase
                string metodo = frame.GetMethod().Name;
                string clase = frame.GetMethod().DeclaringType.FullName;

                // Crear la ruta del archivo actual basada en la información obtenida
                string rutaArchivoActual = Path.Combine(Environment.CurrentDirectory, $"{clase}.{metodo}.cs");

                // Obtener el nombre de la excepción
                string nombreExcepcion = ex.GetType().Name;

                // Escribir en el archivo de registro
                using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
                {
                    string mensajeFinal = $"{Environment.NewLine}{DateTime.Now} " +
                        $": Archivo: {rutaArchivoActual}, " +
                        $"Excepción: {nombreExcepcion}, Mensaje: {ex.Message}";
                    escritor.WriteLine(mensajeFinal);
                }
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                throw new Exception(directoryNotFoundException.Message);
            }
        }

    }
}    

