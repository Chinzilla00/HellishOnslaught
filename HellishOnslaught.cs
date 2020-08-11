using Terraria.ModLoader;

namespace HellishOnslaught
{
    public class HellishOnslaught : Mod
    {
        public static ModHotKey ClanEmblem;

        public override void Load()
        {
            ClanEmblem = RegisterHotKey("Clan Active Ability", "M");
        }

        public override void Unload()
        {
            ClanEmblem = null;
        }
    }
}