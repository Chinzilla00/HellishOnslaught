using HellishOnslaught.Items;
using HellishOnslaught.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class GravelAlt : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileSolid[Type] = true;
            Main.tileBrick[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            TileID.Sets.TouchDamageSands[Type] = 15;
            TileID.Sets.Falling[Type] = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Gravel");
            AddMapEntry(new Color(127, 127, 127), name);
            dustType = 84;
            drop = ModContent.ItemType<GravelBlock>();
        }
    }
}
