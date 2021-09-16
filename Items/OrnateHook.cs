using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TorchicFlamesMod.Items
{
    internal class OrnateHookItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Hook");
        }

        public override void SetDefaults()
        {          
            item.noUseGraphic = true;
            item.noMelee = true;
            item.damage = 0;
            item.useStyle = 5;
            item.shootSpeed = 18f;
            item.shoot = ModContent.ProjectileType<OrnateHookProjectile>();
            item.width = 18;
            item.height = 28;
            item.UseSound = SoundID.Item15;
            item.useAnimation = 18;
            item.useTime = 18;
            item.rare = 6;
            item.value = 60000;
        }


    }

    internal class OrnateHookProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("${ProjectileName.GemHookSapphire}");
        }
            
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BatHook);
        }

        public override bool? CanUseGrapple(Player player)
        {
            int hooksOut = 0;
            for (int l = 0; l < 1000; l++)
            {
                if (Main.projectile[l].active && Main.projectile[l].owner == Main.myPlayer && Main.projectile[l].type == projectile.type)
                    hooksOut++;
            }
            
            if (hooksOut > 1)
            {
                return false;
            }
                return true;
        }
        
        public override float GrappleRange()
        {
            return 400f;   
        }

        public override void NumGrappleHooks(Player player, ref int numHooks)
        {
            numHooks = 2;
        }

        public override void GrappleRetreatSpeed(Player player, ref float speed)
        {
            speed = 12f;
        }

        public override void GrapplePullSpeed(Player player, ref float speed)
        {
            speed = 15;
        }

		public override void GrappleTargetPoint(Player player, ref float grappleX, ref float grappleY) {
			Vector2 dirToPlayer = projectile.DirectionTo(player.Center);
			float hangDist = 50f;
			grappleX += dirToPlayer.X * hangDist;
			grappleY += dirToPlayer.Y * hangDist;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor) {
			Vector2 playerCenter = Main.player[projectile.owner].MountedCenter;
			Vector2 center = projectile.Center;
			Vector2 distToProj = playerCenter - projectile.Center;
			float projRotation = distToProj.ToRotation() - 1.57f;
			float distance = distToProj.Length();
			while (distance > 30f && !float.IsNaN(distance)) {
				distToProj.Normalize();                 
				distToProj *= 24f;                      
				center += distToProj;                   
				distToProj = playerCenter - center;    
				distance = distToProj.Length();
				Color drawColor = lightColor;

				spriteBatch.Draw(mod.GetTexture("Items/OrnateHookChains"), new Vector2(center.X - Main.screenPosition.X, center.Y - Main.screenPosition.Y),
					new Rectangle(0, 0, Main.chain30Texture.Width, Main.chain30Texture.Height), drawColor, projRotation,
					new Vector2(Main.chain30Texture.Width * 0.5f, Main.chain30Texture.Height * 0.5f), 1f, SpriteEffects.None, 0f);
			}
			return true;
		} 
    }
}