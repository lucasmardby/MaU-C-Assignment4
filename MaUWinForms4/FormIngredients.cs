namespace MaUWinForms4
{
    public partial class FormIngredients : Form
    {
        private Recipe recipe;

        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        public FormIngredients(Recipe recipe)
        {
            Recipe = recipe;
            InitializeComponent();
        }

        private void UpdateGUI()
        {
            lstIngredients.Items.Add($"{recipe.Ingredients[Recipe.CurrentNumberOfIngredients() - 1]}");
            txtNameIngredient.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            recipe.Ingredients[recipe.CurrentNumberOfIngredients()] = txtNameIngredient.Text;

            UpdateGUI();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
