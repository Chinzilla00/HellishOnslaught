using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class Quarrystone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileBlendAll[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Quarry Stone");
            AddMapEntry(new Color(127, 51, 0), name);

            dustType = 84;
            drop = ModContent.ItemType<QuarrystoneItem>();
            soundType = SoundID.Tink;
            soundStyle = 1;
        }
    }
}