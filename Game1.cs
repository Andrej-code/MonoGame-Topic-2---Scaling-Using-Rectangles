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

        Texture2D rectangleTexture;
        Texture2D rectangle1Texture;
        Texture2D rectangle2Texture;
        Texture2D rectangle3Texture;
        Texture2D rectangle4Texture;
        Texture2D rectangle5Texture;
        Rectangle rectangleRect;
        Rectangle rectangle1Rect;
        Rectangle rectangle2Rect;
        Rectangle rectangle3Rect;
        Rectangle rectangle4Rect;
        Rectangle rectangle5Rect;


        SpriteFont titleFont;
        SpriteFont titleFont1;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            rectangleRect = new Rectangle(400, 200, 210, 150);
            rectangle4Rect = new Rectangle(460, 200, 35, 150);
            rectangle5Rect = new Rectangle(400, 260, 210, 35);
            // Austria
            rectangle1Rect = new Rectangle(100, 200, 200, 50);
            rectangle2Rect = new Rectangle(100, 250, 200, 50);
            rectangle3Rect = new Rectangle(100, 300, 200, 50);

            //Finland

            //circleRect = new Rectangle(300, 200, 50, 200);
            titleFont = Content.Load<SpriteFont>("Titlefont");
            titleFont1 = Content.Load<SpriteFont>("Titlefont");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            rectangle4Texture = Content.Load<Texture2D>("rectangle");
            rectangle5Texture = Content.Load<Texture2D>("rectangle");
            // Austria
            rectangle1Texture = Content.Load<Texture2D>("rectangle");
            rectangle2Texture = Content.Load<Texture2D>("rectangle");
            rectangle3Texture = Content.Load<Texture2D>("rectangle");
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
            GraphicsDevice.Clear(Color.DarkGreen);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.DrawString(titleFont, "Austria", new Vector2(130, 350), Color.Black);
            _spriteBatch.DrawString(titleFont, "Finland", new Vector2(445, 350), Color.Black);

            //_spriteBatch.Draw(circleTexture, circleRect, Color.Red);

            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.WhiteSmoke);

            _spriteBatch.Draw(rectangle4Texture, rectangle4Rect, Color.MediumBlue);

            _spriteBatch.Draw(rectangle5Texture, rectangle5Rect, Color.MediumBlue);

            _spriteBatch.Draw(rectangle1Texture, rectangle1Rect, Color.DarkRed);

            _spriteBatch.Draw(rectangle2Texture, rectangle2Rect,Color.WhiteSmoke);

            _spriteBatch.Draw(rectangle3Texture, rectangle3Rect, Color.DarkRed);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
