using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod
{
    public class TorchicFlamesModPlayer : ModPlayer
	{
		public int hitCountBeforeRemovalofBlessing;
		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
			if (player.HasBuff(mod.BuffType("CursedGuard")))
			{
				damage = 0;
				playSound = false;
				crit = false;
			}
			return true;
        }

		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
			if (player.HasBuff(mod.BuffType("CursedGuard")))
				Main.PlaySound(SoundID.NPCHit17, player.position);
			
			hitCountBeforeRemovalofBlessing--;
			
			if (hitCountBeforeRemovalofBlessing < 1)
				player.ClearBuff(BuffID.DryadsWard);
		}
		
		public override bool PreItemCheck()
        {
			if (player.HasBuff(mod.BuffType("CursedGuard")))
				player.ClearBuff(mod.BuffType("CursedGuard"));
			return true;
        }
		
		public override void PostItemCheck()
        {
			if (player.HasBuff(mod.BuffType("Fire")) && player.HasBuff(mod.BuffType("Earth")) && !(player.HasBuff(mod.BuffType("Wind"))) && !(player.HasBuff(mod.BuffType("Water"))))
            {
				Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 10f, 0f, ProjectileID.FlamingJack, 70, 0.2f, Main.myPlayer, BuffID.OnFire, 0f);
				
				player.ClearBuff(mod.BuffType("Fire"));
				player.ClearBuff(mod.BuffType("Earth"));
			}

			if (player.HasBuff(mod.BuffType("Water")) && player.HasBuff(mod.BuffType("Wind")) && !(player.HasBuff(mod.BuffType("Fire"))) && !(player.HasBuff(mod.BuffType("Earth"))))
			{
				int proj = Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 8f, 0f, ProjectileID.FrostWave, 50, 4f, Main.myPlayer, BuffID.Frozen, 0f);
				Main.projectile[proj].friendly = true;
				Main.projectile[proj].hostile = false;
				
				player.ClearBuff(mod.BuffType("Water"));
				player.ClearBuff(mod.BuffType("Wind"));
			}
			
			if (player.HasBuff(mod.BuffType("Water")) && player.HasBuff(mod.BuffType("Fire")) && !(player.HasBuff(mod.BuffType("Earth"))) && !(player.HasBuff(mod.BuffType("Wind"))))
			{
				Vector2 mousePosition = Main.MouseWorld;

				Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 8f, 0f, ProjectileID.BallofFrost, 45, 0.2f, Main.myPlayer, BuffID.Frozen, 0f);
				Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 8f, 0f, ProjectileID.BallofFire, 45, 0.2f, Main.myPlayer, BuffID.OnFire, 0f);
				
				Projectile.NewProjectile((float)(player.direction * player.width * -1) + mousePosition.X, mousePosition.Y, (player.direction) * 8f, (mousePosition.Y > player.position.Y ) ? 1f : (mousePosition.Y < player.position.Y) ? -1f : 0f, ProjectileID.LunarFlare, 100, 5f, Main.myPlayer, BuffID.OnFire, 0f);
				
				player.ClearBuff(mod.BuffType("Water"));
				player.ClearBuff(mod.BuffType("Fire"));
				player.statMana -= 15;
			}

			if (player.HasBuff(mod.BuffType("Earth")) && player.HasBuff(mod.BuffType("Wind")) && !(player.HasBuff(mod.BuffType("Fire"))) && !(player.HasBuff(mod.BuffType("Water"))))
			{
				Vector2 mousePosition = Main.MouseWorld;

				Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 49f, 0f, ProjectileID.FlowerPow, 100, 4f, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(player.position.X + (float)(player.direction * 5), player.position.Y, (player.direction) * 8f, 0f, ProjectileID.SporeCloud, 45, 0.2f, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile((float)(player.direction * player.width * -1) + mousePosition.X, mousePosition.Y, (player.direction) * 8f, 0f, ProjectileID.CrystalLeafShot, 45, 0.2f, Main.myPlayer, 0f, 0f);

				player.ClearBuff(mod.BuffType("Earth"));
				player.ClearBuff(mod.BuffType("Wind"));
				player.statMana -= 15;
			}

			if (player.HasBuff(mod.BuffType("Earth")) && player.HasBuff(mod.BuffType("Water")) && !(player.HasBuff(mod.BuffType("Fire"))) && !(player.HasBuff(mod.BuffType("Wind"))))
			{
				player.AddBuff(BuffID.Ironskin, 600);
				player.AddBuff(BuffID.DryadsWard, 600);
				hitCountBeforeRemovalofBlessing = 10;

				player.ClearBuff(mod.BuffType("Earth"));
				player.ClearBuff(mod.BuffType("Water"));
			}

			if (player.HasBuff(mod.BuffType("Fire")) && player.HasBuff(mod.BuffType("Wind")) && !(player.HasBuff(mod.BuffType("Earth"))) && !(player.HasBuff(mod.BuffType("Water"))))
			{
				Vector2 mousePosition = Main.MouseWorld;

				for (int i = 0; i < 100; i++)
					Projectile.NewProjectile(player.position.X, player.position.Y, (player.direction) * 12f, (mousePosition.Y > player.position.Y) ? 1f : (mousePosition.Y < player.position.Y) ? -1f : 0f, ProjectileID.Flames, 100, 4f, Main.myPlayer, 0f, 0f);

				player.ClearBuff(mod.BuffType("Fire"));
				player.ClearBuff(mod.BuffType("Wind"));
			}
		}

		public override void OnEnterWorld(Player player)
		{
			hitCountBeforeRemovalofBlessing = 10;
		}
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (TorchicFlamesMod.OrbTrigger.JustPressed && !player.HasItem(mod.ItemType("HealOrb")) && !player.HasItem(mod.ItemType("SpeedOrb")) && !player.HasBuff(mod.BuffType("OrbCooldown")) && player.HasItem(mod.ItemType("DamageOrb")) && !player.HasItem(mod.ItemType("GoldenOrb")))
			{
				player.AddBuff(7, 600);
				player.AddBuff(16, 600);
				player.AddBuff(71, 600);
				player.AddBuff(100, 600);
				player.AddBuff(115, 600);
				player.AddBuff(117, 600);
				player.AddBuff(mod.BuffType("OrbCooldown"), 1800);
			}
			else
			{
				if (TorchicFlamesMod.OrbTrigger.JustPressed && !player.HasItem(mod.ItemType("DamageOrb")) && !player.HasItem(mod.ItemType("SpeedOrb")) && !player.HasItem(mod.ItemType("GoldenOrb")) && !player.HasBuff(mod.BuffType("OrbCooldown")) && player.HasItem(mod.ItemType("HealOrb")))
				{
					player.AddBuff(48, 600);
					player.AddBuff(58, 600);
					player.AddBuff(105, 600);
					player.AddBuff(113, 600);
					player.AddBuff(119, 600);
					player.AddBuff(175, 600);
					player.AddBuff(mod.BuffType("OrbCooldown"), 1800);
				}
				else
				{
					if (TorchicFlamesMod.OrbTrigger.JustPressed && !player.HasItem(mod.ItemType("DamageOrb")) && !player.HasItem(mod.ItemType("HealOrb")) && !player.HasItem(mod.ItemType("GoldenOrb")) && !player.HasBuff(mod.BuffType("OrbCooldown")) && player.HasItem(mod.ItemType("SpeedOrb")))
					{
						player.AddBuff(3, 900);
						player.AddBuff(63, 900);
						player.AddBuff(192, 900);
						player.AddBuff(8, 900);
						player.AddBuff(mod.BuffType("OrbCooldown"), 1800);
					}
					else
                    {
						if (TorchicFlamesMod.OrbTrigger.JustPressed && !player.HasItem(mod.ItemType("DamageOrb")) && !player.HasItem(mod.ItemType("HealOrb")) && !player.HasBuff(mod.BuffType("OrbCooldown")) && !player.HasItem(mod.ItemType("SpeedOrb")) && player.HasItem(mod.ItemType("GoldenOrb")))
                        {
							player.AddBuff(7, 900);
							player.AddBuff(16, 900);
							player.AddBuff(71, 900);
							player.AddBuff(100, 900);
							player.AddBuff(115, 900);
							player.AddBuff(117, 900);
							player.AddBuff(48, 900);
							player.AddBuff(58, 900);
							player.AddBuff(105, 900);
							player.AddBuff(113, 900);
							player.AddBuff(175, 900);
							player.AddBuff(3, 900);
							player.AddBuff(63, 900);
							player.AddBuff(192, 900);
							player.AddBuff(8, 900);
							player.AddBuff(mod.BuffType("OrbCooldown"), 2700);
							Main.PlaySound(SoundID.Item29, player.position);
						}
                    }
				}
			}
		}
	}
}