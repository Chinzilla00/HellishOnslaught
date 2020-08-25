using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught
{
    class PlayerFile : ModPlayer
    {
        public bool Crude;
        public override void UpdateBadLifeRegen()
        {
            if (Crude)
            {
                if (player.lifeRegen > 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen--;
                if (player.HasBuff(BuffID.OnFire))
                {
                    if (player.lifeRegen > 0)
                    {
                        player.lifeRegen = 0;
                    }
                    player.lifeRegenTime = 0;
                    player.lifeRegen -= 24;
                }
                if (player.HasBuff(BuffID.CursedInferno))
                {
                    if (player.lifeRegen > 0)
                    {
                        player.lifeRegen = 0;
                    }
                    player.lifeRegenTime = 0;
                    player.lifeRegen -= 36;
                }
                if (player.HasBuff(BuffID.Frostburn))
                {
                    if (player.lifeRegen > 0)
                    {
                        player.lifeRegen = 0;
                    }
                    player.lifeRegenTime = 0;
                    player.lifeRegen -= 36;
                }
                if (player.HasBuff(BuffID.ShadowFlame))
                {
                    if (player.lifeRegen > 0)
                    {
                        player.lifeRegen = 0;
                    }
                    player.lifeRegenTime = 0;
                    player.lifeRegen -= 90;
                }
                Mod Paradox = ModLoader.GetMod("Paradox");
                if (Paradox != null)
                {
                    if (player.HasBuff(Paradox.BuffType("HostiliusFlames")))
                    {
                        if (player.lifeRegen > 0)
                        {
                            player.lifeRegen = 0;
                        }
                        player.lifeRegenTime = 0;
                        player.lifeRegen -= 180;
                    }
                    if (player.HasBuff(Paradox.BuffType("HellionInferno")))
                    {
                        if (player.lifeRegen > 0)
                        {
                            player.lifeRegen = 0;
                        }
                        player.lifeRegenTime = 0;
                        player.lifeRegen -= 225;
                    }
                }
            }
        }
        
           
		public override void UpdateBiomes()
		{
            useQuarry = Subworld.IsActive<QuarryWorldFile>();
            player.ManageSpecialBiomeVisuals("HellishOnslaught:Quarry", useQuarry);
        }
    }
}
