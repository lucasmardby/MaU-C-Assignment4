namespace MaUWinForms4
{
    /// <summary>
    /// Recipe class, for all the recipe objects
    /// </summary>
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string name;
        private string[] ingredients;

        private int numOfIngredients = 0;

        //Recipe properties for all the Recipe attributes, making sure all values aren't empty or null

        public FoodCategory Category
        { 
            get { return category; }
            set { category = value; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (value.IsNotNullOrEmpty())
                {
                    description = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set { 
                if (value.IsNotNullOrEmpty())
                { 
                    name = value; 
                }
            }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set
            {
                if (value.ToString().IsNotNullOrEmpty())
                {
                    ingredients = value;
                }
            }
        }
        public int MaxNumOfIngredients 
        {
            get { return Ingredients.Length; }
        }

        /// <summary>
        /// Constructor initializing the ingredient array
        /// </summary>
        /// <param name="maxNumOfIngredients">max amount, from the const in MainForm.cs</param>
        public Recipe(int maxNumOfIngredients)
        {
            Ingredients = new string[maxNumOfIngredients];
        }
        /// <summary>
        /// LINQ lambda statement that gives the current amount of ingredients
        /// </summary>
        /// <returns>the amount</returns>
        public int CurrentNumberOfIngredients()
        {
            return Ingredients.Where(i => i.IsNotNullOrEmpty())
                              .Count();
        }
        /// <summary>
        /// Adds ingredient to the array, and increases the numOfIng counter
        /// </summary>
        /// <param name="input">the ingredient to be added</param>
        /// <returns>true if ingredient can be added</returns>
        public bool AddIngredient(string input)
        {
            bool validInput = false;

            if (numOfIngredients < Ingredients.Length)
            {
                Ingredients[CurrentNumberOfIngredients()] = input;
                numOfIngredients++;
                validInput = true;
            }

            return validInput;
        }
        /// <summary>
        /// Changes an ingredient at a given index
        /// </summary>
        /// <param name="index">the index where a change is to be made</param>
        /// <param name="value">the new value to be inserted</param>
        /// <returns>true if a correct value is input</returns>
        public bool ChangeIngredient(int index, string value)
        {
            bool validInput = false;

            if (value.IsNotNullOrEmpty())
            { 
                Ingredients[index] = value;

                validInput = true;
            }

            return validInput;
        }
        /// <summary>
        /// Deletes an ingredient, and decreases the numOfIng counter
        /// </summary>
        /// <param name="index">the index of the ingredient to be removed</param>
        public void DeleteIngredient(int index)
        {
            Ingredients[index] = null;
            if (Ingredients.Length > 0)
            {
                numOfIngredients--;
            }
            MoveElementsOneStepLeft(index);
        }
        /// <summary>
        /// Adjusts the array after an element has been removed
        /// </summary>
        /// <param name="index">index from where everything is to be adjusted</param>
        private void MoveElementsOneStepLeft(int index)
        {
            for (int i = index; i < Ingredients.Length - 2; i++)
            {
                Ingredients[i] = Ingredients[i + 1];
            }

            Ingredients[Ingredients.Length - 1] = null;
        }
    }
}
