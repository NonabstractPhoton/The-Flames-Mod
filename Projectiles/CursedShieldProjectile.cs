using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TorchicFlamesMod.Projectiles
{
    public class CursedShieldProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.friendly = true;
            projectile.aiStyle = 20;
            projectile.width = 32;
            projectile.height = 16;
            projectile.scale = 1.1f;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.AddBuff(mod.BuffType("CursedGuard"), 2);
            return true;
        }
        public override void AI()
        {
            Player projOwner = Main.player[projectile.owner];
            Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
            projectile.position.X = ownerMountedCenter.X - (float)(.5 * (projectile.width));
        }
    }
}