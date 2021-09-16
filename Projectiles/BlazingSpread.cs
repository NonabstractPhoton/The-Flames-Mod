using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Projectiles
{

    public class BlazingSpread : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 100;
			projectile.height = 100;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.tileCollide = false;
			projectile.penetrate = 3;
			projectile.timeLeft = 260;
			projectile.extraUpdates = 1;
			projectile.friendly = true;
			projectile.aiStyle = 0;
		}
		public override void AI()
		{
			Player owner = Main.player[projectile.owner]; 
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
			projectile.light = 0.8f; 
			int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, new Color(226, 88, 34), 0.75f);
		}
		public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
		{
			Player owner = Main.player[projectile.owner];
			int rand = Main.rand.Next(2); 
			if (rand == 0)
			{
				n.AddBuff(24, 360); 
			}
			else
			{
				n.AddBuff(24, 480);
			}
			
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.FlameBurst, projectile.velocity.X * -0.8f, projectile.velocity.Y * -0.8f);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.FlameBurst, projectile.velocity.X * -0.8f, projectile.velocity.Y * -0.8f);
			return true;
		}
	}
}

