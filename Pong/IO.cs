using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong
{
    public class IO
    {
        Player player;

        public IO (Player player)
        {
            this.player = player;
        }

        public void HandleIO(KeyboardState state, GameTime gameTime)
        {
            if(state.IsKeyDown(Keys.Up))
            {
                Vector2 motion = new Vector2(0, -100);
                motion = motion * (gameTime.ElapsedGameTime.Milliseconds / 1000f);
                player.Move(motion);
            }

            if(state.IsKeyDown(Keys.Down))
            {
                Vector2 motion = new Vector2(0, 100);
                motion = motion * (gameTime.ElapsedGameTime.Milliseconds / 1000f);
                player.Move(motion);
            }
        }
    }
}
