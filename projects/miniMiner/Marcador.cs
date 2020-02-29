using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MiniMiner
{
    class Marcador
    {
        string nombreDeNivel;
        int puntosAMostrar;
        private SpriteFont fuente;

        public Marcador(ContentManager Content)
        {
            fuente = Content.Load<SpriteFont>("PressStart2P");
        }

        public void SetNombreNivel(string nombre)
        {
            nombreDeNivel = nombre;
        }

        public void ReiniciarPuntos()
        {
            puntosAMostrar = 0;
        }

        public void IncrementarPuntos(int cantidad)
        {
            puntosAMostrar += cantidad;
        }

        public void Dibujar(SpriteBatch spritebatch)
        {
            spritebatch.DrawString(fuente,
                nombreDeNivel,
                new Vector2(400, 600), Color.White);
            spritebatch.DrawString(fuente,
                "Puntos: " + puntosAMostrar,
                new Vector2(400, 650), Color.White);
        }
    }
}
