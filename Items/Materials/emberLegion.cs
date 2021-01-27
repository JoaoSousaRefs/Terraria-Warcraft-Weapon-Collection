﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Items.Materials
{
    public class emberLegion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Ember of the Legion");
            Tooltip.SetDefault("It feels strange, but powerfull");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10,3));
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(30);
            item.value = Item.sellPrice(platinum: 15);
            item.rare = ItemRarityID.Red;
            item.stack = 99;
        }

        //The Recipe is for Tests only, the finish item will be a drop item only
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, 0.50f, 2.5f, 0.35f);
        }
    }
}
