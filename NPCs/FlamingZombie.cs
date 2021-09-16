using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.NPCs
{
	public class FlamingZombie : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flaming Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 30;
			npc.defense = 8;
			npc.lifeMax = 140;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 120f;
			npc.knockBackResist = 0.6f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.1f;
		}

		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 127);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
			}
		}
 public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            player.AddBuff(BuffID.OnFire, 300, true);
        }
	}
}