using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class CursedGuard : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cursed Guard");
			Description.SetDefault("Block all outside sources of damage, but recieve a steady decay of health from the heat of the shield's curse");
			Main.pvpBuff[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegenTime = 0;
			player.lifeRegen = -45;
		}
	}
}