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
        Sprite personaje;
        public bool Terminado { get; set; }

        public PantallaDeJuego(int maxX, int maxY)
        {
            // ...
        }

        public void CargarContenidos(ContentManager Content)
        {
            personaje = new Sprite(0, 0, "personaje", Content);
        }

        public void Actualizar(GameTime gameTime)
        {
            MoverElementos(gameTime);
            ComprobarColisiones();
            ComprobarEntrada(gameTime);
        }

        protected void MoverElementos(GameTime gameTime)
        {
            // ...
        }

        protected void ComprobarEntrada(GameTime gameTime)
        {
            var estadoTeclado = Keyboard.GetState();
            var estadoGamePad = GamePad.GetState(PlayerIndex.One);

            if (estadoGamePad.Buttons.Back == ButtonState.Pressed 
                    || estadoTeclado.IsKeyDown(Keys.Escape))
                Terminado = true;

            // ...
        }

        protected void ComprobarColisiones()
        {
            // ...
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            personaje.Dibujar(spriteBatch);
        }
    }
}
