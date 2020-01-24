using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceHawks
{
    public class Game1 : Game
    {
        const int AMOUNT_OF_ENEMIES = 30;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Spaceship ship;
        Enemy[] enemies;
        Shot shot;

        SpriteFont font;
        Song music;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            ship = new Spaceship(Content);
            shot = new Shot(Content);

            enemies = new Enemy[AMOUNT_OF_ENEMIES];
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
            {
                int row = i / 6;
                int column = i % 6;
                int x = 40 + column * 100;
                int y = 30 + row * 50;
                enemies[i] = new Enemy(x, y, Content);
            }

            font = Content.Load<SpriteFont>("Arial");
            music = Content.Load<Song>("spaceHawks-levelTick");
            MediaPlayer.Play(music);
            MediaPlayer.IsRepeating = true;
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back
                    == ButtonState.Pressed
                    || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            CheckInput(gameTime);
            MoveElements(gameTime);
            CheckCollisions();

            base.Update(gameTime);
        }

        private void CheckCollisions()
        {
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
            {
                if (shot.CollidesWith(enemies[i]))
                {
                    enemies[i].Active = false;
                    shot.Active = false;
                }
                if (ship.CollidesWith(enemies[i]))
                    Exit();
            }
        }

        private void MoveElements(GameTime gameTime)
        {
            shot.Move(gameTime);

            bool shouldTurnAround = false;
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
                enemies[i].Move(gameTime);

            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
                if (enemies[i].Active)
                    if ((enemies[i].X < 20) || (enemies[i].X > 850))
                        shouldTurnAround = true;

            if (shouldTurnAround)
            {
                for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
                {
                    enemies[i].SpeedX = -enemies[i].SpeedX;
                    enemies[i].MoveDown(gameTime);
                }
            }
        }

        protected void CheckInput(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
                ship.MoveLeft(gameTime);
            if (keyboardState.IsKeyDown(Keys.Right))
                ship.MoveRight(gameTime);

            if (keyboardState.IsKeyDown(Keys.Space))
                shot.Start(ship.X + 30, ship.Y - 15);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            spriteBatch.DrawString(font,
                "Hello",
                new Vector2(400, 50),
                Color.Crimson);

            ship.Draw(spriteBatch);
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
                enemies[i].Draw(spriteBatch);
            shot.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
