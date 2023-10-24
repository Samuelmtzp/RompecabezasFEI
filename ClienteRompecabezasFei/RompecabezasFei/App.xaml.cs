using System.Collections.Generic;
using System.Windows;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        private List<string> idiomasDisponibles = new List<string>() { "es-MX", "en-US" };
        private string idiomaActual;
        public string IdiomaActual
        {
            get
            {
                return idiomaActual;
            }
            private set
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = 
                    new System.Globalization.CultureInfo(value);
                idiomaActual = value;
            }
        }

        public static new App Current
        {
            get
            {
                return (App) Application.Current;
            }
        }

        App()
        {
            IdiomaActual = idiomasDisponibles[0];
        }

        public void CambiarIdioma(string nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
        }
    }
}
