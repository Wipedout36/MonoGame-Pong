using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Player player;
        public Ball ball;

        IO ioHandler;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            player = new Player(Content.Load<Texture2D>("paddle"), new Vector2(50, 0));
            ball = new Ball(Content.Load<Texture2D>("ball"), new Vector2(700, 300), new Vector2(-60,-60), new Rectangle(0,0,_spriteBatch.GraphicsDevice.Viewport.Width,_spriteBatch.GraphicsDevice.Viewport.Height));

            ioHandler = new IO(player);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            ioHandler.HandleIO(Keyboard.GetState(), gameTime);
            ball.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(ball.ballTexture, ball.ballPosition, Color.White);
            _spriteBatch.Draw(player.playerTexture, player.playerPosition, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
