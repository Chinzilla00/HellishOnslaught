using HellishOnslaught.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace HellishOnslaught.Buffs
{
    public class Covid19 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Covid-19");
            Description.SetDefault("Fuck");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<GlobalNPCFile>().Coughing = true;
        }
    }
}
