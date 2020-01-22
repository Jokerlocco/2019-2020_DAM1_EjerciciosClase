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

        Texture2D spaceship;
        Vector2 shipPosition;
        float shipSpeed;

        Texture2D enemy;
        Vector2[] enemyPos;
        Vector2 enemySpeed;

        SpriteFont font;
        Song music;
        SoundEffect fireSound;

        Texture2D fire;
        Vector2 firePosition;
        float fireSpeed;
        bool fireActive;


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

            spaceship = Content.Load<Texture2D>("nave");
            shipPosition = new Vector2(300, 400);
            shipSpeed = 240;

            enemy = Content.Load<Texture2D>("enemigo1a");

            enemyPos = new Vector2[AMOUNT_OF_ENEMIES];
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
            {
                int row = i / 6;
                int column = i % 6;
                int x = 40 + column * 100;
                int y = 30 + row * 50;
                enemyPos[i] = new Vector2(x, y);
            }

            enemySpeed = new Vector2(150, 500);

            font = Content.Load<SpriteFont>("Arial");
            music = Content.Load<Song>("spaceHawks-levelTick");
            fireSound = Content.Load<SoundEffect>("spaceHawks-fire");
            MediaPlayer.Play(music);
            MediaPlayer.IsRepeating = true;

            fireSpeed = 200;
            fireActive = false;
            fire = Content.Load<Texture2D>("disparo");
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
            Rectangle spaceshipRect = new Rectangle(
                (int)shipPosition.X, (int)shipPosition.Y,
                spaceship.Width, spaceship.Height);
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
            {
                Rectangle enemyRect = new Rectangle(
                    (int)enemyPos[i].X, (int)enemyPos[i].Y,
                    enemy.Width, enemy.Height);
                if (spaceshipRect.Intersects(enemyRect))
                    Exit();
            }
        }

        private void MoveElements(GameTime gameTime)
        {
            bool shouldTurnAround = false;
            for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
            {
                enemyPos[i].X += enemySpeed.X *
                    (float)gameTime.ElapsedGameTime.TotalSeconds;
                if ((enemyPos[i].X < 20) || (enemyPos[i].X > 850))
                    shouldTurnAround = true;
            }

            if (shouldTurnAround)
            {
                enemySpeed.X = -enemySpeed.X;
                for (int i = 0; i < AMOUNT_OF_ENEMIES; i++)
                {
                    enemyPos[i].Y += enemySpeed.Y *
                        (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
            }

            if (fireActive)
            {
                firePosition.Y -= fireSpeed *
                        (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (firePosition.Y < 0)
                    fireActive = false;
            }
        }

        protected void CheckInput(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
                shipPosition.X -= shipSpeed *
                    (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right))
                shipPosition.X += shipSpeed *
                    (float)gameTime.ElapsedGameTime.TotalSeconds;

            if ((keyboardState.IsKeyDown(Keys.Space)) && (! fireActive))
            {
                fireSound.CreateInstance().Play();
                firePosition = new Vector2(
                    shipPosition.X + 30, shipPosition.Y - 15);
                fireActive = true;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.DrawString(font,
                "Hello",
                new Vector2(400, 50),
                Color.Crimson);

            spriteBatch.Draw(spaceship,
                new Rectangle(
                    (int) shipPosition.X, (int)shipPosition.Y, 
                    spaceship.Width, spaceship.Height),
                Color.White);

            foreach (Vector2 pos in enemyPos)
            {
                spriteBatch.Draw(enemy,
                new Rectangle(
                    (int) pos.X, (int) pos.Y,
                    enemy.Width, enemy.Height),
                Color.White);
            }

            if (fireActive)
            {
                spriteBatch.Draw(fire,
                new Rectangle(
                    (int)firePosition.X, (int)firePosition.Y,
                    fire.Width, fire.Height),
                Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
