using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class PaginaResultados : Page
    {
        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnPartida { get; set; }

        private string codigoSala;

        public PaginaResultados(string codigoSala)
        {
            InitializeComponent();
            listaJugadoresPartida.DataContext = this;
            this.codigoSala = codigoSala;
            CargarJugadoresEnPartida();
        }

        private void IrAPaginaSala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala(true);
            VentanaPrincipal.CambiarPagina(paginaSala);
            //Recargar los datos de la sala a la que pertenece el jugador
            //Incluyendo:
            //- Jugadores
            //- EsAnfitrion
            //- Deshabilitar funciones para jugadores normales o habilitar si es anfitrion
            //- Mostrar qué jugadores van regresando de la página de resultados
            //- Mantener al jugador en la sala hasta que este se salga de la misma,
            //  en caso de que decida salirse decrementar el contador de jugadores conectados en sala
        }

        public void CargarJugadoresEnPartida()
        {
            JugadoresEnPartida = new ObservableCollection<Dominio.CuentaJugador>();
            ServicioRompecabezasFei.CuentaJugador[] jugadoresObtenidos = ServicioSala.
                ObtenerJugadoresConectadosEnSala(codigoSala);

            if (jugadoresObtenidos != null && jugadoresObtenidos.Any())
            {
                foreach (ServicioRompecabezasFei.CuentaJugador jugador in jugadoresObtenidos)
                {
                    Dominio.CuentaJugador cuentaJugador = new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        NumeroAvatar = jugador.NumeroAvatar,
                        FuenteImagenAvatar = GeneradorImagenes.GenerarFuenteImagenAvatar(
                            jugador.NumeroAvatar),
                    };
                    JugadoresEnPartida.Add(cuentaJugador);
                }
            }
        }
    }
}
