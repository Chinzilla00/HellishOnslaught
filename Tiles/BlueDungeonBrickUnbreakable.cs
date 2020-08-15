using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    class BlueDungeonBrickUnbreakable : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Blue Dungeon Brick");
            Main.tileBlendAll[Type] = true;
            AddMapEntry(new Color(66, 84, 109), name);
            soundType = SoundID.Tink;
            soundStyle = 1;
        }
        public override bool CanKillTile(int i, int j, ref bool blockDamaged)
        {
            return false;
        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }
}
