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
    class Fuck : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Two Thousand Twenty");
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.value = 100000;
            item.rare = ItemRarityID.Cyan;
            item.magic = true;
            item.noMelee = true;
            item.mana = 7;
            item.useAnimation = 25;
            item.useTime = 25;
            item.damage = 5 * PlayerFile.powerint() * (PlayerFile.Leg1Count > 1 ? 3 : 2);
            item.knockBack = 2f;
            item.shootSpeed = 1f;
            item.shoot = 10;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(mod, "Text", "The Year of Chaos! Maybe we should stay inside..."));
            var Legacy = new TooltipLine(mod, "Leg", "--Legacy-- (Standard: 0)");
            if (PlayerFile.Leg1Count > 1)
            {
                Legacy = new TooltipLine(mod, "Leg", "--Legacy-- (Premium: " + PlayerFile.Leg1Count + ")");
            }
            if (PlayerFile.Leg1Count == PlayerFile.Leg1Max)
            {
                Legacy = new TooltipLine(mod, "Leg", "--Legacy-- (Supreme: " + PlayerFile.Leg1Max + ")");
            }
            Legacy.overrideColor = Color.Lerp(Color.HotPink, Color.SteelBlue, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f)))));
            tooltips.Add(Legacy);
            foreach (TooltipLine line in tooltips)
            {
                if (line.mod == "Terraria" && line.Name == "ItemName")
                {
                    line.overrideColor = Color.Lerp(Color.HotPink, Color.SteelBlue, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f)))));
                }
                if (line.mod == "Terraria" && line.Name == "Damage")
                {
                    var LegColor = Color.Lerp(Color.HotPink, Color.SteelBlue, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))).Hex3();
                    line.text = "[c/" + LegColor + ":" + item.damage + "] Magic Damage";
                }
            }
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, ModContent.ProjectileType<Cough>(), damage, knockBack, player.whoAmI, -1);
            return false;
        }
    }
}