using HellishOnslaught.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace HellishOnslaught
{
    class WorldFile : ModWorld
    {
        public static bool LostFragmentDownedBlue = false;
        public static bool LostFragmentDownedGreen = false;
        public static bool LostFragmentDownedPink = false;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int Altar = tasks.FindIndex((GenPass genpass) => genpass.Name.Equals("Dungeon"));
            if (Altar >= 0)
            {
                tasks.Insert(Altar + 1, new PassLegacy("Generating Quarry Altar", delegate (GenerationProgress progress)
                {
                    bool placed = false;
                    int Min = 50;
                    int Max = Main.maxTilesX / 2;
                    if (Main.dungeonX > Max)
                    {
                        Min = Max;
                        Max = Main.maxTilesX - 50;
                    }
                    while (!placed)
                    {
                        int PlaceHere = WorldGen.genRand.Next(Min, Max);
                        int PlacementHeight = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY - 200);
                        if (Main.wallDungeon[Main.tile[PlaceHere, PlacementHeight].wall] && !Main.tile[PlaceHere, PlacementHeight].active())
                        {
                            while (PlacementHeight < Main.maxTilesY - 200)
                            {
                                PlacementHeight++;
                                if (WorldGen.SolidTile(PlaceHere, PlacementHeight) && ((Main.tile[PlaceHere, PlacementHeight].type == TileID.BlueDungeonBrick && Main.tile[PlaceHere + 1, PlacementHeight].type == TileID.BlueDungeonBrick && Main.tile[PlaceHere + 2, PlacementHeight].type == TileID.BlueDungeonBrick) || (Main.tile[PlaceHere, PlacementHeight].type == TileID.GreenDungeonBrick && Main.tile[PlaceHere + 1, PlacementHeight].type == TileID.GreenDungeonBrick && Main.tile[PlaceHere + 2, PlacementHeight].type == TileID.GreenDungeonBrick) || (Main.tile[PlaceHere, PlacementHeight].type == TileID.PinkDungeonBrick && Main.tile[PlaceHere + 1, PlacementHeight].type == TileID.PinkDungeonBrick && Main.tile[PlaceHere + 2, PlacementHeight].type == TileID.PinkDungeonBrick)))
                                {
                                    int PlacementSuccess = WorldGen.PlaceChest(PlaceHere, PlacementHeight - 2, (ushort)ModContent.TileType<QuarryAltar>());
                                    if (PlacementSuccess >= 0 && Main.tile[PlaceHere, PlacementHeight].type == TileID.BlueDungeonBrick)
                                    {
                                        Main.tile[PlaceHere - 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<BlueDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere, PlacementHeight - 1].type = (ushort)ModContent.TileType<BlueDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere + 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<BlueDungeonBrickUnbreakable>();
                                        if (Main.tile[PlaceHere - 1, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere + 1, PlacementHeight - 1].type > 0)
                                        {
                                            placed = true;
                                            break;
                                        }
                                    }
                                    if (PlacementSuccess >= 0 && Main.tile[PlaceHere, PlacementHeight].type == TileID.GreenDungeonBrick)
                                    {
                                        Main.tile[PlaceHere - 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<GreenDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere, PlacementHeight - 1].type = (ushort)ModContent.TileType<GreenDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere + 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<GreenDungeonBrickUnbreakable>();
                                        if (Main.tile[PlaceHere - 1, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere + 1, PlacementHeight - 1].type > 0)
                                        {
                                            placed = true;
                                            break;
                                        }
                                    }
                                    if (PlacementSuccess >= 0 && Main.tile[PlaceHere, PlacementHeight].type == TileID.PinkDungeonBrick)
                                    {
                                        Main.tile[PlaceHere - 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<PinkDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere, PlacementHeight - 1].type = (ushort)ModContent.TileType<PinkDungeonBrickUnbreakable>();
                                        Main.tile[PlaceHere + 1, PlacementHeight - 1].type = (ushort)ModContent.TileType<PinkDungeonBrickUnbreakable>();
                                        if (Main.tile[PlaceHere - 1, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere, PlacementHeight - 1].type > 0 && Main.tile[PlaceHere + 1, PlacementHeight - 1].type > 0)
                                        {
                                            placed = true;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }));
            }
        }
    }
}
