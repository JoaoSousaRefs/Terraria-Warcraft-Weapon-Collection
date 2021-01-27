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
			DisplayName.SetDefault("Broken Legion Sword"); 
			Tooltip.SetDefault("Strange broken sword");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(80);

			item.damage = 5;
			item.knockBack = 1;
			item.melee = true;

			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(copper: 20);
			item.rare = ItemRarityID.Gray;

			item.UseSound = SoundID.Item1;
		}

	}
}
