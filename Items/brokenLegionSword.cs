using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Items
{
    public class brokenLegionSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Legion Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Strange broken sword");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(80);

			item.damage = 80;
			item.knockBack = 1;
			item.melee = true;
			item.magic = false;

			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(copper: 20);
			item.rare = ItemRarityID.Gray;

			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
