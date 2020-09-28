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

namespace HellishOnslaught.NPCs.Bosses.LostFragmentBlue
{
    [AutoloadBossHead]
    class LostFragmentBlue : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghiestly, The Blue Lost Fragment");
        }
        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.lifeMax = 5000;
            npc.damage = 30;
            npc.defense = 12;
            npc.knockBackResist = 0f;
            npc.width = 50;
            npc.height = 64;
            npc.npcSlots = 12f;
            npc.boss = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.lavaImmune = true;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }

        private float speed = 0.5f;
        private int bonetime = 0;
        private int bonecount = 0;
        private bool spawnings = false;
        private int plasmtime = 0;
        public override void AI()
        {
            if (npc.life == npc.lifeMax && speed < 0.6f)
            {
                speed = 0.5f;
            }
            if (npc.life <= npc.lifeMax / 0.5 && speed < 0.7f)
            {
                speed = 0.6f;
            }
            if (npc.life <= npc.lifeMax / 1 && speed < 0.8f)
            {
                speed = 0.7f;
            }
            if (npc.life <= npc.lifeMax / 1.5 && speed < 0.9f)
            {
                speed = 0.8f;
            }
            if (npc.life <= npc.lifeMax / 2 && speed < 1.0f)
            {
                speed = 0.9f;
            }
            if (npc.life <= npc.lifeMax / 2.5 && speed < 1.1f)
            {
                speed = 1.0f;
            }
            if (npc.life <= npc.lifeMax / 3 && speed < 1.2f)
            {
                speed = 1.1f;
            }
            if (npc.life <= npc.lifeMax / 3.5 && speed < 1.3f)
            {
                speed = 1.2f;
            }
            if (npc.life <= npc.lifeMax / 4 && speed < 1.4f)
            {
                speed = 1.3f;
            }
            if (npc.life <= npc.lifeMax / 4.5 && speed < 1.5f)
            {
                speed = 1.4f;
            }
            if (npc.life <= npc.lifeMax / 5)
            {
                speed = 1.5f;
            }
            Player player = Main.player[npc.target];
            if (!player.active || player.dead || npc.Center.X > player.Center.X + 1000f || npc.Center.X < player.Center.X - 1000f || npc.Center.Y > player.Center.Y + 1000f || npc.Center.Y < player.Center.Y - 1000f || !player.ZoneDungeon)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if (!player.active || player.dead || npc.Center.X > player.Center.X + 1000f || npc.Center.X < player.Center.X - 1000f || npc.Center.Y > player.Center.Y + 1000f || npc.Center.Y < player.Center.Y - 1000f || !player.ZoneDungeon)
                {
                    npc.velocity = new Vector2(0f, 10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
            if (npc.ai[0] == 0)
            {
                npc.Center = new Vector2(player.Center.X, player.Center.Y - 230f);
                npc.ai[0] = Main.rand.Next(1, 3);
                npc.spriteDirection = npc.ai[0] == 1 ? -1 : 1;
            }
            if (npc.ai[0] == 1 && npc.ai[3] != 3)
            {
                npc.spriteDirection = -1;
                if (npc.Center.Y >= player.Center.Y - 210f)
                {
                    npc.velocity.Y = -6f * speed;
                }
                if (npc.Center.Y <= player.Center.Y - 250f)
                {
                    npc.velocity.Y = 6f * speed;
                }
                if (npc.Center.X >= player.Center.X + 250f)
                {
                    npc.velocity.X = -6f * speed;
                }
                if (npc.Center.X <= player.Center.X - 250f)
                {
                    npc.velocity.X = 6f * speed;
                    npc.ai[0] = 2;
                }
                if (npc.ai[1] <= 0)
                {
                    npc.velocity = new Vector2(3f, 3f) * speed;
                    npc.ai[1]++;
                }
                if (npc.ai[1] >= 20 / speed)
                {
                    npc.velocity = new Vector2(3f, -3f) * speed;
                    npc.ai[1]--;
                }
                if (npc.velocity.X == 0 || npc.velocity.Y == 0)
                {
                    npc.ai[0] = Main.rand.Next(1, 3);
                    npc.spriteDirection = npc.ai[0] == 1 ? -1 : 1;
                    npc.ai[1] = 0;
                }
            }
            if (npc.ai[0] == 2 && npc.ai[3] != 3)
            {
                npc.spriteDirection = 1;
                if (npc.Center.Y >= player.Center.Y - 210f)
                {
                    npc.velocity.Y = -6f * speed;
                }
                if (npc.Center.Y <= player.Center.Y - 250f)
                {
                    npc.velocity.Y = 6f * speed;
                }
                if (npc.Center.X >= player.Center.X + 250f)
                {
                    npc.velocity.X = -6f * speed;
                    npc.ai[0] = 1;
                }
                if (npc.Center.X <= player.Center.X - 250f)
                {
                    npc.velocity.X = 6f * speed;
                }
                if (npc.ai[1] <= 0)
                {
                    npc.velocity = new Vector2(-3f, 3f) * speed;
                    npc.ai[1]++;
                }
                if (npc.ai[1] >= 20 / speed)
                {
                    npc.velocity = new Vector2(-3f, -3f) * speed;
                    npc.ai[1]--;
                }
                if (npc.velocity.X == 0 || npc.velocity.Y == 0)
                {
                    npc.ai[0] = Main.rand.Next(1, 3);
                    npc.spriteDirection = npc.ai[0] == 1 ? -1 : 1;
                    npc.ai[1] = 0;
                }
            }
            if (npc.ai[2] == -1 && npc.ai[3] != 2)
            {
                npc.defense = 6;
            }
            else if (npc.ai[2] == -1 && npc.ai[3] == 2)
            {
                npc.defense = 0;
            }
            else
            {
                npc.defense = 12;
            }
            if (npc.ai[2] < 200 / speed && npc.ai[2] != -1)
            {
                npc.ai[2]++;
            }
            if (npc.ai[2] >= 200 / speed)
            {
                npc.ai[3] = Main.rand.Next(1, 4);
                npc.ai[2] = -1;
                bonetime = 0;
                bonecount = 3 + Main.rand.Next(4);
                spawnings = false;
            }
            if (npc.ai[3] == 1)
            {
                bonetime++;
                if (bonetime == 1 || bonetime == 11 || bonetime == 21 || bonetime == 31 || bonetime == 41 || bonetime == 51)
                {
                    Projectile.NewProjectile(npc.Center, new Vector2(0, 8f), ModContent.ProjectileType<LostFragmentBone>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI);
                    bonecount--;
                }
                if (bonecount <= 0)
                {
                    bonecount = 0;
                    bonetime = 0;
                    npc.ai[2] = 0;
                    npc.ai[3] = 0;
                }
            }
            if (npc.ai[3] == 2)
            {
                Projectile.NewProjectile(new Vector2(npc.Center.X, player.Center.Y), npc.velocity, ModContent.ProjectileType<LostFragmentBlueGhost>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI);
                npc.ai[3] = 0;
            }
            if (npc.ai[3] == 3)
            {
                npc.velocity = Vector2.Zero;
                plasmtime++;
                if (!spawnings)
                {
                    Projectile.NewProjectile(npc.Center, new Vector2(0, 10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 1);
                    Projectile.NewProjectile(npc.Center, new Vector2(0, -10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 2);
                    Projectile.NewProjectile(npc.Center, new Vector2(10, 0), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 3);
                    Projectile.NewProjectile(npc.Center, new Vector2(-10, 0), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 4);
                    if (speed >= 1.0f)
                    {
                        Projectile.NewProjectile(npc.Center, new Vector2(10, 10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 5);
                        Projectile.NewProjectile(npc.Center, new Vector2(-10, -10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 6);
                        Projectile.NewProjectile(npc.Center, new Vector2(10, -10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 7);
                        Projectile.NewProjectile(npc.Center, new Vector2(-10, 10), ModContent.ProjectileType<LostFragmentPlasm>(), npc.damage / 3, 1f, player.whoAmI, npc.whoAmI, 8);
                    }
                    spawnings = true;
                }
                if (plasmtime >= 75)
                {
                    npc.ai[2] = 0;
                    npc.ai[3] = 0;
                    plasmtime = 0;
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if ((WorldFile.BlueTiles > 20) && spawnInfo.player.ZoneDungeon && !NPC.AnyNPCs(ModContent.NPCType<LostFragmentBlue>()))
            {
                return SpawnCondition.Dungeon.Chance * 0.04f;
            }
            return 0f;
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return true;
        }
    }

    class LostFragmentPlasm : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghiestly's Plasm");
        }
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 32;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 300;
        }
        private int time = 0;
        public override void AI()
        {
            time += 5;
            if (projectile.ai[1] == 1)
            {
                projectile.velocity = new Vector2(0, 10);
            }
            if (projectile.ai[1] == 2)
            {
                projectile.velocity = new Vector2(0, -10);
            }
            if (projectile.ai[1] == 3)
            {
                projectile.velocity = new Vector2(10, 0);
            }
            if (projectile.ai[1] == 4)
            {
                projectile.velocity = new Vector2(-10, 0);
            }
            if (projectile.ai[1] == 5)
            {
                projectile.velocity = new Vector2(10, 10);
            }
            if (projectile.ai[1] == 6)
            {
                projectile.velocity = new Vector2(-10, -10);
            }
            if (projectile.ai[1] == 7)
            {
                projectile.velocity = new Vector2(10, -10);
            }
            if (projectile.ai[1] == 8)
            {
                projectile.velocity = new Vector2(-10, 10);
            }
            projectile.rotation = projectile.velocity.ToRotation();
            projectile.velocity += projectile.velocity.RotatedBy(MathHelper.ToRadians(time));
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.NewProjectile(projectile.Center, new Vector2(0, 0), ModContent.ProjectileType<PlasmBoom>(), projectile.damage, 1f, Main.player[projectile.owner].whoAmI);
            return true;
        }
    }

    class PlasmBoom : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plasm Blast");
            Main.projFrames[projectile.type] = 7;
        }

        public override void SetDefaults()
        {
            projectile.width = 90;
            projectile.height = 90;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.timeLeft = 3600;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 7)
                {
                    projectile.timeLeft = 0;
                }
            }
        }
    }

    class LostFragmentBone : ModProjectile
    {
        public override string Texture => Main.rand.Next(2) == 0 ? "HellishOnslaught/NPCs/Bosses/LostFragmentBlue/LostFragmentBone" : "HellishOnslaught/NPCs/Bosses/LostFragmentBlue/LostFragmentBoneAlt";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghiestly's Bone");
        }
        public override void SetDefaults()
        {
            projectile.width = 9;
            projectile.height = 19;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 400;
        }
        public override void AI()
        {
            projectile.rotation = projectile.rotation + MathHelper.ToRadians(10f);
        }
    }

    class LostFragmentBlueGhost : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghiestly's Ghost");
            ProjectileID.Sets.DontAttachHideToAlpha[projectile.type] = true;
        }
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 64;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 300;
            projectile.alpha = 100;
        }

        private int mode = 0;
        private float speed = 0.5f;
        private int counter = 0;
        private float floaty = 0f;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            if (Main.npc[(int)projectile.ai[0]].life == Main.npc[(int)projectile.ai[0]].lifeMax && speed < 0.6f)
            {
                speed = 0.5f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 0.5 && speed < 0.7f)
            {
                speed = 0.6f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 1 && speed < 0.8f)
            {
                speed = 0.7f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 1.5 && speed < 0.9f)
            {
                speed = 0.8f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 2 && speed < 1.0f)
            {
                speed = 0.9f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 2.5 && speed < 1.1f)
            {
                speed = 1.0f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 3 && speed < 1.2f)
            {
                speed = 1.1f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 3.5 && speed < 1.3f)
            {
                speed = 1.2f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 4 && speed < 1.4f)
            {
                speed = 1.3f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 4.5 && speed < 1.5f)
            {
                speed = 1.4f;
            }
            if (Main.npc[(int)projectile.ai[0]].life <= Main.npc[(int)projectile.ai[0]].lifeMax / 5)
            {
                speed = 1.5f;
            }
            if (mode == 0)
            {
                mode = (int)Main.npc[(int)projectile.ai[0]].ai[0];
                counter = (int)Main.npc[(int)projectile.ai[0]].ai[1];
                floaty = player.Center.Y;
            }
            if (mode == 1)
            {
                projectile.spriteDirection = 1;
                if (projectile.Center.Y >= floaty + 15f)
                {
                    projectile.velocity.Y = -6f * speed;
                }
                if (projectile.Center.Y <= floaty - 15f)
                {
                    projectile.velocity.Y = 6f * speed;
                }
                if (projectile.Center.X >= player.Center.X + 250f)
                {
                    projectile.velocity.X = -6f * speed;
                }
                if (projectile.Center.X <= player.Center.X - 250f)
                {
                    projectile.velocity.X = 6f * speed;
                    mode = 2;
                }
                if (counter <= 0)
                {
                    projectile.velocity = new Vector2(3f, 3f) * speed;
                    counter++;
                }
                if (counter >= 20 / speed)
                {
                    projectile.velocity = new Vector2(3f, -3f) * speed;
                    counter--;
                }
                if (projectile.velocity.X == 0)
                {
                    mode = 0;
                }
            }
            if (mode == 2)
            {
                projectile.spriteDirection = -1;
                if (projectile.Center.Y >= floaty + 15f)
                {
                    projectile.velocity.Y = -6f * speed;
                }
                if (projectile.Center.Y <= floaty - 15f)
                {
                    projectile.velocity.Y = 6f * speed;
                }
                if (projectile.Center.X >= player.Center.X + 250f)
                {
                    projectile.velocity.X = -6f * speed;
                    mode = 1;
                }
                if (projectile.Center.X <= player.Center.X - 250f)
                {
                    projectile.velocity.X = 6f * speed;
                }
                if (counter <= 0)
                {
                    projectile.velocity = new Vector2(-3f, 3f) * speed;
                    counter++;
                }
                if (counter >= 20 / speed)
                {
                    projectile.velocity = new Vector2(-3f, -3f) * speed;
                    counter--;
                }
                if (projectile.velocity.X == 0)
                {
                    mode = 0;
                }
            }
        }
        public override void Kill(int timeLeft)
        {
            Main.npc[(int)projectile.ai[0]].ai[2] = 0;
        }
    }
}
