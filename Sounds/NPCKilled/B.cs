using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace TorchicFlamesMod.Sounds.NPCKilled
{
	public class B : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			if (soundInstance.State == SoundState.Playing)
				return null;

			soundInstance.Volume = volume * 1f;
			soundInstance.Pan = pan;
			soundInstance.Pitch = Main.rand.Next(-5, 4) * .05f;
			return soundInstance;
		}
	}
}