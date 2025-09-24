using ElementsAwoken;
using Terraria;
using Terraria.ModLoader;

namespace EAMusic
{
    public class EAUpdateMusic: ModSceneEffect
    {
        int music;
        public override int Music => music;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active && Main.invasionX == (double)Main.spawnTileX && MyWorld.voidInvasionUp)
            {
                if (!Main.dayTime && Main.time > 16220.0)
                {
                    music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("DawnOfTheVoidTheme"));
                    return true;
                }
                else
                {
                    music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("DawnOfTheVoidTheme1"));
                    return true;
                }
            }
            if (Main.LocalPlayer.active && Main.invasionX == (double)Main.spawnTileX && MyWorld.radiantRain)
            {
                music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("RadiantRainTheme"));
                return true;
            }
            else return false;
        }
    }
}