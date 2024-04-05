namespace MaUWinForms4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAddRecipe = new GroupBox();
            txtDescription = new TextBox();
            btnAddRecipe = new Button();
            btnAddIngredient = new Button();
            cmbFoodCategory = new ComboBox();
            lblCategory = new Label();
            txtNameRecipe = new TextBox();
            lblNameRecipe = new Label();
            lstRecipe = new ListBox();
            lblListName = new Label();
            lblListCategory = new Label();
            lblNumOfIngredients = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnEditFinish = new Button();
            grpAddRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddRecipe
            // 
            grpAddRecipe.Controls.Add(txtDescription);
            grpAddRecipe.Controls.Add(btnAddRecipe);
            grpAddRecipe.Controls.Add(btnAddIngredient);
            grpAddRecipe.Controls.Add(cmbFoodCategory);
            grpAddRecipe.Controls.Add(lblCategory);
            grpAddRecipe.Controls.Add(txtNameRecipe);
            grpAddRecipe.Controls.Add(lblNameRecipe);
            grpAddRecipe.Location = new Point(12, 12);
            grpAddRecipe.Name = "grpAddRecipe";
            grpAddRecipe.Size = new Size(375, 394);
            grpAddRecipe.TabIndex = 0;
            grpAddRecipe.TabStop = false;
            grpAddRecipe.Text = "Add new recipe";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 100);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 242);
            txtDescription.TabIndex = 3;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(16, 348);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(336, 23);
            btnAddRecipe.TabIndex = 1;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Location = new Point(244, 71);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(108, 23);
            btnAddIngredient.TabIndex = 1;
            btnAddIngredient.Text = "Add Ingredients";
            btnAddIngredient.UseVisualStyleBackColor = true;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Items.AddRange(new object[] { "Ricebowl", "Pasta", "Soup", "Fish", "Vegetarian", "Other" });
            cmbFoodCategory.Location = new Point(125, 71);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(99, 23);
            cmbFoodCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(16, 74);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtNameRecipe
            // 
            txtNameRecipe.Location = new Point(125, 34);
            txtNameRecipe.Name = "txtNameRecipe";
            txtNameRecipe.Size = new Size(227, 23);
            txtNameRecipe.TabIndex = 1;
            // 
            // lblNameRecipe
            // 
            lblNameRecipe.AutoSize = true;
            lblNameRecipe.Location = new Point(16, 37);
            lblNameRecipe.Name = "lblNameRecipe";
            lblNameRecipe.Size = new Size(91, 15);
            lblNameRecipe.TabIndex = 0;
            lblNameRecipe.Text = "Name of Recipe";
            // 
            // lstRecipe
            // 
            lstRecipe.FormattingEnabled = true;
            lstRecipe.ItemHeight = 15;
            lstRecipe.Location = new Point(396, 46);
            lstRecipe.Name = "lstRecipe";
            lstRecipe.Size = new Size(360, 304);
            lstRecipe.TabIndex = 1;
            lstRecipe.MouseDoubleClick += lstRecipe_MouseDoubleClick;
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new Point(408, 22);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(39, 15);
            lblListName.TabIndex = 2;
            lblListName.Text = "Name";
            // 
            // lblListCategory
            // 
            lblListCategory.AutoSize = true;
            lblListCategory.Location = new Point(524, 22);
            lblListCategory.Name = "lblListCategory";
            lblListCategory.Size = new Size(55, 15);
            lblListCategory.TabIndex = 3;
            lblListCategory.Text = "Category";
            // 
            // lblNumOfIngredients
            // 
            lblNumOfIngredients.AutoSize = true;
            lblNumOfIngredients.Location = new Point(640, 22);
            lblNumOfIngredients.Name = "lblNumOfIngredients";
            lblNumOfIngredients.Size = new Size(102, 15);
            lblNumOfIngredients.TabIndex = 4;
            lblNumOfIngredients.Text = "No. of Ingredients";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(558, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(660, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Selection";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(408, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnEditFinish
            // 
            btnEditFinish.Location = new Point(408, 389);
            btnEditFinish.Name = "btnEditFinish";
            btnEditFinish.Size = new Size(96, 23);
            btnEditFinish.TabIndex = 7;
            btnEditFinish.Text = "Finish Edit";
            btnEditFinish.UseVisualStyleBackColor = true;
            btnEditFinish.Click += btnEditFinish_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(btnEditFinish);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblNumOfIngredients);
            Controls.Add(lblListCategory);
            Controls.Add(lblListName);
            Controls.Add(lstRecipe);
            Controls.Add(grpAddRecipe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Book, Lucas Mårdby";
            grpAddRecipe.ResumeLayout(false);
            grpAddRecipe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAddRecipe;
        private Button btnAddRecipe;
        private Button btnAddIngredient;
        private ComboBox cmbFoodCategory;
        private Label lblCategory;
        private TextBox txtNameRecipe;
        private Label lblNameRecipe;
        private ListBox lstRecipe;
        private Label lblListName;
        private Label lblListCategory;
        private Label lblNumOfIngredients;
        private TextBox txtDescription;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private Button btnEditFinish;
    }
}
