using Microsoft.Xna.Framework;
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
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(platinum: 15);
            item.rare = ItemRarityID.Red;
        }

        

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
