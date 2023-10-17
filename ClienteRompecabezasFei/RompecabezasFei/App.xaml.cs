using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        private List<string> idiomas = new List<string>() { "es-MX", "en-US" };
        private string idiomaActual;
        public string IdiomaActual
        {
            get
            {
                return idiomaActual;
            }
            private set
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(value);
                idiomaActual = value;
            }
        }

        public static new App Current
        {
            get
            {
                return (App)Application.Current;
            }
        }

        App()
        {
            IdiomaActual = idiomas[0];
        }

        public void CambiarIdioma(string nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
        }
    }
}
