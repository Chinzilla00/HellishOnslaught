using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI;

namespace HellishOnslaught.UI
{
    class MinigameUI : UIState
    {
        public Basemat basemat;
        public MoveLeft moveLeft;
        public MoveRight moveRight;
        public MoveUp moveUp;
        public MoveDown moveDown;
        public LanternSpot lantern;
        public StartButton startButton;

        public static int LeftSpotLeft;
        public static int LeftSpotTop;
        public static int RightSpotLeft;
        public static int RightSpotTop;
        public static int UpSpotLeft;
        public static int UpSpotTop;
        public static int DownSpotLeft;
        public static int DownSpotTop;

        public static int SpringHP = 100;
        public static int Lanterns = 3;
        public static int Lives = 3;
        public static int Score;
        public static int HighScore;

        public static bool gameStart;
        public static bool creating;
        public static bool tested;
        public static bool created;
        public override void OnInitialize()
        {
            Texture2D texture = ModContent.GetTexture("HellishOnslaught/UI/Texture");
            basemat = new Basemat();
            Append(basemat);
            moveLeft = new MoveLeft(texture);
            moveLeft.Left.Set(LeftSpotLeft, 0f);
            moveLeft.Top.Set(LeftSpotTop, 0f);
            moveLeft.Width.Set(128, 0f);
            moveLeft.Height.Set(128, 0f);
            moveLeft.OnClick += new MouseEvent(Lefter);
            Append(moveLeft);
            moveRight = new MoveRight(texture);
            moveRight.Left.Set(RightSpotLeft, 0f);
            moveRight.Top.Set(RightSpotTop, 0f);
            moveRight.Width.Set(128, 0f);
            moveRight.Height.Set(128, 0f);
            moveRight.OnClick += new MouseEvent(Righter);
            Append(moveRight);
            moveUp = new MoveUp(texture);
            moveUp.Left.Set(UpSpotLeft, 0f);
            moveUp.Top.Set(UpSpotTop, 0f);
            moveUp.Width.Set(128, 0f);
            moveUp.Height.Set(128, 0f);
            moveUp.OnClick += new MouseEvent(Uper);
            Append(moveUp);
            moveDown = new MoveDown(texture);
            moveDown.Left.Set(DownSpotLeft, 0f);
            moveDown.Top.Set(DownSpotTop, 0f);
            moveDown.Width.Set(128, 0f);
            moveDown.Height.Set(128, 0f);
            moveDown.OnClick += new MouseEvent(Downer);
            Append(moveDown);
            lantern = new LanternSpot(texture);
            lantern.Left.Set((Main.screenWidth - 512) / 2, 0f);
            lantern.Top.Set((Main.screenHeight - 512) / 2, 0f);
            lantern.Width.Set(512, 0f);
            lantern.Height.Set(512, 0f);
            lantern.OnRightClick += new MouseEvent(LanternClick);
            Append(lantern);
            startButton = new StartButton(texture);
            startButton.Left.Set((Main.screenWidth - 128) / 2, 0f);
            startButton.Top.Set((Main.screenHeight - 64) / 2, 0f);
            startButton.Width.Set(128, 0f);
            startButton.Height.Set(64, 0f);
            startButton.OnClick += new MouseEvent(Start);
            Append(startButton);
        }

        private void Lefter(UIMouseEvent evt, UIElement listeningElement)
        {
            
        }
        private void Righter(UIMouseEvent evt, UIElement listeningElement)
        {

        }
        private void Uper(UIMouseEvent evt, UIElement listeningElement)
        {

        }
        private void Downer(UIMouseEvent evt, UIElement listeningElement)
        {

        }
        private void LanternClick(UIMouseEvent evt, UIElement listeningElement)
        {

        }
        private void Start(UIMouseEvent evt, UIElement listeningElement)
        {
            if (!gameStart)
            {
                gameStart = true;
                creating = true;
            }
        }
    }
    public class Basemat : UIElement
    {
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (MinigameUI.creating)
            {
                int spawn = Main.rand.Next(64);
                switch (spawn)
                {
                    case 0:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 1:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 2:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 3:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 4:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 5:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 6:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 7:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 512) / 2), Color.White);
                        break;
                    case 8:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 9:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 10:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 11:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 12:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 13:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 14:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 15:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 384) / 2), Color.White);
                        break;
                    case 16:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 17:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 18:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 19:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 20:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 21:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 22:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 23:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 256) / 2), Color.White);
                        break;
                    case 24:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 25:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 26:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 27:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 28:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 29:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 30:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 31:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 128) / 2), Color.White);
                        break;
                    case 32:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 33:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 34:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 35:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 36:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 37:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 38:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 39:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight) / 2), Color.White);
                        break;
                    case 40:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 41:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 42:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 43:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 44:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 45:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 46:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 47:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 128) / 2), Color.White);
                        break;
                    case 48:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 49:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 50:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 51:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 52:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 53:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 54:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 55:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 256) / 2), Color.White);
                        break;
                    case 56:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 57:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 58:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 59:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 60:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 61:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 62:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                    case 63:
                        spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Spawn"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 384) / 2), Color.White);
                        break;
                }
                int exit = Main.rand.Next(64);
                if (spawn != exit)
                {
                    switch (exit)
                    {
                        case 0:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 1:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 2:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 3:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 4:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 5:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 6:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 7:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 512) / 2), Color.White);
                            break;
                        case 8:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 9:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 10:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 11:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 12:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 13:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 14:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 15:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 384) / 2), Color.White);
                            break;
                        case 16:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 17:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 18:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 19:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 20:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 21:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 22:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 23:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 256) / 2), Color.White);
                            break;
                        case 24:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 25:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 26:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 27:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 28:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 29:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 30:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 31:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight - 128) / 2), Color.White);
                            break;
                        case 32:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 33:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 34:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 35:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 36:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 37:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 38:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 39:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight) / 2), Color.White);
                            break;
                        case 40:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 41:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 42:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 43:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 44:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 45:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 46:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 47:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 128) / 2), Color.White);
                            break;
                        case 48:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 49:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 50:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 51:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 52:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 53:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 54:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 55:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 256) / 2), Color.White);
                            break;
                        case 56:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 512) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 57:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 384) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 58:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 256) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 59:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 60:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 61:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 128) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 62:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 256) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                        case 63:
                            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Exit"), new Vector2((Main.screenWidth + 384) / 2, (Main.screenHeight + 384) / 2), Color.White);
                            break;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
    public class LanternSpot : UIImageButton
    {
        public LanternSpot(Texture2D texture) : base(texture)
        {
        }
    }
    public class MoveLeft : UIImageButton
    {
        public MoveLeft(Texture2D texture) : base(texture)
        {
        }
    }
    public class MoveRight : UIImageButton
    {
        public MoveRight(Texture2D texture) : base(texture)
        {
        }
    }
    public class MoveUp : UIImageButton
    {
        public MoveUp(Texture2D texture) : base(texture)
        {
        }
    }
    public class MoveDown : UIImageButton
    {
        public MoveDown(Texture2D texture) : base(texture)
        {
        }
    }
    public class StartButton : UIImageButton
    {
        public StartButton(Texture2D texture) : base(texture)
        {
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!MinigameUI.gameStart)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Start"), new Vector2((Main.screenWidth - 128) / 2, (Main.screenHeight - 64) / 2), Color.White);
            }
        }
    }
}