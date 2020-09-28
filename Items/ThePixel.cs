using HellishOnslaught.Buffs;
using HellishOnslaught.TheQuarry;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class ThePixel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(WorldFile.CreeperAwMan ? WorldFile.Copypaste() : "The Pixel"); //The Best Pixel is the Ultimate Pixel.
        }
        public override void SetDefaults()
        {
            item.width = 2;
            item.height = 2;
            item.maxStack = 1;
            item.value = 0;
            item.rare = ItemRarityID.Cyan;
        }































        //Welcome to the Void.


































        public override Color? GetAlpha(Color lightColor)
        {
            if (!WorldFile.CreeperAwMan)
            {
                return Color.Black;
            }
            return Color.Transparent;
        }
        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (WorldFile.CreeperAwMan)
            {
                item.width = 40;
                item.height = 32;
                item.maxStack = 1;
                item.value = 10000000;
                item.useStyle = ItemUseStyleID.HoldingOut;
                item.noMelee = true;
                item.damage = 9001;
                item.useTime = 30;
                item.useAnimation = 30;
                item.noUseGraphic = true;
                item.channel = true;
                item.rare = ItemRarityID.Cyan;
                item.shoot = ModContent.ProjectileType<BallpeenProjectile>();

                Texture2D texture = Main.itemTexture[item.type];
                var shabagel = 1.5f;
                var bloop = new Vector2(origin.X + 15, origin.Y + 12);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (1 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (1 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (1 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (1 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (1 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (1 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (1 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (1 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (2 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (2 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (2 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (2 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (2 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (2 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (2 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (3 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (3 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (3 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (3 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (3 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (3 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (3 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (3 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (3 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (3 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (3 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (3 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (3 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (3 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (3 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (3 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (3 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (3 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (3 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (4 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (4 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (4 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (4 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (4 * shabagel)), null, Colors(11), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (4 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (4 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (4 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (4 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (4 * shabagel)), null, Colors(10), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (4 * shabagel)), null, Colors(9), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (4 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (4 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (4 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (4 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (4 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (4 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (4 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (4 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (5 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (5 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (5 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (5 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (5 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (5 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (5 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (5 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (5 * shabagel)), null, Colors(7), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (5 * shabagel)), null, Colors(9), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (5 * shabagel)), null, Colors(10), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (5 * shabagel)), null, Colors(9), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (5 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (5 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (5 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (5 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (5 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (5 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (5 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (6 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (6 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (6 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (6 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (6 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (6 * shabagel)), null, Colors(11), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (6 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (6 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (6 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (6 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (6 * shabagel)), null, Colors(7), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (6 * shabagel)), null, Colors(9), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (6 * shabagel)), null, Colors(7), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (6 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (6 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (6 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (6 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (6 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (6 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (7 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (7 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (7 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (7 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (7 * shabagel)), null, Colors(0), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (7 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (7 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (7 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (7 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (7 * shabagel)), null, Colors(8), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (7 * shabagel)), null, Colors(10), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (7 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (7 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (7 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (7 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (7 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (7 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (7 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (8 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (8 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (8 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (8 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (8 * shabagel)), null, Colors(11), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (8 * shabagel)), null, Colors(12), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (8 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (8 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (8 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (8 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (8 * shabagel)), null, Colors(6), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (8 * shabagel)), null, Colors(17), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (8 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (8 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (8 * shabagel)), null, Colors(4), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (8 * shabagel)), null, Colors(4), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (8 * shabagel)), null, Colors(4), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (8 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (9 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (9 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (9 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (9 * shabagel)), null, Colors(18), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (9 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (9 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (9 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (9 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (9 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (9 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (9 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (9 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (9 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (9 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (9 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (9 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (10 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (10 * shabagel)), null, Colors(22), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (10 * shabagel)), null, Colors(20), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (10 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (10 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (10 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (10 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (10 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (10 * shabagel)), null, Colors(3), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (10 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (10 * shabagel)), null, Colors(2), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (10 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (10 * shabagel)), null, Colors(14), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (10 * shabagel)), null, Colors(13), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (10 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (10 * shabagel)), null, Colors(5), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (11 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (11 * shabagel)), null, Colors(23), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (11 * shabagel)), null, Colors(21), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (11 * shabagel)), null, Colors(21), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (11 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (11 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (11 * shabagel)), null, Colors(16), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (11 * shabagel)), null, Colors(15), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (11 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (12 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (12 * shabagel)), null, Colors(23), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (12 * shabagel)), null, Colors(20), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (12 * shabagel)), null, Colors(21), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (12 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (12 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (12 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (12 * shabagel)), null, Colors(1), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (13 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (13 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (13 * shabagel)), null, Colors(23), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (13 * shabagel)), null, Colors(23), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (13 * shabagel)), null, Colors(21), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (13 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (14 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (14 * shabagel)), null, Colors(20), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (14 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (14 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (14 * shabagel)), null, Colors(19), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (14 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (15 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (15 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (15 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (15 * shabagel)), null, Colors(24), 0f, bloop, new Vector2(scale), SpriteEffects.None, 0);
            }
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            if (WorldFile.CreeperAwMan)
            {
                item.width = 40;
                item.height = 32;

                Texture2D texture = Main.itemTexture[item.type];
                var shabagel = 2f;
                var position = item.position - Main.screenPosition;
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (1 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (1 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (1 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (1 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (1 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (1 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (1 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (1 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (2 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (2 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (2 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (2 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (2 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (2 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (2 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (3 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (3 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (3 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (3 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (3 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (3 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (3 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (3 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (3 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (3 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (3 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (3 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (3 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (3 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (3 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (3 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (3 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (3 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (3 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (4 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (4 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (4 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (4 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (4 * shabagel)), Colors(11));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (4 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (4 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (4 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (4 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (4 * shabagel)), Colors(10));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (4 * shabagel)), Colors(9));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (4 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (4 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (4 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (4 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (4 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (4 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (4 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (4 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (5 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (5 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (5 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (5 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (5 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (5 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (5 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (5 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (5 * shabagel)), Colors(7));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (5 * shabagel)), Colors(9));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (5 * shabagel)), Colors(10));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (5 * shabagel)), Colors(9));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (5 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (5 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (5 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (5 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (5 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (5 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (5 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (6 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (6 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (6 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (6 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (6 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (6 * shabagel)), Colors(11));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (6 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (6 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (6 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (6 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (6 * shabagel)), Colors(7));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (6 * shabagel)), Colors(9));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (6 * shabagel)), Colors(7));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (6 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (6 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (6 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (6 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (6 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (6 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (7 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (7 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (7 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (7 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (7 * shabagel)), Colors(0));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (7 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (7 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (7 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (7 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (7 * shabagel)), Colors(8));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (7 * shabagel)), Colors(10));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (7 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (7 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (7 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (7 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (7 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (7 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (7 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (8 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (8 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (8 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (8 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (8 * shabagel)), Colors(11));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (8 * shabagel)), Colors(12));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (8 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (8 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (8 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (8 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (8 * shabagel)), Colors(6));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (8 * shabagel)), Colors(17));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (8 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (8 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (8 * shabagel)), Colors(4));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (8 * shabagel)), Colors(4));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (8 * shabagel)), Colors(4));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (8 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (9 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (9 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (9 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (9 * shabagel)), Colors(18));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (9 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (9 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (9 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (9 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (9 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (9 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (9 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (9 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (9 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (9 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (9 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (9 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (10 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (10 * shabagel)), Colors(22));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (10 * shabagel)), Colors(20));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (10 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (10 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (10 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (10 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (10 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (10 * shabagel)), Colors(3));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (10 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (10 * shabagel)), Colors(2));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (10 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (10 * shabagel)), Colors(14));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (10 * shabagel)), Colors(13));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (10 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (10 * shabagel)), Colors(5));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (11 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (11 * shabagel)), Colors(23));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (11 * shabagel)), Colors(21));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (11 * shabagel)), Colors(21));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (11 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (11 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (11 * shabagel)), Colors(16));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (11 * shabagel)), Colors(15));
                spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (11 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (12 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (12 * shabagel)), Colors(23));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (12 * shabagel)), Colors(20));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (12 * shabagel)), Colors(21));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (12 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (12 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (12 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (12 * shabagel)), Colors(1));
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (13 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (13 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (13 * shabagel)), Colors(23));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (13 * shabagel)), Colors(23));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (13 * shabagel)), Colors(21));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (13 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (14 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (14 * shabagel)), Colors(20));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (14 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (14 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (14 * shabagel)), Colors(19));
                spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (14 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (15 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (15 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (15 * shabagel)), Colors(24));
                spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (15 * shabagel)), Colors(24));
            }
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) { if (WorldFile.CreeperAwMan) { var A = new TooltipLine(mod, "LEMONEYBOMB", Red.L()); var B = new TooltipLine(mod, "LEMONEYBOMB", Green.E()); var C = new TooltipLine(mod, "LEMONEYBOMB", Blue.M()); var D = new TooltipLine(mod, "LEMONEYBOMB", White.O()); var E = new TooltipLine(mod, "LEMONEYBOMB", Teal.N()); var F = new TooltipLine(mod, "LEMONEYBOMB", Pink.E()); var G = new TooltipLine(mod, "LEMONEYBOMB", Yellow.Y()); var H = new TooltipLine(mod, "LEMONEYBOMB", LightsReach.Bomb()); foreach (TooltipLine line in tooltips) { if (line.mod == "Terraria" && line.Name == "ItemName") { line.text = "[c/FF0000:" + A.text + "][c/00FF00:" + B.text + "][c/0000FF:" + C.text + "][c/000000:" + D.text + "][c/00FFFF:" + E.text + "][c/FF00FF:" + F.text + "][c/FFFF00:" + G.text + "][c/FFFFFF:" + H.text + "]"; } if (line.mod == "Terraria" && line.Name == "Damage") { var DevColor = Color.Lerp(Color.LightGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))).Hex3(); line.text = "[c/" + DevColor + ":" + item.damage + " Undefined Damage]"; }} tooltips.Add(new TooltipLine(mod, "Bread", QuarryWorldFile.MoreBread(false, false, false, false, false) + "\nYou Can Check.\n" + PlayerFile.EEEEE(true, true, true, true, true))); var Developer = new TooltipLine(mod, "Dev", Blundergat.NoSus()); Developer.overrideColor = Color.Lerp(Color.LimeGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))); tooltips.Add(Developer); tooltips.Add(new TooltipLine(mod, "Cheater", "Wait a second-... Another?")); }}

        public static Color Colors(int type)
        {
            if (type == 0)
            {
                return new Color(147, 75, 80);
            }
            if (type == 1)
            {
                return new Color(45, 7, 14);
            }
            if (type == 2)
            {
                return new Color(130, 44, 48);
            }
            if (type == 3)
            {
                return new Color(92, 25, 36);
            }
            if (type == 4)
            {
                return new Color(62, 13, 21);
            }
            if (type == 5)
            {
                return new Color(51, 10, 17);
            }
            if (type == 6)
            {
                return new Color(234, 220, 236);
            }
            if (type == 7)
            {
                return new Color(222, 200, 226);
            }
            if (type == 8)
            {
                return new Color(227, 209, 231);
            }
            if (type == 9)
            {
                return new Color(211, 183, 217);
            }
            if (type == 10)
            {
                return new Color(173, 122, 185);
            }
            if (type == 11)
            {
                return new Color(110, 124, 192);
            }
            if (type == 12)
            {
                return new Color(51, 58, 95);
            }
            if (type == 13)
            {
                return new Color(21, 42, 16);
            }
            if (type == 14)
            {
                return new Color(149, 161, 134);
            }
            if (type == 15)
            {
                return new Color(97, 114, 82);
            }
            if (type == 16)
            {
                return new Color(62, 86, 50);
            }
            if (type == 17)
            {
                return new Color(165, 109, 101);
            }
            if (type == 18)
            {
                return new Color(97, 97, 97);
            }
            if (type == 19)
            {
                return new Color(70, 70, 70);
            }
            if (type == 20)
            {
                return new Color(46, 46, 46);
            }
            if (type == 21)
            {
                return new Color(32, 32, 32);
            }
            if (type == 22)
            {
                return new Color(28, 28, 28);
            }
            if (type == 23)
            {
                return new Color(23, 23, 23);
            }
            if (type == 24)
            {
                return new Color(19, 19, 19);
            }
            return Color.Transparent;
        }

        private readonly int[,] TexturalSalami = {
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
            { 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 199, 99, 3, 3, 1, 2, 5, 18, 22, 1, 22, 99, 99, 99, 3, 3 },
        }; // You know I had to do it to em.
    }
    public class BallpeenProjectile : ModProjectile
    {
        public int counter = 0;
        public int chargeLevel = 0;

        public override string Texture => "HellishOnslaught/Items/ThePixel";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(Red.L() + Green.E() + Blue.M() + White.O() + Teal.N() + Pink.E() + Yellow.Y() + LightsReach.Bomb());
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 32;
            projectile.friendly = false;
            projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.magic = true;
            projectile.ignoreWater = true;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = Main.projectileTexture[projectile.type];
            SpriteEffects spriteEffects = SpriteEffects.None;
            if (projectile.spriteDirection == -1)
            {
                spriteEffects = SpriteEffects.FlipHorizontally;
            }
            Rectangle sourceRectangle = new Rectangle(0, 0, texture.Width, texture.Height);
            Vector2 origin = sourceRectangle.Size() / 2f;

            projectile.scale = 2f;

            var shabagel = projectile.spriteDirection == 1 ? (int)projectile.scale : (int)-projectile.scale;
            var shabagel2 = projectile.spriteDirection == 1 ? (int)shabagel : (int)-shabagel;
            var position = projectile.Center - Main.screenPosition + new Vector2(projectile.spriteDirection == 1 ? 3f : -3f, -12f);

            Player player = Main.player[projectile.owner];

            float num1 = 12f;
            Vector2 vector2 = new Vector2(player.position.X + player.width * 0.5f, player.position.Y + player.height * 0.5f);
            float f1 = Main.mouseX + Main.screenPosition.X - vector2.X;
            float f2 = Main.mouseY + Main.screenPosition.Y - vector2.Y;
            if (player.gravDir == -1.0)
                f2 = Main.screenPosition.Y + Main.screenHeight - Main.mouseY - vector2.Y;
            float num4 = (float)Math.Sqrt(f1 * (double)f1 + f2 * (double)f2);
            float num5;
            if (float.IsNaN(f1) && float.IsNaN(f2) || f1 == 0.0 && f2 == 0.0)
            {
                f1 = player.direction;
                f2 = 0.0f;
                num5 = num1;
            }
            else
                num5 = num1 / num4;
            float SpeedX = f1 * num5;
            float SpeedY = f2 * num5;

            var Vloop = new Vector2(SpeedX, SpeedY).ToRotation() + (projectile.spriteDirection == 1 ? MathHelper.ToRadians(0f) : MathHelper.ToRadians(180f));

            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (1 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (2 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (19 * shabagel), (int)position.Y + (3 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(11), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(10), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(9), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (19 * shabagel), (int)position.Y + (4 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(7), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(9), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(10), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(9), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (19 * shabagel), (int)position.Y + (5 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(11), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(7), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(9), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(7), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (6 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(0), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(8), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(10), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (7 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(11), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(12), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(6), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(17), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(4), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(4), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(4), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (8 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(18), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (9 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(22), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(20), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (9 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(3), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(2), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(14), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(13), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (10 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(5), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(23), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(21), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(21), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (6 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (7 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (8 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (10 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (11 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (12 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (13 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (14 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(16), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(15), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (18 * shabagel), (int)position.Y + (11 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(23), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(20), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(21), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (15 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (16 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (17 * shabagel), (int)position.Y + (12 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(1), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(23), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(23), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(21), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (13 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X, (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(20), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(19), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (5 * shabagel), (int)position.Y + (14 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (1 * shabagel), (int)position.Y + (15 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (2 * shabagel), (int)position.Y + (15 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (3 * shabagel), (int)position.Y + (15 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            spriteBatch.Draw(texture, new Vector2((int)position.X + (4 * shabagel), (int)position.Y + (15 * shabagel2)).RotatedBy(Vloop, player.MountedCenter - Main.screenPosition), sourceRectangle, ThePixel.Colors(24), projectile.rotation, origin, projectile.scale, spriteEffects, 0f);
            return false;
        }
        public override void AI()
        {
            Player player = Main.player[projectile.owner];

            float num = 1.57079637f;
            Vector2 vector = player.RotatedRelativePoint(player.MountedCenter, true);
            projectile.ai[0] += 1f;
            int num2 = 0;
            if (projectile.ai[0] >= 30f)
            {
                num2++;
            }
            if (projectile.ai[0] >= 60f)
            {
                num2++;
            }
            if (projectile.ai[0] >= 90f)
            {
                num2++;
            }
            int num3 = 24;
            int num4 = 6;
            projectile.ai[1] += 1f;
            bool flag = false;
            if (projectile.ai[1] >= num3 - num4 * num2)
            {
                projectile.ai[1] = 0f;
                flag = true;
            }
            if (projectile.ai[1] == 1f && projectile.ai[0] != 1f)
            {
                Vector2 vector2 = Vector2.UnitX * 24f;
                vector2 = vector2.RotatedBy(projectile.rotation - 1.57079637f, default);
                Vector2 value = projectile.Center + vector2;
                for (int i = 0; i < 3; i++)
                {
                    int num5 = Dust.NewDust(value - Vector2.One * 8f, 16, 16, 74, projectile.velocity.X / 2f, projectile.velocity.Y / 2f, 100);
                    Main.dust[num5].position.Y -= 0.3f;
                    Main.dust[num5].velocity *= 0.66f;
                    Main.dust[num5].noGravity = true;
                    Main.dust[num5].scale = 1.4f;
                }
            }
            if (flag && Main.myPlayer == projectile.owner)
            {
                if (player.channel && !player.noItems && !player.CCed)
                {
                    float scaleFactor = player.inventory[player.selectedItem].shootSpeed * projectile.scale;
                    Vector2 vector3 = vector;
                    Vector2 value2 = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY) - vector3;
                    if (player.gravDir == -1f)
                    {
                        value2.Y = Main.screenHeight - Main.mouseY + Main.screenPosition.Y - vector3.Y;
                    }
                    Vector2 vector4 = Vector2.Normalize(value2);
                    if (float.IsNaN(vector4.X) || float.IsNaN(vector4.Y))
                    {
                        vector4 = -Vector2.UnitY;
                    }
                    vector4 *= scaleFactor;
                    if (vector4.X != projectile.velocity.X || vector4.Y != projectile.velocity.Y)
                    {
                        projectile.netUpdate = true;
                    }
                    projectile.velocity = vector4;
                }
            }
            projectile.position = player.RotatedRelativePoint(player.MountedCenter, true) - projectile.Size / 2f;
            projectile.rotation = projectile.velocity.ToRotation() + num;
            if (projectile.rotation >= MathHelper.ToRadians(360f))
            {
                projectile.rotation -= MathHelper.ToRadians(360f);
            }
            if (projectile.rotation < 0)
            {
                projectile.rotation += MathHelper.ToRadians(360f);
            }
            projectile.direction = projectile.rotation <= MathHelper.ToRadians(180f) && projectile.rotation >= MathHelper.ToRadians(0f) ? 1 : -1;
            projectile.spriteDirection = projectile.direction;
            projectile.timeLeft = 2;
            player.ChangeDir(projectile.direction);
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;

            float num1 = 12f;
            Vector2 vector5 = new Vector2(player.position.X + player.width * 0.5f, player.position.Y + player.height * 0.5f);
            float f1 = Main.mouseX + Main.screenPosition.X - vector5.X;
            float f2 = Main.mouseY + Main.screenPosition.Y - vector5.Y;
            if (player.gravDir == -1.0)
                f2 = Main.screenPosition.Y + Main.screenHeight - Main.mouseY - vector5.Y;
            float num8 = (float)Math.Sqrt(f1 * (double)f1 + f2 * (double)f2);
            float num9;
            if (float.IsNaN(f1) && float.IsNaN(f2) || f1 == 0.0 && f2 == 0.0)
            {
                f1 = player.direction;
                f2 = 0.0f;
                num9 = num1;
            }
            else
                num9 = num1 / num8;
            float SpeedX = f1 * num9;
            float SpeedY = f2 * num9;

            var Vloop = new Vector2(SpeedX, SpeedY).ToRotation() + (projectile.spriteDirection == 1 ? MathHelper.ToRadians(0f) : MathHelper.ToRadians(180f));

            player.itemRotation = Vloop;

            counter++;

            if (counter >= 180)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 93, 1, 1f);
                Recharge.RechargeRequired = true;
                player.AddBuff(ModContent.BuffType<Recharge>(), 1, true);
                chargeLevel = 3;
            }

            else if (counter >= 90)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 93);
                chargeLevel = 2;
            }

            else if (counter >= 30)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 13);
                chargeLevel = 1;
            }

            else if (counter >= 0)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 13, 1, -1f);
                chargeLevel = 0;
            }

            if (!player.channel)
            {
                projectile.Kill();
            }
        }

        public override void Kill(int timeLeft)
        {
            Player player = Main.player[projectile.owner];
            if (projectile.owner == Main.myPlayer)
            {
                float num1 = 12f;
                Vector2 vector2 = new Vector2(player.position.X + player.width * 0.5f, player.position.Y + player.height * 0.5f);
                float f1 = Main.mouseX + Main.screenPosition.X - vector2.X;
                float f2 = Main.mouseY + Main.screenPosition.Y - vector2.Y;
                if (player.gravDir == -1.0)
                    f2 = Main.screenPosition.Y + Main.screenHeight - Main.mouseY - vector2.Y;
                float num4 = (float)Math.Sqrt(f1 * (double)f1 + f2 * (double)f2);
                float num5;
                if (float.IsNaN(f1) && float.IsNaN(f2) || f1 == 0.0 && f2 == 0.0)
                {
                    f1 = player.direction;
                    f2 = 0.0f;
                    num5 = num1;
                }
                else
                    num5 = num1 / num4;
                float SpeedX = f1 * num5;
                float SpeedY = f2 * num5;
                switch (chargeLevel)
                {
                    case 0:
                        Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 89, 1, -1f);
                        break;
                    case 1:
                        Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 89);
                        Projectile.NewProjectile(vector2.X, vector2.Y, SpeedX, SpeedY, ModContent.ProjectileType<Whack>(), projectile.damage / 3, 1f, player.whoAmI);
                        break;
                    case 2:
                        Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 88);
                        Projectile.NewProjectile(vector2.X, vector2.Y, SpeedX, SpeedY, ModContent.ProjectileType<Thwack>(), projectile.damage / 3, 1f, player.whoAmI, 0f);
                        break;
                    case 3:
                        Recharge.RechargeRequired = false;
                        Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 88);
                        Projectile.NewProjectile(vector2.X, vector2.Y, SpeedX, SpeedY, ModContent.ProjectileType<Thwack>(), (projectile.damage) + (counter - 180), 1f, player.whoAmI, 1f);
                        break;
                }
            }
        }
    }

    internal class Thwack : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/EHHHH";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(Red.L() + Green.E() + Blue.M() + White.O() + Teal.N() + Pink.E() + Yellow.Y() + " Beam");
        }
        public override void SetDefaults()
        {
            projectile.width = 36;
            projectile.height = 36;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.alpha = 255;
            projectile.timeLeft = 3600;
            projectile.tileCollide = false;
        }

        internal const float charge = 5f;
        public float LaserLength { get { return projectile.localAI[1]; } set { projectile.localAI[1] = value; } }
        public const float LaserLengthMax = 2000f;
        int multiplier = 1;
        int laserLifeTime = 120;
        public override bool ShouldUpdatePosition()
        {
            return true;
        }
        public override void DrawBehind(int index, List<int> drawCacheProjsBehindNPCsAndTiles, List<int> drawCacheProjsBehindNPCs, List<int> drawCacheProjsBehindProjectiles, List<int> drawCacheProjsOverWiresUI)
        {
            drawCacheProjsBehindProjectiles.Add(index);
        }
        float attackCounter = 0;
        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write(attackCounter);
        }
        public override void ReceiveExtraAI(BinaryReader reader)
        {
            attackCounter = reader.ReadSingle();
        }

        float rotationAdd = 0f;
        public override void AI()
        {
            Vector2? vector56 = null;
            if (projectile.velocity.HasNaNs() || projectile.velocity == Vector2.Zero)
            {
                projectile.velocity = -Vector2.UnitY;
            }

            projectile.position = (Main.player[Main.myPlayer].Center + new Vector2(projectile.velocity.X, projectile.velocity.Y) / 2f) - new Vector2(projectile.width, projectile.height) / 2f;

            if (projectile.velocity.HasNaNs() || projectile.velocity == Vector2.Zero)
            {
                projectile.velocity = -Vector2.UnitY;
            }

            float num820 = 0.5f;

            if (projectile.ai[0] == 1f)
            {
                num820 = 1f;
            }

            ref float reference = ref projectile.localAI[0];
            ref float reference37 = ref reference;
            float num74 = reference;
            reference37 = num74 + 1f;
            if (projectile.localAI[0] >= 30f)
            {
                projectile.Kill();
                return;
            }
            projectile.scale = (float)Math.Sin(projectile.localAI[0] * (float)Math.PI / 180f) * 10f * num820;
            if (projectile.scale > num820)
            {
                projectile.scale = num820;
            }

            float num823 = projectile.velocity.ToRotation();

            num823 += projectile.ai[1];

            projectile.rotation = num823 - (float)Math.PI / 2f;
            projectile.velocity = num823.ToRotationVector2();
            float num824 = 0f;
            float num825 = 0f;
            Vector2 samplingPoint = projectile.Center;
            if (vector56.HasValue)
            {
                samplingPoint = vector56.Value;
            }

            num824 = 3f;
            num825 = projectile.width;

            float[] array5 = new float[(int)num824];
            Collision.LaserScan(samplingPoint, projectile.velocity, num825 * projectile.scale, 2400f, array5);
            float num826 = 0f;
            for (int num827 = 0; num827 < array5.Length; num827++)
            {
                num826 += array5[num827];
            }
            num826 /= num824;
            float amount = 0.5f;

            projectile.localAI[1] = MathHelper.Lerp(projectile.localAI[1], num826, amount);

            Vector2 vector57 = projectile.Center + projectile.velocity * (projectile.localAI[1] - 14f);
            for (int num828 = 0; num828 < 2; num828++)
            {
                float num829 = projectile.velocity.ToRotation() + ((Main.rand.Next(2) == 1) ? (-1f) : 1f) * ((float)Math.PI / 2f);
                float num830 = (float)Main.rand.NextDouble() * 2f + 2f;
                Vector2 vector58 = new Vector2((float)Math.Cos(num829) * num830, (float)Math.Sin(num829) * num830);
                int num831 = Dust.NewDust(vector57, 0, 0, 229, vector58.X, vector58.Y);
                Main.dust[num831].noGravity = true;
                Main.dust[num831].scale = 1.7f;
            }
            if (Main.rand.Next(5) == 0)
            {
                Vector2 value32 = projectile.velocity.RotatedBy(1.5707963705062866) * ((float)Main.rand.NextDouble() - 0.5f) * projectile.width;
                int num832 = Dust.NewDust(vector57 + value32 - Vector2.One * 4f, 8, 8, 31, 0f, 0f, 100, default(Color), 1.5f);
                Dust dust119 = Main.dust[num832];
                Dust dust2 = dust119;
                dust2.velocity *= 0.5f;
                Main.dust[num832].velocity.Y = 0f - Math.Abs(Main.dust[num832].velocity.Y);
            }

            DelegateMethods.v3_1 = new Vector3(0.3f, 0.65f, 0.7f);
            Utils.PlotTileLine(projectile.Center, projectile.Center + projectile.velocity * projectile.localAI[1], (float)projectile.width * projectile.scale, DelegateMethods.CastLight);
        }


        public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
        {
            float collisionPoint = 0f;
            return (Collision.CheckAABBvLineCollision(targetHitbox.TopLeft(), targetHitbox.Size(), projectile.Center, projectile.Center + projectile.velocity * projectile.localAI[1], projHitbox.Width, ref collisionPoint));
        }
        public override bool? CanCutTiles()
        {
            DelegateMethods.tilecut_0 = Terraria.Enums.TileCuttingContext.AttackProjectile;
            Utils.PlotTileLine(projectile.Center, projectile.Center + projectile.velocity * projectile.localAI[1], (float)projectile.width * projectile.scale * 2, new Utils.PerLinePoint(CutTilesAndBreakWalls));
            return true;
        }

        private bool CutTilesAndBreakWalls(int x, int y)
        {
            return DelegateMethods.CutTiles(x, y);
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            if (projectile.velocity == Vector2.Zero)
            {
                return false;
            }
            Texture2D texture2D18 = Main.projectileTexture[projectile.type];
            Texture2D texture2D19 = mod.GetTexture("Projectiles/AHHHH");
            Texture2D texture2D20 = mod.GetTexture("Projectiles/UHHHH");
            float num203 = projectile.localAI[1];
            Microsoft.Xna.Framework.Color color40 = new Microsoft.Xna.Framework.Color(255, 255, 255, 255);
            spriteBatch.Draw(texture2D18, projectile.Center - Main.screenPosition, null, color40, projectile.rotation, texture2D18.Size() / 2f, projectile.scale, SpriteEffects.None, 0f);
            num203 -= (float)(texture2D18.Height / 2 + texture2D20.Height) * projectile.scale;
            Vector2 center3 = projectile.Center;
            center3 += projectile.velocity * projectile.scale * texture2D18.Height / 2f;
            if (num203 > 0f)
            {
                float num204 = 0f;
                Microsoft.Xna.Framework.Rectangle value21 = new Microsoft.Xna.Framework.Rectangle(0, 16 * (projectile.timeLeft / 3 % 5), texture2D19.Width, 16);
                while (num204 + 1f < num203)
                {
                    if (num203 - num204 < (float)value21.Height)
                    {
                        value21.Height = (int)(num203 - num204);
                    }
                    spriteBatch.Draw(texture2D19, center3 - Main.screenPosition, value21, color40, projectile.rotation, new Vector2(value21.Width / 2, 0f), projectile.scale, SpriteEffects.None, 0f);
                    num204 += (float)value21.Height * projectile.scale;
                    center3 += projectile.velocity * value21.Height * projectile.scale;
                    value21.Y += 16;
                    if (value21.Y + value21.Height > texture2D19.Height)
                    {
                        value21.Y = 0;
                    }
                }
            }
            spriteBatch.Draw(texture2D20, center3 - Main.screenPosition, null, color40, projectile.rotation, texture2D20.Frame().Top(), projectile.scale, SpriteEffects.None, 0f);
            return false;
        }
    }

    internal class Whack : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/Ohhhh";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(Red.L() + Green.E() + Blue.M() + White.O() + Teal.N() + Pink.E() + Yellow.Y() + " Shot");
            Main.projFrames[projectile.type] = 3;
        }

        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.extraUpdates = 2;
        }

        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, 74,
                    projectile.velocity.X, projectile.velocity.Y, 200, Scale: 1f);
                dust.velocity += projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 2)
                {
                    projectile.frame = 0;
                }
            }
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}
