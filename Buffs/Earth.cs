using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class Earth : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Earth");
			Description.SetDefault("Temporarily Harness Earth");
			Main.pvpBuff[Type] = true;
		}
	}
}