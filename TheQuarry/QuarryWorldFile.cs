using SubworldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
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
        public override List<GenPass> tasks => new List<GenPass>()
        {
            new SubworldGenPass(progress =>
            {
                progress.Message = "Loading"; //Sets the text above the worldgen progress bar
		    	Main.worldSurface = 0; //Hides the underground layer just out of bounds
	    		Main.rockLayer = 0; //Hides the cavern layer way out of bounds
    			for (int i = 0; i < Main.maxTilesX; i++)
                {
                    for (int j = 0; j < Main.maxTilesY; j++)
                    {
                        progress.Set((j + i * Main.maxTilesY) / (float)(Main.maxTilesX * Main.maxTilesY)); //Controls the progress bar, should only be set between 0f and 1f
					    Main.tile[i, j].active(true);
                        Main.tile[i, j].type = TileID.Stone;
                    }
                }
            })
       };
    }
}
