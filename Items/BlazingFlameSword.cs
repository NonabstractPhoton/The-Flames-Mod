using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class BlazingFlameSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blazing Flame Sword");
			Tooltip.SetDefault("The sword, well able to harness the Supreme Flame, has revealed its abilites, but its true power has yet to awaken.");
		}
		public override void SetDefaults()
		{
			item.damage = 425;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 9;
			item.useAnimation = 11;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = Item.sellPrice(gold: 50);
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BlazingBeam");
			item.shootSpeed = 7f;
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add Onfire buff to the NPC for a while.
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 3600);
			
			target.AddBuff(BuffID.Frostburn, 3600);
	
			target.AddBuff(BuffID.Oiled, 3600);

			target.AddBuff(BuffID.Daybreak, 3600);

			target.AddBuff(BuffID.ShadowFlame, 3600);
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
			recipe.AddIngredient(mod.ItemType("BurningFlameSword"), 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddIngredient(ItemID.FlaskofFire, 3);
			recipe.AddIngredient(ItemID.DayBreak, 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 30);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	public override bool AltFunctionUse(Player player) {
			return true;
		}
	public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 3;
				item.useTime = 9;
				item.useAnimation = 9;
				item.damage = 375;
				item.shoot = ProjectileID.BallofFrost;
				item.shootSpeed = 6f;
			}
			else {
				item.useStyle = 1;
				item.useTime = 9;
				item.useAnimation = 11;
				item.damage = 425;
				item.shoot = mod.ProjectileType("BlazingBeam");
				item.shootSpeed = 7f;
			}
			return base.CanUseItem(player);
		}

	}
}
