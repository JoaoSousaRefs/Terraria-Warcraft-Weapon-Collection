
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Items;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;
namespace warcraftweaponscollection.Misc
{
    public class globalNPC: GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.SkeletronHead:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<emberLegion>(), 1);
                    break;

                case NPCID.SkeletronHand:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(5, 8));
                    break;

                case NPCID.EaterofWorldsHead:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<brokenLegionSword>(), 1);
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(2, 6));
                    break;

                case NPCID.EaterofWorldsBody:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(1, 5));
                    break;

                case NPCID.EaterofWorldsTail:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(2, 6));
                    break;

                case NPCID.BrainofCthulhu:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    if (Generators.Chance(5))
                    {
                        Item.NewItem(npc.getRect(), ModContent.ItemType<emberLegion>(), 1);
                    }

                    Item.NewItem(npc.getRect(), ModContent.ItemType<brokenLegionSword>(), 1);
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(6, 12));
                    break;

                case NPCID.EyeofCthulhu:
                    //----------------------Cataclysm Edge loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<fellCrystal>(), Generators.StackSize(5, 7));
                    break;

                default:
                    break;
            }
        }
    }

} 
