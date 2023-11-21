using System.Runtime.CompilerServices;
using log4net;

namespace Registros
{
    public static class Registrador
    {
        public static ILog GetLogger([CallerFilePath] string nombreArchivo = "")
        {
            return LogManager.GetLogger(nombreArchivo);
        }
    }
}
