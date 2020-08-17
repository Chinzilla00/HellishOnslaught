using Paradox.Buffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (player.HasBuff(ModContent.BuffType<HostiliusFlames>()))
                {
                    if (player.lifeRegen > 0)
                    {
                        player.lifeRegen = 0;
                    }
                    player.lifeRegenTime = 0;
                    player.lifeRegen -= 180;
                }
                if (player.HasBuff(ModContent.BuffType<HellionInferno>()))
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
}