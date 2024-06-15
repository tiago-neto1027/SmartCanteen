namespace SmartCanteen
{
    partial class MenuAddForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.rBtnOthers = new System.Windows.Forms.RadioButton();
            this.rBtnDrinks = new System.Windows.Forms.RadioButton();
            this.rBtnDesserts = new System.Windows.Forms.RadioButton();
            this.rBtnSoup = new System.Windows.Forms.RadioButton();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.listBoxAvailableExtras = new System.Windows.Forms.ListBox();
            this.btnRemoveExtras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectExtras = new System.Windows.Forms.Button();
            this.listBoxSelectedExtras = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxMenuAddVeggie = new System.Windows.Forms.ComboBox();
            this.cBoxMenuAddFish = new System.Windows.Forms.ComboBox();
            this.cBoxMenuAddMeat = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMenuAddDateConsult = new System.Windows.Forms.Button();
            this.dateTimePickerMenuAdd = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLeaveForm = new System.Windows.Forms.Button();
            this.btnMenuAddRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxExtras);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 485);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.groupBoxFilters);
            this.groupBoxExtras.Controls.Add(this.listBoxAvailableExtras);
            this.groupBoxExtras.Controls.Add(this.btnRemoveExtras);
            this.groupBoxExtras.Controls.Add(this.label4);
            this.groupBoxExtras.Controls.Add(this.label5);
            this.groupBoxExtras.Controls.Add(this.btnSelectExtras);
            this.groupBoxExtras.Controls.Add(this.listBoxSelectedExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(29, 174);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(542, 289);
            this.groupBoxExtras.TabIndex = 7;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras:";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.rBtnOthers);
            this.groupBoxFilters.Controls.Add(this.rBtnDrinks);
            this.groupBoxFilters.Controls.Add(this.rBtnDesserts);
            this.groupBoxFilters.Controls.Add(this.rBtnSoup);
            this.groupBoxFilters.Controls.Add(this.rBtnAll);
            this.groupBoxFilters.Location = new System.Drawing.Point(9, 22);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(525, 61);
            this.groupBoxFilters.TabIndex = 7;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filtros:";
            // 
            // rBtnOthers
            // 
            this.rBtnOthers.AutoSize = true;
            this.rBtnOthers.Location = new System.Drawing.Point(378, 22);
            this.rBtnOthers.Name = "rBtnOthers";
            this.rBtnOthers.Size = new System.Drawing.Size(69, 21);
            this.rBtnOthers.TabIndex = 4;
            this.rBtnOthers.TabStop = true;
            this.rBtnOthers.Text = "Outros";
            this.rBtnOthers.UseVisualStyleBackColor = true;
            this.rBtnOthers.CheckedChanged += new System.EventHandler(this.rBtnOthers_CheckedChanged);
            // 
            // rBtnDrinks
            // 
            this.rBtnDrinks.AutoSize = true;
            this.rBtnDrinks.Location = new System.Drawing.Point(295, 22);
            this.rBtnDrinks.Name = "rBtnDrinks";
            this.rBtnDrinks.Size = new System.Drawing.Size(77, 21);
            this.rBtnDrinks.TabIndex = 3;
            this.rBtnDrinks.TabStop = true;
            this.rBtnDrinks.Text = "Bebidas";
            this.rBtnDrinks.UseVisualStyleBackColor = true;
            this.rBtnDrinks.CheckedChanged += new System.EventHandler(this.rBtnDrinks_CheckedChanged);
            // 
            // rBtnDesserts
            // 
            this.rBtnDesserts.AutoSize = true;
            this.rBtnDesserts.Location = new System.Drawing.Point(184, 22);
            this.rBtnDesserts.Name = "rBtnDesserts";
            this.rBtnDesserts.Size = new System.Drawing.Size(105, 21);
            this.rBtnDesserts.TabIndex = 2;
            this.rBtnDesserts.TabStop = true;
            this.rBtnDesserts.Text = "Sobremesas";
            this.rBtnDesserts.UseVisualStyleBackColor = true;
            this.rBtnDesserts.CheckedChanged += new System.EventHandler(this.rBtnDesserts_CheckedChanged);
            // 
            // rBtnSoup
            // 
            this.rBtnSoup.AutoSize = true;
            this.rBtnSoup.Location = new System.Drawing.Point(112, 22);
            this.rBtnSoup.Name = "rBtnSoup";
            this.rBtnSoup.Size = new System.Drawing.Size(66, 21);
            this.rBtnSoup.TabIndex = 1;
            this.rBtnSoup.TabStop = true;
            this.rBtnSoup.Text = "Sopas";
            this.rBtnSoup.UseVisualStyleBackColor = true;
            this.rBtnSoup.CheckedChanged += new System.EventHandler(this.rBtnSoup_CheckedChanged);
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Checked = true;
            this.rBtnAll.Location = new System.Drawing.Point(40, 22);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(66, 21);
            this.rBtnAll.TabIndex = 0;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "Todos";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // listBoxAvailableExtras
            // 
            this.listBoxAvailableExtras.FormattingEnabled = true;
            this.listBoxAvailableExtras.ItemHeight = 17;
            this.listBoxAvailableExtras.Location = new System.Drawing.Point(6, 132);
            this.listBoxAvailableExtras.Name = "listBoxAvailableExtras";
            this.listBoxAvailableExtras.Size = new System.Drawing.Size(206, 140);
            this.listBoxAvailableExtras.TabIndex = 1;
            // 
            // btnRemoveExtras
            // 
            this.btnRemoveExtras.Location = new System.Drawing.Point(218, 183);
            this.btnRemoveExtras.Name = "btnRemoveExtras";
            this.btnRemoveExtras.Size = new System.Drawing.Size(104, 33);
            this.btnRemoveExtras.TabIndex = 6;
            this.btnRemoveExtras.Text = "<- Remover";
            this.btnRemoveExtras.UseVisualStyleBackColor = true;
            this.btnRemoveExtras.Click += new System.EventHandler(this.btnRemoveExtras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Extras Disponíveis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extras Selecionados:";
            // 
            // btnSelectExtras
            // 
            this.btnSelectExtras.Location = new System.Drawing.Point(218, 144);
            this.btnSelectExtras.Name = "btnSelectExtras";
            this.btnSelectExtras.Size = new System.Drawing.Size(104, 33);
            this.btnSelectExtras.TabIndex = 5;
            this.btnSelectExtras.Text = "Selecionar ->";
            this.btnSelectExtras.UseVisualStyleBackColor = true;
            this.btnSelectExtras.Click += new System.EventHandler(this.btnSelectExtras_Click);
            // 
            // listBoxSelectedExtras
            // 
            this.listBoxSelectedExtras.FormattingEnabled = true;
            this.listBoxSelectedExtras.ItemHeight = 17;
            this.listBoxSelectedExtras.Location = new System.Drawing.Point(328, 132);
            this.listBoxSelectedExtras.Name = "listBoxSelectedExtras";
            this.listBoxSelectedExtras.Size = new System.Drawing.Size(206, 140);
            this.listBoxSelectedExtras.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cBoxMenuAddVeggie);
            this.groupBox3.Controls.Add(this.cBoxMenuAddFish);
            this.groupBox3.Controls.Add(this.cBoxMenuAddMeat);
            this.groupBox3.Location = new System.Drawing.Point(27, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-1, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vegetariano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peixe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carne:";
            // 
            // cBoxMenuAddVeggie
            // 
            this.cBoxMenuAddVeggie.FormattingEnabled = true;
            this.cBoxMenuAddVeggie.Location = new System.Drawing.Point(89, 79);
            this.cBoxMenuAddVeggie.Name = "cBoxMenuAddVeggie";
            this.cBoxMenuAddVeggie.Size = new System.Drawing.Size(432, 25);
            this.cBoxMenuAddVeggie.TabIndex = 2;
            // 
            // cBoxMenuAddFish
            // 
            this.cBoxMenuAddFish.FormattingEnabled = true;
            this.cBoxMenuAddFish.Location = new System.Drawing.Point(89, 50);
            this.cBoxMenuAddFish.Name = "cBoxMenuAddFish";
            this.cBoxMenuAddFish.Size = new System.Drawing.Size(432, 25);
            this.cBoxMenuAddFish.TabIndex = 1;
            // 
            // cBoxMenuAddMeat
            // 
            this.cBoxMenuAddMeat.FormattingEnabled = true;
            this.cBoxMenuAddMeat.Location = new System.Drawing.Point(89, 21);
            this.cBoxMenuAddMeat.Name = "cBoxMenuAddMeat";
            this.cBoxMenuAddMeat.Size = new System.Drawing.Size(432, 25);
            this.cBoxMenuAddMeat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMenuAddDateConsult);
            this.groupBox2.Controls.Add(this.dateTimePickerMenuAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data:";
            // 
            // btnMenuAddDateConsult
            // 
            this.btnMenuAddDateConsult.Location = new System.Drawing.Point(293, 22);
            this.btnMenuAddDateConsult.Name = "btnMenuAddDateConsult";
            this.btnMenuAddDateConsult.Size = new System.Drawing.Size(75, 23);
            this.btnMenuAddDateConsult.TabIndex = 5;
            this.btnMenuAddDateConsult.Text = "Consultar";
            this.btnMenuAddDateConsult.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerMenuAdd
            // 
            this.dateTimePickerMenuAdd.Location = new System.Drawing.Point(65, 20);
            this.dateTimePickerMenuAdd.Name = "dateTimePickerMenuAdd";
            this.dateTimePickerMenuAdd.Size = new System.Drawing.Size(194, 23);
            this.dateTimePickerMenuAdd.TabIndex = 4;
            // 
            // btnLeaveForm
            // 
            this.btnLeaveForm.Location = new System.Drawing.Point(566, 589);
            this.btnLeaveForm.Name = "btnLeaveForm";
            this.btnLeaveForm.Size = new System.Drawing.Size(66, 32);
            this.btnLeaveForm.TabIndex = 20;
            this.btnLeaveForm.Text = "Sair";
            this.btnLeaveForm.UseVisualStyleBackColor = true;
            this.btnLeaveForm.Click += new System.EventHandler(this.btnLeaveForm_Click);
            // 
            // btnMenuAddRegister
            // 
            this.btnMenuAddRegister.Location = new System.Drawing.Point(494, 589);
            this.btnMenuAddRegister.Name = "btnMenuAddRegister";
            this.btnMenuAddRegister.Size = new System.Drawing.Size(66, 32);
            this.btnMenuAddRegister.TabIndex = 19;
            this.btnMenuAddRegister.Text = "Registar";
            this.btnMenuAddRegister.UseVisualStyleBackColor = true;
            this.btnMenuAddRegister.Click += new System.EventHandler(this.btnMenuAddRegister_Click);
            // 
            // MenuAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 633);
            this.Controls.Add(this.btnLeaveForm);
            this.Controls.Add(this.btnMenuAddRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerMenuAdd;
        private System.Windows.Forms.Button btnMenuAddDateConsult;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxMenuAddVeggie;
        private System.Windows.Forms.ComboBox cBoxMenuAddFish;
        private System.Windows.Forms.ComboBox cBoxMenuAddMeat;
        private System.Windows.Forms.Button btnLeaveForm;
        private System.Windows.Forms.Button btnMenuAddRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveExtras;
        private System.Windows.Forms.Button btnSelectExtras;
        private System.Windows.Forms.ListBox listBoxSelectedExtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAvailableExtras;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton rBtnDrinks;
        private System.Windows.Forms.RadioButton rBtnDesserts;
        private System.Windows.Forms.RadioButton rBtnSoup;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.RadioButton rBtnOthers;
    }
}