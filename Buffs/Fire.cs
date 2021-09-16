using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class Fire : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Fire");
			Description.SetDefault("Temporarily Harness Fire");
			Main.pvpBuff[Type] = true;
		}
	}
}