using HellishOnslaught.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class JooksDespair : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jook's Despair");
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 20;
            item.height = 18;
            item.maxStack = 1;
            item.value = 100000;
            item.rare = ItemRarityID.Cyan;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = 26 * PlayerFile.powerint();
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.shoot = ModContent.ProjectileType<JooksDespairProj>();
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var Developer = new TooltipLine(mod, "Dev", "Developer: Jook Nookem");
            Developer.overrideColor = Color.Lerp(Color.LimeGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f)))));
            tooltips.Add(Developer);
            foreach (TooltipLine line in tooltips)
            {
                if (line.mod == "Terraria" && line.Name == "ItemName")
                {
                    Color color0 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.70))));
                    Color color1 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.65))));
                    Color color2 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.60))));
                    Color color3 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.55))));
                    Color color4 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.50))));
                    Color color5 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.45))));
                    Color color6 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.40))));
                    Color color7 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.35))));
                    Color color8 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.30))));
                    Color color9 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.25))));
                    Color color10 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.20))));
                    Color color11 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.15))));
                    Color color12 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.10))));
                    Color color13 = Color.Lerp(Color.Red, Color.Purple, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f) + 0.05))));
                    line.text = "[c/" + color0.Hex3() + ":J]" + "[c/" + color1.Hex3() + ":o]" + "[c/" + color2.Hex3() + ":o]" + "[c/" + color3.Hex3() + ":k]" + "[c/" + color4.Hex3() + ":']" + "[c/" + color5.Hex3() + ":s]" + "[c/" + color6.Hex3() + ": ]" + "[c/" + color7.Hex3() + ":D]" + "[c/" + color8.Hex3() + ":e]" + "[c/" + color9.Hex3() + ":s]" + "[c/" + color10.Hex3() + ":p]" + "[c/" + color11.Hex3() + ":a]" + "[c/" + color12.Hex3() + ":i]" + "[c/" + color13.Hex3() + ":r]";
                }
                if (line.mod == "Terraria" && line.Name == "Damage")
                {
                    var DevColor = Color.Lerp(Color.LightGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))).Hex3();
                    line.text = "[c/" + DevColor + ":" + item.damage + "] Melee Damage";
                }
            }
        }
        public override void OnCraft(Recipe recipe)
        {
            Player player = Main.LocalPlayer;
            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem(new Rectangle((int)player.Center.X, (int)player.Center.Y, player.width, player.height), ModContent.ItemType<DeveloperCore>());
            }
        }
    }
}
