using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class Wind : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Wind");
			Description.SetDefault("Temporarily Harness Wind");
			Main.pvpBuff[Type] = true;
		}
	}
}