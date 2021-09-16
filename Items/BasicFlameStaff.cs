using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class BasicFlameStaff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Basic Flame Staff");
			Tooltip.SetDefault("A staff that harnesses the power of the supreme flame to a low extent");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 40;
			item.magic = true;
			item.mana = 8;
			item.width = 41;
			item.height = 41;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BlazingSpread");
			item.shootSpeed = 13f;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 3600);
			}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.Flamelash, 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}