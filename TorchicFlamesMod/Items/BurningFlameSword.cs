using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class BurningFlameSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Burning Flame Sword");
			Tooltip.SetDefault("This powered up sword harnesses the power of the supreme flame well");
		}
		public override void SetDefaults()
		{
			item.damage = 140;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 5;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add Onfire buff to the NPC for a while.
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 1800);
		}
			public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BasicFlameSword"), 1);
			recipe.AddIngredient(mod.ItemType("Ashesofaherossword"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
