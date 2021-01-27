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
    public class fellCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fell Crystal");
            Tooltip.SetDefault("This tiny crystal has a very strong feel to him");
            
        }

        public override void SetDefaults()
        {
            item.scale = 20;
            item.Size = new Vector2(20);
            item.value = Item.sellPrice(platinum: 15);
            item.rare = ItemRarityID.Red;
            item.stack = 199;
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
            Lighting.AddLight(item.position, 0.48f, 2.2f, 0.33f);
        }
    }
}
