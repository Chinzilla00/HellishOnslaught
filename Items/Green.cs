using HellishOnslaught.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    public class Green : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Lantern");
            Tooltip.SetDefault("Must Be Placed");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = ModContent.TileType<GreenLantern>();
            item.width = 24;
            item.height = 32;
            item.value = 0;
        }
        public static string E()
        {
            return "r";
        }
    }
}