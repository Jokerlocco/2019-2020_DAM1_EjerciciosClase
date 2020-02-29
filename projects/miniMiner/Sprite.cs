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

        protected int cantidadDeFotogramas;
        private Texture2D[][] secuencia;
        protected int fotogramaActual;
        protected int tiempoEnCadaFotograma;
        protected int tiempoHastaSiguienteFotograma;
        protected bool haySecuencia;

        protected float xInicial, yInicial;

        protected enum direcciones
        {
            DERECHA, IZQUIERDA,
            ARRIBA, ABAJO, APARECIENDO, DESAPARECENDO
        };
        int direccionActual = (int)direcciones.DERECHA;

        public Sprite(int x, int y, string nombreImagen, ContentManager Content)
        {
            X = x;
            Y = y;
            xInicial = x;
            yInicial = y;
            imagen = Content.Load<Texture2D>(nombreImagen);
            Activo = true;
            haySecuencia = false;
        }

        public Sprite(int x, int y, Sprite sprite)
        {
            X = x;
            Y = y;
            xInicial = x;
            yInicial = y;
            imagen = sprite.imagen;
            Activo = true;
            haySecuencia = false;
        }

        public Sprite(int x, int y, string[] imagenes, ContentManager Content)
        {
            X = x;
            Y = y;
            xInicial = x;
            yInicial = y;
            Activo = true;
            secuencia = new Texture2D[sizeof(direcciones)][];
            CargarSecuencia(0, imagenes, Content);
            imagen = secuencia[0][0];
            fotogramaActual = 0;
            tiempoEnCadaFotograma = 500;
            tiempoHastaSiguienteFotograma = tiempoEnCadaFotograma;
        }

        public void CargarSecuencia(byte direcc, string[] imagenes, ContentManager contenido)
        {
            byte tamanyoSecuencia = (byte)imagenes.Length;
            secuencia[direcc] = new Texture2D[tamanyoSecuencia];
            for (int i = 0; i < imagenes.Length; i++)
            {
                secuencia[direcc][i] = contenido.Load<Texture2D>(imagenes[i]);
            }
            haySecuencia = true;
            cantidadDeFotogramas = imagenes.Length;
            direccionActual = direcc;
        }

        public void MoverAPosicionInicial()
        {
            X = xInicial;
            Y = yInicial;
        }

        public void CambiarDireccion(byte nuevaDir)
        {
            if (!haySecuencia)
                return;

            if (direccionActual != nuevaDir)
            {
                direccionActual = nuevaDir;
                fotogramaActual = 0;
                cantidadDeFotogramas = (byte)secuencia[direccionActual].Length;
            }
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
                    imagen = secuencia[direccionActual][fotogramaActual];
                }
            }
        }
    }
}
