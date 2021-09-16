using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Mounts
{
    public class Flameboard : ModMountData
	{
		public override void SetDefaults() {
			mountData.spawnDust = 6;
			mountData.buff = mod.BuffType("Flameboard");
			mountData.heightBoost = 30;
			mountData.fallDamage = 0f;
			mountData.runSpeed = 26f;
			mountData.dashSpeed = 26f;
			mountData.flightTimeMax = 50;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 9;
			mountData.acceleration = .9f;
			mountData.jumpSpeed = 8f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 4;
			mountData.constantJump = true;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++) {
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 15;
			mountData.bodyFrame = 3;
			mountData.yOffset = -1;
			mountData.playerHeadOffset = 0;
			mountData.standingFrameCount = 4;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 4;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 0;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 4;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode == NetmodeID.Server) {
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width + 20;
			mountData.textureHeight = mountData.backTexture.Height;
		}
	}
}