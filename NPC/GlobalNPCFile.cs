using Paradox.Buffs;
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
    class GlobalNPCFile : GlobalNPC
    {
        public bool Crude;
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (Crude)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                if (damage < 1)
                {
                    damage = 1;
                }
                npc.lifeRegen--;
                if (npc.HasBuff(BuffID.OnFire))
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    if (damage < 12)
                    {
                        damage = 12;
                    }
                    npc.lifeRegen -= damage;
                }
                if (npc.HasBuff(BuffID.CursedInferno))
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    if (damage < 18)
                    {
                        damage = 18;
                    }
                    npc.lifeRegen -= damage;
                }
                if (npc.HasBuff(BuffID.Frostburn))
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    if (damage < 24)
                    {
                        damage = 24;
                    }
                    npc.lifeRegen -= damage;
                }
                if (npc.HasBuff(BuffID.ShadowFlame))
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    if (damage < 45)
                    {
                        damage = 45;
                    }
                    npc.lifeRegen -= damage;
                }
                if (npc.HasBuff(ModContent.BuffType<HostiliusFlames>()))
                {
                    if (npc.lifeRegen > 0)
                    {
                        npc.lifeRegen = 0;
                    }
                    if (damage < 90)
                    {
                        damage = 90;
                    }
                    npc.lifeRegen -= damage;
                }
            }
        }
    }
}
