using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class PlasmaSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plasma Sword");
			Tooltip.SetDefault("Not a lightsaber ripoff, I swear");
		}
		public override void SetDefaults()
		{
			item.damage = 49;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = Item.sellPrice(gold: 40);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
			{
			target.AddBuff(BuffID.Electrified, 1800);
			target.AddBuff(144, 1800);
			target.AddBuff(BuffID.Frostburn, 1800);
			}
			public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 263);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 20);
			recipe.AddIngredient(ItemID.UnicornHorn, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.PearlstoneBlock, 100);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
