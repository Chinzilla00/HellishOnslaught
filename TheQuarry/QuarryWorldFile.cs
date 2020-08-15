using HellishOnslaught.Tiles;
using SubworldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace HellishOnslaught.TheQuarry
{
    class QuarryWorldFile : Subworld
    {
        public override int width => 1200;
        public override int height => 1200;
        public override bool saveSubworld => false;
        public override bool disablePlayerSaving => true;
        public override bool saveModData => true;
        public static bool FirstTime = true;
        public override List<GenPass> tasks => new List<GenPass>()
        {
            new SubworldGenPass(progress =>
            {
                if (FirstTime)
                {
                    progress.Message = "Welcome to the Quarry!";
                    Main.worldSurface = 0;
                    Main.rockLayer = 0;
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            progress.Set((j + i * Main.maxTilesY) / (float)(Main.maxTilesX * Main.maxTilesY)); //Controls the progress bar, should only be set between 0f and 1f
			                Main.tile[i, j].active(true);
                            Main.tile[i, j].type = (ushort)(ModContent.TileType<Quarrystone>());
                        }
                    }
                    FirstTime = false;
                }
                else
                {
                    progress.Message = "Cave Collapsed! Generating new Mineshaft";
                    Main.worldSurface = 0;
                    Main.rockLayer = 0;
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            progress.Set((j + i * Main.maxTilesY) / (float)(Main.maxTilesX * Main.maxTilesY)); //Controls the progress bar, should only be set between 0f and 1f
			                Main.tile[i, j].active(true);
                            Main.tile[i, j].type = (ushort)(ModContent.TileType<Quarrystone>());
                        }
                    }
                }
            })
        };
        public override void Load()
        {
            Main.dayTime = true;
            Main.time = 27000;
        }
    }
}
