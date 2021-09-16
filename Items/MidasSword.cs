using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
	public class MidasSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Sword of Midas");
			Tooltip.SetDefault("A sword forged by the greediest of Terrarians.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 350000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = ProjectileID.GoldenBullet;
			item.shootSpeed = 20f;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add Onfire buff to the NPC for a while.
			// 60 frames = 1 second
			target.AddBuff(BuffID.Midas, 900);
		}
		public override void MeleeEffects(Player player, Rectangle hitbox) {
		if (Main.rand.NextBool(3)) {
			//Emit dusts when swing the sword
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Gold);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TrueGoldBar"), 8);
			recipe.AddIngredient(ItemID.RichMahogany, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
