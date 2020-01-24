using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace SpaceHawks
{
    class Enemy : Sprite
    {
        public Enemy(float x, float y, ContentManager c)
            : base("enemigo1a", x, y, c)
        {
            SetSpeed(150, 500);
        }

        public override void Move(GameTime gameTime)
        {
            if (Active)
                X += SpeedX * (float) gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void MoveDown(GameTime gameTime)
        {
            if (Active)
                Y += SpeedY * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
