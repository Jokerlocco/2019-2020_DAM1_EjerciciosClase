﻿using Microsoft.Xna.Framework;
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
        double x, y;
        int velocidad = 120;
        int columnas = 1280 / 40;
        int filas = 720 / 40;
        string[] nivel =
        {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X                 X            X",
            "X                 X            X",
            "X                              X",
            "XXXXXXXX                X      X",
            "X                       X      X",
            "X                       X      X",
            "X                              X",
            "X                              X",
            "X       XXXXXXXXXXXXXXXXXX     X",
            "X                   X          X",
            "X                   X          X",
            "X                   X          X",
            "X                              X",
            "X     X                        X",
            "X     X                        X",
            "X     X                        X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        };
        List<Rectangle> obstaculos = new List<Rectangle>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            x = 300;
            y = 200;

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (nivel[fila][columna] == 'X')
                    {
                        obstaculos.Add(
                            new Rectangle(columna * 40, fila * 40, 40, 40));
                    }
                }
            }

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
                x += velocidad * gameTime.ElapsedGameTime.TotalSeconds;

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                x -= velocidad * gameTime.ElapsedGameTime.TotalSeconds;

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                y -= velocidad * gameTime.ElapsedGameTime.TotalSeconds;

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                y += velocidad * gameTime.ElapsedGameTime.TotalSeconds;

            // Comprobación de colisiones
            foreach(Rectangle r in obstaculos)
            {
                if (r.Intersects(
                        new Rectangle((int)x, (int)y, 40, 40)))
                    Exit();
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

            spriteBatch.Draw(serpiente,
                new Rectangle((int) x, (int) y, 40, 40),
                Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}