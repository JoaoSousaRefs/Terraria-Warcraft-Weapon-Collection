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
            //----------------------Cataclysm Edge loot pools ----------------------
			if ((npc.type == NPCID.SkeletronHead))
			{   
                //10% chance of drop
                if (Generators.Chance(10))
                {   
                    //Boss will drop only 1
                    Item.NewItem(npc.getRect(), ModContent.ItemType<emberLegion>(), 1);
                }

                //65% chance of drop
                if (Generators.Chance(65))
                {
                    //Boss will drop nº from 15 to 30
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(15, 30));
                }
            }

            if ((npc.type == NPCID.SkeletronHand))
            {
                //100% chance of drop
                if (Generators.Chance(100))
                {
                    //Boss will drop nº from 10 to 20
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(10, 20));
                }
            }
            //----------------------End of => Cataclysm Edge loot pools ----------------------

        }
    }

} 
