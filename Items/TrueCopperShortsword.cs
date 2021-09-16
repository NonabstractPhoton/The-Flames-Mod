using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class TrueCopperShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Copper Shortsword");
			Tooltip.SetDefault("A completely average weapon.");
		}
		public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 1;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			//One minute each, pretty debilitating on a normal player

			target.AddBuff(BuffID.OnFire, 3600);
			
			target.AddBuff(BuffID.Frostburn, 3600);
	
			target.AddBuff(BuffID.Oiled, 3600);

			target.AddBuff(BuffID.Daybreak, 3600);

			target.AddBuff(BuffID.ShadowFlame, 3600);

			target.AddBuff(BuffID.Poisoned, 3600);

			target.AddBuff(21, 3600);

			target.AddBuff(BuffID.Darkness, 3600);

			target.AddBuff(BuffID.Cursed, 3600);

			target.AddBuff(BuffID.Tipsy, 3600);

			target.AddBuff(BuffID.Bleeding, 3600);

			target.AddBuff(BuffID.Confused, 3600);

			target.AddBuff(BuffID.Slow, 3600);

			target.AddBuff(BuffID.Weak, 3600);

			target.AddBuff(BuffID.Silenced, 3600);

			target.AddBuff(36, 3600);

			target.AddBuff(BuffID.Horrified, 3600);

			target.AddBuff(38, 3600);

			target.AddBuff(39, 3600);

			target.AddBuff(BuffID.Chilled, 3600);

			target.AddBuff(BuffID.Frozen, 3600);

			target.AddBuff(67, 3600);

			target.AddBuff(68, 3600);

			target.AddBuff(69, 3600);

			target.AddBuff(70, 3600);

			target.AddBuff(72, 3600);

			target.AddBuff(80, 3600);

			target.AddBuff(88, 3600);

			target.AddBuff(94, 3600);

			target.AddBuff(103, 3600);

			target.AddBuff(137, 3600);

			target.AddBuff(144, 3600);

			target.AddBuff(145, 3600);

			target.AddBuff(148, 3600);

			target.AddBuff(149, 3600);

			target.AddBuff(156, 3600);

			target.AddBuff(163, 3600);

			target.AddBuff(164, 3600);

			target.AddBuff(169, 3600);

			target.AddBuff(195, 3600);

			target.AddBuff(196, 3600);

			target.AddBuff(197, 3600);

			target.AddBuff(199, 3600);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 43);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
