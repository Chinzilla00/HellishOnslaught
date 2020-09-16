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
    public class LightsReach : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lights Reach");
            Description.SetDefault("I guess I can see now...");
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }
        public static string Bomb()
        {
            //Hello Data Miner!
            //Keep Searching!
            return Crude.Bomb();
        }
    }
}
