﻿using HellishOnslaught.Tiles;
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
    class Boom : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 2;
            projectile.height = 2;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 5;
        }
        public override void AI()
        {
            projectile.timeLeft--;
            if (projectile.owner == Main.myPlayer && projectile.timeLeft <= 3)
            {
                projectile.tileCollide = false;
                projectile.damage = 250;
                projectile.knockBack = 10f;
            }
        }
        public override void Kill(int timeLeft)
        {
            int explosionRadius = 7;
            int minTileX = (int)(projectile.position.X / 16f - (float)explosionRadius);
            int maxTileX = (int)(projectile.position.X / 16f + (float)explosionRadius);
            int minTileY = (int)(projectile.position.Y / 16f - (float)explosionRadius);
            int maxTileY = (int)(projectile.position.Y / 16f + (float)explosionRadius);
            if (minTileX < 0)
            {
                minTileX = 0;
            }
            if (maxTileX > Main.maxTilesX)
            {
                maxTileX = Main.maxTilesX;
            }
            if (minTileY < 0)
            {
                minTileY = 0;
            }
            if (maxTileY > Main.maxTilesY)
            {
                maxTileY = Main.maxTilesY;
            }
            bool canKillWalls = false;
            for (int x = minTileX; x <= maxTileX; x++)
            {
                for (int y = minTileY; y <= maxTileY; y++)
                {
                    float diffX = Math.Abs((float)x - projectile.position.X / 16f);
                    float diffY = Math.Abs((float)y - projectile.position.Y / 16f);
                    double distance = Math.Sqrt((double)(diffX * diffX + diffY * diffY));
                    if (distance < (double)explosionRadius && Main.tile[x, y] != null && Main.tile[x, y].wall == 0)
                    {
                        canKillWalls = true;
                        break;
                    }
                }
            }
            for (int i = minTileX; i <= maxTileX; i++)
            {
                for (int j = minTileY; j <= maxTileY; j++)
                {
                    float diffX = Math.Abs((float)i - projectile.position.X / 16f);
                    float diffY = Math.Abs((float)j - projectile.position.Y / 16f);
                    double distanceToTile = Math.Sqrt((double)(diffX * diffX + diffY * diffY));
                    if (distanceToTile < (double)explosionRadius)
                    {
                        bool canKillTile = true;
                        if (Main.tile[i, j] != null && Main.tile[i, j].active())
                        {
                            canKillTile = true;
                            if (Main.tileDungeon[(int)Main.tile[i, j].type] || Main.tile[i, j].type == 88 || Main.tile[i, j].type == 21 || Main.tile[i, j].type == 26 || Main.tile[i, j].type == 107 || Main.tile[i, j].type == 108 || Main.tile[i, j].type == 111 || Main.tile[i, j].type == 226 || Main.tile[i, j].type == 237 || Main.tile[i, j].type == 221 || Main.tile[i, j].type == 222 || Main.tile[i, j].type == 223 || Main.tile[i, j].type == 211 || Main.tile[i, j].type == 404)
                            {
                                canKillTile = false;
                            }
                            if (!Main.hardMode && Main.tile[i, j].type == 58)
                            {
                                canKillTile = false;
                            }
                            if (!TileLoader.CanExplode(i, j))
                            {
                                canKillTile = false;
                            }
                            if (canKillTile)
                            {
                                WorldGen.KillTile(i, j, false, false, false);
                                if (!Main.tile[i, j].active() && Main.netMode != NetmodeID.SinglePlayer)
                                {
                                    NetMessage.SendData(MessageID.TileChange, -1, -1, null, 0, (float)i, (float)j, 0f, 0, 0, 0);
                                }
                            }
                        }
                        if (canKillTile)
                        {
                            for (int x = i - 1; x <= i + 1; x++)
                            {
                                for (int y = j - 1; y <= j + 1; y++)
                                {
                                    if (Main.tile[x, y] != null && Main.tile[x, y].wall > 0 && canKillWalls && WallLoader.CanExplode(x, y, Main.tile[x, y].wall))
                                    {
                                        WorldGen.KillWall(x, y, false);
                                        if (Main.tile[x, y].wall == 0 && Main.netMode != NetmodeID.SinglePlayer)
                                        {
                                            NetMessage.SendData(MessageID.TileChange, -1, -1, null, 2, (float)x, (float)y, 0f, 0, 0, 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
