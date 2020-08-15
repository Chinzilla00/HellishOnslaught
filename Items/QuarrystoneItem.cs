using HellishOnslaught.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    public class QuarrystoneItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's a football!");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = ModContent.TileType<Quarrystone>();
            item.width = 16;
            item.height = 16;
            item.value = 0;
        }
    }
}