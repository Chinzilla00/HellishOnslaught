using HellishOnslaught.Buffs;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Projectiles
{
    class Cough : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cough");
        }

        public override void SetDefaults()
        {
            projectile.width = 64;
            projectile.height = 140;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.scale = 1f;
            projectile.tileCollide = true;
            projectile.timeLeft = 120;
            projectile.alpha = 135;
        }

        private bool spawning = true;
        public override void AI()
        {
            if (spawning)
            {
                projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
                if (projectile.ai[0] == -1)
                {
                    Player player = Main.player[projectile.owner];
                    projectile.Center = new Vector2(player.position.X + player.width * 0.5f, player.position.Y + player.height * 0.5f);
                }
                else
                {
                    NPC npc = Main.npc[(int)projectile.ai[0]];
                    projectile.Center = new Vector2(npc.position.X + npc.width * 0.5f, npc.position.Y + npc.height * 0.5f);
                }
                spawning = false;
            }
            projectile.velocity = Vector2.Zero;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.ai[0] == target.whoAmI)
            {
                damage = 0;
                knockback = 0f;
                crit = false;
            }
            if (projectile.ai[0] != target.whoAmI)
            {
                target.AddBuff(ModContent.BuffType<Covid19>(), 300, false);
            }
        }
    }
}