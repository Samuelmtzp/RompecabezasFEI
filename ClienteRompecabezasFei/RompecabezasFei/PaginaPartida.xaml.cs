using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
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
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaPartida : Page, IServicioPartidaCallback
    {
        private bool cursorSostienePieza;

        private bool hayPartidaEnCurso;

        private bool hayPartidaFinalizada;

        private bool esAnfitrion;

        private string codigoSala;

        private Dominio.Tablero tablero;

        private Point posicionActualCursor;

        private Pieza piezaActual;

        private ServicioPartida servicioPartida;

        public bool HayConexionConPartida { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnPartida { get; set; }

        public PaginaPartida () 
        { 
        }

        public PaginaPartida(string codigoSala)
        {
            InitializeComponent();            
            ConfigurarDatosIniciales(false, codigoSala);
            
            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                UnirseAPartida(Dominio.CuentaJugador.Actual.NombreJugador);                
            }
        }

        public PaginaPartida(string codigoSala, 
            DificultadPartida dificultadPartida, int numeroImagen)
        {
            InitializeComponent();
            ConfigurarDatosIniciales(true, codigoSala);
            CrearNuevaPartida(dificultadPartida, numeroImagen);
        }

        private void ConfigurarDatosIniciales(bool esAnfitrion, 
            string codigoSala)
        {
            JugadoresEnPartida = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresPartida.DataContext = this;
            this.esAnfitrion = esAnfitrion;
            this.codigoSala = codigoSala;
            hayPartidaEnCurso = false;
            hayPartidaFinalizada = false;
            HayConexionConPartida = false;
            servicioPartida = new ServicioPartida(this);

            if (esAnfitrion)
            {
                HabilitarFuncionesDeAnfitrionEnPartida();
            }
        }

        private void CrearNuevaPartida(DificultadPartida dificultadPartida, 
            int numeroImagen)
        {
            bool hayPartidaCreada = servicioPartida.
                CrearNuevaPartida(codigoSala, dificultadPartida, numeroImagen);

            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                if (hayPartidaCreada)
                {
                    UnirseAPartida(Dominio.CuentaJugador.Actual.NombreJugador);
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.
                        ETIQUETA_CREACIONPARTIDA_MENSAJEERRORCREACIONPARTIDA,
                        Properties.Resources.
                        ETIQUETA_CREACIONPARTIDA_ERRORCREACIONPARTIDA);
                    servicioPartida.CerrarConexion();
                }
            }
        }

        private void UnirseAPartida(string nombreJugador)
        {
            servicioPartida.UnirseAPartida(codigoSala, nombreJugador);

            if (servicioPartida.EstadoOperacion == 
                EstadoOperacion.Correcto)
            {
                CargarJugadoresEnPartida();
            }
        }

        public void CargarJugadoresEnPartida()
        {
            var jugadoresEnPartida = servicioPartida.
                ObtenerJugadoresConPresenciaSinConfirmarEnPartida(codigoSala);

            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                foreach (var jugadorEnPartida in jugadoresEnPartida)
                {
                    var cuentaJugador = new Dominio.CuentaJugador
                    {
                        NombreJugador = jugadorEnPartida.NombreJugador,
                        NumeroAvatar = jugadorEnPartida.NumeroAvatar,
                        FuenteImagenAvatar = GeneradorImagenes.
                            GenerarFuenteImagenAvatar(
                            jugadorEnPartida.NumeroAvatar),
                    };
                    JugadoresEnPartida.Add(cuentaJugador);
                }
            }
        }
        
        private void CrearTablero(int totalFilas, int totalColumnas)
        {
            tablero = new Dominio.Tablero
            {
                TotalFilas = totalFilas,
                TotalColumnas = totalColumnas,
                Piezas = new List<Pieza>(),
                Celdas = new List<Celda>(),
                AlturaDeCelda = tableroRompecabezas.ActualHeight / totalFilas,
                AnchoDeCelda = tableroRompecabezas.ActualWidth / totalColumnas,
            };
            bool pintarCelda;
            bool pintarCeldaAlIniciarFila = true;
            int numeroCelda = 1;

            for (int fila = 0; fila < totalFilas; fila++)
            {
                pintarCelda = pintarCeldaAlIniciarFila;
                int siguienteColumna;

                for (int columna = 0; columna < totalColumnas; columna++)
                {
                    Celda celda = new Celda
                    {
                        NumeroCelda = numeroCelda++,
                        PosicionX = columna * tablero.AnchoDeCelda,
                        PosicionY = fila * tablero.AlturaDeCelda,
                        Area = new Rectangle
                        {
                            Width = tablero.AnchoDeCelda,
                            Height = tablero.AlturaDeCelda,
                            Stroke = Brushes.Black,
                            StrokeThickness = 0.5
                        }
                    };

                    if (pintarCelda)
                    {
                        celda.Area.Fill = Brushes.LightGray;
                        pintarCelda = false;
                    }
                    else
                    {
                        celda.Area.Fill = Brushes.White;
                        pintarCelda = true;
                    }

                    siguienteColumna = columna + 1;

                    if (siguienteColumna == totalColumnas)
                    {
                        if (pintarCeldaAlIniciarFila)
                        {
                            pintarCeldaAlIniciarFila = false;
                        }
                        else
                        {
                            pintarCeldaAlIniciarFila = true;
                        }
                    }

                    Canvas.SetLeft(celda.Area, celda.PosicionX);
                    Canvas.SetTop(celda.Area, celda.PosicionY);
                    tableroRompecabezas.Children.Add(celda.Area);
                    tablero.Celdas.Add(celda);
                }
            }
        }

        private void RecortarImagenEnPiezas(BitmapImage fuenteImagenOriginal)
        {
            int anchoRecorte = (int)(fuenteImagenOriginal.
                Width / tablero.TotalColumnas);
            int alturaRecorte = (int)(fuenteImagenOriginal.
                Height / tablero.TotalFilas);
            int numeroPieza = 1;

            for (int fila = 0; fila < tablero.TotalFilas; fila++)
            {
                for (int columna = 0; columna < tablero.TotalColumnas; columna++)
                {
                    var areaRecorte = new Int32Rect(columna * anchoRecorte, 
                        fila * alturaRecorte, anchoRecorte, alturaRecorte);
                    var nuevaPieza = new Pieza
                    {
                        PosicionX = columna * tablero.AnchoDeCelda,
                        PosicionY = fila * tablero.AlturaDeCelda,
                        NumeroPieza = numeroPieza++,
                        Ancho = tablero.AnchoDeCelda,
                        Alto = tablero.AlturaDeCelda,
                        EstaDentroDeCelda = false,
                    };
                    nuevaPieza.EstablecerFuenteImagen(fuenteImagenOriginal, areaRecorte);
                    nuevaPieza.Borde = new Border();
                    nuevaPieza.Borde.MouseLeftButtonDown += IntentarBloquearPieza;
                    nuevaPieza.Borde.MouseMove += MoverPieza;
                    nuevaPieza.Borde.MouseLeftButtonUp += SoltarPieza;
                    nuevaPieza.EsPiezaBloqueada = false;
                    tablero.Piezas.Add(nuevaPieza);
                }
            }
        }

        private void MostrarPiezasAleatoriamente()
        {
            Random aleatorio = new Random();

            foreach (Pieza pieza in tablero.Piezas)
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

        private void MandarAlFrenteAPiezasFaltantesDeColocar()
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

        private bool EsPiezaDentroDeLimitesDeTablero(double nuevaPosicionX, 
            double nuevaPosicionY)
        {
            bool esPosicionValida = false;

            if ((nuevaPosicionX + piezaActual.
                ObtenerDiferenciaAnchoEntreImagenYBorde()) >= 0 &&
                (nuevaPosicionY + piezaActual.
                ObtenerDiferenciaAlturaEntreImagenYBorde()) >= 0 &&
                (piezaActual.Ancho + nuevaPosicionX <= 
                tableroRompecabezas.ActualWidth) &&
                (piezaActual.Alto + nuevaPosicionY <= 
                tableroRompecabezas.ActualHeight))
            {
                esPosicionValida = true;
            }

            return esPosicionValida;
        }

        private Pieza BuscarPiezaPertenecienteABorde(Border borde)
        {
            var piezasEncontradas = tablero.Piezas.
                Where(pieza => pieza.Borde.Equals(borde));
            Pieza piezaEncontrada = new Pieza();

            if (piezasEncontradas.Any())
            {
                piezaEncontrada = piezasEncontradas.First();
            }

            return piezaEncontrada;
        }

        private void ColocarPieza(Pieza pieza)
        {
            Canvas.SetLeft(pieza.Borde, pieza.PosicionX);
            Canvas.SetTop(pieza.Borde, pieza.PosicionY);
            pieza.EstaDentroDeCelda = true;
            MandarAlFrenteAPiezasFaltantesDeColocar();
        }

        private bool EsPosicionCorrespondienteAPiezaActual(Point posicion)
        {
            bool esPosicionCorrespondiente = false;

            foreach (var area in tableroRompecabezas.Children.OfType<Rectangle>())
            {
                double posicionXMinima = Canvas.GetLeft(area);
                double posicionYMinima = Canvas.GetTop(area);
                double posicionXMaxima = posicionXMinima + area.Width;
                double posicionYMaxima = posicionYMinima + area.Height;

                if (posicion.X >= posicionXMinima &&
                    posicion.X <= posicionXMaxima &&
                    posicion.Y >= posicionYMinima &&
                    posicion.Y <= posicionYMaxima)
                {
                    var celdaEncontrada = tablero.Celdas.Where(celda => 
                        celda.Area.Equals(area)).FirstOrDefault();

                    if (celdaEncontrada != null && celdaEncontrada.NumeroCelda == 
                        piezaActual.NumeroPieza)
                    {
                        piezaActual.PosicionX = celdaEncontrada.PosicionX;
                        piezaActual.PosicionY = celdaEncontrada.PosicionY;
                        esPosicionCorrespondiente = true;
                    }

                    break;
                }
            }

            return esPosicionCorrespondiente;
        }

        private void AgregarEventoSoltarPiezaAlDesactivarVentana(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            if (VentanaPrincipal.ObtenerVentanaActual() != null)
            {
                VentanaPrincipal.ObtenerVentanaActual().Deactivated +=
                    SoltarPiezaAlDesactivarVentana;
            }
        }

        private void RemoverEventoSoltarPiezaAlDesactivarVentana(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            if (VentanaPrincipal.ObtenerVentanaActual() != null)
            {
                VentanaPrincipal.ObtenerVentanaActual().Deactivated -=
                    SoltarPiezaAlDesactivarVentana;
            }
        }

        private void AbandonarPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            servicioPartida.AbandonarPartida(codigoSala, 
                Dominio.CuentaJugador.Actual.NombreJugador);
            servicioPartida.CerrarConexion();

            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
        }

        private void SoltarPiezaAlDesactivarVentana(object objetoOrigen, EventArgs evento)
        {
            if (cursorSostienePieza && piezaActual != null && 
                !piezaActual.EstaDentroDeCelda)
            {
                cursorSostienePieza = false;
                DesbloquearPiezaActual();
            }
        }

        private void IniciarPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            servicioPartida.IniciarPartida(codigoSala);

            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                hayPartidaEnCurso = true;
                botonIniciarPartida.Visibility = Visibility.Hidden;
            }
        }

        private void IrPaginaMenuPrincipal()
        {           
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void IntentarBloquearPieza(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            piezaActual = BuscarPiezaPertenecienteABorde((Border)objetoOrigen);

            if (!piezaActual.EstaDentroDeCelda && !piezaActual.EsPiezaBloqueada)
            {
                posicionActualCursor = evento.GetPosition(tableroRompecabezas);
                servicioPartida.BloquearPieza(codigoSala, piezaActual.NumeroPieza, 
                    Dominio.CuentaJugador.Actual.NombreJugador);
            }
        }

        private void MoverPieza(object objetoOrigen, MouseEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                Point nuevaPosicionCursor = evento.GetPosition(tableroRompecabezas);
                double diferenciaPosicionX = nuevaPosicionCursor.X - posicionActualCursor.X;
                double diferenciaPosicionY = nuevaPosicionCursor.Y - posicionActualCursor.Y;
                double nuevaPosicionX = Canvas.GetLeft(piezaActual.Borde) + diferenciaPosicionX;
                double nuevaPosicionY = Canvas.GetTop(piezaActual.Borde) + diferenciaPosicionY;

                if (EsPiezaDentroDeLimitesDeTablero(nuevaPosicionX, nuevaPosicionY))
                {
                    Canvas.SetLeft(piezaActual.Borde, Canvas.GetLeft(piezaActual.Borde) + 
                        diferenciaPosicionX);
                    Canvas.SetTop(piezaActual.Borde, Canvas.GetTop(piezaActual.Borde) + 
                        diferenciaPosicionY);
                    posicionActualCursor = nuevaPosicionCursor;
                }
            }
        }

        private void SoltarPieza(object objetoOrigen, MouseButtonEventArgs evento)
        {
            if (cursorSostienePieza)
            {
                piezaActual.Borde.ReleaseMouseCapture();
                cursorSostienePieza = false;
                Point ultimaPosicion = evento.GetPosition(tableroRompecabezas);
                
                if (EsPosicionCorrespondienteAPiezaActual(ultimaPosicion))
                {
                    Posicion posicion = new Posicion()
                    {
                        X = piezaActual.PosicionX,
                        Y = piezaActual.PosicionY,
                    };

                    servicioPartida.ColocarPieza(codigoSala,
                            piezaActual.NumeroPieza, Dominio.CuentaJugador.
                            Actual.NombreJugador, posicion);
                }
                else
                {
                    DesbloquearPiezaActual();
                }
            }
        }

        private void DesbloquearPiezaActual()
        {
            servicioPartida.DesbloquearPieza(codigoSala,
                piezaActual.NumeroPieza, Dominio.CuentaJugador.
                Actual.NombreJugador);

            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                piezaActual.EsPiezaBloqueada = false;
            }
        }

        public void MostrarTableroDePartida(ServicioRompecabezasFei.Tablero tablero)
        {
            CrearTablero(tablero.TotalFilas, tablero.TotalColumnas);
            BitmapImage fuenteImagenOriginal = GeneradorImagenes.
                GenerarFuenteImagenRompecabezas(tablero.NumeroImagenRompecabezas);
            RecortarImagenEnPiezas(fuenteImagenOriginal);
            MostrarPiezasAleatoriamente();
            hayPartidaEnCurso = true;
        }

        public void MostrarBloqueoDePieza(int numeroPieza, string nombreJugador)
        {
            if (hayPartidaEnCurso)
            {
                foreach (var bordePieza in tableroRompecabezas.Children.OfType<Border>())
                {
                    Pieza piezaEncontrada = BuscarPiezaPertenecienteABorde(bordePieza);
                    
                    if (piezaEncontrada.NumeroPieza == numeroPieza)
                    {
                        if (nombreJugador == Dominio.CuentaJugador.Actual.NombreJugador)
                        {
                            tableroRompecabezas.Children.Remove(piezaActual.Borde);
                            tableroRompecabezas.Children.Add(piezaActual.Borde);
                            piezaActual.Borde.CaptureMouse();
                            cursorSostienePieza = true;
                            piezaActual.EsPiezaBloqueada = true;
                            piezaActual.EstablecerEstiloDePiezaBloqueadaPorJugadorActual();
                        }
                        else
                        {
                            piezaEncontrada.EsPiezaBloqueada = true;
                            piezaEncontrada.EstablecerEstiloDePiezaBloqueadaPorAdversario();
                        }

                        break;
                    }
                }
            }
        }

        public void MostrarDesbloqueoDePieza(int numeroPieza, string nombreJugador)
        {
            if (hayPartidaEnCurso)
            {
                foreach (var bordePieza in tableroRompecabezas.Children.OfType<Border>())
                {
                    Pieza piezaEncontrada = BuscarPiezaPertenecienteABorde(bordePieza);

                    if (piezaEncontrada.NumeroPieza == numeroPieza)
                    {
                        piezaEncontrada.EsPiezaBloqueada = false;
                        break;
                    }
                }
            }
        }

        public void MostrarColocacionDePieza(int numeroPieza, string nombreJugador,
            int puntaje, Posicion posicion)
        {
            if (hayPartidaEnCurso)
            {
                foreach (UIElement control in tableroRompecabezas.Children)
                {
                    if (control is Border bordeCelda)
                    {
                        Pieza piezaEncontrada = BuscarPiezaPertenecienteABorde(bordeCelda);

                        if (piezaEncontrada.NumeroPieza == numeroPieza)
                        {
                            piezaEncontrada.PosicionX = posicion.X;
                            piezaEncontrada.PosicionY = posicion.Y;
                            ColocarPieza(piezaEncontrada);
                            var jugadorEncontrado = JugadoresEnPartida.Where(jugador => 
                                jugador.NombreJugador == nombreJugador).FirstOrDefault();

                            if (jugadorEncontrado != null)
                            {
                                JugadoresEnPartida.Remove(jugadorEncontrado);
                                jugadorEncontrado.Puntaje += puntaje;
                                JugadoresEnPartida.Add(jugadorEncontrado);
                            }

                            break;
                        }
                    }
                }
            }
        }

        public void MostrarResultadosDePartida(string nombreJugadorGanador)
        {
            hayPartidaEnCurso = false;
            hayPartidaFinalizada = true;
            panelFondoPartida.Visibility = Visibility.Visible;
            panelResultadosPartida.Visibility = Visibility.Visible;
            
            if (!string.IsNullOrEmpty(nombreJugadorGanador))
            {
                etiquetaAJustesPartida.Content = nombreJugadorGanador + " " +
                    Properties.Resources.ETIQUETA_RESULTADOS_MENSAJEGANADOR;
            }
            else
            {
                etiquetaAJustesPartida.Content = Properties.Resources.
                    ETIQUETA_RESULTADOSPARTIDA_MENSAJEEMPATE;
            }

            if (esAnfitrion)
            {
                botonRegresarASala.Visibility = Visibility.Visible;
            }
        }

        public void MostrarDesconexionDeJugadorEnPartida(string nombreJugadorDesconexion)
        {
            Dominio.CuentaJugador cuentaJugadorEncontrada = 
                JugadoresEnPartida.FirstOrDefault(jugador => 
                jugador.NombreJugador == nombreJugadorDesconexion);

            if (cuentaJugadorEncontrada != null)
            {
                JugadoresEnPartida.Remove(cuentaJugadorEncontrada);
            }
        }

        public void ConvertirJugadorEnAnfitrionDesdePartida(string nombreJugador)
        {
            servicioPartida.ConvertirJugadorEnAnfitrionDesdePartida(
                nombreJugador, codigoSala);
            
            if (servicioPartida.EstadoOperacion == EstadoOperacion.Correcto)
            {
                DeshabilitarFuncionesDeAnfitrionEnPartida();
            }
        }

        public void MostrarMensajePartidaCancelada()
        {
            hayPartidaEnCurso = false;
            hayPartidaFinalizada = true;
            GestorPanelBloqueoVentana.MostrarPanelBloqueo();
            servicioPartida.CerrarConexion();
            GestorCuadroDialogo.MostrarAdvertencia(
                Properties.Resources.ETIQUETA_PARTIDA_MENSAJEPARTIDACANCELADA,
                Properties.Resources.ETIQUETA_PARTIDA_PARTIDACANCELADA);

            if (VentanaPrincipal.ServicioJugador.
                EstadoOperacion == EstadoOperacion.Correcto)
            {
                GestorPanelBloqueoVentana.OcultarPanelBloqueo();
                IrPaginaMenuPrincipal();
            }
        }

        public void MostrarMensajeExpulsionDePartida()
        {
            hayPartidaEnCurso = false;
            hayPartidaFinalizada = true;
            GestorPanelBloqueoVentana.MostrarPanelBloqueo();
            servicioPartida.CerrarConexion();
            GestorCuadroDialogo.MostrarAdvertencia(
                Properties.Resources.ETIQUETA_PARTIDA_MENSAJEEXPULSIONDEPARTIDA,
                Properties.Resources.ETIQUETA_PARTIDA_EXPULSIONDEPARTIDA);
            
            if (VentanaPrincipal.ServicioJugador.
                EstadoOperacion == EstadoOperacion.Correcto)
            {
                GestorPanelBloqueoVentana.OcultarPanelBloqueo();
                IrPaginaMenuPrincipal();
            }
        }

        public void HabilitarFuncionesDeAnfitrionEnPartida()
        {
            esAnfitrion = true;

            if (!hayPartidaFinalizada)
            {
                if (!hayPartidaEnCurso)
                {
                    botonIniciarPartida.Visibility = Visibility.Visible;
                }

                imagenAjustesPartida.Visibility = Visibility.Visible;
                etiquetaAJustesPartida.Visibility = Visibility.Visible;
            }
            else
            {
                botonRegresarASala.Visibility = Visibility.Visible;
            }
        }

        public void DeshabilitarFuncionesDeAnfitrionEnPartida()
        {
            esAnfitrion = false;
            
            if (!hayPartidaEnCurso)
            {
                botonIniciarPartida.Visibility = Visibility.Hidden;
            }

            imagenAjustesPartida.Visibility = Visibility.Visible;
            etiquetaAJustesPartida.Visibility = Visibility.Visible;

            if (panelAjustesPartida.IsVisible)
            {
                panelFondoPartida.Visibility = Visibility.Hidden;
                panelAjustesPartida.Visibility = Visibility.Hidden;
            }
        }

        public void HabilitarOpcionDeRegresoASala()
        {
            if (!hayPartidaEnCurso && panelResultadosPartida.IsVisible)
            {
                botonRegresarASala.Visibility = Visibility.Visible;
            }
        }

        private void MostrarPanelAjustesPartida(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            panelFondoPartida.Visibility = Visibility.Visible;
            panelAjustesPartida.Visibility = Visibility.Visible;
        }

        private void CerrarPanelAjustesPartida(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            panelFondoPartida.Visibility = Visibility.Hidden;
            panelAjustesPartida.Visibility = Visibility.Hidden;
        }

        private void IrAMenuPrincipal(object objetoOrigen, RoutedEventArgs evento)
        {
            AbandonarPartida(objetoOrigen, evento);
        }

        private void IrAPaginaSala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala(esAnfitrion, codigoSala);

            if (paginaSala.HayConexionConSala)
            {
                VentanaPrincipal.CambiarPagina(paginaSala);
            }
        }

        private void botonHacerAnfitrionAJugador_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonExpulsarJugador_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonFinalizarPartida_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}