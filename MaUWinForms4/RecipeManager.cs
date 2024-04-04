namespace MaUWinForms4
{
    public class RecipeManager
    {
        private Recipe[] recipeList;

        private int numOfElements = 0;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        public bool Add(Recipe recipe)
        {
            bool validInput = false;

            if (numOfElements < recipeList.Length)
            {
                recipeList[GetCurrentNumberOfRecipes()] = recipe;
                numOfElements++;
                validInput = true;
            }

            return validInput;
        }
        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            if (numOfElements < recipeList.Length)
            {
                //
                numOfElements++;
            }

            return true;
        }

        public int GetCurrentNumberOfRecipes()
        {
            return numOfElements;
        }

        private void DeleteElement(int index)
        {
            recipeList[index] = null;
            numOfElements--;
            MoveElementsOneStepLeft(index);
        }

        public Recipe GetRecipeAt(int index)
        {
            Recipe recipe = recipeList[index];
            return recipe;
        }

        private void MoveElementsOneStepLeft(int index)
        { 
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1];
            }

            recipeList[recipeList.Length - 1] = null;
        }
    }
}
