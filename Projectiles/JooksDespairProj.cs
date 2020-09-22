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
    class JooksDespairProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jook's Despair");
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 2.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 240f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }

        private bool spawnproj1 = true;
        private bool spawnproj2 = true;
        private bool spawnproj3 = true;

        public override void AI()
        {
            if (spawnproj1)
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity, ModContent.ProjectileType<JooksDispairProj2>(), projectile.damage, 2.5f, projectile.owner);
                spawnproj1 = false;
            }
            if (spawnproj2)
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity, ModContent.ProjectileType<JooksDispairProj3>(), projectile.damage, 2.5f, projectile.owner);
                spawnproj2 = false;
            }
            if (spawnproj3)
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity, ModContent.ProjectileType<JooksDispairProj4>(), projectile.damage, 2.5f, projectile.owner);
                spawnproj3 = false;
            }
        }
        public override void Kill(int timeLeft)
        {
            spawnproj1 = true;
            spawnproj2 = true;
            spawnproj3 = true;
        }

    }
    class JooksDispairProj2 : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/JooksDespairProj";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jook's Despair");
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 2.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 60f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
    }
    class JooksDispairProj3 : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/JooksDespairProj";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jook's Despair");
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 2.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 120f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
    }
    class JooksDispairProj4 : ModProjectile
    {
        public override string Texture => "HellishOnslaught/Projectiles/JooksDespairProj";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jook's Despair");
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 2.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 180f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
    }
}