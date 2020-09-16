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
        public override Color? GetAlpha(Color lightColor)
        {
            if (!WorldFile.CreeperAwMan)
            {
                return Color.Black;
            }
            return Color.Transparent;
        }
        public override void SetDefaults()
        {
            item.width = 2;
            item.height = 2;
            item.maxStack = 1;
            item.value = 0;
        }































        //Welcome to the Void.


































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
                item.damage = 900001;
                item.magic = true;
                item.useTime = 30;
                item.useAnimation = 30;
                item.autoReuse = true;
                item.shoot = ModContent.ProjectileType<BallpeenProjectile>();

                Texture2D texture = HellishOnslaught.instance.GetTexture("Items/ThePixel");
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

                Texture2D texture = HellishOnslaught.instance.GetTexture("Items/ThePixel");
                var shabagel = 1.5f;
                var position =  item.position;
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

        public override void ModifyTooltips(List<TooltipLine> tooltips) { if (WorldFile.CreeperAwMan) { var A = new TooltipLine(mod, "LEMONEYBOMB", Red.L()); var B = new TooltipLine(mod, "LEMONEYBOMB", Green.E()); var C = new TooltipLine(mod, "LEMONEYBOMB", Blue.M()); var D = new TooltipLine(mod, "LEMONEYBOMB", White.O()); var E = new TooltipLine(mod, "LEMONEYBOMB", Teal.N()); var F = new TooltipLine(mod, "LEMONEYBOMB", Pink.E()); var G = new TooltipLine(mod, "LEMONEYBOMB", Yellow.Y()); var H = new TooltipLine(mod, "LEMONEYBOMB", LightsReach.Bomb()); foreach (TooltipLine line in tooltips) { if (line.mod == "Terraria" && line.Name == "ItemName") { line.text = "[c/FF0000:" + A.text + "][c/00FF00:" + B.text + "][c/0000FF:" + C.text + "][c/000000:" + D.text + "][c/00FFFF:" + E.text + "][c/FF00FF:" + F.text + "][c/FFFF00:" + G.text + "][c/FFFFFF:" + H.text + "]"; }} tooltips.Add(new TooltipLine(mod, "Bread", QuarryWorldFile.MoreBread(false, false, false, false, false) + "\nYou Can Check.\n" + PlayerFile.EEEEE(true, true, true, true, true))); }}

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
            projectile.height = 40;
            projectile.friendly = false;
            projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.magic = true;
            projectile.ignoreWater = true;
            projectile.alpha = 255;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = HellishOnslaught.instance.GetTexture("Items/ThePixel");
            var shabagel = 1.5f;
            var position = projectile.position;
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (1 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (1 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (2 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (3 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(11));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(10));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(9));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (4 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(7));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(9));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(10));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(9));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (19 * shabagel), position.Y + (5 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (6 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(11));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(7));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(9));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(7));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (6 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(0));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(8));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(10));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (7 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(11));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(12));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(6));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(17));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(4));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(4));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(4));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (8 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(18));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (9 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(22));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(20));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (9 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(3));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(2));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(14));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(13));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (10 * shabagel)), ThePixel.Colors(5));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(23));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(21));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(21));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (6 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (7 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (8 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (10 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (11 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (12 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (13 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (14 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(16));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(15));
            spriteBatch.Draw(texture, new Vector2(position.X + (18 * shabagel), position.Y + (11 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (12 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(23));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(20));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(21));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (15 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (16 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X + (17 * shabagel), position.Y + (12 * shabagel)), ThePixel.Colors(1));
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (13 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (13 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (13 * shabagel)), ThePixel.Colors(23));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (13 * shabagel)), ThePixel.Colors(23));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (13 * shabagel)), ThePixel.Colors(21));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (13 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y + (14 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (14 * shabagel)), ThePixel.Colors(20));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (14 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (14 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (14 * shabagel)), ThePixel.Colors(19));
            spriteBatch.Draw(texture, new Vector2(position.X + (5 * shabagel), position.Y + (14 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (1 * shabagel), position.Y + (15 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (2 * shabagel), position.Y + (15 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (3 * shabagel), position.Y + (15 * shabagel)), ThePixel.Colors(24));
            spriteBatch.Draw(texture, new Vector2(position.X + (4 * shabagel), position.Y + (15 * shabagel)), ThePixel.Colors(24));
            return true;
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
            projectile.spriteDirection = projectile.direction;
            projectile.timeLeft = 2;
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = (float)Math.Atan2(projectile.velocity.Y * projectile.direction, projectile.velocity.X * projectile.direction);

            counter++;

            if (counter >= 90)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 93);
                chargeLevel = 3;
            }

            else if (counter >= 90)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 101);
                chargeLevel = 2;
            }

            else if (counter >= 30)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 13);
                chargeLevel = 1;
            }

            else if (counter >= 30)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 13);
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
                        Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 89);
                        Projectile.NewProjectile(vector2.X, vector2.Y, SpeedX, SpeedY, ModContent.ProjectileType<Whack>(), projectile.damage, 1f, player.whoAmI);
                        break;
                }
            }
        }
    }

    internal class Whack : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/UHHHH";
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
