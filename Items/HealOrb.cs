using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class HealOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orb of Health");
			Tooltip.SetDefault("Use with the Orb Trigger hotkey for a temporary yet powerful buff to healing. Cannot be used with another orb in your inventory.");
		}
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 36;
			item.value = 100000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 20);
			recipe.AddIngredient(ItemID.Mushroom, 10);
			recipe.AddIngredient(ItemID.RegenerationPotion, 10);
			recipe.AddIngredient(ItemID.BandofRegeneration, 1);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
