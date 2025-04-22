using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_Topic_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Rectangle circleRect;
            
        Texture2D  rectangleTexture;
        Rectangle rectangleRect;

        SpriteFont titleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            rectangleRect = new Rectangle(100, 100, 90, 50);
            circleRect = new Rectangle(300, 200, 50, 200);
            titleFont = Content.Load<SpriteFont>("Titlefont");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.DrawString(titleFont,"Andrej", new Vector2 (10,300), Color.Black);

            _spriteBatch.Draw(circleTexture, circleRect, Color.Red);         

            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.Green);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
