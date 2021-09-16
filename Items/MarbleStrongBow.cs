using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
    public class MarbleStrongBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marble Strongbow");
			Tooltip.SetDefault("A sturdy bow made of tempered marble.");
		}
		public override void SetDefaults()
		{
			item.damage = 29;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.noMelee = true;
			item.shoot = 1;
			item.shootSpeed = 25f;
			item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MarbleBlock, 50);
			recipe.AddIngredient(ItemID.Cobweb, 10);
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
