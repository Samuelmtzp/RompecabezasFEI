using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        private readonly List<string> idiomasDisponibles;
        private string idiomaActual;
        private bool musicaActiva;
        SoundPlayer reproductorMusica;

        public string IdiomaActual
        {
            get { return idiomaActual; }
            private set
            {
                Thread.CurrentThread.CurrentUICulture = new System.
                    Globalization.CultureInfo(value);
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
            idiomasDisponibles = new List<string>() 
            { 
                "es-MX", 
                "en-US" 
            };
            IdiomaActual = idiomasDisponibles[0];
        }

        public void CambiarIdioma(string nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
        }

        public void EstadoMusica(bool musicaActivada)
        {
            if (musicaActivada)
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

        protected override void OnStartup(StartupEventArgs evento)
        {
            reproductorMusica = new SoundPlayer(RompecabezasFei.Properties.
                ResourceSonidos.MusicaRompecabezasFei);
            EstadoMusica(false);
        }
    }
}