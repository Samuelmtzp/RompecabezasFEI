using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    public partial class PaginaPartida : Page, IServicioPartidaCallback
    {
        private bool cursorSostienePieza;

        public string CodigoSala { get; set; }
        
        private Dominio.Tablero tablero;
        
        private Point posicionInicialCursor;
        
        private Dominio.Pieza piezaActual;

        private ServicioPartidaClient clienteServicioPartida;

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnPartida { get; set; }

        public PaginaPartida() 
        { 
        }

        public PaginaPartida(DificultadPartida dificultad, int numeroImagenRompecabezas)
        {
            InitializeComponent();
            // Mandar un mensaje al servidor para que redirija a los jugadores de la sala aquí
            clienteServicioPartida = new ServicioPartidaClient(new InstanceContext(this));
            clienteServicioPartida.CrearNuevaPartida(CodigoSala, dificultad);

            // Cargar jugadores que sigan conectados en la sala            
            listaJugadoresPartida.DataContext = this;
            CargarJugadoresEnPartida();



            // Click en botón de iniciar partida de parte de anfitrión para mandar aviso al server y que este mande el tablero

            // Distribuir el tablero localmente, pero con el mismo orden


            //tablero = new Tablero
            //{
            //    Dificultad = dificultad,
            //    Piezas = new List<Pieza>(),
            //    Celdas = new List<Celda>(),
            //    NumeroImagenRompecabezas = numeroImagenRompecabezas
            //};
            //JugadoresPartida = new ObservableCollection<Dominio.CuentaJugador>();

        }

        private void CargarJugadoresEnPartida()
        {
            JugadoresEnPartida = new ObservableCollection<Dominio.CuentaJugador>();
            ServicioRompecabezasFei.CuentaJugador[] amigosObtenidos = ServicioSala.
                ObtenerJugadoresConectadosEnSala(Dominio.CuentaJugador.Actual.NombreJugador);

            if (amigosObtenidos != null && amigosObtenidos.Any())
            {
                foreach (ServicioRompecabezasFei.CuentaJugador amigo in amigosObtenidos)
                {
                    Dominio.CuentaJugador cuentaAmigo = new Dominio.CuentaJugador
                    {
                        NombreJugador = amigo.NombreJugador,
                        NumeroAvatar = amigo.NumeroAvatar,
                        FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                            GenerarFuenteImagenAvatar(amigo.NumeroAvatar),
                    };
                    JugadoresEnPartida.Add(cuentaAmigo);
                }
            }
        }

        private void CrearTablero()
        {
            tablero.AnchoDeCelda = tableroRompecabezas.ActualWidth / tablero.TotalColumnas;
            tablero.AlturaDeCelda = tableroRompecabezas.ActualHeight / tablero.TotalFilas;
            bool pintarCeldaConColorGris;
            bool pintarCeldaConColorGrisAlIniciarFila = true;

            for (int fila = 0; fila < tablero.TotalFilas; fila++)
            {
                pintarCeldaConColorGris = pintarCeldaConColorGrisAlIniciarFila;
                for (int columna = 0; columna < tablero.TotalColumnas; columna++)
                {
                    Celda celda = new Celda
                    {
                        Fila = fila,
                        Columna = columna,
                        Area = new Rectangle
                        {
                            Width = tablero.AnchoDeCelda,
                            Height = tablero.AlturaDeCelda,
                            Stroke = Brushes.Black,
                            StrokeThickness = 0.5
                        }
                    };

                    if (pintarCeldaConColorGris)
                    {
                        celda.Area.Fill = Brushes.LightGray;
                        pintarCeldaConColorGris = false;
                    }
                    else
                    {
                        celda.Area.Fill = Brushes.AliceBlue;
                        pintarCeldaConColorGris = true;
                    }

                    if (columna + 1 == tablero.TotalColumnas)
                    {
                        if (pintarCeldaConColorGrisAlIniciarFila)
                        {
                            pintarCeldaConColorGrisAlIniciarFila = false;
                        }
                        else
                        {
                            pintarCeldaConColorGrisAlIniciarFila = true;
                        }
                    }

                    double posicionX = columna * tablero.AnchoDeCelda;
                    double posicionY = fila * tablero.AlturaDeCelda;
                    Canvas.SetLeft(celda.Area, posicionX);
                    Canvas.SetTop(celda.Area, posicionY);
                    tableroRompecabezas.Children.Add(celda.Area);
                    tablero.Celdas.Add(celda);
                }
            }
        }        

        private void RecortarImagenEnPiezas(BitmapImage fuenteImagenOriginal)
        {
            int anchoRecorte = (int)(fuenteImagenOriginal.Width / tablero.TotalColumnas);
            int alturaRecorte = (int)(fuenteImagenOriginal.Height / tablero.TotalFilas);

            for (int fila = 0; fila < tablero.TotalFilas; fila++)
            {
                for (int columna = 0; columna < tablero.TotalColumnas; columna++)
                {
                    Int32Rect areaRecorte = new Int32Rect(columna * anchoRecorte, fila *
                        alturaRecorte, anchoRecorte, alturaRecorte);
                    Dominio.Pieza nuevaPieza = new Dominio.Pieza
                    {
                        Ancho = tablero.AnchoDeCelda,
                        Alto = tablero.AlturaDeCelda,
                        EstaDentroDeCelda = false,
                        FilaCorrecta = fila,
                        ColumnaCorrecta = columna
                    };
                    nuevaPieza.EstablecerFuenteImagen(fuenteImagenOriginal, areaRecorte);
                    nuevaPieza.Borde = GenerarNuevoBordeParaPieza();
                    nuevaPieza.EstablecerEstiloDePiezaSinSeleccionar();
                    tablero.Piezas.Add(nuevaPieza);
                }
            }
        }

        private Border GenerarNuevoBordeParaPieza()
        {
            Border bordeImagen = new Border();
            bordeImagen.MouseLeftButtonDown += SeleccionarPieza;
            bordeImagen.MouseMove += MoverPieza;
            bordeImagen.MouseLeftButtonUp += SoltarPieza;

            return bordeImagen;
        }

        private void MostrarPiezasAleatoriamente()
        {
            Random aleatorio = new Random();

            foreach (Dominio.Pieza pieza in tablero.Piezas)
            {
                double anchoTablero = tableroRompecabezas.ActualWidth;
                double alturaTablero = tableroRompecabezas.ActualHeight;
                double posicionX = aleatorio.NextDouble() * 
                    (anchoTablero - pieza.Imagen.Width);
                double posicionY = aleatorio.NextDouble() * 
                    (alturaTablero - pieza.Imagen.Height);
                Canvas.SetLeft(pieza.Borde, posicionX);
                Canvas.SetTop(pieza.Borde, posicionY);
                tableroRompecabezas.Children.Add(pieza.Borde);
            }
        }

        private void SobreponerEnTableroPiezasFaltantesDePosicionar()
        {
            foreach (Dominio.Pieza pieza in tablero.Piezas)
            {
                if (!pieza.EstaDentroDeCelda)
                {
                    tableroRompecabezas.Children.Remove(pieza.Borde);
                    tableroRompecabezas.Children.Add(pieza.Borde);
                }
            }
        }

        private bool EsPosicionValidaParaPiezaActual(double nuevaPosicionX, 
            double nuevaPosicionY)
        {
            bool esPosicionValida = false;

            if ((nuevaPosicionX + piezaActual.ObtenerDiferenciaAnchoEntreImagenYBorde()) >= 0 &&
                (nuevaPosicionY + piezaActual.ObtenerDiferenciaAlturaEntreImagenYBorde()) >= 0 &&
                (piezaActual.Ancho + nuevaPosicionX <= tableroRompecabezas.ActualWidth) &&
                (piezaActual.Alto + nuevaPosicionY <= tableroRompecabezas.ActualHeight))
            {
                esPosicionValida = true;
            }

            return esPosicionValida;
        }

        private Dominio.Pieza BuscarPiezaPertenecienteABorde(Border borde)
        {
            var piezasEncontradas = tablero.Piezas.Where(pieza => pieza.Borde.Equals(borde));
            Dominio.Pieza piezaEncontrada = new Dominio.Pieza();

            if (piezasEncontradas.Any())
            {
                piezaEncontrada = piezasEncontradas.First();
            }

            return piezaEncontrada;
        }

        private Celda BuscarCeldaPertenecienteAArea(Rectangle areaCelda)
        {
            var celdasEncontradas = tablero.Celdas.Where(celda => celda.Area.Equals(areaCelda));
            Celda celdaEncontrada = new Celda();

            if (celdasEncontradas.Any())
            {
                celdaEncontrada = celdasEncontradas.First();
            }

            return celdaEncontrada;
        }

        private void PosicionarPiezaEnCeldaCorrespondiente(Point posicion)
        {
            foreach (UIElement control in tableroRompecabezas.Children)
            {
                if (control is Rectangle areaCelda)
                {
                    double posicionXMinima = Canvas.GetLeft(areaCelda);
                    double posicionYMinima = Canvas.GetTop(areaCelda);
                    double posicionXMaxima = posicionXMinima + areaCelda.Width;
                    double posicionYMaxima = posicionYMinima + areaCelda.Height;

                    if (posicion.X >= posicionXMinima &&
                        posicion.X <= posicionXMaxima &&
                        posicion.Y >= posicionYMinima &&
                        posicion.Y <= posicionYMaxima)
                    {
                        Celda celda = BuscarCeldaPertenecienteAArea(areaCelda);

                        if (celda.Fila == piezaActual.FilaCorrecta &&
                            celda.Columna == piezaActual.ColumnaCorrecta)
                        {
                            Canvas.SetLeft(piezaActual.Borde, posicionXMinima);
                            Canvas.SetTop(piezaActual.Borde, posicionYMinima);
                            piezaActual.EstaDentroDeCelda = true;
                            SobreponerEnTableroPiezasFaltantesDePosicionar();
                            break;
                        }
                    }
                }
            }
        }
        
        private void RemoverEventoVentanaDesactivada()
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated -= SoltarPiezaAlDesactivarVentana;
        }        

        private void CargarDatosPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated += SoltarPiezaAlDesactivarVentana;
            CrearTablero();
        }

        private void SoltarPiezaAlDesactivarVentana(object objetoOrigen, EventArgs evento)
        {
            cursorSostienePieza = false;

            if (piezaActual != null && !piezaActual.EstaDentroDeCelda)
            {
                piezaActual.EstablecerEstiloDePiezaSinSeleccionar();
            }
        }

        private void IrPaginaAjustesPartida(object objetoOrigen, MouseButtonEventArgs evento)
        {
            // Implementar la funcionalidad de redirigir a pagina de ajustes de partida
        }

        private void IniciarJuego(object objetoOrigen, RoutedEventArgs evento)
        {
            botonIniciar.IsEnabled = false;
            BitmapImage fuenteImagenOriginal = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenRompecabezas(tablero.NumeroImagenRompecabezas);
            RecortarImagenEnPiezas(fuenteImagenOriginal);
            MostrarPiezasAleatoriamente();
        }

        private void SeleccionarPieza(object objetoOrigen, MouseButtonEventArgs evento)
        {
            piezaActual = BuscarPiezaPertenecienteABorde((Border)objetoOrigen);

            if (!piezaActual.EstaDentroDeCelda)
            {
                tableroRompecabezas.Children.Remove(piezaActual.Borde);
                tableroRompecabezas.Children.Add(piezaActual.Borde);
                piezaActual.EstablecerEstiloDePiezaSeleccionada();
                posicionInicialCursor = evento.GetPosition(tableroRompecabezas);
                piezaActual.Borde.CaptureMouse();
                cursorSostienePieza = true;
            }
        }

        private void MoverPieza(object objetoOrigen, MouseEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                piezaActual = BuscarPiezaPertenecienteABorde((Border)objetoOrigen);
                Point posicionActualCursor = evento.GetPosition(tableroRompecabezas);
                double diferenciaPosicionX = posicionActualCursor.X - posicionInicialCursor.X;
                double diferenciaPosicionY = posicionActualCursor.Y - posicionInicialCursor.Y;
                double nuevaPosicionX = Canvas.GetLeft(piezaActual.Borde) + diferenciaPosicionX;
                double nuevaPosicionY = Canvas.GetTop(piezaActual.Borde) + diferenciaPosicionY;

                if (EsPosicionValidaParaPiezaActual(nuevaPosicionX, nuevaPosicionY))
                {
                    Canvas.SetLeft(piezaActual.Borde,
                        Canvas.GetLeft(piezaActual.Borde) + diferenciaPosicionX);
                    Canvas.SetTop(piezaActual.Borde,
                        Canvas.GetTop(piezaActual.Borde) + diferenciaPosicionY);
                    posicionInicialCursor = posicionActualCursor;
                }
            }
        }

        private void SoltarPieza(object objetoOrigen, MouseButtonEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                piezaActual.Borde.ReleaseMouseCapture();
                cursorSostienePieza = false;
                piezaActual = BuscarPiezaPertenecienteABorde((Border)objetoOrigen);
                piezaActual.Borde.BorderBrush = Brushes.Transparent;
                Point posicionActual = evento.GetPosition(tableroRompecabezas);
                piezaActual.EstablecerEstiloDePiezaSinSeleccionar();
                PosicionarPiezaEnCeldaCorrespondiente(posicionActual);
                if (tablero.EsRompecabezasCompletado())
                {
                    MessageBox.Show(Properties.Resources.ETIQUETA_PARTIDA_JUEGOFINALIZADO);
                    RemoverEventoVentanaDesactivada();
                    VentanaPrincipal.CambiarPagina(new PaginaResultados());
                }
            }
        }

        public void ActualizarNuevaPosicionDePieza(double posicionX, double posicionY)
        {
            throw new NotImplementedException();
        }

        public void NotificarPartidaListaParaIniciar()
        {
            throw new NotImplementedException();
        }

        public void ActualizarPosicionDePieza(double posicionX, double posicionY)
        {
            throw new NotImplementedException();
        }

        public void MostrarTablero(ServicioRompecabezasFei.Tablero tablero)
        {
            throw new NotImplementedException();
        }

        public void NotificarPiezaMarcadaComoBloqueada()
        {
            throw new NotImplementedException();
        }

        public void ActualizarPosicionDePieza(int numeroPieza, double posicionX, double posicionY)
        {
            throw new NotImplementedException();
        }

        public void NotificarPiezaMarcadaComoCorrecta(int numeroPieza, string jugador)
        {
            throw new NotImplementedException();
        }

        public void NotificarFinDePartida()
        {
            throw new NotImplementedException();
        }
    }
}