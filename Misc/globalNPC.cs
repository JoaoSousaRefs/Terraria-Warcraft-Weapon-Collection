using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Dusts;
using warcraftweaponscollection.Items;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Misc
{
    public class globalNPC: GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool eFlames = false;

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
           
            if (eFlames)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 16;
                if (damage < 2)
                {
                    damage = 2;
                }
            }
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (eFlames)
            {
                if (Main.rand.Next(4) < 3)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<holyfire>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    if (Main.rand.NextBool(4))
                    {
                        Main.dust[dust].noGravity = false;
                        Main.dust[dust].scale *= 0.5f;
                    }
                }
                Lighting.AddLight(npc.position, 0.1f, 0.2f, 0.7f);
            }
        }
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

                case NPCID.MoonLordCore:
                    //----------------------Thori'dal loot pools ----------------------
                    Item.NewItem(npc.getRect(), ModContent.ItemType<thoridal>(), 1);
                    break;

                default:
                    break;
            }
        }
    }

} 
