namespace SmartCanteen
{
    partial class MealEditForm
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
            this.btnMealEditDelete = new System.Windows.Forms.Button();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.btnMealEditLeave = new System.Windows.Forms.Button();
            this.btnMealEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMealEditIdValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMealEditCategoryVeggie = new System.Windows.Forms.RadioButton();
            this.radioMealEditCategoryFish = new System.Windows.Forms.RadioButton();
            this.radioMealEditCategoryMeat = new System.Windows.Forms.RadioButton();
            this.labelMealEditId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMealEditDescription = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMealEditDelete
            // 
            this.btnMealEditDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMealEditDelete.Location = new System.Drawing.Point(35, 401);
            this.btnMealEditDelete.Name = "btnMealEditDelete";
            this.btnMealEditDelete.Size = new System.Drawing.Size(66, 32);
            this.btnMealEditDelete.TabIndex = 34;
            this.btnMealEditDelete.Text = "Delete";
            this.btnMealEditDelete.UseVisualStyleBackColor = false;
            this.btnMealEditDelete.Click += new System.EventHandler(this.btnMealEditDelete_Click);
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(35, 233);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.ReadOnly = true;
            this.dataGridViewMeals.RowHeadersWidth = 47;
            this.dataGridViewMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMeals.Size = new System.Drawing.Size(614, 150);
            this.dataGridViewMeals.TabIndex = 32;
            this.dataGridViewMeals.SelectionChanged += new System.EventHandler(this.dataGridViewMeals_SelectionChanged);
            // 
            // btnMealEditLeave
            // 
            this.btnMealEditLeave.Location = new System.Drawing.Point(583, 401);
            this.btnMealEditLeave.Name = "btnMealEditLeave";
            this.btnMealEditLeave.Size = new System.Drawing.Size(66, 32);
            this.btnMealEditLeave.TabIndex = 31;
            this.btnMealEditLeave.Text = "Sair";
            this.btnMealEditLeave.UseVisualStyleBackColor = true;
            this.btnMealEditLeave.Click += new System.EventHandler(this.btnMealEditLeave_Click);
            // 
            // btnMealEdit
            // 
            this.btnMealEdit.Location = new System.Drawing.Point(511, 401);
            this.btnMealEdit.Name = "btnMealEdit";
            this.btnMealEdit.Size = new System.Drawing.Size(66, 32);
            this.btnMealEdit.TabIndex = 30;
            this.btnMealEdit.Text = "Editar";
            this.btnMealEdit.UseVisualStyleBackColor = true;
            this.btnMealEdit.Click += new System.EventHandler(this.btnMealEditRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxActive);
            this.groupBox1.Controls.Add(this.labelMealEditIdValue);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelMealEditId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBoxMealEditDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 176);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prato:";
            // 
            // labelMealEditIdValue
            // 
            this.labelMealEditIdValue.AutoSize = true;
            this.labelMealEditIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealEditIdValue.Location = new System.Drawing.Point(281, 27);
            this.labelMealEditIdValue.Name = "labelMealEditIdValue";
            this.labelMealEditIdValue.Size = new System.Drawing.Size(16, 17);
            this.labelMealEditIdValue.TabIndex = 36;
            this.labelMealEditIdValue.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMealEditCategoryVeggie);
            this.groupBox2.Controls.Add(this.radioMealEditCategoryFish);
            this.groupBox2.Controls.Add(this.radioMealEditCategoryMeat);
            this.groupBox2.Location = new System.Drawing.Point(29, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria:";
            // 
            // radioMealEditCategoryVeggie
            // 
            this.radioMealEditCategoryVeggie.AutoSize = true;
            this.radioMealEditCategoryVeggie.Location = new System.Drawing.Point(420, 20);
            this.radioMealEditCategoryVeggie.Name = "radioMealEditCategoryVeggie";
            this.radioMealEditCategoryVeggie.Size = new System.Drawing.Size(103, 21);
            this.radioMealEditCategoryVeggie.TabIndex = 2;
            this.radioMealEditCategoryVeggie.TabStop = true;
            this.radioMealEditCategoryVeggie.Text = "Vegetariano";
            this.radioMealEditCategoryVeggie.UseVisualStyleBackColor = true;
            // 
            // radioMealEditCategoryFish
            // 
            this.radioMealEditCategoryFish.AutoSize = true;
            this.radioMealEditCategoryFish.Location = new System.Drawing.Point(215, 20);
            this.radioMealEditCategoryFish.Name = "radioMealEditCategoryFish";
            this.radioMealEditCategoryFish.Size = new System.Drawing.Size(60, 21);
            this.radioMealEditCategoryFish.TabIndex = 1;
            this.radioMealEditCategoryFish.TabStop = true;
            this.radioMealEditCategoryFish.Text = "Peixe";
            this.radioMealEditCategoryFish.UseVisualStyleBackColor = true;
            // 
            // radioMealEditCategoryMeat
            // 
            this.radioMealEditCategoryMeat.AutoSize = true;
            this.radioMealEditCategoryMeat.Checked = true;
            this.radioMealEditCategoryMeat.Location = new System.Drawing.Point(10, 20);
            this.radioMealEditCategoryMeat.Name = "radioMealEditCategoryMeat";
            this.radioMealEditCategoryMeat.Size = new System.Drawing.Size(64, 21);
            this.radioMealEditCategoryMeat.TabIndex = 0;
            this.radioMealEditCategoryMeat.TabStop = true;
            this.radioMealEditCategoryMeat.Text = "Carne";
            this.radioMealEditCategoryMeat.UseVisualStyleBackColor = true;
            // 
            // labelMealEditId
            // 
            this.labelMealEditId.AutoSize = true;
            this.labelMealEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealEditId.Location = new System.Drawing.Point(253, 27);
            this.labelMealEditId.Name = "labelMealEditId";
            this.labelMealEditId.Size = new System.Drawing.Size(25, 17);
            this.labelMealEditId.TabIndex = 35;
            this.labelMealEditId.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // tBoxMealEditDescription
            // 
            this.tBoxMealEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMealEditDescription.Location = new System.Drawing.Point(29, 54);
            this.tBoxMealEditDescription.Name = "tBoxMealEditDescription";
            this.tBoxMealEditDescription.Size = new System.Drawing.Size(564, 23);
            this.tBoxMealEditDescription.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(449, 27);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(65, 21);
            this.checkBoxActive.TabIndex = 37;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // MealEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnMealEditDelete);
            this.Controls.Add(this.dataGridViewMeals);
            this.Controls.Add(this.btnMealEditLeave);
            this.Controls.Add(this.btnMealEdit);
            this.Controls.Add(this.groupBox1);
            this.Name = "MealEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MealEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMealEditDelete;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.Button btnMealEditLeave;
        private System.Windows.Forms.Button btnMealEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMealEditCategoryVeggie;
        private System.Windows.Forms.RadioButton radioMealEditCategoryFish;
        private System.Windows.Forms.RadioButton radioMealEditCategoryMeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMealEditDescription;
        private System.Windows.Forms.Label labelMealEditIdValue;
        private System.Windows.Forms.Label labelMealEditId;
        private System.Windows.Forms.CheckBox checkBoxActive;
    }
}