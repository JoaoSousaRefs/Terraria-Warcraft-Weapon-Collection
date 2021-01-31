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
				"Converts wooden arrows on its own projectile");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 60;

			item.damage = 200;
			item.knockBack = 5;
			item.ranged = true;
			item.noMelee = true;
			item.shoot = ModContent.ProjectileType<Projectile.starArrow>();
			item.shootSpeed = 15f;
			item.crit = 7;
			item.useAmmo = AmmoID.Arrow;

			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;

			item.value = Item.sellPrice(gold: 150);
			item.rare = ItemRarityID.LightRed;

			item.UseSound = SoundID.Item10;
		}
        
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
			{ 
                type = ModContent.ProjectileType<Projectile.starArrow>(); 
            }
            return true;
        }

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			target.AddBuff(ModContent.BuffType<starfire>(), 240);
		}

	}
}
