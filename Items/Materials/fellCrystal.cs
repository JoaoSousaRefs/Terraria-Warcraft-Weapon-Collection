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
            Tooltip.SetDefault("This tiny crystal has a very strong evil aura to it");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(20);
            item.value = Item.sellPrice(platinum: 15);
            item.rare = ItemRarityID.Red;
            item.maxStack = 999;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, 0.48f, 2f, 0.33f);
        }
    }
}
