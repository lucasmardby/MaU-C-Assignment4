namespace MaUWinForms4
{
    public partial class FormIngredients : Form
    {
        
        private Recipe recipe = new Recipe(200);
        
        public Recipe Recipe 
        { 
            get { return recipe; } 
            set { recipe = value; }
        }

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
        }

        private void UpdateGUI()
        {
            lstIngredients.Items.Add($"{recipe.Ingredients[Recipe.CurrentNumberOfIngredients()]}");

            txtNameIngredient.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNameIngredient.Text = recipe.Ingredients[Recipe.CurrentNumberOfIngredients()];

            UpdateGUI();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
