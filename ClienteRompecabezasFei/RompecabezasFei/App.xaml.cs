using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows;

namespace RompecabezasFei
{
    public partial class App : Application
    {
        public const string RepresentacionIdiomaIngles = "en-US";

        public const string RepresentacionIdiomaEspanol = "es-MX";
        
        private readonly List<string> idiomasDisponibles;

        private string idiomaActual;
        
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

        public static new App Current
        {
            get { return (App)Application.Current; }
        }

        public bool MusicaActiva { get; set; }

        App()
        {
            const int NumeroIdiomaInicial = 0;
            idiomasDisponibles = new List<string>()
            {
                RepresentacionIdiomaIngles,
                RepresentacionIdiomaEspanol
            };
            IdiomaActual = idiomasDisponibles[NumeroIdiomaInicial];
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
                MusicaActiva = true;
            }
            else
            {
                reproductorMusica.Stop();
                MusicaActiva = false;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            reproductorMusica = new SoundPlayer(RompecabezasFei.Properties.
                ResourceSonidos.MusicaRompecabezasFei);
            EstadoMusica(false);
        }
    }
}