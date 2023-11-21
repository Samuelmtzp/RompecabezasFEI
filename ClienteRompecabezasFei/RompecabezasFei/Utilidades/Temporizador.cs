using System;
using System.Windows.Threading;

namespace RompecabezasFei.Utilidades
{
    public class Temporizador
    {
        public const int DuracionContadorSegundos = 60;
        public const int MinimoSegundosRestantes = 0; 
        public const int IntervaloDeSegundos = 1;
        public int SegundosRestantes { get; set; }
        public DispatcherTimer Cronometro { get; set; }

        public void IniciarTemporizador()
        {
            SegundosRestantes = DuracionContadorSegundos;
            Cronometro = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(IntervaloDeSegundos)
            };
            Cronometro.Start();
        }

        public void DetenerTemporizador()
        {
            SegundosRestantes = 0;
            Cronometro.Stop();
        }
    }
}