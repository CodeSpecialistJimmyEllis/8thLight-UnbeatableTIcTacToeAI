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

namespace TicTacToe
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        // TODO: 
        // send tic tac toe gamescreen variables to game1.cs
        // send tic tac toe ai variables tso game1.cs
        // transfer gamescreen variables to a.i.
        // transfer a.i. variables to gamescreen.
        // debug accordingly 

        public Game1()
        {
            
            ScreenManager.Instance.Dimensions = new Vector2(1024, 720);
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            //ScreenManager.Instance.DimensionsX = 1024;

            //ScreenManager.Instance.DimensionsY = 720;
     
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            
            ScreenManager.Instance.Initialize();

          
           // graphics.ApplyChanges();
            IsMouseVisible = true;
            this.Window.AllowUserResizing = true;
            base.Initialize();
            
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.LoadContent(Content);
        }
        protected override void UnloadContent()
        {

        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Escape))
                this.Exit();

            ScreenManager.Instance.Update(gameTime);
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
