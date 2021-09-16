using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class DesertStaff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Desert Staff");
			Tooltip.SetDefault("A staff that flows with the energy of the desert, and can shoot sand and the bones of terrrarians who have died in the desert.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 15;
			item.magic = true;
			item.mana = 8;
			item.width = 35;
			item.height = 35;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = ProjectileID.SandBallGun;
			item.shootSpeed = 11f;
		}
		public override bool AltFunctionUse(Player player) {
			return true;
		}
	public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 5;
				item.useTime = 25;
				item.useAnimation = 25;
				item.damage = 35;
				item.shoot = ProjectileID.Bone;
				item.shootSpeed = 12f;
				item.mana = 20;
			}
			else {
				item.useStyle = 5;
				item.useTime = 30;
				item.useAnimation = 30;
				item.damage = 15;
				item.shoot = ProjectileID.SandBallGun;
				item.shootSpeed = 11f;
				item.mana = 8;
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 100);
			recipe.AddIngredient(ItemID.Cactus, 20);
			recipe.AddIngredient(ItemID.DesertFossil, 5);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}