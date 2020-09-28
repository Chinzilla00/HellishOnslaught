using HellishOnslaught.UI;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class DeveloperCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Allows you to get Developer Weapon Varients Easily!" +
                "\n50% Conusme rate on Crafting.");
        }
        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 20;
            item.value = 1000;
            item.rare = ItemRarityID.Cyan;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ModContent.ItemType<Blundergat>());
            recipe.SetResult(ModContent.ItemType<Acidgat>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ModContent.ItemType<Acidgat>());
            recipe.SetResult(ModContent.ItemType<Blundergat>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ModContent.ItemType<JooksDespair>());
            recipe.SetResult(ModContent.ItemType<JooksDenial>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ModContent.ItemType<JooksDenial>());
            recipe.SetResult(ModContent.ItemType<JooksDespair>());
            recipe.AddRecipe();
        }
    }
}