namespace MaUWinForms4
{
    /// <summary>
    /// RecipeManager class with managing methods
    /// </summary>
    public class RecipeManager
    {
        private Recipe[] recipeList;

        private int numOfElements = 0;

        /// <summary>
        /// Initialize the recipe array
        /// </summary>
        /// <param name="maxNumOfElements"></param>
        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        /// <summary>
        /// Adds a recipe to the array, and adds one to the numOfElements counter
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns>Returns true if the recipe can be added</returns>
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
        /// <summary>
        /// Checks the current number of recipes
        /// </summary>
        /// <returns>The amount in an int</returns>
        public int CurrentNumberOfRecipes()
        {
            return numOfElements;
        }
        /// <summary>
        /// Deletes a recipe, and removes one from the numOfElements counter
        /// </summary>
        /// <param name="index">The array index of the recipe to be removed</param>
        public void DeleteElement(int index)
        {
            recipeList[index] = null;
            if (numOfElements > 0)
            {
                numOfElements--;
            }
            MoveElementsOneStepLeft(index);
        }
        /// <summary>
        /// Gives a certain selected recipe
        /// </summary>
        /// <param name="index">the array index of the selected recipe</param>
        /// <returns>the recipe</returns>
        public Recipe GetRecipeAt(int index)
        {
            Recipe recipe = recipeList[0];

            if (numOfElements > 0 && index >= 0)
            {
                recipe = recipeList[index];
            }
            return recipe;
        }
        /// <summary>
        /// Adjusts the array after an element has been removed
        /// </summary>
        /// <param name="index">index from where everything is to be adjusted</param>
        private void MoveElementsOneStepLeft(int index)
        { 
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1];
            }

            recipeList[recipeList.Length - 1] = null;
        }
        /// <summary>
        /// Changes a recipe at the given index
        /// </summary>
        /// <param name="index">The selected recipe index</param>
        /// <param name="recipe">The Recipe its to be changed to</param>
        public void ChangeElement(int index, Recipe recipe)
        {
            recipeList[index] = recipe;
        }
    }
}
