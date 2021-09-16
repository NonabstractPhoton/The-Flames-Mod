using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace TorchicFlamesMod.Items
{
	public class Chlorosphereshooter : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("ChloroSphere Cannon");
			Tooltip.SetDefault("A powerful cannon that shoots orbs of Chlorophyte energy. 20% chance to not consume ammo.");
		}

		public override void SetDefaults() {
			item.damage = 130;
			item.ranged = true;
			item.width = 60;
			item.height = 30;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 9;
			item.value = 100000;
			item.rare = 7;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.ChlorophyteOrb;
			item.shootSpeed = 18f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet);
			{
				type = ProjectileID.ChlorophyteOrb; 
			}
			return true; 
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 25);
			recipe.AddIngredient(ItemID.RichMahogany, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .20f;
		}
	}
}