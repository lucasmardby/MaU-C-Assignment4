namespace MaUWinForms4
{
    /// <summary>
    /// FormIngredient Class, for the ingredients of the recipes
    /// </summary>
    public partial class FormIngredients : Form
    {
        private Recipe recipe;
        private readonly string[] tempIngredients;

        /// <summary>
        /// Recipe property
        /// </summary>
        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        /// <summary>
        /// Initializes the Form, taking in the passed Recipe from MainForm and creates tempIngredients for later use
        /// </summary>
        /// <param name="recipe"></param>
        public FormIngredients(Recipe recipe)
        {
            Recipe = recipe;
            InitializeComponent();
            tempIngredients = new string[recipe.MaxNumOfIngredients];
            for (int i = 0; i < tempIngredients.Length; i++)
            {
                tempIngredients[i] = recipe.Ingredients[i];
            }
            InitializeGUI();
        }

        /// <summary>
        /// If a recipe is passed for editing, it lists all of its ingredients in the listbox
        /// </summary>
        private void InitializeGUI()
        {
            if (recipe.Ingredients[0] != null)
            {
                for (var i = 0; i < recipe.Ingredients[Recipe.CurrentNumberOfIngredients() - 1].Length; i++)
                {
                    lstIngredients.Items.Add($"{recipe.Ingredients[i]}");
                }
            }
        }

        /// <summary>
        /// Empties the form after adding or editing a recipe
        /// </summary>
        private void UpdateGUI()
        {
            txtNameIngredient.Text = string.Empty;
            lstIngredients.ClearSelected();
        }
        /// <summary>
        /// Adds an ingredient to the recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (recipe != null)
            {
                recipe.AddIngredient(txtNameIngredient.Text);
                lstIngredients.Items.Add($"{recipe.Ingredients[Recipe.CurrentNumberOfIngredients() - 1]}");

                UpdateGUI();
            }
        }
        /// <summary>
        /// Closes the form, with all the added ingredients sent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Cancels adding ingredients, and deletes any added from the recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Recipe.CurrentNumberOfIngredients(); i++)
            {
                Recipe.DeleteIngredient(i);
            }

            lstIngredients.Items.Clear();

            Close();
        }
        /// <summary>
        /// Edits an added ingredient, taking new input from the textbox
        /// Gives error message if text is missing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex >= 0)
            {
                bool validInput = recipe.ChangeIngredient(lstIngredients.SelectedIndex, txtNameIngredient.Text);

                if (validInput)
                {
                    lstIngredients.Items[lstIngredients.SelectedIndex] = txtNameIngredient.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Incorrect ingredient name!", "Error");   
                }

                UpdateGUI();
            }
        }
        /// <summary>
        /// Deletes the selected ingredient from the recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex >= 0)
            {
                recipe.DeleteIngredient(lstIngredients.SelectedIndex);
                lstIngredients.Items.Remove(lstIngredients.SelectedItem);
            }
        }
    }
}
