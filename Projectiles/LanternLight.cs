using HellishOnslaught.Buffs;
using HellishOnslaught.Tiles;
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
    class LanternLight : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lantern Light");
            ProjectileID.Sets.DontAttachHideToAlpha[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 256;
            projectile.height = 256;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.hide = true;
            projectile.penetrate = -1;
            projectile.ignoreWater = true;
            projectile.light = 1;
            projectile.tileCollide = false;
            projectile.timeLeft = 600;
            projectile.alpha = 230;
        }

        public override void DrawBehind(int index, List<int> drawCacheProjsBehindNPCsAndTiles, List<int> drawCacheProjsBehindNPCs, List<int> drawCacheProjsBehindProjectiles, List<int> drawCacheProjsOverWiresUI)
        {
            drawCacheProjsBehindNPCsAndTiles.Add(index);
        }

        public override void AI()
        {
            projectile.timeLeft--;
            if (projectile.timeLeft <= 60 && projectile.timeLeft > 30)
            {
                projectile.timeLeft = 600;
            }
            int i = (int)((projectile.Center.X - 8) / 16);
            int j = (int)((projectile.Center.Y - 8) / 16);
            if ((Main.tile[i, j].type == ModContent.TileType<WhiteLantern>() || Main.tile[i, j].type == ModContent.TileType<RedLantern>() || Main.tile[i, j].type == ModContent.TileType<GreenLantern>() || Main.tile[i, j].type == ModContent.TileType<BlueLantern>() || Main.tile[i, j].type == ModContent.TileType<YellowLantern>() || Main.tile[i, j].type == ModContent.TileType<PinkLantern>() || Main.tile[i, j].type == ModContent.TileType<TealLantern>()) && Main.tile[i, j] != null)
            {
                if (Main.player[projectile.owner].Center.X >= projectile.Center.X - 180 && Main.player[projectile.owner].Center.Y >= projectile.Center.Y - 180 && Main.player[projectile.owner].Center.X <= projectile.Center.X + 180 && Main.player[projectile.owner].Center.Y <= projectile.Center.Y + 180)
                {
                    Main.player[projectile.owner].AddBuff(ModContent.BuffType<LightsReach>(), 1);
                }
            }
            else
            {
                projectile.timeLeft = 10;
            }
        }
    }
}
