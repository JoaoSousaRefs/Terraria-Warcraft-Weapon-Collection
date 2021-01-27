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
            Tooltip.SetDefault("It feels strange, chaotic, wrong but so powerfull");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(11,3));
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(30);
            item.value = Item.sellPrice(platinum: 15);
            item.rare = ItemRarityID.Red;
            item.maxStack = 1;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, 0.50f, 2.5f, 0.35f);
        }
    }
}
