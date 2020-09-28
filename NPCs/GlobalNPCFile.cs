using HellishOnslaught.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.NPCs
{
    class GlobalNPCFile : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool Crude;
        public bool Coughing;
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (Coughing)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                if (damage < 4)
                {
                    damage = 4;
                }
                npc.lifeRegen -= damage;
                if (Main.rand.Next(200) == 0)
                {
                    Vector2 perturbedSpeed = new Vector2(Main.rand.Next(-1, 2), Main.rand.Next(-1, 2)).RotatedByRandom(MathHelper.ToRadians(30));
                    Projectile.NewProjectile(npc.Center, new Vector2(perturbedSpeed.X, perturbedSpeed.Y), ModContent.ProjectileType<Cough>(), 5 * PlayerFile.powerint(), 2f, Main.player[npc.target].whoAmI, npc.whoAmI);
                }
            }
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
                Mod Paradox = ModLoader.GetMod("Paradox");
                if (Paradox != null)
                {
                    if (npc.HasBuff(Paradox.BuffType("HostiliusFlames")))
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
        public static string Bagel()
        {
            //Bet you didn't notice your a Bagel now!
            //Anyway!
            //Congrats!
            //Your Mission is Finally Complete Whatever it was!
            //Here!
            //A Star!
            return " Star";
        }
    }
}
