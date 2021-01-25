﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Items
{
    public class cataclysmEdge : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cataclysm's Edge"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Chance on hit: Set the target Burning. \n" +
				"Attacking Burning enemies results in a critical hit.");
			
			
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(80);

			item.damage = 80;
			item.knockBack = 10;
			item.melee = true;
			item.magic = true;
			item.crit = 5;

			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(gold: 150);
			item.rare = ItemRarityID.Purple;

			item.UseSound = SoundID.DD2_OgreGroundPound;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			Random mathRandom = new Random();
			var debuffChange = mathRandom.Next(1, 100);

			//theres a 25% chance per hit to apply Onfire debuff
            if (debuffChange < 50 && debuffChange > 25)
            {
				target.AddBuff(BuffID.OnFire, 160);
            }
            
		}

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
			//If the target has Onfire debuff, the next hit should be a 100% crit chance
			if (target.HasBuff(BuffID.OnFire))
			{
				crit = true;
			}
        }

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 127, 1f, 1f, 0, default(Color), 2.105263f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity.X += player.direction * 2f;
					Main.dust[dust].velocity.Y += 0.2f;
			}
		}
	}
}
