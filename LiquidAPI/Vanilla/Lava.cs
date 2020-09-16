using HellishOnslaught.LiquidAPI.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ObjectData;

namespace HellishOnslaught.LiquidAPI.Vanilla
{
    public class Lava : ModLiquid
    {
        public override bool Autoload(ref string name, ref string texture, ref string fancyTexture) => false;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lava");
            WaterfallLength = 3;
            DefaultOpacity = 0.95f;
            WaveMaskStrength = 0;
            ViscosityMask = 200;
            Name = "Lava";

            HellishOnslaught.interactionResult[Type, LiquidID.Honey] = TileID.CrispyHoneyBlock;
            HellishOnslaught.interactionResult[Type, LiquidID.Water] = TileID.Obsidian;
        }

        public override bool CanKillTile(int x, int y) => TileObjectData.CheckLavaDeath(Main.tile[x, y]);
        public static string Bomb()
        {
            //Your So Close!
            return Honey.Bomb();
        }
    }
}
