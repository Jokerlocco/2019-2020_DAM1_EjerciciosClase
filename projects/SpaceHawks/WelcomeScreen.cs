using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceHawks
{
    class WelcomeScreen
    {
        GraphicsDeviceManager graphics;
        ContentManager content;

        private SpriteFont font;
        private ScreenManager manager;

        public WelcomeScreen(ScreenManager manager)
        {
            this.manager = manager;
        }

        public void LoadContent(ContentManager Content)
        {
            font = Content.Load<SpriteFont>("Arial");
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                manager.currentMode = ScreenManager.MODE.GAME;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                manager.Exit();
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "1.- Play", new Vector2(380, 240), Color.White);
            spriteBatch.DrawString(font, "Q. Quit", new Vector2(380, 280), Color.DimGray);
        }

    }
}
