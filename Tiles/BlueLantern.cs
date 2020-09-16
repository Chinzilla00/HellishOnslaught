using HellishOnslaught.Projectiles;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace HellishOnslaught.Tiles
{
    class BlueLantern : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileSolid[Type] = false;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newTile.AnchorWall = true;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Blue Lantern");
            AddMapEntry(new Color(255, 255, 255), name);
        }

        public override bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak)
        {
            int projectileType = ModContent.ProjectileType<LanternLight>();
            float positionX = i * 16 + 8;
            float positionY = j * 16 + 8;

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                Projectile.NewProjectile(positionX, positionY, 0f, 0f, projectileType, 0, 0f, Main.myPlayer);
            }
            else if (Main.netMode == NetmodeID.Server)
            {
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
                    Projectile.NewProjectile(positionX, positionY, 0f, 0f, projectileType, 0, 0f, Main.myPlayer);
                }
            }
            return true;
        }
    }
}