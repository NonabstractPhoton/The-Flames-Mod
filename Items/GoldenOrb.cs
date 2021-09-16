using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class GoldenOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orb of Purity");
			Tooltip.SetDefault("Use with the OrbTrigger hotkey to activate an extended buff to healing, damage, and speed with more cooldown. Cannot be used with another orb in your inventory.");
		}
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 36;
			item.value = 100000;
			item.rare = -12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("SpeedOrb"), 1); ;
			recipe.AddIngredient(mod.ItemType("HealOrb"), 1);
			recipe.AddIngredient(mod.ItemType("DamageOrb"), 1);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 50);
			recipe.AddIngredient(ItemID.ShinyStone, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool CanBurnInLava()
		{
			return false;
		}
	}
}
