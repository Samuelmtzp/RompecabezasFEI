using Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    public partial class PaginaPartida : Page
    {
        #region Atributos
        private bool cursorSostienePieza;
        private readonly Tablero tablero;
        private Point posicionInicialCursor;
        private Pieza piezaActual;

        #endregion

        #region Constructor
        public PaginaPartida()
        {
            InitializeComponent();
            tablero = new Tablero
            {
                Piezas = new List<Pieza>(),
                Celdas = new List<Celda>(),
                TotalFilas = 6,
                TotalColumnas = 10,
                NumeroImagenRompecabezas = 1
            };
        }
        #endregion

        #region Métodos privados
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

        private BitmapImage GenerarFuenteImagenRompecabezas(string rutaImagen)
        {
            return new BitmapImage(new Uri(rutaImagen, UriKind.Relative));
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
                    Pieza nuevaPieza = new Pieza
                    {
                        Ancho = tablero.AnchoDeCelda,
                        Alto = tablero.AlturaDeCelda,
                        EstaDentroDeCelda = false,
                        FilaCorrecta = fila,
                        ColumnaCorrecta = columna
                    };
                    nuevaPieza.EstablecerFuenteImagen(fuenteImagenOriginal, areaRecorte);
                    nuevaPieza.Borde = GenerarBordeDePieza();
                    nuevaPieza.EstablecerEstiloPiezaSinSeleccionar();
                    tablero.Piezas.Add(nuevaPieza);
                }
            }
        }

        private Border GenerarBordeDePieza()
        {
            Border bordeImagen = new Border();
            bordeImagen.MouseLeftButtonDown += EventoPresionarPieza;
            bordeImagen.MouseMove += EventoCursorMoviendoseSobrePieza;
            bordeImagen.MouseLeftButtonUp += EventoSoltarPieza;

            return bordeImagen;
        }

        private void MostrarPiezasAleatoriamente()
        {
            Random aleatorio = new Random();

            foreach (Pieza pieza in tablero.Piezas)
            {
                double anchoTablero = tableroRompecabezas.ActualWidth;
                double alturaTablero = tableroRompecabezas.ActualHeight;
                double posicionX = aleatorio.NextDouble() * (anchoTablero - pieza.Imagen.Width);
                double posicionY = aleatorio.NextDouble() * (alturaTablero - pieza.Imagen.Height);
                Canvas.SetLeft(pieza.Borde, posicionX);
                Canvas.SetTop(pieza.Borde, posicionY);
                tableroRompecabezas.Children.Add(pieza.Borde);
            }
        }

        private void ActualizarPiezasFaltantesDePosicionarEnTablero()
        {
            foreach (Pieza pieza in tablero.Piezas)
            {
                if (!pieza.EstaDentroDeCelda)
                {
                    tableroRompecabezas.Children.Remove(pieza.Borde);
                    tableroRompecabezas.Children.Add(pieza.Borde);
                }
            }
        }

        private bool EsPosicionValidaParaPiezaActual(double nuevaPosicionX, double nuevaPosicionY)
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

        private string ObtenerRutaAbsolutaImagen(string rutaRelativaImagen)
        {
            string rutaDirectorioBase = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(System.IO.Path.Combine(rutaDirectorioBase, "..\\..\\"));
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaAbsoluta = System.IO.Path.Combine(directorioActual, rutaRelativaImagen);
            return rutaAbsoluta;
        }

        private Pieza BuscarPiezaDeBorde(Border borde)
        {
            var piezasEncontradas = tablero.Piezas.Where(pieza => pieza.Borde.Equals(borde));
            Pieza piezaEncontrada = new Pieza();

            if (piezasEncontradas.Any())
            {
                piezaEncontrada = piezasEncontradas.First();
            }

            return piezaEncontrada;
        }

        private Celda BuscarCeldaDeArea(Rectangle areaCelda)
        {
            var celdasEncontradas = tablero.Celdas.Where(celda => celda.Area.Equals(areaCelda));
            Celda celdaEncontrada = new Celda();

            if (celdasEncontradas.Any())
            {
                celdaEncontrada = celdasEncontradas.First();
            }

            return celdaEncontrada;
        }

        private void PosicionarPiezaEnTableroSegunPosicion(Point posicion)
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
                        Celda celda = BuscarCeldaDeArea(areaCelda);

                        if (celda.Fila == piezaActual.FilaCorrecta &&
                            celda.Columna == piezaActual.ColumnaCorrecta)
                        {
                            Canvas.SetLeft(piezaActual.Borde, posicionXMinima);
                            Canvas.SetTop(piezaActual.Borde, posicionYMinima);
                            piezaActual.EstaDentroDeCelda = true;
                            ActualizarPiezasFaltantesDePosicionarEnTablero();
                            break;
                        }
                    }
                }
            }
        }
        
        private void RemoverEventoVentanaDesactivada()
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated -= EventoVentanaDesactivada;
        }
        #endregion

        #region Eventos
        private void EventoPaginaCargada(object remitente, RoutedEventArgs evento)
        {            
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated += EventoVentanaDesactivada;
            CrearTablero();
        }

        private void EventoVentanaDesactivada(object remitente, EventArgs evento)
        {
            cursorSostienePieza = false;
            if (piezaActual != null && !piezaActual.EstaDentroDeCelda)
            {
                piezaActual.EstablecerEstiloPiezaSinSeleccionar();
            }
        }

        private void EventoClickAjustes(object remitente, MouseButtonEventArgs evento)
        {

        }

        private void EventoClickIniciar(object remitente, RoutedEventArgs evento)
        {
            botonIniciar.IsEnabled = false;
            string rutaAbsolutaImagen = ObtenerRutaAbsolutaImagen(
                $"Imagenes\\Rompecabezas\\{tablero.NumeroImagenRompecabezas}.png");
            BitmapImage fuenteImagenOriginal = GenerarFuenteImagenRompecabezas(rutaAbsolutaImagen);
            RecortarImagenEnPiezas(fuenteImagenOriginal);
            MostrarPiezasAleatoriamente();
        }

        private void EventoPresionarPieza(object remitente, MouseButtonEventArgs evento)
        {
            piezaActual = BuscarPiezaDeBorde((Border)remitente);
            if (!piezaActual.EstaDentroDeCelda)
            {
                tableroRompecabezas.Children.Remove(piezaActual.Borde);
                tableroRompecabezas.Children.Add(piezaActual.Borde);
                piezaActual.EstablecerEstiloPiezaSeleccionada();
                posicionInicialCursor = evento.GetPosition(tableroRompecabezas);
                piezaActual.Borde.CaptureMouse();
                cursorSostienePieza = true;
            }
        }

        private void EventoCursorMoviendoseSobrePieza(object remitente, MouseEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                piezaActual = BuscarPiezaDeBorde((Border)remitente);
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

        private void EventoSoltarPieza(object remitente, MouseButtonEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                piezaActual.Borde.ReleaseMouseCapture();
                cursorSostienePieza = false;
                piezaActual = BuscarPiezaDeBorde((Border)remitente);
                piezaActual.Borde.BorderBrush = Brushes.Transparent;
                Point posicionActual = evento.GetPosition(tableroRompecabezas);
                piezaActual.EstablecerEstiloPiezaSinSeleccionar();
                PosicionarPiezaEnTableroSegunPosicion(posicionActual);
                if (tablero.EsRompecabezasCompletado())
                {
                    MessageBox.Show(Properties.Resources.ETIQUETA_PARTIDA_JUEGOFINALIZADO);
                    RemoverEventoVentanaDesactivada();
                    VentanaPrincipal.CambiarPagina(new PaginaResultados());
                }
            }
        }
        #endregion

        
    }
}