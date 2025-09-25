using System;
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
        }
    }
}