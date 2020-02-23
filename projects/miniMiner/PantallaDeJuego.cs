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

        public bool Terminado { get; set; }

        public PantallaDeJuego(int maxX, int maxY)
        {
            // ...
        }

        public void CargarContenidos(ContentManager Content)
        {
            personaje = new Personaje(Content);
            enemigo = new Enemigo(Content);
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

            // ...
            if (estadoTeclado.IsKeyDown(Keys.Right)
                || estadoGamePad.DPad.Right > 0
                || estadoGamePad.ThumbSticks.Left.X > 0)
            {
                personaje.MoverDerecha(gameTime);
            }

            if (estadoTeclado.IsKeyDown(Keys.Left)
                || estadoGamePad.DPad.Left > 0
                || estadoGamePad.ThumbSticks.Left.X < 0)
            {
                personaje.MoverIzquierda(gameTime);
            }

            if (estadoTeclado.IsKeyDown(Keys.Up)
                || estadoGamePad.DPad.Up > 0
                || estadoGamePad.ThumbSticks.Left.Y > 0)
            {
                personaje.MoverArriba(gameTime);
            }

            if (estadoTeclado.IsKeyDown(Keys.Down)
                || estadoGamePad.DPad.Down > 0
                || estadoGamePad.ThumbSticks.Left.Y < 0)
            {
                personaje.MoverAbajo(gameTime);
            }
        }

        protected void ComprobarColisiones()
        {
            // ...
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            personaje.Dibujar(spriteBatch);
            enemigo.Dibujar(spriteBatch);
        }
    }
}
