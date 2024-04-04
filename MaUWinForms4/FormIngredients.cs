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
            txtNameIngredient.Text = string.Empty;
            lstIngredients.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            recipe.AddIngredient(txtNameIngredient.Text);
            lstIngredients.Items.Add($"{recipe.Ingredients[Recipe.CurrentNumberOfIngredients() - 1]}");

            UpdateGUI();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex >= 0)
            {
                bool test = recipe.ChangeIngredient(lstIngredients.SelectedIndex, txtNameIngredient.Text);

                if (test)
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
