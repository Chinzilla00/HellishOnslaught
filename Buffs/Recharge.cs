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
    public class Recharge : ModBuff
    {
        public static bool RechargeRequired = false;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Overloaded");
            Description.SetDefault("Stop Holding Down! Your going to die!");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (RechargeRequired)
            {
                player.GetModPlayer<PlayerFile>().Recharge = true;
            }
            if (!RechargeRequired)
            {
                player.GetModPlayer<PlayerFile>().Recharge = false;
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
        public static string Bomb()
        {
            //Your Effort's Are In Vein!
            //Keep Going! 
            return WorldFile.Bomb();
        }
    }
}
