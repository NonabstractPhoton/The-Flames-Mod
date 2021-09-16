using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
    public class DarknessBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bow of Darkness");
			Tooltip.SetDefault("Forged at the most corrupted of altars, this bow has the darkness flowing through it.");
		}
		public override void SetDefaults()
		{
			item.damage = 55;
			item.ranged = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 200000;
			item.rare = 7;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.noMelee = true;
			item.shoot = 1;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddIngredient(ItemID.Shadewood, 10);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddIngredient(ItemID.Ebonwood, 10);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
