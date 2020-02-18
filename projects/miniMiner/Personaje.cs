using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace MiniMiner
{
    class Personaje : Sprite
    {

        public Personaje(ContentManager Content)
            : base (500, 300, "personaje", Content)
        {
            VelocX = 200;
            VelocY = 200;
        }

        public void MoverDerecha(GameTime gameTime)
        {
            X += VelocX * (float) gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void MoverIzquierda(GameTime gameTime)
        {
            X -= VelocX * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void MoverArriba(GameTime gameTime)
        {
            Y -= VelocY * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void MoverAbajo(GameTime gameTime)
        {
            Y += VelocY * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
