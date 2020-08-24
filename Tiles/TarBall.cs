using HellishOnslaught.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class TarBall : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileBlendAll[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Tar Ball");
            AddMapEntry(new Color(20, 20, 20), name);

            //drop = ModContent.ItemType<Tar>();
        }
    }
}