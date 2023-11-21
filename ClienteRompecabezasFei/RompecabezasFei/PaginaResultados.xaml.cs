using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class PaginaResultados : Page
    {

        public PaginaResultados()
        {
            InitializeComponent();
        }

        private void IrAPaginaSala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();
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
    }
}
