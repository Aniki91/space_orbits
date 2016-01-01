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
    class planetJupiter : planetActor
    {
        public override void Initialize()
        {
        }

        public override void LoadContent()
        {
            planetPos = new Vector2(960, 540);
            sunCent = new Vector2(208, 208);

            planetSprite = spaceGame.Instance.Content.Load<Texture2D>("Jupiter");
        }

        public override void Update(GameTime gameTime)
        {
            float timeDelta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            planetRot += (0.025f * spaceGame.Instance.timeSpeed) * timeDelta;
        }

        public override void Draw(GameTime gameTime)
        {
            spaceGame.Instance.spriteBatch.Draw(planetSprite, planetPos, null, Color.White, planetRot, sunCent, 1, SpriteEffects.None, 1);
        }
    }
}