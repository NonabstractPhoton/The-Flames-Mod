using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TorchicFlamesMod.Items
{
    public class Hellsword : ModItem
	{
        private int tridentsAtOnce = 0;

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellsword");
			Tooltip.SetDefault("A powerful blade made from the essence of Hell. \nSummons an unholy trident that moves in the direction of the player.");
		}
		public override void SetDefaults()
		{
			item.damage = 88;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.sellPrice(gold: 20);
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 10;
			item.mana = 1;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
		{
			target.AddBuff(BuffID.OnFire, 1800);
		}
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire);
            }
        }

        public override void OnConsumeMana(Player player, int manaConsumed)
        {
			int trident = Projectile.NewProjectile(player.position.X, player.position.Y, player.direction*20f, 0f, ProjectileID.UnholyTridentFriendly, 85, 8f, Main.myPlayer, 0f, 0f);
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddIngredient(ItemID.UnholyTrident, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ItemID.Fireblossom, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
