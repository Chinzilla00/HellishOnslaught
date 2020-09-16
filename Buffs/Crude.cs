using HellishOnslaught.LiquidFile;
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
    public class Crude : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Crude");
            Description.SetDefault("A Crude joke is not always funny!");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PlayerFile>().Crude = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<GlobalNPCFile>().Crude = true;
        }
        public static string Bomb()
        {
            //Not Here!
            return Oil.Bomb();
        }
    }
}
