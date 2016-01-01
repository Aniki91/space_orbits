using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace spaceProject
{
    public class planetControls : planetActor
    {
        public int timeSpeed;

        public planetControls(int timeSpeed)
        {
            this.timeSpeed = timeSpeed;
        }

        public override void Initialize()
        {
        }

        public override void LoadContent()
        {
            timeSpeed = 1;
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.Up))
            {
                timeSpeed += 50;
            }
        }

        public override void Draw(GameTime gameTime)
        {
        }
    }
}
