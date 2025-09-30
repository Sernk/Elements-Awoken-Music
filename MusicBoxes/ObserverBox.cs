using Terraria.ModLoader;

namespace EAMusic.MusicBoxes
{
    public class ObserverBox : MusicBoxesTile
    {
        public override int ItemType => ModContent.ItemType<ObserverBoxItem>();
    }
}