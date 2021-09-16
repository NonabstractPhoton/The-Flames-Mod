using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class Water : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Water");
			Description.SetDefault("Temporarily Harness Water");
			Main.pvpBuff[Type] = true;
		}
	}
}