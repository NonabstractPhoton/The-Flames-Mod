using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.NPCs
{
    public class BSlime : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("B Slime");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 32;
			npc.damage = 50;
			npc.defense = 2;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCKilled, "Sounds/NPCKilled/B");
			npc.value = 100f;
			npc.knockBackResist = 0.4f;
			npc.aiStyle = 1;
			aiType = 1;
			animationType = 1;
			banner = Item.NPCtoBanner(1);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDaySlime.Chance * 0.05f;
		}

		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 221);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.05f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.02f;
			}
		}
		 public override void OnHitPlayer(Player player, int damage, bool crit)
			{
				player.AddBuff(86, 600, true);
			}



	}
}