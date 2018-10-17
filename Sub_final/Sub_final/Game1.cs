using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using Game1.Classes;

namespace Sub_final
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont fonte;

        //Cria os objetos para o programa utilizar;
        //1 parte, criar as propriedades

        //Tipo Imagem2D:
        Texture2D vida;
        Texture2D fundo;
        Texture2D gameOver;
        Texture2D vitoria;
        Texture2D estrela_img;
        Texture2D estrela_img_2;
        Texture2D estrela_img_3;

        // Listas
        List<Submarine> submarines;
        List<Torpedos> torpedos;

        //Objetos de som
        Song musica;

        //Teclado
        KeyboardState teclado_agr;
        KeyboardState teclado_antes;

        //Objetos tipo vetor
        Vector2 posicao;
        Vector2 estrela_pos;
        Vector2 estrela_pos_2;
        Vector2 estrela_pos_3;
        

        Sub_final player;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            ContentUtil.Content = Content;
        }

        
        protected override void Initialize()
        {
            // Definindo tamanho da tela.
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //2 parte, carregar os valores nas propriedades.
            tecladoAntes = new KeyboardState();
            tecladoAgora = new KeyboardState();
            musicaFundo = Content.Load<Song>("mus_sonar");
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(musicaFundo);

            //fundo = Content.Load<Texture2D>("fig_fundo");
            gameOver = Content.Load<Texture2D>("fig_perdeu");
            vitoria = Content.Load<Texture2D>("fig_venceu");
            posicao = new Vector2(0,0);

            vida = Content.Load<Texture2D>("fig_vida");
            fonte = Content.Load<SpriteFont>("fonte");

            torpedos = new List<Torpedos>();

            //Texture2D i = Content.Load<Texture2D>("fig_subazul");
            //Vector2 p = new Vector2(0, 350);
            //Vector2 v = new Vector2(4, 4);
            //player = new Sub_final(i, p, v);

            //inimigo

            // Submarino azul
            fundo = ContentUtil
            submarines.Add(new Submarine(new List<Texture2D>(){ ContentUtil.LoadImage()

        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
