using HellishOnslaught.LiquidAPI.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ObjectData;

namespace HellishOnslaught.LiquidAPI.Vanilla
{
    public class Water : ModLiquid
    {
        public override bool Autoload(ref string name, ref string texture, ref string fancyTexture) => false;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Water");
            WaterfallLength = 10;
            DefaultOpacity = 0.6f;
            WaveMaskStrength = 0;
            ViscosityMask = 0;
            Name = "Water";

            HellishOnslaught.interactionResult[Type, LiquidID.Honey] = TileID.HoneyBlock;
            HellishOnslaught.interactionResult[Type, LiquidID.Lava] = TileID.Obsidian;
        }

        public override bool CanKillTile(int x, int y) => TileObjectData.CheckWaterDeath(Main.tile[x, y]);
        public static string Bomb()
        {
            //I Can Do This All Day!
            //But I Won't! :D
            return Lava.Bomb();
        }
    }
}
