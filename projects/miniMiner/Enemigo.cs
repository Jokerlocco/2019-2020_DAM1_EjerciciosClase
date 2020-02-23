using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace MiniMiner
{
    class Enemigo : Sprite
    {
        private float MaxX, MinX, MaxY, MinY;

        public Enemigo(ContentManager Content) : base(
            100, 100,
            new string[] { "enemigoD1", "enemigoD2", "enemigoD3", "enemigoD2" },
            Content)
        {
            VelocX = 150;
            VelocY = 0;
            MinX = 50;
            MaxX = 600;
            MinY = 100;
            MaxY = 100;
            CargarSecuencia( (byte) direcciones.IZQUIERDA,
                new string[] { "enemigoI1", "enemigoI2", "enemigoI3", "enemigoI2" },
                Content);
            CambiarDireccion( (byte) direcciones.DERECHA);
            tiempoEnCadaFotograma = 200;
        }

        public override void Mover(GameTime gameTime)
        {
            base.Mover(gameTime);

            X += VelocX * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if ((X > MaxX) || (X < MinX))
            {
                VelocX *= -1;
                if (VelocX < 1)
                    CambiarDireccion((byte)direcciones.IZQUIERDA);
                else
                    CambiarDireccion((byte)direcciones.DERECHA);
            }

            Y += VelocY * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if ((Y > MaxY) || (Y < MinY))
                VelocY *= -1;
        }
    }
}
