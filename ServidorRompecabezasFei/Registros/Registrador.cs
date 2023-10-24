using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Registros
{
    public class Registrador
    {
        public static ILog GetLogger([CallerFilePath] string nombreArchivo = "")
        {
            return LogManager.GetLogger(nombreArchivo);
        }
    }
}
