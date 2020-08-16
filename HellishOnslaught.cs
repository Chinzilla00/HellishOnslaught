using HellishOnslaught.TheQuarry;
using SubworldLibrary;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace HellishOnslaught
{
    class HellishOnslaught : Mod
    {

        public static ModHotKey ClanEmblem;

        public override void Load()
        {
            ClanEmblem = RegisterHotKey("Clan Active Ability", "M");
        }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }

            if (Subworld.IsActive<QuarryWorldFile>())
            {
                music = GetSoundSlot(SoundType.Music, "Music/IntoTheMineshaft");
                priority = MusicPriority.Environment;
            }
        }

        public override void Unload()
        {
            ClanEmblem = null;
        }
    }
}