using Terraria;
using Terraria.ID;
using Terraria.ModLoader; 

namespace TorchicFlamesMod.Items
{
    public class MistTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An already potent tome that, when paired together with its magma counterpart, can produce all sorts of spells \nThe buffs granted from using an elemental cast combine with others of its kind to create combo spells");
        }
		
		public override void SetDefaults()
		{
			item.damage = 10;
			item.width = 28;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item21;
			item.value = 50000;
			item.rare = 3;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.magic = true;
			item.mana = 15;
			item.shoot = ProjectileID.WaterBolt;
			item.shootSpeed = 8f;
			item.crit = 5;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{

				item.useTime = 30;
				item.useAnimation = 30;
				item.damage = 15;
				item.shoot = ProjectileID.DD2ApprenticeStorm;
				item.shootSpeed = 6f;
			}
			else
			{
				item.useTime = 25;
				item.useAnimation = 25;
				item.damage = 10;
				item.shootSpeed = 8f;
				item.shoot = ProjectileID.WaterBolt;
			}
			return base.CanUseItem(player);
		}

		public override void OnConsumeMana(Player player, int manaConsumed)
        {
			if (player.altFunctionUse != 2)
			{
				player.AddBuff(mod.BuffType("Water"), 600);
			}
			else if (player.altFunctionUse == 2)
			{
				player.AddBuff(mod.BuffType("Wind"), 600);
			}
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddIngredient(ItemID.RainCloud, 15);
			recipe.AddIngredient(ItemID.SnowBlock, 50);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}