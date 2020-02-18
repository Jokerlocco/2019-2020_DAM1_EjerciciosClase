using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiniMiner
{
    class PantallaDeBienvenida
    {
        private SpriteFont fuente;
        private GestorDePantallas gestor;

        public PantallaDeBienvenida(GestorDePantallas gestor)
        {
            this.gestor = gestor;
        }

        public void CargarContenidos(ContentManager Content)
        {
            fuente = Content.Load<SpriteFont>("Arial");
        }

        public void Actualizar(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                gestor.modoActual = GestorDePantallas.MODO.JUEGO;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                gestor.Terminar();
            }
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spritebatch)
        {
            spritebatch.DrawString(fuente, "1. Jugar",
                new Vector2(400, 100), Color.White);
            spritebatch.DrawString(fuente, "S. Salir",
                new Vector2(400, 150), Color.White);
        }

    }
}
