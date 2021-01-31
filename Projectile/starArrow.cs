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
namespace warcraftweaponscollection.Projectile
{
    public class starArrow : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Arrow");    
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
			
		}

		public override void SetDefaults()
		{
			
			projectile.width = 15;    
			projectile.height = 8;   
			projectile.aiStyle = ProjectileID.Starfury;
			projectile.friendly = true;    
			projectile.hostile = false;    
			projectile.ranged = true;     
			projectile.penetrate = 7;
			projectile.timeLeft = 600;      
			projectile.light = 0.9f;       
			projectile.ignoreWater = false;   
			projectile.tileCollide = true; 
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Starfury;
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			if (projectile.type == ModContent.ProjectileType<Projectile.starArrow>())
			{
				target.AddBuff(ModContent.BuffType<starfire>(), 160);
			}
		}

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}
