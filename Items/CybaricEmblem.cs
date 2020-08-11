﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class CybaricEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Emblem of Technology and Discovery" +
                "\nAllows travel to the Cybaric Kingdom");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 32;
            item.maxStack = 1;
            item.value = 0;
            item.rare = ItemRarityID.Purple;
        }
    }
}
