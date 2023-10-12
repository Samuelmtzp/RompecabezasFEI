﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Registros
{
    public class Registros
    {
        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(filename);
        }
    }
}
