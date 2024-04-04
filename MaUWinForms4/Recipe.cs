namespace MaUWinForms4
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string name;
        private string[] ingredients;

        private int numOfIngredients = 0;

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

        public Recipe(int maxNumOfIngredients)
        {
            Ingredients = new string[maxNumOfIngredients];
        }

        public int CurrentNumberOfIngredients()
        {
            return Ingredients.Where(i => i.IsNotNullOrEmpty())
                              .Count();
        }

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

        public void DeleteIngredient(int index)
        {
            Ingredients[index] = null;
            if (Ingredients.Length > 0)
            {
                numOfIngredients--;
            }
            MoveElementsOneStepLeft(index);
        }
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
