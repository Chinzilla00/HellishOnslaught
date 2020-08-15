using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class QuarrystoneAlt : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Quarry Stone");
            AddMapEntry(new Color(66, 197, 53), name);

            dustType = 84;
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