using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace MiniSnake
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D serpiente;
        Texture2D ladrillo;
        Texture2D manzana;
        List<Vector2> posicSegmentos = new List<Vector2>();
        int velocidad = 40;
        int velocidadX = 40, velocidadY = 0;
        int columnas = 1280 / 40;
        int filas = 720 / 40;
        string[] nivel =
        {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X        M        X            X",
            "X                 X            X",
            "X                              X",
            "XXXXXXXX                X      X",
            "X                       X      X",
            "X              M        X      X",
            "X                              X",
            "X                              X",
            "X       XXXXXXXXXXXXXXXXXX     X",
            "X                   X          X",
            "X                   X          X",
            "X                   X          X",
            "X                              X",
            "X     X        M               X",
            "X     X                 M      X",
            "X     X                        X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        };
        List<Rectangle> obstaculos = new List<Rectangle>();
        List<Rectangle> manzanas = new List<Rectangle>();
        int puntos = 0;
        SpriteFont fuente;
        int fotogramasPorSegundo = 3;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            posicSegmentos.Add(new Vector2(300, 200));

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (nivel[fila][columna] == 'X')
                    {
                        obstaculos.Add(
                            new Rectangle(columna * 40, fila * 40, 40, 40));
                    }
                    if (nivel[fila][columna] == 'M')
                    {
                        manzanas.Add(
                            new Rectangle(columna * 40, fila * 40, 40, 40));
                    }
                }
            }

            IsFixedTimeStep = true;
            TargetElapsedTime = System.TimeSpan.FromSeconds(
                1.0f / fotogramasPorSegundo);
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
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            serpiente = Content.Load<Texture2D>("ball");
            ladrillo = Content.Load<Texture2D>("brick");
            manzana = Content.Load<Texture2D>("apple");
            fuente = Content.Load<SpriteFont>("arial");
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Comprobación de teclas
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                velocidadX = velocidad;
                velocidadY = 0;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                velocidadX = -velocidad;
                velocidadY = 0;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                velocidadX = 0;
                velocidadY = -velocidad;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                velocidadX = 0;
                velocidadY = velocidad;
            }

            for (int i = posicSegmentos.Count - 1; i >= 1; i--)
                posicSegmentos[i] = posicSegmentos[i - 1];

            posicSegmentos[0] = new Vector2(
                    (float)(posicSegmentos[0].X +
                        velocidadX),
                    (float)(posicSegmentos[0].Y +
                        velocidadY));

            // Comprobación de colisiones
            foreach (Rectangle r in obstaculos)
            {
                if (r.Intersects(
                        new Rectangle(
                            (int) posicSegmentos[0].X, 
                            (int) posicSegmentos[0].Y, 
                            40, 40)))
                    Exit();
            }

            for (int i = 0; i < manzanas.Count; i++)
            {
                if (manzanas[i].Intersects(
                        new Rectangle(
                            (int) posicSegmentos[0].X, 
                            (int) posicSegmentos[0].Y, 
                            40, 40)))
                {
                    manzanas.RemoveAt(i);
                    puntos += 10;

                    float xUltima = posicSegmentos[posicSegmentos.Count - 1].X;
                    float yUltima = posicSegmentos[posicSegmentos.Count - 1].Y;

                    posicSegmentos.Add(
                        new Vector2(
                            xUltima - System.Math.Sign(velocidadX) * 40,
                            yUltima - System.Math.Sign(velocidadY) * 40));
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear( new Color(30, 30, 30) );

            spriteBatch.Begin();

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (nivel[fila][columna] == 'X')
                        spriteBatch.Draw(ladrillo,
                            new Rectangle(columna * 40, fila *40, 40, 40),
                            Color.White);
                }
            }

            foreach (Rectangle r in manzanas)
            {
                spriteBatch.Draw(manzana,
                    r,
                    Color.White);
            }

            spriteBatch.DrawString(fuente,
                "Puntos: " + puntos,
                new Vector2(400, 300),
                Color.Yellow);

            foreach (Vector2 pos in posicSegmentos)
                spriteBatch.Draw(serpiente,
                    new Rectangle((int)pos.X, (int)pos.Y, 40, 40),
                    Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
