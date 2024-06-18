namespace SmartCanteen
{
    partial class ExtrasEditForm
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
            this.labelExtrasEditIdValue = new System.Windows.Forms.Label();
            this.labelExtrasEditId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericExtrasEditStudentPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioExtrasAddTypeOther = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeBeverage = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeDessert = new System.Windows.Forms.RadioButton();
            this.radioExtrasAddTypeSoup = new System.Windows.Forms.RadioButton();
            this.extrasEditNameLabel = new System.Windows.Forms.Label();
            this.tBoxExtrasEditDescription = new System.Windows.Forms.TextBox();
            this.btnExtrasEditLeave = new System.Windows.Forms.Button();
            this.btnExtrasEditRegister = new System.Windows.Forms.Button();
            this.dataGridViewExtras = new System.Windows.Forms.DataGridView();
            this.btnExtrasEditDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExtrasEditStudentPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelExtrasEditIdValue);
            this.groupBox1.Controls.Add(this.labelExtrasEditId);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.extrasEditNameLabel);
            this.groupBox1.Controls.Add(this.tBoxExtrasEditDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra:";
            // 
            // labelExtrasEditIdValue
            // 
            this.labelExtrasEditIdValue.AutoSize = true;
            this.labelExtrasEditIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtrasEditIdValue.Location = new System.Drawing.Point(290, 27);
            this.labelExtrasEditIdValue.Name = "labelExtrasEditIdValue";
            this.labelExtrasEditIdValue.Size = new System.Drawing.Size(16, 17);
            this.labelExtrasEditIdValue.TabIndex = 7;
            this.labelExtrasEditIdValue.Text = "0";
            // 
            // labelExtrasEditId
            // 
            this.labelExtrasEditId.AutoSize = true;
            this.labelExtrasEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtrasEditId.Location = new System.Drawing.Point(262, 27);
            this.labelExtrasEditId.Name = "labelExtrasEditId";
            this.labelExtrasEditId.Size = new System.Drawing.Size(25, 17);
            this.labelExtrasEditId.TabIndex = 6;
            this.labelExtrasEditId.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericExtrasEditStudentPrice);
            this.groupBox3.Location = new System.Drawing.Point(360, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço estudante";
            // 
            // numericExtrasEditStudentPrice
            // 
            this.numericExtrasEditStudentPrice.DecimalPlaces = 2;
            this.numericExtrasEditStudentPrice.Location = new System.Drawing.Point(16, 32);
            this.numericExtrasEditStudentPrice.Name = "numericExtrasEditStudentPrice";
            this.numericExtrasEditStudentPrice.Size = new System.Drawing.Size(120, 23);
            this.numericExtrasEditStudentPrice.TabIndex = 0;
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
            // extrasEditNameLabel
            // 
            this.extrasEditNameLabel.AutoSize = true;
            this.extrasEditNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasEditNameLabel.Location = new System.Drawing.Point(26, 27);
            this.extrasEditNameLabel.Name = "extrasEditNameLabel";
            this.extrasEditNameLabel.Size = new System.Drawing.Size(49, 17);
            this.extrasEditNameLabel.TabIndex = 2;
            this.extrasEditNameLabel.Text = "Nome:";
            // 
            // tBoxExtrasEditDescription
            // 
            this.tBoxExtrasEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxExtrasEditDescription.Location = new System.Drawing.Point(29, 54);
            this.tBoxExtrasEditDescription.Name = "tBoxExtrasEditDescription";
            this.tBoxExtrasEditDescription.Size = new System.Drawing.Size(564, 23);
            this.tBoxExtrasEditDescription.TabIndex = 1;
            // 
            // btnExtrasEditLeave
            // 
            this.btnExtrasEditLeave.Location = new System.Drawing.Point(581, 399);
            this.btnExtrasEditLeave.Name = "btnExtrasEditLeave";
            this.btnExtrasEditLeave.Size = new System.Drawing.Size(66, 32);
            this.btnExtrasEditLeave.TabIndex = 20;
            this.btnExtrasEditLeave.Text = "Sair";
            this.btnExtrasEditLeave.UseVisualStyleBackColor = true;
            this.btnExtrasEditLeave.Click += new System.EventHandler(this.btnExtrasAddLeave_Click);
            // 
            // btnExtrasEditRegister
            // 
            this.btnExtrasEditRegister.Location = new System.Drawing.Point(509, 399);
            this.btnExtrasEditRegister.Name = "btnExtrasEditRegister";
            this.btnExtrasEditRegister.Size = new System.Drawing.Size(66, 32);
            this.btnExtrasEditRegister.TabIndex = 19;
            this.btnExtrasEditRegister.Text = "Registar";
            this.btnExtrasEditRegister.UseVisualStyleBackColor = true;
            this.btnExtrasEditRegister.Click += new System.EventHandler(this.btnExtrasEditRegister_Click);
            // 
            // dataGridViewExtras
            // 
            this.dataGridViewExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtras.Location = new System.Drawing.Point(33, 231);
            this.dataGridViewExtras.Name = "dataGridViewExtras";
            this.dataGridViewExtras.ReadOnly = true;
            this.dataGridViewExtras.RowHeadersWidth = 47;
            this.dataGridViewExtras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExtras.Size = new System.Drawing.Size(614, 150);
            this.dataGridViewExtras.TabIndex = 21;
            this.dataGridViewExtras.SelectionChanged += new System.EventHandler(this.dataGridViewExtras_SelectionChanged);
            // 
            // btnExtrasEditDelete
            // 
            this.btnExtrasEditDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExtrasEditDelete.Location = new System.Drawing.Point(33, 399);
            this.btnExtrasEditDelete.Name = "btnExtrasEditDelete";
            this.btnExtrasEditDelete.Size = new System.Drawing.Size(66, 32);
            this.btnExtrasEditDelete.TabIndex = 23;
            this.btnExtrasEditDelete.Text = "Delete";
            this.btnExtrasEditDelete.UseVisualStyleBackColor = false;
            this.btnExtrasEditDelete.Click += new System.EventHandler(this.btnExtrasEditDelete_Click);
            // 
            // ExtrasEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnExtrasEditDelete);
            this.Controls.Add(this.dataGridViewExtras);
            this.Controls.Add(this.btnExtrasEditLeave);
            this.Controls.Add(this.btnExtrasEditRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExtrasEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExtrasEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericExtrasEditStudentPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericExtrasEditStudentPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeOther;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeBeverage;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeDessert;
        private System.Windows.Forms.RadioButton radioExtrasAddTypeSoup;
        private System.Windows.Forms.Label extrasEditNameLabel;
        private System.Windows.Forms.TextBox tBoxExtrasEditDescription;
        private System.Windows.Forms.Button btnExtrasEditLeave;
        private System.Windows.Forms.Button btnExtrasEditRegister;
        private System.Windows.Forms.DataGridView dataGridViewExtras;
        private System.Windows.Forms.Label labelExtrasEditIdValue;
        private System.Windows.Forms.Label labelExtrasEditId;
        private System.Windows.Forms.Button btnExtrasEditDelete;
    }
}