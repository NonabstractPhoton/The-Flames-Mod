using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFLamesMod.Items
{
	public class FlameboardKey : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons a Flameboard.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("Flameboard");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddIngredient(ItemID.SoulofFlight, 15);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddIngredient(ItemID.CrystalShard, 15);

			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}