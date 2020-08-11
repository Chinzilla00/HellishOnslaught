using HellishOnslaught.TheQuarry;
using Microsoft.Xna.Framework;
using SubworldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace HellishOnslaught.Tiles
{
    class QuarryAltar : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Direction = TileObjectDirection.None;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("The Quarry Altar");
            AddMapEntry(new Color(255, 203, 255), name);
            animationFrameHeight = 54;
        }
        public static int count = 0;
        public static bool WorldEvilFill = false;
        public static bool DungeonBoneFill = false;
        public override bool CanKillTile(int i, int j, ref bool blockDamaged)
        {
            return false;
        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }
        public override bool NewRightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            if (player.HeldItem.type == ItemID.TissueSample && !DungeonBoneFill)
            {
                if (player.ConsumeItem(ItemID.TissueSample))
                {
                    if (count < 20)
                    {
                        WorldEvilFill = true;
                        Main.PlaySound(SoundID.Tink, (int)(player.position.X), (int)(player.position.Y), 1, 1, 1);
                        count++;
                        //Frame Update Every 5
                    }
                    if (count >= 20)
                    {
                        WorldEvilFill = false;
                        count = 0;
                        Subworld.Enter<QuarryWorldFile>();
                    }
                }
            }
            if (player.HeldItem.type == ItemID.ShadowScale && !DungeonBoneFill)
            {
                if (player.ConsumeItem(ItemID.ShadowScale))
                {
                    if (count < 20)
                    {
                        WorldEvilFill = true;
                        Main.PlaySound(SoundID.Tink, (int)(player.position.X), (int)(player.position.Y), 1, 1, 1);
                        count++;
                        //Frame Update Every 5
                    }
                    if (count >= 20)
                    {
                        WorldEvilFill = false;
                        count = 0;
                        //Boss Spawn
                    }
                }
            }
            if (player.HeldItem.type == ItemID.Bone && !WorldEvilFill && (WorldFile.LostFragmentDownedBlue || WorldFile.LostFragmentDownedGreen || WorldFile.LostFragmentDownedPink))
            {
                if (player.ConsumeItem(ItemID.Bone))
                {
                    if (count < 100)
                    {
                        DungeonBoneFill = true;
                        Main.PlaySound(SoundID.Tink, (int)(player.position.X), (int)(player.position.Y), 1, 1, 1);
                        count++;
                        //Frame Update Every 25
                    }
                    if (count >= 100)
                    {
                        DungeonBoneFill = false;
                        count = 0;
                        
                    }
                }
            }
            return true;
        }
    }
}
