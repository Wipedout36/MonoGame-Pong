using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    public class Ball
    {
        public Texture2D ballTexture;
        public Vector2 ballPosition;
        public Vector2 ballVelocity;

        private Rectangle screenBounds;

        public Ball(Texture2D texture, Vector2 position, Vector2 velocity, Rectangle screenBounds)
        {
            ballTexture = texture;
            ballPosition = position;
            ballVelocity = velocity;
            this.screenBounds = screenBounds;
        }

        private void keepOnScreen()
        {
            if(ballPosition.X + ballTexture.Width > screenBounds.Width)
            {
                ballVelocity.X *= -1;
            }

            if(ballPosition.Y < screenBounds.Y)
            {
                ballVelocity.Y *= -1;
            }

            if (ballPosition.Y + ballTexture.Height > screenBounds.Height)
            {
                ballVelocity.Y *= -1;
            }
        }

        public void Update(GameTime gameTime)
        {
            keepOnScreen();
            ballPosition += ballVelocity * gameTime.ElapsedGameTime.Milliseconds / 1000f;
        }
    }
}
