using Microsoft.Xna.Framework;
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
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(40);

			item.damage = 50;
			item.crit = 10;
			item.knockBack = 6;
			item.melee = true;
			item.magic = true;

			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(gold: 150);
			item.rare = ItemRarityID.Purple;

			item.UseSound = SoundID.DD2_DarkMageAttack;
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
				target.AddBuff(BuffID.OnFire, 60);
		}

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {

			if (IsUndead.isUndead(target))
			{
				damage *= 2;
			}
        }

        public override void HoldItem(Player player)
		{
			if (Main.rand.Next(player.itemAnimation > 0 ? 40 : 80) == 0)
			{
				Dust.NewDust(new Vector2(player.itemLocation.X + 16f * player.direction, player.itemLocation.Y - 14f * player.gravDir), 4, 4, DustID.Fire);
			}
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
			Lighting.AddLight(position, 1f, 1f, 1f);

			

		}

		
	}
}
