using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class BasicFlameSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Basic Flame Sword");
			Tooltip.SetDefault("This sword harnesses the power of the supreme flame to a low extent");
		}
		public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add Onfire buff to the NPC for a while.
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 1800);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 30);
			recipe.AddIngredient(ItemID.CrystalShard, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
