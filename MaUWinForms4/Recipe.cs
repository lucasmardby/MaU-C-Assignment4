namespace MaUWinForms4
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string name;
        private string[] ingredients;

        public FoodCategory Category 
            { get; set; }
        public string Description
            { get; set; }
        public string Name
            { get; set; }
        public string[] Ingredients
            { get; set; }
    }
}
