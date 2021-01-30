using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Buffs;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Items
{
    public class thoridal : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thori'dal, the Stars' Fury");
			Tooltip.SetDefault("The energy of the Sunwell courses through Thori'dal.\n" +
				"Fires its own ammunition");
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 50;

			item.damage = 200;
			item.knockBack = 25;
			item.ranged = true;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.shoot = ProjectileID.HolyArrow;
			item.shootSpeed = 66f;
			item.crit = 7;
			item.useAmmo = AmmoID.Arrow;

			item.useTime = 20;
			item.useAnimation = 20;

			item.useStyle = ItemUseStyleID.HoldingOut;

			item.value = Item.sellPrice(gold: 150);
			item.rare = ItemRarityID.Purple;

			item.UseSound = SoundID.Item10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 5f;
		}
        
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.HolyArrow; // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			target.AddBuff(ModContent.BuffType<Holyfire>(), 500);
		}

	}
}
