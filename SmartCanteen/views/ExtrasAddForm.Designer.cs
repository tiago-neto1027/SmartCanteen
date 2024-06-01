namespace SmartCanteen
{
    partial class ExtrasAddForm
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
            this.btnExtrasAddLeave = new System.Windows.Forms.Button();
            this.btnExtrasAddRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioExtrasAddTypeOther = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeBeverage = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeDessert = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeSoup = new System.Windows.Forms.RadioButton();
            this.extrasAddDescriptionLabel = new System.Windows.Forms.Label();
            this.extrasAddNameLabel = new System.Windows.Forms.Label();
            this.tBoxExtrasAddDescription = new System.Windows.Forms.TextBox();
            this.tBoxExtrasAddName = new System.Windows.Forms.TextBox();
            this.numericExtrasAddStudentPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExtrasAddStudentPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtrasAddLeave
            // 
            this.btnExtrasAddLeave.Location = new System.Drawing.Point(562, 392);
            this.btnExtrasAddLeave.Name = "btnExtrasAddLeave";
            this.btnExtrasAddLeave.Size = new System.Drawing.Size(66, 32);
            this.btnExtrasAddLeave.TabIndex = 18;
            this.btnExtrasAddLeave.Text = "sair";
            this.btnExtrasAddLeave.UseVisualStyleBackColor = true;
            this.btnExtrasAddLeave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExtrasAddRegister
            // 
            this.btnExtrasAddRegister.Location = new System.Drawing.Point(451, 392);
            this.btnExtrasAddRegister.Name = "btnExtrasAddRegister";
            this.btnExtrasAddRegister.Size = new System.Drawing.Size(66, 32);
            this.btnExtrasAddRegister.TabIndex = 17;
            this.btnExtrasAddRegister.Text = "Registar";
            this.btnExtrasAddRegister.UseVisualStyleBackColor = true;
            this.btnExtrasAddRegister.Click += new System.EventHandler(this.btnExtrasAddRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.extrasAddDescriptionLabel);
            this.groupBox1.Controls.Add(this.extrasAddNameLabel);
            this.groupBox1.Controls.Add(this.tBoxExtrasAddDescription);
            this.groupBox1.Controls.Add(this.tBoxExtrasAddName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 323);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericExtrasAddStudentPrice);
            this.groupBox3.Location = new System.Drawing.Point(360, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço estudante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeOther);
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeBeverage);
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeDessert);
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeSoup);
            this.groupBox2.Location = new System.Drawing.Point(29, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo:";
            // 
            // radioExtrasAddTypeOther
            // 
            this.radioExtrasAddTypeOther.AutoSize = true;
            this.radioExtrasAddTypeOther.Checked = true;
            this.radioExtrasAddTypeOther.Location = new System.Drawing.Point(236, 21);
            this.radioExtrasAddTypeOther.Name = "radioExtrasAddTypeOther";
            this.radioExtrasAddTypeOther.Size = new System.Drawing.Size(62, 21);
            this.radioExtrasAddTypeOther.TabIndex = 3;
            this.radioExtrasAddTypeOther.TabStop = true;
            this.radioExtrasAddTypeOther.Text = "Outro";
            this.radioExtrasAddTypeOther.UseVisualStyleBackColor = true;
            // 
            // radioExtrasAddTypeBeverage
            // 
            this.radioExtrasAddTypeBeverage.AutoSize = true;
            this.radioExtrasAddTypeBeverage.Location = new System.Drawing.Point(166, 20);
            this.radioExtrasAddTypeBeverage.Name = "radioExtrasAddTypeBeverage";
            this.radioExtrasAddTypeBeverage.Size = new System.Drawing.Size(70, 21);
            this.radioExtrasAddTypeBeverage.TabIndex = 2;
            this.radioExtrasAddTypeBeverage.TabStop = true;
            this.radioExtrasAddTypeBeverage.Text = "Bebida";
            this.radioExtrasAddTypeBeverage.UseVisualStyleBackColor = true;
            // 
            // radioExtrasAddTypeDessert
            // 
            this.radioExtrasAddTypeDessert.AutoSize = true;
            this.radioExtrasAddTypeDessert.Location = new System.Drawing.Point(71, 20);
            this.radioExtrasAddTypeDessert.Name = "radioExtrasAddTypeDessert";
            this.radioExtrasAddTypeDessert.Size = new System.Drawing.Size(98, 21);
            this.radioExtrasAddTypeDessert.TabIndex = 1;
            this.radioExtrasAddTypeDessert.TabStop = true;
            this.radioExtrasAddTypeDessert.Text = "Sobremesa";
            this.radioExtrasAddTypeDessert.UseVisualStyleBackColor = true;
            // 
            // radioExtrasAddTypeSoup
            // 
            this.radioExtrasAddTypeSoup.AutoSize = true;
            this.radioExtrasAddTypeSoup.Location = new System.Drawing.Point(7, 21);
            this.radioExtrasAddTypeSoup.Name = "radioExtrasAddTypeSoup";
            this.radioExtrasAddTypeSoup.Size = new System.Drawing.Size(59, 21);
            this.radioExtrasAddTypeSoup.TabIndex = 0;
            this.radioExtrasAddTypeSoup.TabStop = true;
            this.radioExtrasAddTypeSoup.Text = "Sopa";
            this.radioExtrasAddTypeSoup.UseVisualStyleBackColor = true;
            // 
            // extrasAddDescriptionLabel
            // 
            this.extrasAddDescriptionLabel.AutoSize = true;
            this.extrasAddDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasAddDescriptionLabel.Location = new System.Drawing.Point(26, 154);
            this.extrasAddDescriptionLabel.Name = "extrasAddDescriptionLabel";
            this.extrasAddDescriptionLabel.Size = new System.Drawing.Size(75, 17);
            this.extrasAddDescriptionLabel.TabIndex = 3;
            this.extrasAddDescriptionLabel.Text = "Descrição:";
            // 
            // extrasAddNameLabel
            // 
            this.extrasAddNameLabel.AutoSize = true;
            this.extrasAddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasAddNameLabel.Location = new System.Drawing.Point(26, 27);
            this.extrasAddNameLabel.Name = "extrasAddNameLabel";
            this.extrasAddNameLabel.Size = new System.Drawing.Size(49, 17);
            this.extrasAddNameLabel.TabIndex = 2;
            this.extrasAddNameLabel.Text = "Nome:";
            // 
            // tBoxExtrasAddDescription
            // 
            this.tBoxExtrasAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxExtrasAddDescription.Location = new System.Drawing.Point(26, 172);
            this.tBoxExtrasAddDescription.Multiline = true;
            this.tBoxExtrasAddDescription.Name = "tBoxExtrasAddDescription";
            this.tBoxExtrasAddDescription.Size = new System.Drawing.Size(570, 128);
            this.tBoxExtrasAddDescription.TabIndex = 1;
            // 
            // tBoxExtrasAddName
            // 
            this.tBoxExtrasAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxExtrasAddName.Location = new System.Drawing.Point(26, 46);
            this.tBoxExtrasAddName.Name = "tBoxExtrasAddName";
            this.tBoxExtrasAddName.Size = new System.Drawing.Size(570, 23);
            this.tBoxExtrasAddName.TabIndex = 0;
            // 
            // numericExtrasAddStudentPrice
            // 
            this.numericExtrasAddStudentPrice.Location = new System.Drawing.Point(16, 32);
            this.numericExtrasAddStudentPrice.Name = "numericExtrasAddStudentPrice";
            this.numericExtrasAddStudentPrice.Size = new System.Drawing.Size(120, 23);
            this.numericExtrasAddStudentPrice.TabIndex = 0;
            // 
            // ExtrasAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnExtrasAddLeave);
            this.Controls.Add(this.btnExtrasAddRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExtrasAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExtrasAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExtrasAddStudentPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtrasAddLeave;
        private System.Windows.Forms.Button btnExtrasAddRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeOther;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeBeverage;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeDessert;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeSoup;
        private System.Windows.Forms.Label extrasAddDescriptionLabel;
        private System.Windows.Forms.Label extrasAddNameLabel;
        private System.Windows.Forms.TextBox tBoxExtrasAddDescription;
        private System.Windows.Forms.TextBox tBoxExtrasAddName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericExtrasAddStudentPrice;
    }
}