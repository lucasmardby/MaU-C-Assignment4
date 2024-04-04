namespace MaUWinForms4
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string name;
        private string[] ingredients;

        public FoodCategory Category
        { 
            get { return category; }
            set { category = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
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
            set { ingredients = value; }
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

    }
}
