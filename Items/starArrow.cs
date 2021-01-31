using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Items
{
    public class starArrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Arrow");
			Tooltip.SetDefault("This arrow is made of pure energy");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Projectile.starArrow>();
			item.shootSpeed = 1.5f;                 
			item.ammo = AmmoID.Arrow;
		}

	}
}
