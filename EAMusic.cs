using EAMusic.MusicBoxes;
using Terraria;
using Terraria.ModLoader;

namespace EAMusic
{
	public class EAMusic : Mod
	{
        public static bool EARetroLoaded;

        public static string SoundSlot(string name)
        {
            return $"EAMusic/Sounds/Music/{name}";
        }
        public override void Load()
        {
            EARetroLoaded = ModLoader.TryGetMod("EARetroMusic", out Mod EARetroMusic);
            if (!Main.dedServ)
            {
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("AncientsTheme")), ModContent.ItemType<AncientsBoxItem>(), ModContent.TileType<AncientsBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("AqueousTheme")), ModContent.ItemType<AqueousBoxItem>(), ModContent.TileType<AqueousBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("AzanaTheme")), ModContent.ItemType<AzanaBoxItem>(), ModContent.TileType<AzanaBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("CelestialThemeSolar")), ModContent.ItemType<CelestialSolarBoxItem>(), ModContent.TileType<CelestialSolarBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("CelestialThemeStardust")), ModContent.ItemType<CelestialStardustBoxItem>(), ModContent.TileType<CelestialStardustBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("CelestialThemeNebula")), ModContent.ItemType<AstraBoxItem>(), ModContent.TileType<AstraBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("AstraTheme")), ModContent.ItemType<InfernaceBoxItem>(), ModContent.TileType<InfernaceBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("InfernaceTheme")), ModContent.ItemType<CelestialVortexBoxItem>(), ModContent.TileType<CelestialVortexBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("ObserverTheme")), ModContent.ItemType<ObserverBoxItem>(), ModContent.TileType<ObserverBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("ObsidiousTheme")), ModContent.ItemType<ObsidiousBoxItem>(), ModContent.TileType<ObsidiousBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("PermafrostTheme")), ModContent.ItemType<PermafrostBoxItem>(), ModContent.TileType<PermafrostBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("RegarothTheme")), ModContent.ItemType<RegarothBoxItem>(), ModContent.TileType<RegarothBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("ScourgeFighterTheme")), ModContent.ItemType<ScourgeFighterBoxItem>(), ModContent.TileType<ScourgeFighterBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("ToySlimeTheme")), ModContent.ItemType<ToySlimeBoxItem>(), ModContent.TileType<ToySlimeBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("VoidLeviathanTheme")), ModContent.ItemType<VoidLeviathanBoxItem>(), ModContent.TileType<VoidLeviathanBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("VolcanoxTheme")), ModContent.ItemType<VolcanoxBoxItem>(), ModContent.TileType<VolcanoxBox>(), 0);
                MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(SoundSlot("WastelandTheme")), ModContent.ItemType<WastelandBoxItem>(), ModContent.TileType<WastelandBox>(), 0);
            }
        }
    }
}