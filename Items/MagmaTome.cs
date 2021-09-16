using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
	public class MagmaTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An already potent tome that, when paired together with its mist counterpart, can produce all sorts of spells \nThe buffs granted from using an elemental cast combine with others of its kind to create combo spells");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.width = 28;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item20;
			item.value = 100000;
			item.rare = 3;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.magic = true;
			item.mana = 18;
			item.shoot = ProjectileID.DD2PhoenixBowShot;
			item.shootSpeed = 8f;
			item.crit = 6;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{

				item.damage = 23;
				item.useTime = 30;
				item.useAnimation = 30;
				item.shoot = ProjectileID.GolemFist;
				item.shootSpeed = 6f;
			}
			else
			{
				item.useTime = 25;
				item.useAnimation = 25;
				item.damage = 20;
				item.shootSpeed = 8f;
				item.shoot = ProjectileID.DD2PhoenixBowShot;
			}
			return base.CanUseItem(player);
		}

		public override void OnConsumeMana(Player player, int manaConsumed)
		{
			if (player.altFunctionUse != 2)
			{
				player.AddBuff(mod.BuffType("Fire"), 600);
			}
			else if (player.altFunctionUse == 2)
			{
				player.AddBuff(mod.BuffType("Earth"), 600);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemonScythe, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Obsidian, 15);
			recipe.AddIngredient(ItemID.DirtBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}