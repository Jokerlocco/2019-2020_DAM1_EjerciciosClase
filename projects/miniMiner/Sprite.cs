using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MiniMiner
{
    class Sprite
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float VelocX { get; set; }
        public float VelocY { get; set; }
        public bool Activo { get; set; }
        private Texture2D imagen;

        public Sprite(int x, int y, string nombreImagen, ContentManager Content)
        {
            X = x;
            Y = y;
            imagen = Content.Load<Texture2D>(nombreImagen);
            Activo = true;
        }

        public void SetVelocidad(float vx, float vy)
        {
            VelocX = vx;
            VelocY = vy;
        }

        public void Dibujar(SpriteBatch spriteBatch)
        {
            if (Activo)
                spriteBatch.Draw(imagen,
                    new Rectangle(
                        (int)X,
                        (int)Y,
                        imagen.Width, imagen.Height),
                    Color.White);
        }

        public bool ColisionaCon(Sprite otro)
        {
            if (!Activo) return false;
            if (!otro.Activo) return false;
            Rectangle r1 = new Rectangle(
                (int)X, (int)Y,
                imagen.Width, imagen.Height);
            Rectangle r2 = new Rectangle(
                (int)otro.X, (int)otro.Y,
                otro.imagen.Width, otro.imagen.Height);

            return r1.Intersects(r2);
        }
    }
}
