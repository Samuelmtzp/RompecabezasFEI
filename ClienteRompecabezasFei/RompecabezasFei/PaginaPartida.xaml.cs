using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        private bool todasLasPiezasEstanMostradas;

        private Dominio.Tablero tablero;

        private Point posicionActualCursor;

        private Pieza piezaActual;

        private ServicioPartidaClient clienteServicioPartida;

        private string codigoSala;

        public bool EsAnfitrion { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnPartida { get; set; }

        public PaginaPartida(bool cargarDatos, string codigoSala)
        {
            if (cargarDatos)
            {
                InitializeComponent();
                this.codigoSala = codigoSala;
                clienteServicioPartida = new ServicioPartidaClient(new InstanceContext(this));
                listaJugadoresPartida.DataContext = this;
                EsAnfitrion = false;
                piezaActual = null;
                ConectarJugadorAPartida(Dominio.CuentaJugador.Actual.NombreJugador);
                AgregarEventoAbandonarPartidaAlCerrarVentana();
            }
        }

        public PaginaPartida(string codigoSala, DificultadPartida dificultadPartida, 
            int numeroImagen)
        {
            InitializeComponent();
            
            if (!string.IsNullOrEmpty(codigoSala))
            {
                this.codigoSala = codigoSala;
                EsAnfitrion = true;
                botonIniciarPartida.Visibility = Visibility.Visible;
                clienteServicioPartida = new ServicioPartidaClient(new InstanceContext(this));
                bool resultadoCreacionPartida = false;

                try
                {
                    resultadoCreacionPartida = clienteServicioPartida.CrearNuevaPartida(
                        codigoSala, dificultadPartida, numeroImagen);
                }
                catch (EndpointNotFoundException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }

                if (resultadoCreacionPartida)
                {
                    listaJugadoresPartida.DataContext = this;
                    ConectarJugadorAPartida(Dominio.CuentaJugador.Actual.NombreJugador);
                    CargarJugadoresEnPartida();
                }
            }
        }

        private void ConectarJugadorAPartida(string nombreJugador)
        {
            try
            {
                clienteServicioPartida.ConectarJugadorAPartida(codigoSala, nombreJugador);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
        }

        private void DesconectarJugadorDePartida(string nombreJugador)
        {
            try
            {
                clienteServicioPartida.DesconectarJugadorDePartida(codigoSala, nombreJugador);
                clienteServicioPartida.Close();
                RemoverEventoAbandonarPartidaAlCerrarVentana();
                RemoverEventoDesbloqueoPiezaAlDesactivarVentana();
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
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
            int anchoRecorte = (int)(fuenteImagenOriginal.Width / tablero.TotalColumnas);
            int alturaRecorte = (int)(fuenteImagenOriginal.Height / tablero.TotalFilas);
            int numeroPieza = 1;

            for (int fila = 0; fila < tablero.TotalFilas; fila++)
            {
                for (int columna = 0; columna < tablero.TotalColumnas; columna++)
                {
                    Int32Rect areaRecorte = new Int32Rect(columna * anchoRecorte, fila *
                        alturaRecorte, anchoRecorte, alturaRecorte);
                    
                    Pieza nuevaPieza = new Pieza
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

            todasLasPiezasEstanMostradas = true;
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

            if ((nuevaPosicionX + piezaActual.ObtenerDiferenciaAnchoEntreImagenYBorde()) >= 0 &&
                (nuevaPosicionY + piezaActual.ObtenerDiferenciaAlturaEntreImagenYBorde()) >= 0 &&
                (piezaActual.Ancho + nuevaPosicionX <= tableroRompecabezas.ActualWidth) &&
                (piezaActual.Alto + nuevaPosicionY <= tableroRompecabezas.ActualHeight))
            {
                esPosicionValida = true;
            }

            return esPosicionValida;
        }

        private Pieza BuscarPiezaPertenecienteABorde(Border borde)
        {
            var piezasEncontradas = tablero.Piezas.Where(pieza => pieza.Borde.Equals(borde));
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
        
        private void AgregarEventoDesbloqueoPiezaAlDesactivarVentana(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated += SoltarPiezaAlDesactivarVentana;
        }

        private void RemoverEventoDesbloqueoPiezaAlDesactivarVentana()
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Deactivated -= SoltarPiezaAlDesactivarVentana;
        }
        
        private void AgregarEventoAbandonarPartidaAlCerrarVentana()
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Closing += AbandonarPartidaAlCerrarVentana;
        }

        private void RemoverEventoAbandonarPartidaAlCerrarVentana()
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)Window.GetWindow(this);
            ventanaPrincipal.Closing -= AbandonarPartidaAlCerrarVentana;
        }

        private void AbandonarPartidaAlCerrarVentana(object objetoOrigen, 
            CancelEventArgs evento)
        {
            DesconectarJugadorDePartida(Dominio.CuentaJugador.Actual.NombreJugador);
        }

        private void AbandonarPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            DesconectarJugadorDePartida(Dominio.CuentaJugador.Actual.NombreJugador);
        }

        private void SoltarPiezaAlDesactivarVentana(object objetoOrigen, EventArgs evento)
        {
            cursorSostienePieza = false;

            if (piezaActual != null && !piezaActual.EstaDentroDeCelda)
            {
                DesbloquearPiezaActual();
            }
        }

        private void IrAPaginaAjustesPartida(object objetoOrigen, MouseButtonEventArgs evento)
        {
            // Implementar la funcionalidad de mostrar los ajustes de partida
        }

        private void IniciarPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            try
            {
                clienteServicioPartida.IniciarPartida(codigoSala);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }

            botonIniciarPartida.Visibility = Visibility.Hidden;
        }

        private void IntentarBloquearPieza(object objetoOrigen, MouseButtonEventArgs evento)
        {
            piezaActual = BuscarPiezaPertenecienteABorde((Border)objetoOrigen);

            if (!piezaActual.EstaDentroDeCelda && !piezaActual.EsPiezaBloqueada)
            {
                posicionActualCursor = evento.GetPosition(tableroRompecabezas);

                try
                {
                    clienteServicioPartida.BloquearPieza(codigoSala, 
                        piezaActual.NumeroPieza, Dominio.CuentaJugador.Actual.NombreJugador);
                }
                catch (EndpointNotFoundException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }
                catch (TimeoutException excepcion)
                {
                    Registros.Registrador.EscribirRegistro(excepcion);
                    GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                    clienteServicioPartida.Abort();
                }
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
                    try
                    {
                        clienteServicioPartida.ColocarPieza(codigoSala,
                            piezaActual.NumeroPieza, Dominio.CuentaJugador.
                            Actual.NombreJugador, piezaActual.PosicionX, piezaActual.PosicionY);
                    }
                    catch (EndpointNotFoundException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                        clienteServicioPartida.Abort();
                    }
                    catch (CommunicationObjectFaultedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                        clienteServicioPartida.Abort();
                    }
                    catch (TimeoutException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                        clienteServicioPartida.Abort();
                    }

                    ColocarPieza(piezaActual);
                }
                else
                {
                    DesbloquearPiezaActual();
                }
            }
        }

        private void DesbloquearPiezaActual()
        {
            try
            {
                clienteServicioPartida.DesbloquearPieza(codigoSala,
                    piezaActual.NumeroPieza, Dominio.CuentaJugador.
                    Actual.NombreJugador);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioPartida.Abort();
            }

            piezaActual.EsPiezaBloqueada = false;
        }

        public void NotificarInicioDePartida(ServicioRompecabezasFei.Tablero tablero)
        {
            CrearTablero(tablero.TotalFilas, tablero.TotalColumnas);
            BitmapImage fuenteImagenOriginal = GeneradorImagenes.
                GenerarFuenteImagenRompecabezas(tablero.NumeroImagenRompecabezas);
            RecortarImagenEnPiezas(fuenteImagenOriginal);
            MostrarPiezasAleatoriamente();
        }

        public void NotificarBloqueoDePieza(int numeroPieza, string nombreJugador)
        {
            if (todasLasPiezasEstanMostradas)
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

        public void NotificarDesbloqueoDePieza(int numeroPieza, string nombreJugador)
        {
            if (todasLasPiezasEstanMostradas)
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

        public void NotificarColocacionDePieza(int numeroPieza, string nombreJugador, 
            int puntaje, double posicionX, double posicionY)
        {
            if (todasLasPiezasEstanMostradas)
            {
                foreach (UIElement control in tableroRompecabezas.Children)
                {
                    if (control is Border bordeCelda)
                    {
                        Pieza piezaEncontrada = BuscarPiezaPertenecienteABorde(bordeCelda);

                        if (piezaEncontrada.NumeroPieza == numeroPieza)
                        {
                            piezaEncontrada.PosicionX = posicionX;
                            piezaEncontrada.PosicionY = posicionY;
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

        public void NotificarFinDePartida()
        {
            RemoverEventoDesbloqueoPiezaAlDesactivarVentana();
            MessageBox.Show("Partida finalizada");
        }

        public void NotificarJugadorDesconectadoDePartida(string nombreJugadorDesconectado)
        {
            if (JugadoresEnPartida != null)
            {
                if (Dominio.CuentaJugador.Actual.NombreJugador != nombreJugadorDesconectado)
                {
                    var jugadorDesconectado = JugadoresEnPartida.FirstOrDefault(jugador =>
                        jugador.NombreJugador == nombreJugadorDesconectado);
                    JugadoresEnPartida.Remove(jugadorDesconectado);
                }
                else
                {
                    MessageBox.Show("Te han expulsado de la partida");
                    VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
                }
            }
        }        
    }
}