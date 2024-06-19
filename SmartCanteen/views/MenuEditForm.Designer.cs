namespace SmartCanteen.views
{
    partial class MenuEditForm
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
            this.groupBoxOthers = new System.Windows.Forms.GroupBox();
            this.nrPrice = new System.Windows.Forms.NumericUpDown();
            this.nrQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeaveForm = new System.Windows.Forms.Button();
            this.btnMenuEdit = new System.Windows.Forms.Button();
            this.lExistingMenus = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data:";
            // 
            // rBtnDinner
            // 
            this.rBtnDinner.AutoSize = true;
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
            this.dateTimePickerMenuAdd.Location = new System.Drawing.Point(65, 20);
            this.dateTimePickerMenuAdd.Name = "dateTimePickerMenuAdd";
            this.dateTimePickerMenuAdd.Size = new System.Drawing.Size(194, 21);
            this.dateTimePickerMenuAdd.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxExtras);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(260, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 423);
            this.groupBox1.TabIndex = 4;
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
            this.groupBoxExtras.Location = new System.Drawing.Point(16, 141);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(435, 269);
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
            this.groupBoxFilters.Location = new System.Drawing.Point(9, 19);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(417, 61);
            this.groupBoxFilters.TabIndex = 7;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filtros:";
            // 
            // rBtnOthers
            // 
            this.rBtnOthers.AutoSize = true;
            this.rBtnOthers.Location = new System.Drawing.Point(343, 20);
            this.rBtnOthers.Name = "rBtnOthers";
            this.rBtnOthers.Size = new System.Drawing.Size(61, 19);
            this.rBtnOthers.TabIndex = 4;
            this.rBtnOthers.TabStop = true;
            this.rBtnOthers.Text = "Outros";
            this.rBtnOthers.UseVisualStyleBackColor = true;
            this.rBtnOthers.CheckedChanged += new System.EventHandler(this.rBtnOthers_CheckedChanged);
            // 
            // rBtnDrinks
            // 
            this.rBtnDrinks.AutoSize = true;
            this.rBtnDrinks.Location = new System.Drawing.Point(267, 20);
            this.rBtnDrinks.Name = "rBtnDrinks";
            this.rBtnDrinks.Size = new System.Drawing.Size(70, 19);
            this.rBtnDrinks.TabIndex = 3;
            this.rBtnDrinks.TabStop = true;
            this.rBtnDrinks.Text = "Bebidas";
            this.rBtnDrinks.UseVisualStyleBackColor = true;
            this.rBtnDrinks.CheckedChanged += new System.EventHandler(this.rBtnDrinks_CheckedChanged);
            // 
            // rBtnDesserts
            // 
            this.rBtnDesserts.AutoSize = true;
            this.rBtnDesserts.Location = new System.Drawing.Point(166, 20);
            this.rBtnDesserts.Name = "rBtnDesserts";
            this.rBtnDesserts.Size = new System.Drawing.Size(95, 19);
            this.rBtnDesserts.TabIndex = 2;
            this.rBtnDesserts.TabStop = true;
            this.rBtnDesserts.Text = "Sobremesas";
            this.rBtnDesserts.UseVisualStyleBackColor = true;
            this.rBtnDesserts.CheckedChanged += new System.EventHandler(this.rBtnDesserts_CheckedChanged);
            // 
            // rBtnSoup
            // 
            this.rBtnSoup.AutoSize = true;
            this.rBtnSoup.Location = new System.Drawing.Point(100, 20);
            this.rBtnSoup.Name = "rBtnSoup";
            this.rBtnSoup.Size = new System.Drawing.Size(60, 19);
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
            this.rBtnAll.Location = new System.Drawing.Point(35, 20);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(59, 19);
            this.rBtnAll.TabIndex = 0;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "Todos";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // listBoxAvailableExtras
            // 
            this.listBoxAvailableExtras.FormattingEnabled = true;
            this.listBoxAvailableExtras.ItemHeight = 15;
            this.listBoxAvailableExtras.Location = new System.Drawing.Point(11, 117);
            this.listBoxAvailableExtras.Name = "listBoxAvailableExtras";
            this.listBoxAvailableExtras.Size = new System.Drawing.Size(140, 139);
            this.listBoxAvailableExtras.TabIndex = 1;
            // 
            // btnRemoveExtras
            // 
            this.btnRemoveExtras.Location = new System.Drawing.Point(166, 168);
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
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Extras Disponíveis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extras Selecionados:";
            // 
            // btnSelectExtras
            // 
            this.btnSelectExtras.Location = new System.Drawing.Point(166, 129);
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
            this.listBoxSelectedExtras.ItemHeight = 15;
            this.listBoxSelectedExtras.Location = new System.Drawing.Point(286, 117);
            this.listBoxSelectedExtras.Name = "listBoxSelectedExtras";
            this.listBoxSelectedExtras.Size = new System.Drawing.Size(140, 139);
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
            this.groupBox3.Location = new System.Drawing.Point(16, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 115);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vegetariano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peixe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carne:";
            // 
            // cBoxMenuAddVeggie
            // 
            this.cBoxMenuAddVeggie.FormattingEnabled = true;
            this.cBoxMenuAddVeggie.Location = new System.Drawing.Point(83, 80);
            this.cBoxMenuAddVeggie.Name = "cBoxMenuAddVeggie";
            this.cBoxMenuAddVeggie.Size = new System.Drawing.Size(343, 23);
            this.cBoxMenuAddVeggie.TabIndex = 2;
            // 
            // cBoxMenuAddFish
            // 
            this.cBoxMenuAddFish.FormattingEnabled = true;
            this.cBoxMenuAddFish.Location = new System.Drawing.Point(83, 51);
            this.cBoxMenuAddFish.Name = "cBoxMenuAddFish";
            this.cBoxMenuAddFish.Size = new System.Drawing.Size(343, 23);
            this.cBoxMenuAddFish.TabIndex = 1;
            // 
            // cBoxMenuAddMeat
            // 
            this.cBoxMenuAddMeat.FormattingEnabled = true;
            this.cBoxMenuAddMeat.Location = new System.Drawing.Point(83, 22);
            this.cBoxMenuAddMeat.Name = "cBoxMenuAddMeat";
            this.cBoxMenuAddMeat.Size = new System.Drawing.Size(343, 23);
            this.cBoxMenuAddMeat.TabIndex = 0;
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.Controls.Add(this.nrPrice);
            this.groupBoxOthers.Controls.Add(this.nrQuantity);
            this.groupBoxOthers.Controls.Add(this.label6);
            this.groupBoxOthers.Controls.Add(this.label7);
            this.groupBoxOthers.Location = new System.Drawing.Point(15, 354);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(229, 92);
            this.groupBoxOthers.TabIndex = 24;
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
            this.nrPrice.Location = new System.Drawing.Point(90, 56);
            this.nrPrice.Name = "nrPrice";
            this.nrPrice.Size = new System.Drawing.Size(120, 20);
            this.nrPrice.TabIndex = 3;
            // 
            // nrQuantity
            // 
            this.nrQuantity.Location = new System.Drawing.Point(90, 19);
            this.nrQuantity.Name = "nrQuantity";
            this.nrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nrQuantity.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Preço base:";
            // 
            // btnLeaveForm
            // 
            this.btnLeaveForm.Location = new System.Drawing.Point(188, 452);
            this.btnLeaveForm.Name = "btnLeaveForm";
            this.btnLeaveForm.Size = new System.Drawing.Size(66, 32);
            this.btnLeaveForm.TabIndex = 23;
            this.btnLeaveForm.Text = "Sair";
            this.btnLeaveForm.UseVisualStyleBackColor = true;
            this.btnLeaveForm.Click += new System.EventHandler(this.btnLeaveForm_Click);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.Location = new System.Drawing.Point(14, 452);
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Size = new System.Drawing.Size(80, 32);
            this.btnMenuEdit.TabIndex = 22;
            this.btnMenuEdit.Text = "Editar";
            this.btnMenuEdit.UseVisualStyleBackColor = true;
            this.btnMenuEdit.Click += new System.EventHandler(this.btnMenuEdit_Click);
            // 
            // lExistingMenus
            // 
            this.lExistingMenus.FormattingEnabled = true;
            this.lExistingMenus.Location = new System.Drawing.Point(14, 32);
            this.lExistingMenus.Name = "lExistingMenus";
            this.lExistingMenus.Size = new System.Drawing.Size(229, 316);
            this.lExistingMenus.TabIndex = 8;
            this.lExistingMenus.SelectedIndexChanged += new System.EventHandler(this.lExistingMenus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Menus:";
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(105, 452);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(84, 32);
            this.btnDeleteMenu.TabIndex = 25;
            this.btnDeleteMenu.Text = "Eliminar";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // MenuEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 510);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lExistingMenus);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.btnLeaveForm);
            this.Controls.Add(this.btnMenuEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuEditForm";
            this.Text = "MenuEdit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxOthers.ResumeLayout(false);
            this.groupBoxOthers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnDinner;
        private System.Windows.Forms.RadioButton rBtnLunch;
        private System.Windows.Forms.DateTimePicker dateTimePickerMenuAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton rBtnOthers;
        private System.Windows.Forms.RadioButton rBtnDrinks;
        private System.Windows.Forms.RadioButton rBtnDesserts;
        private System.Windows.Forms.RadioButton rBtnSoup;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.ListBox listBoxAvailableExtras;
        private System.Windows.Forms.Button btnRemoveExtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectExtras;
        private System.Windows.Forms.ListBox listBoxSelectedExtras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxMenuAddVeggie;
        private System.Windows.Forms.ComboBox cBoxMenuAddFish;
        private System.Windows.Forms.ComboBox cBoxMenuAddMeat;
        private System.Windows.Forms.GroupBox groupBoxOthers;
        private System.Windows.Forms.NumericUpDown nrPrice;
        private System.Windows.Forms.NumericUpDown nrQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLeaveForm;
        private System.Windows.Forms.Button btnMenuEdit;
        private System.Windows.Forms.ListBox lExistingMenus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteMenu;
    }
}