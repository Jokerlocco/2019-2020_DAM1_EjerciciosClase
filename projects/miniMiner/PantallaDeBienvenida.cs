using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiniMiner
{
    class PantallaDeBienvenida
    {
        GraphicsDeviceManager graphics;
        ContentManager content;

        private SpriteFont font;
        private GestorDePantallas gestor;

        public PantallaDeBienvenida(GestorDePantallas gestor)
        {
            this.gestor = gestor;
        }

        public void CargarContenidos(ContentManager Content)
        {
            font = Content.Load<SpriteFont>("Arial");
        }

        public void Actualizar(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                gestor.modoActual = GestorDePantallas.MODO.JUEGO;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                gestor.Exit();
            }
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "1.- Play", new Vector2(460, 240), Color.White);
            spriteBatch.DrawString(font, "Q.- Quit", new Vector2(460, 280), Color.DimGray);
        }
    }
}
