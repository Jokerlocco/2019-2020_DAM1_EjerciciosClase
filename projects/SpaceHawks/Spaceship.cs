using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace SpaceHawks
{
    class Spaceship : Sprite
    {
        public Spaceship(ContentManager c)
            : base ("nave", 300, 400, c)
        {
            SetSpeed(240, 0);
        }

        public void MoveRight(GameTime gameTime)
        {
            X += SpeedX *
                (float) gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void MoveLeft(GameTime gameTime)
        {
            X -= SpeedX *
                (float) gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
