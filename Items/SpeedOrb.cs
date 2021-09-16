using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class SpeedOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orb of Speed");
			Tooltip.SetDefault("Use with the Orb Trigger hotkey for a temporary yet powerful buff to damage. Cannot be used with other orbs in your inventory.");
		}
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 36;
			item.value = 100000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Daybloom, 10);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddIngredient(ItemID.FeatherfallPotion, 1);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddIngredient(ItemID.HermesBoots, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Daybloom, 10);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddIngredient(ItemID.FeatherfallPotion, 1);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddIngredient(ItemID.SailfishBoots, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
