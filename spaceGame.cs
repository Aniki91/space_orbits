using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace spaceProject
{
    public class spaceGame : Microsoft.Xna.Framework.Game
    {
        private static spaceGame instance;

        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        public int timeSpeed;

        public planetActor Pluto;
        public planetActor Neptune;
        public planetActor Uranus;
        public planetActor Saturn;
        public planetActor Jupiter;
        public planetActor Mars;
        public planetActor Earth;
        public planetActor Venus;
        public planetActor Mercury;

        public Texture2D Sun;
        public Texture2D Space;
        public Texture2D OrbitRings;

        public static spaceGame Instance
        {
            get
            {
                return instance;
            }
        }

        public spaceGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            //graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
            instance = this;
        }

        protected override void Initialize()
        {
            Pluto = new planetPluto();
            Neptune = new planetNeptune();
            Uranus = new planetUranus();
            Saturn = new planetSaturn();
            Jupiter = new planetJupiter();
            Mars = new planetMars();
            Earth = new planetEarth();
            Venus = new planetVenus();
            Mercury = new planetMercury();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Sun = spaceGame.Instance.Content.Load<Texture2D>("Sun");
            Space = spaceGame.Instance.Content.Load<Texture2D>("Space");
            OrbitRings = spaceGame.Instance.Content.Load<Texture2D>("OrbitRings");

            timeSpeed = 1;

            Pluto.LoadContent();
            Neptune.LoadContent();
            Uranus.LoadContent();
            Saturn.LoadContent();
            Jupiter.LoadContent();
            Mars.LoadContent();
            Earth.LoadContent();
            Venus.LoadContent();
            Mercury.LoadContent();

            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            Pluto.Update(gameTime);
            Neptune.Update(gameTime);
            Uranus.Update(gameTime);
            Saturn.Update(gameTime);
            Jupiter.Update(gameTime);
            Mars.Update(gameTime);
            Earth.Update(gameTime);
            Venus.Update(gameTime);
            Mercury.Update(gameTime);

            KeyboardState keyState = Keyboard.GetState();

            if(keyState.IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }

            if (keyState.IsKeyDown(Keys.Up))
            {
                timeSpeed += 1;
            }

            if (keyState.IsKeyDown(Keys.Down))
            {
                timeSpeed -= 1;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(Space, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(OrbitRings, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(Sun, new Vector2(924, 504), Color.White);

            Pluto.Draw(gameTime);
            Neptune.Draw(gameTime);
            Uranus.Draw(gameTime);
            Saturn.Draw(gameTime);
            Jupiter.Draw(gameTime);
            Mars.Draw(gameTime);
            Earth.Draw(gameTime);
            Venus.Draw(gameTime);
            Mercury.Draw(gameTime);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
