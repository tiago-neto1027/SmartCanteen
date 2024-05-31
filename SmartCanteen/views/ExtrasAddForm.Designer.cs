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
            this.tBoxExtrasAddProfessorPrice = new System.Windows.Forms.TextBox();
            this.tBoxExtrasAddStudentPrice = new System.Windows.Forms.TextBox();
            this.extrasAddProfessorPriceLabel = new System.Windows.Forms.Label();
            this.extrasAddStudentPriceLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioExtrasAddTypeOther = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeBeverage = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeDesert = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeSoup = new System.Windows.Forms.RadioButton();
            this.extrasAddDescriptionLabel = new System.Windows.Forms.Label();
            this.extrasAddNameLabel = new System.Windows.Forms.Label();
            this.tBoxExtrasAddDescription = new System.Windows.Forms.TextBox();
            this.tBoxExtrasAddName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox3.Controls.Add(this.tBoxExtrasAddProfessorPrice);
            this.groupBox3.Controls.Add(this.tBoxExtrasAddStudentPrice);
            this.groupBox3.Controls.Add(this.extrasAddProfessorPriceLabel);
            this.groupBox3.Controls.Add(this.extrasAddStudentPriceLabel);
            this.groupBox3.Location = new System.Drawing.Point(360, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço";
            // 
            // tBoxExtrasAddProfessorPrice
            // 
            this.tBoxExtrasAddProfessorPrice.Location = new System.Drawing.Point(128, 36);
            this.tBoxExtrasAddProfessorPrice.Name = "tBoxExtrasAddProfessorPrice";
            this.tBoxExtrasAddProfessorPrice.Size = new System.Drawing.Size(87, 21);
            this.tBoxExtrasAddProfessorPrice.TabIndex = 3;
            // 
            // tBoxExtrasAddStudentPrice
            // 
            this.tBoxExtrasAddStudentPrice.Location = new System.Drawing.Point(9, 36);
            this.tBoxExtrasAddStudentPrice.Name = "tBoxExtrasAddStudentPrice";
            this.tBoxExtrasAddStudentPrice.Size = new System.Drawing.Size(87, 21);
            this.tBoxExtrasAddStudentPrice.TabIndex = 2;
            // 
            // extrasAddProfessorPriceLabel
            // 
            this.extrasAddProfessorPriceLabel.AutoSize = true;
            this.extrasAddProfessorPriceLabel.Location = new System.Drawing.Point(125, 15);
            this.extrasAddProfessorPriceLabel.Name = "extrasAddProfessorPriceLabel";
            this.extrasAddProfessorPriceLabel.Size = new System.Drawing.Size(59, 15);
            this.extrasAddProfessorPriceLabel.TabIndex = 1;
            this.extrasAddProfessorPriceLabel.Text = "Professor";
            // 
            // extrasAddStudentPriceLabel
            // 
            this.extrasAddStudentPriceLabel.AutoSize = true;
            this.extrasAddStudentPriceLabel.Location = new System.Drawing.Point(6, 17);
            this.extrasAddStudentPriceLabel.Name = "extrasAddStudentPriceLabel";
            this.extrasAddStudentPriceLabel.Size = new System.Drawing.Size(62, 15);
            this.extrasAddStudentPriceLabel.TabIndex = 0;
            this.extrasAddStudentPriceLabel.Text = "Estudante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeOther);
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeBeverage);
            this.groupBox2.Controls.Add(this.radioExtrasAddTypeDesert);
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
            this.radioExtrasAddTypeOther.Location = new System.Drawing.Point(236, 21);
            this.radioExtrasAddTypeOther.Name = "radioExtrasAddTypeOther";
            this.radioExtrasAddTypeOther.Size = new System.Drawing.Size(55, 19);
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
            this.radioExtrasAddTypeBeverage.Size = new System.Drawing.Size(64, 19);
            this.radioExtrasAddTypeBeverage.TabIndex = 2;
            this.radioExtrasAddTypeBeverage.TabStop = true;
            this.radioExtrasAddTypeBeverage.Text = "Bebida";
            this.radioExtrasAddTypeBeverage.UseVisualStyleBackColor = true;
            // 
            // radioExtrasAddTypeDesert
            // 
            this.radioExtrasAddTypeDesert.AutoSize = true;
            this.radioExtrasAddTypeDesert.Location = new System.Drawing.Point(71, 20);
            this.radioExtrasAddTypeDesert.Name = "radioExtrasAddTypeDesert";
            this.radioExtrasAddTypeDesert.Size = new System.Drawing.Size(89, 19);
            this.radioExtrasAddTypeDesert.TabIndex = 1;
            this.radioExtrasAddTypeDesert.TabStop = true;
            this.radioExtrasAddTypeDesert.Text = "Sobremesa";
            this.radioExtrasAddTypeDesert.UseVisualStyleBackColor = true;
            // 
            // radioExtrasAddTypeSoup
            // 
            this.radioExtrasAddTypeSoup.AutoSize = true;
            this.radioExtrasAddTypeSoup.Location = new System.Drawing.Point(7, 21);
            this.radioExtrasAddTypeSoup.Name = "radioExtrasAddTypeSoup";
            this.radioExtrasAddTypeSoup.Size = new System.Drawing.Size(54, 19);
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
            this.extrasAddDescriptionLabel.Size = new System.Drawing.Size(65, 15);
            this.extrasAddDescriptionLabel.TabIndex = 3;
            this.extrasAddDescriptionLabel.Text = "Descrição:";
            // 
            // extrasAddNameLabel
            // 
            this.extrasAddNameLabel.AutoSize = true;
            this.extrasAddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasAddNameLabel.Location = new System.Drawing.Point(26, 27);
            this.extrasAddNameLabel.Name = "extrasAddNameLabel";
            this.extrasAddNameLabel.Size = new System.Drawing.Size(44, 15);
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
            this.tBoxExtrasAddName.Size = new System.Drawing.Size(570, 21);
            this.tBoxExtrasAddName.TabIndex = 0;
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
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtrasAddLeave;
        private System.Windows.Forms.Button btnExtrasAddRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeOther;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeBeverage;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeDesert;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeSoup;
        private System.Windows.Forms.Label extrasAddDescriptionLabel;
        private System.Windows.Forms.Label extrasAddNameLabel;
        private System.Windows.Forms.TextBox tBoxExtrasAddDescription;
        private System.Windows.Forms.TextBox tBoxExtrasAddName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBoxExtrasAddProfessorPrice;
        private System.Windows.Forms.TextBox tBoxExtrasAddStudentPrice;
        private System.Windows.Forms.Label extrasAddProfessorPriceLabel;
        private System.Windows.Forms.Label extrasAddStudentPriceLabel;
    }
}