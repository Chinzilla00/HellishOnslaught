﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LiquidAPI;
using System;
using HellishOnslaught.Buffs;

namespace HellishOnslaught.Liquid
{
    class Oil : ModLiquid
    {
        public override bool Autoload(ref string name, ref string texture, ref string fancyTexture) => false;
        public override Color LiquidColor => Color.Black;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Oil");
            DefaultOpacity = 0.6f;
            customDelay = 50;
            WaterfallLength = 50;
            LiquidDust = new LiquidDust(DustID.Blood, 20, 1f, 2.5f, 1.3f, 100, true);
            Name = "Oil";
        }
        public override void PreDrawValueSet(ref bool bg, ref int style, ref float Alpha)
        {
            style = 12;
            Alpha = 0.2f;
        }
        public override void PlayerInteraction(Player target)
        {
            target.AddBuff(BuffID.Slow, 90);
            target.AddBuff(ModContent.BuffType<Crude>(), 300);
        }
        public override void NPCInteraction(NPC target)
        {
            target.AddBuff(BuffID.Slow, 90);
            target.AddBuff(ModContent.BuffType<Crude>(), 300);
        }
    }
}
