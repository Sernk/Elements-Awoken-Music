using Terraria;
using Terraria.ModLoader;

namespace EAMusic.MusicBoxes
{
    public class CelestialStardustBoxItem : MusicBoxesItem
    {
        public override int Tileype => ModContent.TileType<CelestialStardustBox>();
        public override void AddRecipes()
        {
            Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
            modRecipe.AddIngredient(3459, 10);
            modRecipe.AddIngredient(576, 1);
            modRecipe.AddTile(412);
            modRecipe.Register();
        }
    }
}