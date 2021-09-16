using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Buffs
{
	public class Flameboard : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Flameboard Mount");
			Description.SetDefault("Riding on a poorly sprited flaming hoverboard.");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.Flameboard>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}