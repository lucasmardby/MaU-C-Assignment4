namespace MaUWinForms4
{
    /// <summary>
    /// MainForm Class
    /// </summary>
    public partial class FormMain : Form
    {
        //Instance variables, constant numbers and objects
        const int maxNumberOfElements = 50;
        const int maxNumberOfIngredients = 200;

        private Recipe currentRecipe = new Recipe(maxNumberOfIngredients);
        private RecipeManager recipeMngr = new RecipeManager(maxNumberOfElements);

        /// <summary>
        /// FormMain(), initializing the Form and GUI
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Fixes the GUI, clearing listbox, setting the combobox, and hiding buttons for use
        /// </summary>
        private void InitializeGUI()
        {
            lstRecipe.Items.Clear();
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            
            btnEdit.Visible = false;
            btnEditFinish.Visible = false;
            btnDelete.Visible = false;
        }
        /// <summary>
        /// Updates the GUI after adding or editing a recipe, clearing the textboxes,
        /// and if a recipe is passed for editing, reveals the appropriate buttons
        /// </summary>
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

        /// <summary>
        /// Adds recipe from user-input information into the recipeManager, and text into the listbox,
        /// before creating a new currentRecipe
        /// Gives an error if no ingredients are specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Opens FormIngredients() to add ingredients to the recipe
        /// Gives an error if no ingredients are specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Edits the selected recipe, inserting its information into the textboxes and FormIngredients
        /// Reveals finish-edit button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Passes the new, edited information into the selected recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                btnAddRecipe.Visible = true;
                btnEditFinish.Visible = false;
                UpdateGUI();
            }
        }
        /// <summary>
        /// Deletes the selected recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0)
            {
                recipeMngr.DeleteElement(lstRecipe.SelectedIndex);
                lstRecipe.Items.Remove(lstRecipe.SelectedItem);
            }
        }
        /// <summary>
        /// Clears and unselects the selected recipe, and resets any input recipe information 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRecipe.ClearSelected();

            if (btnEditFinish.Visible == true)
            {
                txtNameRecipe.Text = string.Empty;
                txtDescription.Text = string.Empty;
                cmbFoodCategory.SelectedItem = FoodCategory.RiceBowl;

                btnAddRecipe.Visible = true;
                btnEditFinish.Visible = false;
            }

        }
        /// <summary>
        /// Opens detailed information about a recipe if you double-click on it in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
