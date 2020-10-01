using HellishOnslaught.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellishOnslaught.Items
{
    class TerraBoi : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I Wonder if Legend of Maxx is on this.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 50;
            item.maxStack = 1;
            item.value = 10000;
            item.rare = ItemRarityID.Lime;
            item.useAnimation = 1;
            item.useTime = 1;
            item.channel = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shoot = ModContent.ProjectileType<TerraBoiProj>();
            item.noUseGraphic = true;
        }
    }
    class TerraBoiProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 42;
            projectile.friendly = false;
            projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        private bool restarttest = false;
        public override void AI()
        {
            if (!restarttest)
            {
                HellishOnslaught.instance.MinigameShow();
                restarttest = true;
            }
            if (!Main.player[projectile.owner].channel && HellishOnslaught.instance._minigame.CurrentState != null)
            {
                Main.player[projectile.owner].channel = true;
            }
            else
            {
                Main.player[projectile.owner].channel = false;
                restarttest = false;
            }
        }
    }
}