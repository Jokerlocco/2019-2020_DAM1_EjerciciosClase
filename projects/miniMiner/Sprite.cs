using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

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
        int cantidadDeFotogramas;
        private Texture2D[] secuencia;
        int fotogramaActual;
        int tiempoEnCadaFotograma;
        int tiempoHastaSiguienteFotograma;
        bool haySecuencia;

        public Sprite(int x, int y, string nombreImagen, ContentManager Content)
        {
            X = x;
            Y = y;
            imagen = Content.Load<Texture2D>(nombreImagen);
            Activo = true;
            haySecuencia = false;
        }

        public Sprite(int x, int y, string[] imagenes, ContentManager Content)
        {
            X = x;
            Y = y;
            Activo = true;
            cantidadDeFotogramas = imagenes.Length;
            secuencia = new Texture2D[cantidadDeFotogramas];
            for (int i = 0; i < cantidadDeFotogramas; i++)
            {
                secuencia[i] = Content.Load<Texture2D>(imagenes[i]);
            }
            imagen = secuencia[0];
            fotogramaActual = 0;
            tiempoEnCadaFotograma = 500;
            tiempoHastaSiguienteFotograma = tiempoEnCadaFotograma;
            haySecuencia = true;
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

        public virtual void Mover(GameTime gameTime)
        {
            if (haySecuencia)
            {
                tiempoHastaSiguienteFotograma -= gameTime.ElapsedGameTime.Milliseconds;
                if (tiempoHastaSiguienteFotograma <= 0)
                {
                    fotogramaActual++;
                    if (fotogramaActual >= cantidadDeFotogramas)
                        fotogramaActual = 0;
                    tiempoHastaSiguienteFotograma = tiempoEnCadaFotograma;
                    imagen = secuencia[fotogramaActual];
                }
            }
        }
    }
}
