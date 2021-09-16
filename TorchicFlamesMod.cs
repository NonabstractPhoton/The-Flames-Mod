using Terraria.ModLoader;

namespace TorchicFlamesMod
{
    class TorchicFlamesMod : Mod
	{
		public static ModHotKey OrbTrigger;
		public override void Load()
		{
			OrbTrigger = RegisterHotKey("OrbTrigger", "T");
		}
		public TorchicFlamesMod()
		{
		}
	}
}
