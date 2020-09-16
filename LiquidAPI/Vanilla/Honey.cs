using HellishOnslaught.LiquidAPI.ID;
using HellishOnslaught.LiquidAPI.Items;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace HellishOnslaught.LiquidAPI.Vanilla
{
    public class Honey : ModLiquid
    {
        public override bool Autoload(ref string name, ref string texture, ref string fancyTexture) => false;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Honey");
            WaterfallLength = 2;
            DefaultOpacity = 0.95f;
            WaveMaskStrength = 0;
            ViscosityMask = 240;
            Name = "Honey";

            HellishOnslaught.interactionResult[Type, LiquidID.Water] = TileID.HoneyBlock;
            HellishOnslaught.interactionResult[Type, LiquidID.Lava] = TileID.CrispyHoneyBlock;
        }

        public override void Update()
        {
            
        }

        public static string Bomb()
        {
            //Two More!
            return ModBucket.Bomb();
        }
    }
}
