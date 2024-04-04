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
                recipeList[CurrentNumberOfRecipes()] = recipe;
                numOfElements++;
                validInput = true;
            }

            return validInput;
        }
        public int CurrentNumberOfRecipes()
        {
            return numOfElements;
        }
        public void DeleteElement(int index)
        {
            recipeList[index] = null;
            if (recipeList.Length > 0)
            {
                numOfElements--;
            }
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
        public void ChangeElement(int index, Recipe recipe)
        { 
            
        }
    }
}
