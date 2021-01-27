using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;
namespace warcraftweaponscollection.Misc
{
    public class globalNPC: GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
			if ((npc.type == NPCID.Zombie))
			{   
                //10% chance of drop
                if (ChanceGenerator.Chance(10))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<emberLegion>(), 1);
                }
			}
		}
    }

} 
