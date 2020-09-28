﻿using HellishOnslaught.Projectiles;
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
    class Acidgat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidgat");
        }
        public override void SetDefaults()
        {
            item.width = 56;
            item.height = 20;
            item.maxStack = 1;
            item.value = 100000;
            item.rare = ItemRarityID.Cyan;
            item.autoReuse = true;
            item.shootSpeed = 21f;
            item.useTime = 40;
            item.useAnimation = 40;
            item.knockBack = 2f;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.ranged = true;
            item.damage = 16 * PlayerFile.powerint();
            item.shoot = 10;
            item.UseSound = SoundID.Item21;
            item.noMelee = true;
            item.useAmmo = AmmoID.Bullet;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) { var Developer = new TooltipLine(mod, "Dev", "Developer: TailstheFox92"); Developer.overrideColor = Color.Lerp(Color.LimeGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))); tooltips.Add(Developer); foreach (TooltipLine line in tooltips) { if (line.mod == "Terraria" && line.Name == "ItemName") { line.overrideColor = Color.Blue; } if (line.mod == "Terraria" && line.Name == "Damage") { var DevColor = Color.Lerp(Color.LightGreen, Color.Orange, (float)(Math.Abs(Math.Sin(Math.Abs(Main.GameUpdateCount * 0.02f))))).Hex3(); line.text = "[c/" + DevColor + ":" + item.damage + "] Ranged Damage"; }}}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(3);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, ModContent.ProjectileType<AcidgatProj>(), damage, knockBack, player.whoAmI);
            }
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return false;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(10, 0);
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