using HellishOnslaught.Items;
using HellishOnslaught.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Tiles
{
    public class BoomBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileBlendAll[Type] = true;

            soundType = SoundID.Tink;
            soundStyle = 1;
        }

        public override bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak)
        {
            int projectileType = ModContent.ProjectileType<Boom>();
            float positionX = i * 16 + 8;
            float positionY = j * 16 + 8;

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                Main.tile[i, j].ClearTile();
                int proj = Projectile.NewProjectile(positionX, positionY, 0f, 0.41f, projectileType, 10, 0f, Main.myPlayer);
                Main.projectile[proj].ai[0] = 1f;
            }
            else if (Main.netMode == NetmodeID.Server)
            {
                Main.tile[i, j].active(false);
                bool spawnProj = true;

                for (int k = 0; k < 1000; k++)
                {
                    Projectile otherProj = Main.projectile[k];

                    if (otherProj.active && otherProj.owner == Main.myPlayer && otherProj.type == projectileType && Math.Abs(otherProj.timeLeft - 3600) < 60 && otherProj.Distance(new Vector2(positionX, positionY)) < 4f)
                    {
                        spawnProj = false;
                        break;
                    }
                }
                if (spawnProj)
                {
                    int proj = Projectile.NewProjectile(positionX, positionY, 0f, 2.5f, projectileType, 10, 0f, Main.myPlayer);
                    Main.projectile[proj].velocity.Y = 0.5f;
                    Main.projectile[proj].position.Y += 2f;
                    Main.projectile[proj].netUpdate = true;
                }
            }
            return false;
        }
    }
}