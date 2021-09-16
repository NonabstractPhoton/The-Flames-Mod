using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class DevSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DevSword");
			Tooltip.SetDefault("Stop Cheating.");
		}
		public override void SetDefaults()
		{
			item.damage = 5000000;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Ichor, 1800); //Why not?
		}
	}
}
