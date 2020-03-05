using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MiniMiner
{
    public class PantallaDeJuego
    {
        Personaje personaje;
        Enemigo enemigo;
        GestorDeNiveles gestorDeNiveles;
        Marcador marcador;

        public bool Terminado { get; set; }

        public PantallaDeJuego(int maxX, int maxY)
        {
            // ...
        }

        public void CargarContenidos(ContentManager Content)
        {
            personaje = new Personaje(Content);
            enemigo = new Enemigo(Content);
            gestorDeNiveles = new GestorDeNiveles(Content);
            marcador = new Marcador(Content);

            Reiniciar();
        }

        public void Reiniciar()
        {
            Terminado = false;
            gestorDeNiveles.NivelActual.Reiniciar();
            personaje.Vidas = 3;
            marcador.SetVidas(personaje.Vidas);
            marcador.SetNombreNivel(gestorDeNiveles.NivelActual.GetNombre());
            marcador.ReiniciarPuntos();
        }

        public void Actualizar(GameTime gameTime)
        {
            MoverElementos(gameTime);
            ComprobarColisiones();
            ComprobarEntrada(gameTime);
        }

        protected void MoverElementos(GameTime gameTime)
        {
            enemigo.Mover(gameTime);
        }

        protected void ComprobarEntrada(GameTime gameTime)
        {
            var estadoTeclado = Keyboard.GetState();
            var estadoGamePad = GamePad.GetState(PlayerIndex.One);

            if (estadoGamePad.Buttons.Back == ButtonState.Pressed
                    || estadoTeclado.IsKeyDown(Keys.Escape))
                Terminado = true;

            if (estadoTeclado.IsKeyDown(Keys.T) &&
                    estadoTeclado.IsKeyDown(Keys.N))
                gestorDeNiveles.AvanzarNivel();

            // ...
            if (estadoTeclado.IsKeyDown(Keys.Right)
                || estadoGamePad.DPad.Right > 0
                || estadoGamePad.ThumbSticks.Left.X > 0)
            {
                personaje.MoverDerecha(gameTime, gestorDeNiveles.NivelActual);
            }

            if (estadoTeclado.IsKeyDown(Keys.Left)
                || estadoGamePad.DPad.Left > 0
                || estadoGamePad.ThumbSticks.Left.X < 0)
            {
                personaje.MoverIzquierda(gameTime, gestorDeNiveles.NivelActual);
            }

            if (estadoTeclado.IsKeyDown(Keys.Up)
                || estadoGamePad.DPad.Up > 0
                || estadoGamePad.ThumbSticks.Left.Y > 0)
            {
                personaje.MoverArriba(gameTime, gestorDeNiveles.NivelActual);
            }

            if (estadoTeclado.IsKeyDown(Keys.Down)
                || estadoGamePad.DPad.Down > 0
                || estadoGamePad.ThumbSticks.Left.Y < 0)
            {
                personaje.MoverAbajo(gameTime, gestorDeNiveles.NivelActual);
            }
        }

        protected void ComprobarColisiones()
        {
            int puntosEnEsteFotograma = gestorDeNiveles.NivelActual.ComprobarPuntosPorItems(personaje);
            if (puntosEnEsteFotograma > 0)
            {
                marcador.IncrementarPuntos(puntosEnEsteFotograma);
                if (! gestorDeNiveles.NivelActual.QuedaLlavesPorRecoger())
                {
                    gestorDeNiveles.NivelActual.Reiniciar();
                    gestorDeNiveles.AvanzarNivel();
                }
            }

            if ((personaje.ColisionaCon(enemigo)) ||
                (gestorDeNiveles.NivelActual.HayColisionesMortales(personaje)))
            {
                personaje.Vidas--;
                personaje.MoverAPosicionInicial();
                marcador.SetVidas(personaje.Vidas);

                if (personaje.Vidas <= 0)
                {
                    Terminado = true;
                }
            }
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            gestorDeNiveles.NivelActual.Dibujar(spriteBatch);
            personaje.Dibujar(spriteBatch);
            enemigo.Dibujar(spriteBatch);
            marcador.Dibujar(spriteBatch);
        }
    }
}
