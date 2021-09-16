using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class Aerowings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Wings forged purely with the esscence of the air. This allows them to reach high speeds after catching the wind.");
			DisplayName.SetDefault("Aero Wings");
        }

        public override void SetDefaults()
        {
            item.width = 5;
            item.height = 5;
            item.value = 30000;
            item.rare = 5;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 80;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.90f;
            ascentWhenRising = 0.4f;
            maxCanAscendMultiplier = 3f;
            maxAscentMultiplier = 4f;
            constantAscend = 0.116f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 3f;
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 33);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFlight, 35);
            recipe.AddIngredient(ItemID.Cloud, 50);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}