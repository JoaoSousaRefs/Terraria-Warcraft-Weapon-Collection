using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using warcraftweaponscollection.Items.Materials;
using warcraftweaponscollection.Misc;
using warcraftweaponscollection.Utils;

namespace warcraftweaponscollection.Buffs
{
    public class Holyfire : ModBuff
    {
		public override bool Autoload(ref string name, ref string texture)
		{
			// NPC only buff so we'll just assign it a useless buff icon.
			texture = "Buffs/Holyfire";
			return base.Autoload(ref name, ref texture);
		}
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Holy Fire");
			Description.SetDefault("Losing life");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<globalNPC>().eFlames = true;
		}
	}
}
