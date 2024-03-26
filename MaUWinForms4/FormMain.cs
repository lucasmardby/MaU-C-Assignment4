namespace MaUWinForms4
{
    public partial class FormMain : Form
    {
        private const int maxNumberOfElements = 50;
        private const int maxNumberOfIngredients = 200;
        private RecipeManager[] recipeMngr;

        private Recipe currentRecipe = new Recipe(maxNumberOfIngredients);

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        { 
            
        }
        private void UpdateGUI()
        {
            lstRecipe.Items.Add($"{currentRecipe.Name}");
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

            UpdateGUI();
        }
    }
}
