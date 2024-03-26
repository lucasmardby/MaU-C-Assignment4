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
            set { name = value; }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public Recipe(int maxNumOfIngredients)
        {

        }

        public int CurrentNumberOfIngredients()
        {
            //
            return 1;
        }


    }
}
