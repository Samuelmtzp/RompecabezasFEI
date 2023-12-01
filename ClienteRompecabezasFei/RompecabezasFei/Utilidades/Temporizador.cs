using System;
using System.Windows.Threading;

namespace RompecabezasFei.Utilidades
{
    public class Temporizador
    {
        public const int DuracionSegundosMaximaReenvioDeCorreo = 60;

        public const int DuracionSegundosMaximaBloqueoDePiezaRompecabezas = 15;

        public const int MinimoSegundosRestantes = 0;
        
        public const int IntervaloEnSegundos = 1;

        public int SegundosRestantes { get; set; }
        
        public DispatcherTimer DespachadorDeTiempo { get; set; }

        public void IniciarTemporizador(int duracionSegundosMaxima)
        {
            SegundosRestantes = duracionSegundosMaxima;
            DespachadorDeTiempo = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(IntervaloEnSegundos)
            };
            DespachadorDeTiempo.Start();
        }

        public void DetenerTemporizador()
        {
            SegundosRestantes = 0;
            DespachadorDeTiempo.Stop();
        }
    }
}