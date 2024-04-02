namespace MaUWinForms4
{
    public partial class FormMain : Form
    {
        const int maxNumberOfElements = 50;
        const int maxNumberOfIngredients = 200;
        private RecipeManager[] recipeMngr;

        private Recipe currentRecipe = new Recipe (maxNumberOfIngredients);

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
        }
        private void UpdateGUI()
        {
            lstRecipe.Items.Add($"{currentRecipe.Name}");
            lstRecipe.Items.Add($"{currentRecipe.Ingredients[currentRecipe.CurrentNumberOfIngredients()]}");
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FormIngredients dlg = new FormIngredients(currentRecipe);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (currentRecipe.CurrentNumberOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified", "Error");
                }
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            currentRecipe.Name = txtNameRecipe.Text;
            currentRecipe.Description = txtDescription.Text;
            //currentRecipe.Category = cmbFoodCategory.SelectedItem;
            //currentRecipe.Ingredients = ??

            UpdateGUI();
        }

    }
}
