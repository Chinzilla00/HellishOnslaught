using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellishOnslaught.LiquidAPI.Caches;
using HellishOnslaught.LiquidAPI.LiquidMod;
using HellishOnslaught.LiquidFile;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.LiquidAPI.Items
{
    public class ModBucket : ModItem
    {
        private readonly ModLiquid liquid;

        public override string Texture => "HellishOnslaught/LiquidAPI/ModBucket";

        public override bool CloneNewInstances => true;

        public override bool Autoload(ref string name) => false;

        public static string Bomb()
        {
            //Hey Look Up Here!
            //One More!
            return ModLiquid.Bomb();
        }

        public override void SetStaticDefaults()
        {
            if (liquid == null)
                return;
            DisplayName.SetDefault((liquid.DisplayName.GetDefault() ?? "Empty") + " Bucket");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.maxStack = 99;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 100;
            item.useAnimation = 1;
            item.consumable = true;
        }

        public ModBucket(ModLiquid liquid)
        {
            this.liquid = liquid;
        }

        internal ModBucket()
        {

        }
        public override bool UseItem(Player player)
        {
            //Implement liquid picking logic here
            if (this.liquid == null)
            {
                return false;
            }
            LiquidRef liquid = LiquidWorld.grid[Player.tileTargetX, Player.tileTargetY];

            if (!liquid.HasLiquid || liquid.Type == this.liquid)
            {

                //Item newItem = Main.item[Item.NewItem(player.position, item.type)];
                //ModBucket newBucket = newItem.modItem as ModBucket;

                liquid.Type = this.liquid;
                liquid.Amount = 255;

                WorldGen.SquareTileFrame(Player.tileTargetX, Player.tileTargetY, true);
            }

            return true;
        }

        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            item.useAnimation = 100;
            item.useTime = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;

            if (liquid.Type == 0)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Water_Bucket");
                spriteBatch.Draw(liquidTexture, position, null, Color.White, 0f, origin, new Vector2(scale), SpriteEffects.None, 0);
            }
            if (liquid.Type == 1)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Lava_Bucket");
                spriteBatch.Draw(liquidTexture, position, null, Color.White, 0f, origin, new Vector2(scale), SpriteEffects.None, 0);
            }
            if (liquid.Type == 2)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Honey_Bucket");
                spriteBatch.Draw(liquidTexture, position, null, Color.White, 0f, origin, new Vector2(scale), SpriteEffects.None, 0);
            }
            if (liquid.Type == 3)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Oil_Bucket");
                spriteBatch.Draw(liquidTexture, position, null, Color.White, 0f, origin, new Vector2(scale), SpriteEffects.None, 0);
            }
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            if (liquid.Type == 0)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Water_Bucket");
                spriteBatch.Draw(liquidTexture, item.position, Color.White);
            }
            if (liquid.Type == 1)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Lava_Bucket");
                spriteBatch.Draw(liquidTexture, item.position, Color.White);
            }
            if (liquid.Type == 2)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Honey_Bucket");
                spriteBatch.Draw(liquidTexture, item.position, Color.White);
            }
            if (liquid.Type == 3)
            {
                Texture2D liquidTexture = ModContent.GetTexture("HellishOnslaught/LiquidAPI/Texture/Bucket/Oil_Bucket");
                spriteBatch.Draw(liquidTexture, item.position, Color.White);
            }
        }

        //This is a static method for helping at creating mod bucket in game
        public static Item CreateBucketItem(ModLiquid liquid)
        {
            List<ModItem> itemList = (List<ModItem>)ReflectionCaches.fieldCache[typeof(ItemLoader)]["items"].GetValue(null);
            ModBucket modBucket = (ModBucket) itemList.Single(i => i is ModBucket i2 && i2.liquid.Type == liquid.Type);

            Item bucket = new Item();
            bucket.SetDefaults(modBucket.item.type);
            return bucket;
        }
    }
}
