using TorchicFlamesMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class GaeBolg : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("\"Originality is Clearly Not My Strong Suit\"");
		}

		public override void SetDefaults()
		{
			item.damage = 240;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 24;
			item.useTime = 24;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(platinum: 1);

			item.melee = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 

			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<GaeBolgProjectile>();
		}
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Cursed, 60);
			target.AddBuff(BuffID.Bleeding, 100000);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DayBreak, 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddIngredient(ItemID.AdamantiteBar, 25);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(ItemID.FragmentNebula, 3);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}