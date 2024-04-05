namespace MaUWinForms4
{
    public partial class FormMain : Form
    {
        const int maxNumberOfElements = 50;
        const int maxNumberOfIngredients = 200;

        private Recipe currentRecipe = new Recipe(maxNumberOfIngredients);
        private RecipeManager recipeMngr = new RecipeManager(maxNumberOfElements);

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lstRecipe.Items.Clear();
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            
            btnEdit.Visible = false;
            btnEditFinish.Visible = false;
            btnDelete.Visible = false;
        }
        private void UpdateGUI()
        {
            txtNameRecipe.Text = string.Empty;
            txtDescription.Text = string.Empty;

            if (currentRecipe != null)
            { 
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (currentRecipe.CurrentNumberOfIngredients() > 0)
            {
                currentRecipe.Name = txtNameRecipe.Text;
                currentRecipe.Description = txtDescription.Text;
                currentRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;

                recipeMngr.Add(currentRecipe);

                string listboxString = String.Format("{0,-15} {1,-9} {2,10}  ",
                currentRecipe.Name, currentRecipe.Category, currentRecipe.CurrentNumberOfIngredients());
                lstRecipe.Items.Add(listboxString);

                UpdateGUI();

                currentRecipe = new Recipe(maxNumberOfIngredients);
            }
            else
            {
                MessageBox.Show("No ingredients specified", "Error");
            }

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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0)
            {
                currentRecipe = recipeMngr.GetRecipeAt(lstRecipe.SelectedIndex);

                if (currentRecipe != null)
                {
                    txtNameRecipe.Text = currentRecipe.Name;
                    txtDescription.Text = currentRecipe.Description;
                    cmbFoodCategory.SelectedItem = currentRecipe.Category;

                    FormIngredients formIngredients = new FormIngredients(currentRecipe);
                    formIngredients.Text = currentRecipe.Name;
                }

                btnAddRecipe.Visible = false;
                btnEditFinish.Visible = true;
            }
        }
        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0)
            {
                currentRecipe.Name = txtNameRecipe.Text;
                currentRecipe.Description = txtDescription.Text;
                currentRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;

                recipeMngr.ChangeElement(lstRecipe.SelectedIndex, currentRecipe);

                string listboxString = String.Format("{0,-15} {1,-9} {2,10}  ",
                currentRecipe.Name, currentRecipe.Category, currentRecipe.CurrentNumberOfIngredients());

                lstRecipe.Items[lstRecipe.SelectedIndex] = listboxString;

                btnEditFinish.Visible = false;
                UpdateGUI();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0)
            {
                recipeMngr.DeleteElement(lstRecipe.SelectedIndex);
                lstRecipe.Items.Remove(lstRecipe.SelectedItem);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRecipe.ClearSelected();

            if (btnEditFinish.Visible == true)
            {
                ////

                btnEditFinish.Visible = false;
            }

        }

        private void lstRecipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Recipe recipe = recipeMngr.GetRecipeAt(lstRecipe.SelectedIndex);

            string ingredients = "";
            for (var i = 0; i < recipe.CurrentNumberOfIngredients(); i++)
            {
                ingredients += $"{recipe.Ingredients[i]}, ";
            }

            MessageBox.Show($"INGREDIENTS\n{ingredients}\n\n{recipe.Description}", $"Cooking Instructions - {recipe.Name}");
        }
        
    }
}
