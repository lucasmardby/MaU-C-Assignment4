namespace MaUWinForms4
{
    public class RecipeManager
    {
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        public bool Add(Recipe recipe)
        {
            return true;
        }
        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            return true;
        }
    }
}
