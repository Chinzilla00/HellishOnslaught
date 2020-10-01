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
    class LostFragmentGreen : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Excav, The Green Lost Fragment");
        }
        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.lifeMax = 5000;
            npc.damage = 40;
            npc.defense = -8;
            npc.knockBackResist = 0f;
            npc.width = 44;
            npc.height = 66;
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
        public bool tail;
        public bool body;
        public bool head;
        public override void AI()
        {
            if (npc.localAI[1] == 0f)
            {
                Init();
                npc.localAI[1] = 1f;
            }
            if (npc.ai[3] > 0f)
            {
                npc.realLife = (int)npc.ai[3];
            }
            if (npc.timeLeft < 300)
            {
                npc.timeLeft = 300;
            }
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead)
            {
                npc.TargetClosest(true);
            }
            if (Main.player[npc.target].dead && npc.timeLeft > 300)
            {
                npc.timeLeft = 300;
            }
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                if (!tail && npc.ai[0] == 0f)
                {
                    if (!head)
                    {
                        npc.ai[3] = (float)npc.whoAmI;
                        npc.realLife = npc.whoAmI;
                        npc.ai[2] = 4f;
                        npc.ai[0] = (float)NPC.NewNPC((int)(npc.position.X + (float)(npc.width / 2)), (int)(npc.position.Y + (float)npc.height), ModContent.NPCType<LostFragmentGreenSegment>(), npc.whoAmI);
                        head = true;
                    }
                    else if (npc.ai[2] > 0f)
                    {
                        npc.ai[0] = (float)NPC.NewNPC((int)(npc.position.X + (float)(npc.width / 2)), (int)(npc.position.Y + (float)npc.height), npc.type, npc.whoAmI);
                    }
                    else
                    {
                        npc.ai[0] = (float)NPC.NewNPC((int)(npc.position.X + (float)(npc.width / 2)), (int)(npc.position.Y + (float)npc.height), ModContent.NPCType<LostFragmentGreenTail>(), npc.whoAmI);
                    }
                    Main.npc[(int)npc.ai[0]].ai[3] = npc.ai[3];
                    Main.npc[(int)npc.ai[0]].realLife = npc.realLife;
                    Main.npc[(int)npc.ai[0]].ai[1] = (float)npc.whoAmI;
                    Main.npc[(int)npc.ai[0]].ai[2] = npc.ai[2] - 1f;
                    npc.netUpdate = true;
                }
                if (!tail && (!Main.npc[(int)npc.ai[0]].active || Main.npc[(int)npc.ai[0]].type != ModContent.NPCType<LostFragmentGreenSegment>() && Main.npc[(int)npc.ai[0]].type != ModContent.NPCType<LostFragmentGreenTail>()))
                {
                    npc.life = 0;
                    npc.HitEffect(0, 10.0);
                    npc.active = false;
                }
            }
        }
        public void Init()
        {
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if ((WorldFile.GreenTiles > 20) && spawnInfo.player.ZoneDungeon && !NPC.AnyNPCs(ModContent.NPCType<LostFragmentGreen>()))
            {
                return SpawnCondition.Dungeon.Chance * 0.04f;
            }
            return 0f;
        }
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return head ? (bool?)null : false;
        }
    }
    class LostFragmentGreenSegment : LostFragmentGreen
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Excav, The Green Lost Fragment");
        }
        public void Init()
        {
            base.Init();
            body = true;
        }
    }
    class LostFragmentGreenTail : LostFragmentGreen
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Excav, The Green Lost Fragment");
        }
        public void Init()
        {
            base.Init();
            tail = true;
        }
    }
}