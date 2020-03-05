using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace MiniMiner
{
    class Personaje : Sprite
    {
        public int Vidas { get; set; }
        public Personaje(ContentManager Content)
            : base (500, 320, "personaje", Content)
        {
            VelocX = 200;
            VelocY = 200;
            Vidas = 3;
        }

        public void MoverDerecha(GameTime gameTime, Nivel nivel)
        {
            float desplazamiento = VelocX * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (nivel.EsPosibleMover(this, desplazamiento, 0))
                X += desplazamiento;
        }

        public void MoverIzquierda(GameTime gameTime, Nivel nivel)
        {
            float desplazamiento = VelocX * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (nivel.EsPosibleMover(this, -desplazamiento, 0))
                X -= desplazamiento;
        }

        public void MoverArriba(GameTime gameTime, Nivel nivel)
        {
            float desplazamiento = VelocY * (float)gameTime.ElapsedGameTime.TotalSeconds;
            //if (nivel.EsPosibleMover(this, 0, -desplazamiento))
                Y -= desplazamiento;
        }

        public void MoverAbajo(GameTime gameTime, Nivel nivel)
        {
            float desplazamiento = VelocY * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (nivel.EsPosibleMover(this, 0, desplazamiento))
                Y += desplazamiento;
        }
    }
}
