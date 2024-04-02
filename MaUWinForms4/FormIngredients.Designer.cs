namespace MaUWinForms4
{
    partial class FormIngredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpIngredient = new GroupBox();
            btnDelete = new Button();
            lstIngredients = new ListBox();
            btnEdit = new Button();
            txtNameIngredient = new TextBox();
            btnAdd = new Button();
            lblNumIngredients = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            grpIngredient.SuspendLayout();
            SuspendLayout();
            // 
            // grpIngredient
            // 
            grpIngredient.Controls.Add(btnDelete);
            grpIngredient.Controls.Add(lstIngredients);
            grpIngredient.Controls.Add(btnEdit);
            grpIngredient.Controls.Add(txtNameIngredient);
            grpIngredient.Controls.Add(btnAdd);
            grpIngredient.Location = new Point(12, 32);
            grpIngredient.Name = "grpIngredient";
            grpIngredient.Size = new Size(404, 278);
            grpIngredient.TabIndex = 0;
            grpIngredient.TabStop = false;
            grpIngredient.Text = "Ingredients";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstIngredients
            // 
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 15;
            lstIngredients.Location = new Point(6, 51);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(284, 214);
            lstIngredients.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(310, 51);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtNameIngredient
            // 
            txtNameIngredient.Location = new Point(6, 22);
            txtNameIngredient.Name = "txtNameIngredient";
            txtNameIngredient.Size = new Size(284, 23);
            txtNameIngredient.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(310, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblNumIngredients
            // 
            lblNumIngredients.AutoSize = true;
            lblNumIngredients.Location = new Point(12, 9);
            lblNumIngredients.Name = "lblNumIngredients";
            lblNumIngredients.Size = new Size(127, 15);
            lblNumIngredients.TabIndex = 1;
            lblNumIngredients.Text = "Number of Ingredients";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(110, 316);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(227, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormIngredients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 359);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblNumIngredients);
            Controls.Add(grpIngredient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormIngredients";
            Text = "FormIngredients";
            grpIngredient.ResumeLayout(false);
            grpIngredient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpIngredient;
        private Button btnDelete;
        private ListBox lstIngredients;
        private Button btnEdit;
        private TextBox txtNameIngredient;
        private Button btnAdd;
        private Label lblNumIngredients;
        private Button btnOk;
        private Button btnCancel;
    }
}