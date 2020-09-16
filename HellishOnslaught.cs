using HellishOnslaught.LiquidAPI;
using HellishOnslaught.LiquidAPI.Caches;
using HellishOnslaught.LiquidAPI.Vanilla;
using HellishOnslaught.TheQuarry;
using HellishOnslaught.LiquidAPI.Hooks;
using Microsoft.Xna.Framework.Graphics;
using SubworldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using HellishOnslaught.LiquidFile;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;

namespace HellishOnslaught
{
    class HellishOnslaught : Mod
    {
        public static ModHotKey ClanEmblem;

        internal static HellishOnslaught instance;
		
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
                music = GetSoundSlot(SoundType.Music, "Music/IntoTheMineshaft");
                priority = MusicPriority.Environment;
            }
        }

        private const int INITIAL_LIQUID_TEXTURE_INDEX = 12;

        public static event Action OnUnload;

        public static int[,] interactionResult = new int[256, 256];
        public static bool[,] killTile = new bool[TileLoader.TileCount, 256];

        public override void Load()
        {
            LiquidRenderer.Instance = new LiquidRenderer();
            instance = this;

            ClanEmblem = RegisterHotKey("Clan Active Ability", "M");

            interactionResult = new int[255, 255];
            killTile = new bool[TileLoader.TileCount, 255];

            ReflectionCaches.Load();

            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j < 255; j++)
                {
                    interactionResult[i, j] = -1;
                }
            }

            this.AddLiquid<Water>("LiquidWater");
            this.AddLiquid<Lava>("LiquidLava");
            this.AddLiquid<Honey>("LiquidHoney");
            this.AddLiquid<Oil>("LiquidOil");
	    
            Filters.Scene["HellishOnslaught:Quarry"] = new Filter(new ScreenShaderData("FilterMiniTower").UseColor(0f, 0f, 0f).UseOpacity(0.85f), EffectPriority.High);

            LiquidHooks.OldHoneyTexture = new List<Texture2D>()
            {
                Main.liquidTexture[1],
		    };
            LiquidHooks.OldLavaTexture = new List<Texture2D>()
            {
                Main.liquidTexture[11],
            };
            List<Texture2D> OldWaterTextureList = new List<Texture2D>();
            for (int i = 0; i < 11; i++)
            {
                if (i == 1 || i == 11)
                {
                    continue;
                }
                OldWaterTextureList.Add(Main.liquidTexture[i]);
            }

            LiquidHooks.OldWaterTexture = OldWaterTextureList;
            LoadModContent(Autoload);
        }
        public override void PostSetupContent()
        {
            LiquidRegistry.AddHooks();
        }

        public override void Unload()
        {
            OnUnload?.Invoke();
            OnUnload = null;
            Array.Resize(ref Main.liquidTexture, INITIAL_LIQUID_TEXTURE_INDEX);
            ReflectionCaches.Unload();

            ClanEmblem = null;
        }

        private static void LoadModContent(Action<Mod> loadAction)
        {
            foreach (Mod mod in ModLoader.Mods)
            {
                try
                {
                    loadAction(mod);
                }
                catch (Exception e)
                {
                    Main.statusText = e.Message;
                    throw e;
                }
            }
        }
        private void Autoload(Mod mod)
        {
            if (mod.Code == null) { return; }

            foreach (Type type in mod.Code.DefinedTypes.Where(type => type.IsSubclassOf(typeof(ModLiquid))).OrderBy(type => type.FullName))
            {
                AutoloadLiquid(mod, type);
            }
        }
        private void AutoloadLiquid(Mod mod, Type type)
        {
            ModLiquid liquid = (ModLiquid)Activator.CreateInstance(type);
            liquid.Mod = mod;
            string name = type.Name;
            string texturePath = liquid.GetType().FullName.Replace(".", "/").Replace(this.Name + "/", "");
            string fancyTexturePath = liquid.GetType().FullName.Replace(".", "/").Replace(this.Name + "/", "") + "Fancy";
            if (liquid.Autoload(ref name, ref texturePath, ref fancyTexturePath))
            {
                mod.AddLiquid(name, liquid, this.GetTexture(texturePath), this.GetTexture(fancyTexturePath));
            }
        }
    }
}
