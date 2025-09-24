using Terraria.ModLoader;

namespace EAMusic
{
	public class EAMusic : Mod
	{
        public static string SoundSlot(string name)
        {
            return $"EAMusic/Sounds/Music/{name}";
        }
        public static bool EALoaded;
        public static bool EARetroLoaded;
    }
}