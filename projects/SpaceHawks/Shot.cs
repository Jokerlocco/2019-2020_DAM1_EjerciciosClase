using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace SpaceHawks
{
    class Shot : Sprite
    {
        SoundEffect fireSound;

        public Shot(ContentManager c)
            : base("disparo", 0, 0, c)
        {
            Active = false;
            SetSpeed(0, 200);
            fireSound = c.Load<SoundEffect>("spaceHawks-fire");
        }

        public void Start(float x, float y)
        {
            if (!Active)
            {
                fireSound.CreateInstance().Play();
                X = x;
                Y = y;
                Active = true;
            }
        }

        public override void Move(GameTime gameTime)
        {
            if (Active)
            {
                Y -= SpeedY *
                    (float) gameTime.ElapsedGameTime.TotalSeconds;
                if (Y < 0)
                    Active = false;
            }
        }
    }
}
