using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;

namespace warcraftweaponscollection.Utils
{
    public class IsUndead
    {

		//Stupid long switch case to identify if NPC is considereted undead
		public static bool isUndead(NPC target)
		{
			switch (target.type)
			{
				case NPCID.Zombie:
					return true;
				case NPCID.ZombieDoctor:
					return true;
				case NPCID.ZombieElf:
					return true;
				case NPCID.ZombieElfBeard:
					return true;
				case NPCID.ZombieElfGirl:
					return true;
				case NPCID.ZombieEskimo:
					return true;
				case NPCID.ZombieMushroom:
					return true;
				case NPCID.ZombieMushroomHat:
					return true;
				case NPCID.ZombiePixie:
					return true;
				case NPCID.ZombieRaincoat:
					return true;
				case NPCID.ZombieSuperman:
					return true;
				case NPCID.ZombieSweater:
					return true;
				case NPCID.ZombieXmas:
					return true;
				case NPCID.ArmedZombie:
					return true;
				case NPCID.ArmedZombieCenx:
					return true;
				case NPCID.ArmedZombieEskimo:
					return true;
				case NPCID.ArmedZombiePincussion:
					return true;
				case NPCID.ArmedZombieSlimed:
					return true;
				case NPCID.ArmedZombieSwamp:
					return true;
				case NPCID.ArmedZombieTwiggy:
					return true;
				case NPCID.BaldZombie:
					return true;
				case NPCID.BigBaldZombie:
					return true;
				case NPCID.BigFemaleZombie:
					return true;
				case NPCID.BigPincushionZombie:
					return true;
				case NPCID.BigRainZombie:
					return true;
				case NPCID.BigSlimedZombie:
					return true;
				case NPCID.BigSwampZombie:
					return true;
				case NPCID.BigTwiggyZombie:
					return true;
				case NPCID.BigZombie:
					return true;
				case NPCID.BloodZombie:
					return true;
				case NPCID.FemaleZombie:
					return true;
				case NPCID.PincushionZombie:
					return true;
				case NPCID.SlimedZombie:
					return true;
				case NPCID.SmallBaldZombie:
					return true;
				case NPCID.SmallFemaleZombie:
					return true;
				case NPCID.SmallPincushionZombie:
					return true;
				case NPCID.SmallRainZombie:
					return true;
				case NPCID.SmallSlimedZombie:
					return true;
				case NPCID.SmallSwampZombie:
					return true;
				case NPCID.SmallTwiggyZombie:
					return true;
				case NPCID.SmallZombie:
					return true;
				case NPCID.SwampZombie:
					return true;
				case NPCID.TwiggyZombie:
					return true;
				case NPCID.UndeadMiner:
					return true;
				case NPCID.UndeadViking:
					return true;
				case NPCID.Skeleton:
					return true;
				case NPCID.SkeletonAlien:
					return true;
				case NPCID.SkeletonArcher:
					return true;
				case NPCID.SkeletonAstonaut:
					return true;
				case NPCID.SkeletonCommando:
					return true;
				case NPCID.SkeletonMerchant:
					return true;
				case NPCID.SkeletonSniper:
					return true;
					
				case NPCID.SkeletonTopHat:
					return true;
					
				case NPCID.ArmoredSkeleton:
					return true;
					
				case NPCID.BigHeadacheSkeleton:
					return true;
					
				case NPCID.BigMisassembledSkeleton:
					return true;
					
				case NPCID.BigPantlessSkeleton:
					return true;
					
				case NPCID.BigSkeleton:
					return true;
					
				case NPCID.BoneThrowingSkeleton:
					return true;
					
				case NPCID.BoneThrowingSkeleton3:
					return true;
					
				case NPCID.BoneThrowingSkeleton2:
					return true;
					
				case NPCID.BoneThrowingSkeleton4:
					return true;
					
				case NPCID.DD2SkeletonT1:
					return true;
					
				case NPCID.DD2SkeletonT3:
					return true;
					
				case NPCID.GreekSkeleton:
					return true;
					
				case NPCID.HeadacheSkeleton:
					return true;
					
				case NPCID.HeavySkeleton:
					return true;
					
				case NPCID.MisassembledSkeleton:
					return true;
					
				case NPCID.PantlessSkeleton:
					return true;
					
				case NPCID.SmallHeadacheSkeleton:
					return true;
					
				case NPCID.SmallMisassembledSkeleton:
					return true;
					
				case NPCID.SmallPantlessSkeleton:
					return true;
					
				case NPCID.SmallSkeleton:
					return true;
					
				case NPCID.TacticalSkeleton:
					return true;
					
				case NPCID.SkeletronHand:
					return true;
					
				case NPCID.SkeletronHead:
					return true;
					
				case NPCID.SkeletronPrime:
					return true;
					
				case NPCID.BoneLee:
					return true;
					
				case NPCID.BoneSerpentBody:
					return true;
					
				case NPCID.BoneSerpentHead:
					return true;
					
				case NPCID.BoneSerpentTail:
					return true;
					
				case NPCID.AngryBones:
					return true;
					
				case NPCID.AngryBonesBig:
					return true;
					
				case NPCID.AngryBonesBigHelmet:
					return true;
					
				case NPCID.AngryBonesBigMuscle:
					return true;
					
				case NPCID.BigBoned:
					return true;

				case NPCID.BlueArmoredBones:
					return true;
					
				case NPCID.BlueArmoredBonesMace:
					return true;
					
				case NPCID.BlueArmoredBonesSword:
					return true;
					
				case NPCID.DoctorBones:
					return true;
					
				case NPCID.HellArmoredBones:
					return true;
					
				case NPCID.HellArmoredBonesMace:
					return true;
					
				case NPCID.HellArmoredBonesSpikeShield:
					return true;
					
				case NPCID.HellArmoredBonesSword:
					return true;
					
				case NPCID.RustyArmoredBonesSwordNoArmor:
					return true;
					
				case NPCID.RustyArmoredBonesFlail:
					return true;
					
				case NPCID.ShortBones:
					return true;
				default:
					return false;
			}
		}
	}
}
