using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
    public class UtilityKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Utility Knife");
			Tooltip.SetDefault("An effective utility knife. Perfect for avid anglers, on right click this knife is capable of making sashimi from most fish");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 34;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add Onfire buff to the NPC for a while.
			// 60 frames = 1 second
			target.AddBuff(BuffID.Bleeding, 1800);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddIngredient(ItemID.Obsidian, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 15);
			recipe.AddIngredient(ItemID.Obsidian, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	public override bool AltFunctionUse(Player player) {
			return true;
		}
	public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 4;
				item.useTime = 18;
				item.useAnimation = 18;
				item.melee = false;
				item.noMelee = true;
				int whichFish = 0;
				if (player.HasItem(2300))
					whichFish = 2300;
				if (player.HasItem(2297))
					whichFish = 2297;
				if (player.HasItem(2298))
					whichFish = 2298;
				if (player.HasItem(2309))
					whichFish = 2309;
				if (player.HasItem(2301))
					whichFish = 2301;
				if (player.HasItem(2307))
					whichFish = 2307;
				if (player.HasItem(2302))
					whichFish = 2302;
				if (player.HasItem(4401))
					whichFish = 4401;
				if (player.HasItem(2313))
					whichFish = 2313;
				if (player.HasItem(2304))
					whichFish = 2304;
				if (player.HasItem(2290))
					whichFish = 2290;
				if (player.HasItem(2229))
					whichFish = 2229;
				if (whichFish > 0)
				{
					player.PutItemInInventory(2427);
					player.ConsumeItem(whichFish, false);
				}
			}

			else {
				item.damage = 30;
				item.useTime = 15;
				item.useAnimation = 15;
				item.useStyle = 3;
				item.melee = true;
				item.noMelee = false;
			}
			return base.CanUseItem(player);
		}

	}
}
