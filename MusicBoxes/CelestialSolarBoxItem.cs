using Terraria;
using Terraria.ModLoader;

namespace EAMusic.MusicBoxes
{
    public class CelestialSolarBoxItem : MusicBoxesItem
    {
        public override int Tileype => ModContent.TileType<AqueousBox>();
        public override void AddRecipes()
        {
            Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
            modRecipe.AddIngredient(3458, 10);
            modRecipe.AddIngredient(576, 1);
            modRecipe.AddTile(412);
            modRecipe.Register();
        }
    }
}