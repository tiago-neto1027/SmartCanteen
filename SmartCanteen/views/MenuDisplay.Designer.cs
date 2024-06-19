namespace SmartCanteen.views
{
    partial class MenuDisplay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnDinner = new System.Windows.Forms.RadioButton();
            this.rBtnLunch = new System.Windows.Forms.RadioButton();
            this.dateTimePickerMenuAdd = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxMenuAddVeggie = new System.Windows.Forms.ComboBox();
            this.cBoxMenuAddFish = new System.Windows.Forms.ComboBox();
            this.cBoxMenuAddMeat = new System.Windows.Forms.ComboBox();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.listBoxAvailableExtras = new System.Windows.Forms.ListBox();
            this.groupBoxOthers = new System.Windows.Forms.GroupBox();
            this.nrPrice = new System.Windows.Forms.NumericUpDown();
            this.nrQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLeaveForm = new System.Windows.Forms.Button();
            this.btnMenuAddRegister = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBoxOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnDinner);
            this.groupBox2.Controls.Add(this.rBtnLunch);
            this.groupBox2.Controls.Add(this.dateTimePickerMenuAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data:";
            // 
            // rBtnDinner
            // 
            this.rBtnDinner.AutoSize = true;
            this.rBtnDinner.Enabled = false;
            this.rBtnDinner.Location = new System.Drawing.Point(357, 22);
            this.rBtnDinner.Name = "rBtnDinner";
            this.rBtnDinner.Size = new System.Drawing.Size(59, 19);
            this.rBtnDinner.TabIndex = 6;
            this.rBtnDinner.TabStop = true;
            this.rBtnDinner.Text = "Jantar";
            this.rBtnDinner.UseVisualStyleBackColor = true;
            // 
            // rBtnLunch
            // 
            this.rBtnLunch.AutoSize = true;
            this.rBtnLunch.Checked = true;
            this.rBtnLunch.Enabled = false;
            this.rBtnLunch.Location = new System.Drawing.Point(285, 22);
            this.rBtnLunch.Name = "rBtnLunch";
            this.rBtnLunch.Size = new System.Drawing.Size(66, 19);
            this.rBtnLunch.TabIndex = 5;
            this.rBtnLunch.TabStop = true;
            this.rBtnLunch.Text = "Almoço";
            this.rBtnLunch.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerMenuAdd
            // 
            this.dateTimePickerMenuAdd.Enabled = false;
            this.dateTimePickerMenuAdd.Location = new System.Drawing.Point(65, 20);
            this.dateTimePickerMenuAdd.Name = "dateTimePickerMenuAdd";
            this.dateTimePickerMenuAdd.Size = new System.Drawing.Size(194, 21);
            this.dateTimePickerMenuAdd.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cBoxMenuAddVeggie);
            this.groupBox3.Controls.Add(this.cBoxMenuAddFish);
            this.groupBox3.Controls.Add(this.cBoxMenuAddMeat);
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 128);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pratos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-1, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vegetariano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peixe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carne:";
            // 
            // cBoxMenuAddVeggie
            // 
            this.cBoxMenuAddVeggie.Enabled = false;
            this.cBoxMenuAddVeggie.FormattingEnabled = true;
            this.cBoxMenuAddVeggie.Location = new System.Drawing.Point(89, 79);
            this.cBoxMenuAddVeggie.Name = "cBoxMenuAddVeggie";
            this.cBoxMenuAddVeggie.Size = new System.Drawing.Size(432, 21);
            this.cBoxMenuAddVeggie.TabIndex = 2;
            // 
            // cBoxMenuAddFish
            // 
            this.cBoxMenuAddFish.Enabled = false;
            this.cBoxMenuAddFish.FormattingEnabled = true;
            this.cBoxMenuAddFish.Location = new System.Drawing.Point(89, 50);
            this.cBoxMenuAddFish.Name = "cBoxMenuAddFish";
            this.cBoxMenuAddFish.Size = new System.Drawing.Size(432, 21);
            this.cBoxMenuAddFish.TabIndex = 1;
            // 
            // cBoxMenuAddMeat
            // 
            this.cBoxMenuAddMeat.Enabled = false;
            this.cBoxMenuAddMeat.FormattingEnabled = true;
            this.cBoxMenuAddMeat.Location = new System.Drawing.Point(89, 21);
            this.cBoxMenuAddMeat.Name = "cBoxMenuAddMeat";
            this.cBoxMenuAddMeat.Size = new System.Drawing.Size(432, 21);
            this.cBoxMenuAddMeat.TabIndex = 0;
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.listBoxAvailableExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(12, 209);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(259, 234);
            this.groupBoxExtras.TabIndex = 8;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras:";
            // 
            // listBoxAvailableExtras
            // 
            this.listBoxAvailableExtras.FormattingEnabled = true;
            this.listBoxAvailableExtras.Location = new System.Drawing.Point(6, 15);
            this.listBoxAvailableExtras.Name = "listBoxAvailableExtras";
            this.listBoxAvailableExtras.Size = new System.Drawing.Size(247, 212);
            this.listBoxAvailableExtras.TabIndex = 1;
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.Controls.Add(this.nrPrice);
            this.groupBoxOthers.Controls.Add(this.nrQuantity);
            this.groupBoxOthers.Controls.Add(this.label7);
            this.groupBoxOthers.Controls.Add(this.label6);
            this.groupBoxOthers.Location = new System.Drawing.Point(296, 209);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(260, 113);
            this.groupBoxOthers.TabIndex = 22;
            this.groupBoxOthers.TabStop = false;
            this.groupBoxOthers.Text = "Outros:";
            // 
            // nrPrice
            // 
            this.nrPrice.DecimalPlaces = 2;
            this.nrPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nrPrice.Location = new System.Drawing.Point(106, 75);
            this.nrPrice.Name = "nrPrice";
            this.nrPrice.Size = new System.Drawing.Size(120, 20);
            this.nrPrice.TabIndex = 3;
            // 
            // nrQuantity
            // 
            this.nrQuantity.Location = new System.Drawing.Point(106, 28);
            this.nrQuantity.Name = "nrQuantity";
            this.nrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nrQuantity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Preço base:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade:";
            // 
            // btnLeaveForm
            // 
            this.btnLeaveForm.Location = new System.Drawing.Point(456, 351);
            this.btnLeaveForm.Name = "btnLeaveForm";
            this.btnLeaveForm.Size = new System.Drawing.Size(66, 32);
            this.btnLeaveForm.TabIndex = 24;
            this.btnLeaveForm.Text = "Sair";
            this.btnLeaveForm.UseVisualStyleBackColor = true;
            this.btnLeaveForm.Click += new System.EventHandler(this.btnLeaveForm_Click);
            // 
            // btnMenuAddRegister
            // 
            this.btnMenuAddRegister.Location = new System.Drawing.Point(325, 351);
            this.btnMenuAddRegister.Name = "btnMenuAddRegister";
            this.btnMenuAddRegister.Size = new System.Drawing.Size(66, 32);
            this.btnMenuAddRegister.TabIndex = 23;
            this.btnMenuAddRegister.Text = "Registar";
            this.btnMenuAddRegister.UseVisualStyleBackColor = true;
            this.btnMenuAddRegister.Click += new System.EventHandler(this.btnMenuAddRegister_Click);
            // 
            // MenuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.btnLeaveForm);
            this.Controls.Add(this.btnMenuAddRegister);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.groupBoxExtras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MenuDisplay";
            this.Text = "MenuDisplay";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxOthers.ResumeLayout(false);
            this.groupBoxOthers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnDinner;
        private System.Windows.Forms.RadioButton rBtnLunch;
        private System.Windows.Forms.DateTimePicker dateTimePickerMenuAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxMenuAddVeggie;
        private System.Windows.Forms.ComboBox cBoxMenuAddFish;
        private System.Windows.Forms.ComboBox cBoxMenuAddMeat;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.ListBox listBoxAvailableExtras;
        private System.Windows.Forms.GroupBox groupBoxOthers;
        private System.Windows.Forms.NumericUpDown nrPrice;
        private System.Windows.Forms.NumericUpDown nrQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLeaveForm;
        private System.Windows.Forms.Button btnMenuAddRegister;
    }
}