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
            InitializeGUI();
        }

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

        private void UpdateGUI()
        {
            txtNameIngredient.Text = string.Empty;
            lstIngredients.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (recipe != null)
            {
                recipe.AddIngredient(txtNameIngredient.Text);
                lstIngredients.Items.Add($"{recipe.Ingredients[Recipe.CurrentNumberOfIngredients() - 1]}");

                UpdateGUI();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            // change to addIngredients on OK click

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
