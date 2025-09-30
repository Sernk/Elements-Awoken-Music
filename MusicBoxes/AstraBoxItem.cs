using Terraria;
using Terraria.ModLoader;

namespace EAMusic.MusicBoxes
{
    public class AstraBoxItem : MusicBoxesItem
    {
        public override int Tileype => ModContent.TileType<AstraBox>();
        public override void AddRecipes()
        {
            Recipe modRecipe = CreateRecipe(1);
            modRecipe.AddIngredient(3459, 2);
            modRecipe.AddIngredient(3457, 2);
            modRecipe.AddIngredient(3459, 2);
            modRecipe.AddIngredient(3458, 2);
            modRecipe.AddIngredient(576, 1);
            modRecipe.AddTile(412);
            modRecipe.Register();
        }
    }
}