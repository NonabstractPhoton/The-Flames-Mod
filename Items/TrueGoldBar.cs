using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class TrueGoldBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Gold Bar");
			Tooltip.SetDefault("The most expensive of ingots.");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 50000;
			item.rare = 4;
			item.maxStack = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
