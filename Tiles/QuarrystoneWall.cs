using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class QuarrystoneWall : ModWall
    {
        public override void SetDefaults()
        {
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Quarry Stone Wall");
            AddMapEntry(new Color(127, 51, 0), name);

            drop = ModContent.ItemType<QuarrystoneItem>();
            soundType = SoundID.Tink;
            soundStyle = 1;
        }
    }
}