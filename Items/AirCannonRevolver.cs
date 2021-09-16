using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
    public class AirCannonRevolver : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Air Cannon Revolver");
			Tooltip.SetDefault("A revolver that shoots bullets with extremely high pressured air. This makes the bullets go extremely fast. 10% not to consume ammo");
		}

		public override void SetDefaults() {
			item.damage = 32;
			item.ranged = true;
			item.width = 40;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 7;
			item.value = 150000;
			item.rare = 4;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TrueGoldBar"), 1);
			recipe.AddIngredient(ItemID.Revolver, 1);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .10f;
		}
	}
}