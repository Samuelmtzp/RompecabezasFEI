using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        private List<string> idiomasDisponibles = new List<string>() { "es-MX", "en-US" };
        private string idiomaActual;
        private bool musicaActiva;
        public System.IO.Stream str = RompecabezasFei.Properties.
            ResourceSonidos.MusicaRompecabezasFei;
        private readonly System.IO.Stream pistaAudio = RompecabezasFei.Properties.
            ResourceSonidos.MusicaRompecabezasFei;
        SoundPlayer reproductorMusica;

        public string IdiomaActual
        {
            get 
            { 
                return idiomaActual; 
            }
            private set
            {
                Thread.CurrentThread.CurrentUICulture = 
                    new System.Globalization.CultureInfo(value);
                idiomaActual = value;
            }
        }

        public bool MusicaActiva
        {
            get
            {
                return musicaActiva;
            }
            set
            {
                musicaActiva = value;   
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

        public void EstadoMusica(bool musicaReproduciendose)
        {
            if (musicaReproduciendose)
            {
                reproductorMusica.PlayLooping();    
                musicaActiva = true;
            }
            else
            {
                reproductorMusica.Stop();
                musicaActiva = false;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            reproductorMusica = new SoundPlayer(pistaAudio);
            EstadoMusica(false);
        }
    }
}