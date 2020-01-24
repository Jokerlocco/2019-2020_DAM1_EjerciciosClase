using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceHawks
{
    class Sprite
    {
        protected Texture2D image;        
        public float X { get; set; }
        public float Y { get; set; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
        public bool Active { get; set;  }
        

        public Sprite(string imageName, float x, float y,
            ContentManager c)
        {
            image = c.Load<Texture2D>(imageName);
            //position = new Vector2(x, y);
            X = x;
            Y = y;
            Active = true;
        }

        public void SetSpeed(float xSpeed, float ySpeed)
        {
            SpeedX = xSpeed;
            SpeedY = ySpeed;
        }

        public void Draw(SpriteBatch sb)
        {
            if (Active)
                sb.Draw(image,
                    new Rectangle(
                        (int) X, (int) Y,
                        image.Width, image.Height),
                    Color.White);
        }

        public bool CollidesWith(Sprite s2)
        {
            if (!Active) return false;
            if (!s2.Active) return false;
            Rectangle r1 = new Rectangle(
                    (int) X, (int) Y,
                    image.Width, image.Height);
            Rectangle r2 = new Rectangle(
                    (int) s2.X, (int) s2.Y,
                    s2.image.Width, s2.image.Height);
            return r1.Intersects(r2);
        }

        public virtual void Move(GameTime gameTime)
        {
            // To be redefined in derived classes
        }
    }
}
