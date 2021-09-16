using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class DamageOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orb of Damage");
			Tooltip.SetDefault("Use with the Orb Trigger hotkey for a temporary yet powerful buff to damage. Cannot be used with other orbs in your inventory.");
		}
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 36;
			item.value = 100000;
			item.rare = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RagePotion, 1);
			recipe.AddIngredient(ItemID.WrathPotion, 1);
			recipe.AddIngredient(ItemID.ViciousPowder, 30);
			recipe.AddIngredient(ItemID.CrimtaneBar, 20);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RagePotion, 1);
			recipe.AddIngredient(ItemID.WrathPotion, 1);
			recipe.AddIngredient(ItemID.ViciousPowder, 30);
			recipe.AddIngredient(ItemID.DemoniteBar, 20);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
