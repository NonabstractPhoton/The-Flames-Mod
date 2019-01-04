using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class Ashesofaherossword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ashes of a Hero's Sword");
			Tooltip.SetDefault("The ashes of a sword once held be a hero. They hold a mysterious power.");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 0;
			item.rare = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.CursedFlame, 30);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
