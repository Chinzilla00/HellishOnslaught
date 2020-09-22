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
    class AcidgatProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidgat Acid");
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 20;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.ranged = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 3600;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            if (killing && projectile.timeLeft <= 1)
            {
                Projectile.NewProjectile(new Vector2(projectile.Center.X, projectile.Center.Y), new Vector2(0f, 0f), ModContent.ProjectileType<AcidgatTileWait>(), 0, 0f, projectile.owner);
                projectile.timeLeft = 0;
            }
            projectile.velocity.X *= 0.98f;
            projectile.velocity.Y += 0.45f;
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
        }

        private bool killing = false;

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (!killing)
            {
                projectile.tileCollide = false;
                projectile.penetrate = -1;
                projectile.timeLeft = 3;
                killing = true;
            }
            return false;
        }

        public override bool PreKill(int timeLeft)
        {
            if (!killing)
            {
                Projectile.NewProjectile(new Vector2(projectile.Center.X, projectile.Center.Y), new Vector2(0f, 0f), ModContent.ProjectileType<AcidgatExplode>(), 0, 0f, projectile.owner);
            }
            return true;
        }
    }
    class AcidgatTileWait : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidgat Acid Puddle");
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 6;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.ranged = true;
            projectile.tileCollide = false;
            projectile.timeLeft = 240;
            projectile.ignoreWater = true;
        }

        public override bool PreKill(int timeLeft)
        {
            Projectile.NewProjectile(new Vector2(projectile.Center.X, projectile.Center.Y), new Vector2(0f, 0f), ModContent.ProjectileType<AcidgatExplode2>(), 32 * PlayerFile.powerint(), 4f, projectile.owner);
            return true;
        }
    }

    class AcidgatExplode : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidgat Explosion");
            Main.projFrames[projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.ranged = true;
            projectile.tileCollide = false;
            projectile.timeLeft = 3600;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.timeLeft = 0;
                }
            }
        }
    }

    class AcidgatExplode2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidgat Explosion");
            Main.projFrames[projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 13;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.ranged = true;
            projectile.tileCollide = false;
            projectile.timeLeft = 3600;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.timeLeft = 0;
                }
            }
        }
    }
}