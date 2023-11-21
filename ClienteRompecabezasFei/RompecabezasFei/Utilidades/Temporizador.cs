using System;
using System.Windows.Threading;

namespace RompecabezasFei.Utilidades
{
    public class Temporizador
    {
        public const int DuracionContadorSegundos = 60;
        public const int MinimoSegundosRestantes = 0; 
        public const int IntervaloDeSegundos = 1;
        public int segundosRestantes;
        public DispatcherTimer temporizador;

        public void IniciarTemporizador()
        {
            segundosRestantes = DuracionContadorSegundos;
            temporizador = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(IntervaloDeSegundos)
            };
            temporizador.Start();
        }

        public void DetenerTemporizador()
        {
            segundosRestantes = 0;
            temporizador.Stop();
        }
    }
}