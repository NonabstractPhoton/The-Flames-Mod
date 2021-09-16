using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class OrbCooldown : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Orb Cooldown");
			Description.SetDefault("You must wait before activating your orb again.");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
		}
	}
}