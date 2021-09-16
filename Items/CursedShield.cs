using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
    public class CursedShield : ModItem
    {
       public override void SetStaticDefaults() 
        {
			Tooltip.SetDefault("An otherwise perfect shield cursed to gradually destroy its user through its intense heat");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 38;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item1;
			item.value = 200000;
			item.rare = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.channel = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("CursedShieldProjectile");
			item.shootSpeed = 15f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TrueGoldBar"), 10);
			recipe.AddIngredient(ItemID.PaladinsShield, 1);
			recipe.AddIngredient(ItemID.BeetleHusk, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}