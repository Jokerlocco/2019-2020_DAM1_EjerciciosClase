using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceHawks
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D spaceship;
        Vector2 shipPosition;
        float shipSpeed;

        Texture2D enemy;
        Vector2 enemyPosition;
        Vector2 enemySpeed;

        SpriteFont font;
        Song music;
        SoundEffect fireSound;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            spaceship = Content.Load<Texture2D>("nave");
            shipPosition = new Vector2(300, 400);
            shipSpeed = 240;

            enemy = Content.Load<Texture2D>("enemigo1a");
            enemyPosition = new Vector2(50, 70);
            enemySpeed = new Vector2(150, 50);

            font = Content.Load<SpriteFont>("Arial");
            music = Content.Load<Song>("spaceHawks-levelTick");
            fireSound = Content.Load<SoundEffect>("spaceHawks-fire");
            MediaPlayer.Play(music);
            MediaPlayer.IsRepeating = true;
        }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back 
                    == ButtonState.Pressed 
                    || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Player movement
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
                shipPosition.X -= shipSpeed * 
                    (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right))
                shipPosition.X += shipSpeed *
                    (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Enemy movement
            enemyPosition.X += enemySpeed.X *
                (float)gameTime.ElapsedGameTime.TotalSeconds;
            enemyPosition.Y += enemySpeed.Y *
                (float)gameTime.ElapsedGameTime.TotalSeconds;

            if ((enemyPosition.X < 20) || (enemyPosition.X > 700))
                enemySpeed.X = -enemySpeed.X;
            if ((enemyPosition.Y < 20) || (enemyPosition.Y > 400))
                enemySpeed.Y = -enemySpeed.Y;

            //Collisions checking
            Rectangle spaceshipRect = new Rectangle(
                (int)shipPosition.X, (int)shipPosition.Y,
                spaceship.Width, spaceship.Height);
            Rectangle enemyRect = new Rectangle(
                    (int)enemyPosition.X, (int)enemyPosition.Y,
                    enemy.Width, enemy.Height);
            if (spaceshipRect.Intersects(enemyRect))
                Exit();

            // Fire !!!
            if (keyboardState.IsKeyDown(Keys.Space))
                fireSound.CreateInstance().Play();


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
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

            spriteBatch.Draw(enemy,
                new Rectangle(
                    (int)enemyPosition.X, (int)enemyPosition.Y,
                    enemy.Width, enemy.Height),
                Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
