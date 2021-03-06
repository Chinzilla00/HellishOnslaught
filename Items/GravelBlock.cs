﻿using HellishOnslaught.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class GravelBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The basic yet most dangerous." +
                "\nEven More Powerful then Sand!" +
                "\nNot included in dynamite, parts sold sepreately.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = ModContent.TileType<Gravel>();
        }
    }
}
