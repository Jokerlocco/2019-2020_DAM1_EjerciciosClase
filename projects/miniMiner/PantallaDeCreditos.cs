using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiniMiner
{
    class PantallaDeCreditos
    {
        private SpriteFont fuente;
        private GestorDePantallas gestor;
        
        public PantallaDeCreditos(GestorDePantallas gestor)
        {
            this.gestor = gestor;
        }

        public void CargarContenidos(ContentManager Content)
        {
            fuente = Content.Load<SpriteFont>("PressStart2P");
        }

        public void Actualizar(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                gestor.modoActual = GestorDePantallas.MODO.BIENVENIDA;
            }
        }

        public void Dibujar(GameTime gameTime, SpriteBatch spritebatch)
        {
            spritebatch.DrawString(fuente, "Juego original:",
                new Vector2(100, 100), Color.White);
            spritebatch.DrawString(fuente, "(C) 1984 Software Projects",
                new Vector2(200, 150), Color.White);
            spritebatch.DrawString(fuente, "Remake: Nacho Cabanes",
                new Vector2(100, 250), Color.White);

            spritebatch.DrawString(fuente, "(ESC para volver)",
                new Vector2(100, 550), Color.White);
        }

    }
}
