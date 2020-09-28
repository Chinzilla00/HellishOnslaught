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
    class ButtonUI : UIState
    {
        public LegacyShop legacy;
        public Select select;
        public LeftButton left;
        public RightButton right;
        public override void OnInitialize()
        {
            Texture2D texture = ModContent.GetTexture("HellishOnslaught/UI/Texture");
            legacy = new LegacyShop();
            Append(legacy);
            select = new Select(texture);
            select.Left.Set((Main.screenWidth - 32) / 2f, 0f);
            select.Top.Set((Main.screenHeight - 146) / 2f, 0f);
            select.Width.Set(32, 0f);
            select.Height.Set(32, 0f);
            select.OnClick += new MouseEvent(SelectClicky);
            Append(select);
            left = new LeftButton(texture);
            left.Left.Set((Main.screenWidth - 96) / 2f, 0f);
            left.Top.Set((Main.screenHeight - 146) / 2f, 0f);
            left.Width.Set(32, 0f);
            left.Height.Set(32, 0f);
            left.OnClick += new MouseEvent(LeftClicky);
            Append(left);
            right = new RightButton(texture);
            right.Left.Set((Main.screenWidth + 32) / 2f, 0f);
            right.Top.Set((Main.screenHeight - 146) / 2f, 0f);
            right.Width.Set(32, 0f);
            right.Height.Set(32, 0f);
            right.OnClick += new MouseEvent(RightClicky);
            Append(right);
        }
        private void SelectClicky(UIMouseEvent evt, UIElement listeningElement)
        {
            Player player = Main.LocalPlayer;
            if (LegacyShop.LegShopPos == 0)
            {
                int chance = Main.rand.Next(3);
                if (chance == 0)
                {
                    Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<Blundergat>());
                    Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<DeveloperCore>());
                }
                if (chance == 1)
                {
                    Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<JooksDespair>());
                    Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<DeveloperCore>());
                }
                if (chance == 2)
                {
                    Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<Fuck>());
                    //player.GetModPlayer<PlayerFile>().Leg1 = true;
                }
                HellishOnslaught.instance.HideMyUI();
            }
            if (LegacyShop.LegShopPos == 1)
            {
                Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<DeveloperCore>(), 5);
                HellishOnslaught.instance.HideMyUI();
            }
            if (LegacyShop.LegShopPos == 2)
            {
                Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<Fuck>());
                //player.GetModPlayer<PlayerFile>().Leg1 = true;
                HellishOnslaught.instance.HideMyUI();
            }
        }
        private void LeftClicky(UIMouseEvent evt, UIElement listeningElement)
        {
            LegacyShop.LegShopPos--;
            if (LegacyShop.LegShopPos == -1)
            {
                LegacyShop.LegShopPos = LegacyShop.LegShopPosMax - 1;
            }
        }
        private void RightClicky(UIMouseEvent evt, UIElement listeningElement)
        {
            LegacyShop.LegShopPos++;
            if (LegacyShop.LegShopPos == LegacyShop.LegShopPosMax)
            {
                LegacyShop.LegShopPos = 0;
            }
        }
    }
    class LegacyShop : UIElement
    {
        public static int LegShopPos = 0;
        public static int LegShopPosMax = 3;
        public override void Draw(SpriteBatch spriteBatch)
        {
            Color color = Color.Lerp(Color.HotPink, Color.SteelBlue, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f)))));
            spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Border"), new Vector2(Main.screenWidth - 128, Main.screenHeight - 220) / 2f, color);
            if (LegShopPos == 0)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Ugly"), new Vector2(Main.screenWidth - 17, Main.screenHeight - 216) / 2f, Color.White);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/DeveloperCore"), new Vector2(Main.screenWidth + 40, Main.screenHeight - 216) / 2f, Color.Gray);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/Fuck"), new Vector2(Main.screenWidth - 124, Main.screenHeight - 216) / 2f, Color.Gray);
            }
            if (LegShopPos == 1)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/DeveloperCore"), new Vector2(Main.screenWidth - 40, Main.screenHeight - 216) / 2f, Color.White);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/Fuck"), new Vector2(Main.screenWidth + 60, Main.screenHeight - 216) / 2f, Color.Gray);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Ugly"), new Vector2(Main.screenWidth - 124, Main.screenHeight - 216) / 2f, Color.Gray);
            }
            if (LegShopPos == 2)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/Fuck"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 216) / 2f, Color.White);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Ugly"), new Vector2(Main.screenWidth + 90, Main.screenHeight - 216) / 2f, Color.Gray);
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/Items/DeveloperCore"), new Vector2(Main.screenWidth - 124, Main.screenHeight - 216) / 2f, Color.Gray);
            }
        }
    }
    internal class Select : UIImageButton
    {
        private int frameCounter = 0;
        private int frame = 0;
        public Select(Texture2D texture) : base(texture)
        {
        }
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            if (frame == 0)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select0"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 1)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select1"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 2)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select2"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 3)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select3"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 4)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select4"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 5)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select5"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 6)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Select6"), new Vector2(Main.screenWidth - 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (IsMouseHovering)
            {
                if (LegacyShop.LegShopPos == 0)
                {
                    Main.hoverItemName = "Random: Chance for Dev Item.";
                }
                if (LegacyShop.LegShopPos == 1)
                {
                    Main.hoverItemName = "Restock: Get 5 Developer Cores.";
                }
                if (LegacyShop.LegShopPos == 2)
                {
                    Main.hoverItemName = "Legacy Item: Two Thousand Twenty";
                }
            }
        }
        public override void Update(GameTime gameTime)
        {
            frameCounter++;
            if (frameCounter >= 30)
            {
                frameCounter = 0;
                frame++;
                if (frame == 7)
                {
                    frame = 0;
                }
            }
        }
    }
    internal class LeftButton : UIImageButton
    {
        private int frameCounter = 0;
        private int frame = 0;
        public LeftButton(Texture2D texture) : base(texture)
        {
        }
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            if (frame == 0)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left0"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 1)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left1"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 2)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left2"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 3)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left3"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 4)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left4"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 5)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left5"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 6)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Left6"), new Vector2(Main.screenWidth - 96, Main.screenHeight - 146) / 2f, Color.White);
            }
        }
        public override void Update(GameTime gameTime)
        {
            frameCounter++;
            if (frameCounter >= 30)
            {
                frameCounter = 0;
                frame++;
                if (frame == 7)
                {
                    frame = 0;
                }
            }
        }
    }
    internal class RightButton : UIImageButton
    {
        private int frameCounter = 0;
        private int frame = 0;
        public RightButton(Texture2D texture) : base(texture)
        {
        }
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            if (frame == 0)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right0"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 1)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right1"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 2)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right2"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 3)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right3"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 4)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right4"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 5)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right5"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
            if (frame == 6)
            {
                spriteBatch.Draw(ModContent.GetTexture("HellishOnslaught/UI/Right6"), new Vector2(Main.screenWidth + 32, Main.screenHeight - 146) / 2f, Color.White);
            }
        }
        public override void Update(GameTime gameTime)
        {
            frameCounter++;
            if (frameCounter >= 30)
            {
                frameCounter = 0;
                frame++;
                if (frame == 7)
                {
                    frame = 0;
                }
            }
        }
    }
}