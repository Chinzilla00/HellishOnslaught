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
using Terraria.UI;
using HellishOnslaught.UI;
using Microsoft.Xna.Framework;
using HellishOnslaught.Items;

namespace HellishOnslaught
{
    class HellishOnslaught : Mod
    {
        public static ModHotKey ClanEmblem;
        internal static HellishOnslaught instance;
        internal UserInterface _legacyshop;
        internal UserInterface _minigame;

        internal ButtonUI Buttoney;
        internal MinigameUI Minigame;

        private GameTime gamertime;
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
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/IntoTheMineshaft");
                priority = MusicPriority.Environment;
            }
        }

        public override void Load()
        {
            instance = this;
            Filters.Scene["HellishOnslaught:Quarry"] = new Filter(new ScreenShaderData("FilterTower").UseColor(0.0f, 0.0f, 0.0f).UseOpacity(0.85f), EffectPriority.High);
            ClanEmblem = RegisterHotKey("Clan Active Ability", "M");
            if (!Main.dedServ)
            {
                _legacyshop = new UserInterface();

                Buttoney = new ButtonUI();
                Buttoney.Activate();

                _minigame = new UserInterface();

                Minigame = new MinigameUI();
                Minigame.Activate();
            }
        }

        public override void Unload()
        {
            ClanEmblem = null;
        }

        public override void UpdateUI(GameTime gameTime)
        {
            gamertime = gameTime;
            if (_legacyshop?.CurrentState != null)
            {
                _legacyshop.Update(gameTime);
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "HellishOnslaught: LegacyShop",
                    delegate
                    {
                        if (gamertime != null && _legacyshop?.CurrentState != null)
                        {
                            _legacyshop.Draw(Main.spriteBatch, gamertime);
                        }
                        return true;
                    },
                InterfaceScaleType.UI));
            }
            if (mouseTextIndex != -2)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "HellishOnslaught: MinigameUI",
                    delegate
                    {
                        if (gamertime != null && _minigame?.CurrentState != null)
                        {
                            _minigame.Draw(Main.spriteBatch, gamertime);
                        }
                        return true;
                    },
                InterfaceScaleType.UI));
            }
        }

        internal void ShowMyUI()
        {
            _legacyshop?.SetState(Buttoney);
        }

        internal void HideMyUI()
        {
            _legacyshop?.SetState(null);
        }
        internal void MinigameShow()
        {
            _minigame?.SetState(Minigame);
        }

        internal void MinigameHide()
        {
            _minigame?.SetState(null);
        }
    }
}