using HellishOnslaught.TheQuarry;
using Microsoft.Xna.Framework.Graphics;
using SubworldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;

namespace HellishOnslaught
{
    class HellishOnslaught : Mod
    {
        public static ModHotKey ClanEmblem;

        internal HellishOnslaught instance;
		
        public HellishOnslaught()
        {
	        Properties = new ModProperties()
	        {
		        Autoload = true,
		        AutoloadGores = true,
		        AutoloadSounds = true,
		        AutoloadBackgrounds = true
	        };
        }
		
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Subworld.IsActive<QuarryWorldFile>())
            {
                music = instance.GetSoundSlot(SoundType.Music, "HellishOnslaught/Music/IntoTheMineshaft");
                priority = MusicPriority.Environment;
            }
        }

        public override void Load()
        {
            instance = this;

            ClanEmblem = RegisterHotKey("Clan Active Ability", "M");

        }
        public override void Unload()
        {
            ClanEmblem = null;
        }
    }
}
