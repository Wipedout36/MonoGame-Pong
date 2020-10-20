using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong
{
    public class Player
    {
        public Texture2D playerTexture;
        public Vector2 playerPosition;

        public Player(Texture2D texture, Vector2 position)
        {
            playerTexture = texture;
            playerPosition = position;            
        }

        public void Move(Vector2 motion)
        {
            playerPosition += motion;
        }
    }
}
