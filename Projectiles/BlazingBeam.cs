using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Projectiles
{

    public class BlazingBeam : ModProjectile
	{
		public override void SetDefaults()
		{ 
			projectile.width = 60;
			projectile.height = 60;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 200;
			projectile.light = 0.9f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
		}
		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.light = 0.9f; 
		}

		public virtual bool CanCutTiles()
		{
			return true;
		}

		public virtual void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 158, projectile.velocity.X * -0.4f, projectile.velocity.Y * -0.4f);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 158, projectile.velocity.X * -0.8f, projectile.velocity.Y * -0.8f);
			Main.PlaySound(0, projectile.position);
			return true;
		}

	}
}