using TorchicFlamesMod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchicFlamesMod
{
    public class TorchicFlamesModWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            for (int i = 0; i < 1000; i++)
            {
                Chest chest = Main.chest[i];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36)
                {
                    for (int inv = 0; inv < 7; inv++)
                    {
                        if (chest.item[inv].type == ItemID.None)
                        {
                            if (Main.rand.Next(10) == 0)
                            {
                                chest.item[inv].SetDefaults(ModContent.ItemType<OrnateHookItem>());
                                break;
                            }  
                            
                        }
                    }
                }
            }
        }
    }
}