using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class LegacyToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Legacy Token Holds Many Wonders.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 8));
        }
        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.value = 1000;
            item.rare = ItemRarityID.Cyan;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = ItemUseStyleID.HoldingUp;
        }
        /*public override bool UseItem(Player player)
        {
            return true;
        }*/
    }
}
