namespace SmartCanteen
{
    partial class MealAddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMealAddCategoryVeggie = new System.Windows.Forms.RadioButton();
            this.radioMealAddCategoryFish = new System.Windows.Forms.RadioButton();
            this.radioMealAddCategoryMeat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMealAddDescription = new System.Windows.Forms.TextBox();
            this.btnMealAddLeave = new System.Windows.Forms.Button();
            this.btnMealAddRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBoxMealAddDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMealAddCategoryVeggie);
            this.groupBox2.Controls.Add(this.radioMealAddCategoryFish);
            this.groupBox2.Controls.Add(this.radioMealAddCategoryMeat);
            this.groupBox2.Location = new System.Drawing.Point(29, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria:";
            // 
            // radioMealAddCategoryVeggie
            // 
            this.radioMealAddCategoryVeggie.AutoSize = true;
            this.radioMealAddCategoryVeggie.Location = new System.Drawing.Point(420, 20);
            this.radioMealAddCategoryVeggie.Name = "radioMealAddCategoryVeggie";
            this.radioMealAddCategoryVeggie.Size = new System.Drawing.Size(103, 21);
            this.radioMealAddCategoryVeggie.TabIndex = 2;
            this.radioMealAddCategoryVeggie.TabStop = true;
            this.radioMealAddCategoryVeggie.Text = "Vegetariano";
            this.radioMealAddCategoryVeggie.UseVisualStyleBackColor = true;
            // 
            // radioMealAddCategoryFish
            // 
            this.radioMealAddCategoryFish.AutoSize = true;
            this.radioMealAddCategoryFish.Location = new System.Drawing.Point(215, 20);
            this.radioMealAddCategoryFish.Name = "radioMealAddCategoryFish";
            this.radioMealAddCategoryFish.Size = new System.Drawing.Size(60, 21);
            this.radioMealAddCategoryFish.TabIndex = 1;
            this.radioMealAddCategoryFish.TabStop = true;
            this.radioMealAddCategoryFish.Text = "Peixe";
            this.radioMealAddCategoryFish.UseVisualStyleBackColor = true;
            // 
            // radioMealAddCategoryMeat
            // 
            this.radioMealAddCategoryMeat.AutoSize = true;
            this.radioMealAddCategoryMeat.Checked = true;
            this.radioMealAddCategoryMeat.Location = new System.Drawing.Point(10, 20);
            this.radioMealAddCategoryMeat.Name = "radioMealAddCategoryMeat";
            this.radioMealAddCategoryMeat.Size = new System.Drawing.Size(64, 21);
            this.radioMealAddCategoryMeat.TabIndex = 0;
            this.radioMealAddCategoryMeat.TabStop = true;
            this.radioMealAddCategoryMeat.Text = "Carne";
            this.radioMealAddCategoryMeat.UseVisualStyleBackColor = true;
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
            // tBoxMealAddDescription
            // 
            this.tBoxMealAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMealAddDescription.Location = new System.Drawing.Point(29, 54);
            this.tBoxMealAddDescription.Name = "tBoxMealAddDescription";
            this.tBoxMealAddDescription.Size = new System.Drawing.Size(564, 23);
            this.tBoxMealAddDescription.TabIndex = 1;
            // 
            // btnMealAddLeave
            // 
            this.btnMealAddLeave.Location = new System.Drawing.Point(563, 246);
            this.btnMealAddLeave.Name = "btnMealAddLeave";
            this.btnMealAddLeave.Size = new System.Drawing.Size(66, 32);
            this.btnMealAddLeave.TabIndex = 15;
            this.btnMealAddLeave.Text = "Sair";
            this.btnMealAddLeave.UseVisualStyleBackColor = true;
            this.btnMealAddLeave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMealAddRegister
            // 
            this.btnMealAddRegister.Location = new System.Drawing.Point(485, 246);
            this.btnMealAddRegister.Name = "btnMealAddRegister";
            this.btnMealAddRegister.Size = new System.Drawing.Size(66, 32);
            this.btnMealAddRegister.TabIndex = 14;
            this.btnMealAddRegister.Text = "Registar";
            this.btnMealAddRegister.UseVisualStyleBackColor = true;
            this.btnMealAddRegister.Click += new System.EventHandler(this.btnMealAddRegister_Click);
            // 
            // MealAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 313);
            this.Controls.Add(this.btnMealAddLeave);
            this.Controls.Add(this.btnMealAddRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "MealAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MealAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMealAddDescription;
        private System.Windows.Forms.Button btnMealAddLeave;
        private System.Windows.Forms.Button btnMealAddRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMealAddCategoryVeggie;
        private System.Windows.Forms.RadioButton radioMealAddCategoryFish;
        private System.Windows.Forms.RadioButton radioMealAddCategoryMeat;
    }
}