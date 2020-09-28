using HellishOnslaught.NPCs.Bosses.LostFragmentBlue;
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
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("The Quarry Altar");
            AddMapEntry(new Color(255, 203, 255), name);
            animationFrameHeight = 54;
        }
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
            if (player.HeldItem.type == ItemID.Bone && player.HeldItem.stack >= 100 && (WorldFile.LostFragmentDownedBlue || WorldFile.LostFragmentDownedPink || WorldFile.LostFragmentDownedGreen))
            {
                player.HeldItem.stack -= 100;
                Subworld.Enter<QuarryWorldFile>();
            }
            if ((player.HeldItem.type == ItemID.TissueSample || player.HeldItem.type == ItemID.ShadowScale) && player.HeldItem.stack >= 20)
            {
                player.HeldItem.stack -= 20;
                int spawn = Main.rand.Next(3);
                if (spawn == 0 && !NPC.AnyNPCs(ModContent.NPCType<LostFragmentBlue>()))
                {
                    NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, ModContent.NPCType<LostFragmentBlue>());
                }
                /*if (spawn == 1 && !NPC.AnyNPCs(ModContent.NPCType<LostFragmentPink>()))
                {
                    NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, ModContent.NPCType<LostFragmentPink>());
                }*/
                /*if (spawn == 2 && !NPC.AnyNPCs(ModContent.NPCType<LostFragmentGreen>()))
                {
                    NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, ModContent.NPCType<LostFragmentGreen>());
                }*/
            }
            return true;
        }
    }
}
