using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RompecabezasFei.Properties;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        private List<string> idiomas = new List<string>() { "es-MX", "en-US" };
        private string idiomaActual;
        private bool musicaActiva;
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

        protected override void OnStartup(StartupEventArgs e)
        {
            Task.Run(() =>
            {
                System.IO.Stream str = RompecabezasFei.Properties.ResourceSonidos.Elevator_Music___Vanoss_Gaming_Background_Music__HD_;
                SoundPlayer musicPlayer = new SoundPlayer(str);
                while (true)
                {
                    musicPlayer.PlaySync();
                }
            });
        }

    }
}
