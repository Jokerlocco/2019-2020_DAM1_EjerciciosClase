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

        private byte[,] fondo =
        {
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1}
        };

        private byte anchoFondo = 20;
        private byte altoFondo = 16;
        private short margenXFondo = 200;
        private byte margenYFondo = 100;
        private byte anchoCasillaFondo = 32;
        private byte altoCasillaFondo = 32;
        private Texture2D pared;
        private Texture2D suelo;

        public PantallaDeBienvenida(GestorDePantallas gestor)
        {
            this.gestor = gestor;
        }

        public void CargarContenidos(ContentManager Content)
        {
            fuente = Content.Load<SpriteFont>("PressStart2P");
            pared = Content.Load<Texture2D>("paredNivel1");
            suelo = Content.Load<Texture2D>("sueloNivel1");
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
            for (int fila = 0; fila < altoFondo; fila++)  // Fondo
                for (int col = 0; col < anchoFondo; col++)
                {
                    if (fondo[fila, col] == 1)
                        spritebatch.Draw(pared,
                            new Rectangle(
                                margenXFondo + col * anchoCasillaFondo,
                                margenYFondo + fila * altoCasillaFondo,
                                anchoCasillaFondo,
                                altoCasillaFondo),
                            Color.White);
                    else if (fondo[fila, col] == 2)
                        spritebatch.Draw(suelo,
                            new Rectangle(
                                margenXFondo + col * anchoCasillaFondo,
                                margenYFondo + fila * altoCasillaFondo,
                                anchoCasillaFondo,
                                altoCasillaFondo),
                            Color.White);
                }
            spritebatch.DrawString(fuente, "1. Jugar",
                new Vector2(400, 100), Color.White);
            spritebatch.DrawString(fuente, "S. Salir",
                new Vector2(400, 150), Color.White);
        }

    }
}
