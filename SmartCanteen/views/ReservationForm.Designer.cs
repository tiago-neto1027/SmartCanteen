namespace SmartCanteen
{
    partial class ReservationForm
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
            this.monthCalendarReservation = new System.Windows.Forms.MonthCalendar();
            this.btnReservationLeave = new System.Windows.Forms.Button();
            this.btnReservationRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioReservationMenuMeat = new System.Windows.Forms.RadioButton();
            this.radioReservationMenuVeggie = new System.Windows.Forms.RadioButton();
            this.radioReservationMenuFish = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReservationSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxReservationNif = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelReservationResultPrice = new System.Windows.Forms.Label();
            this.labelReservationResultMenu = new System.Windows.Forms.Label();
            this.labelReservationResultDate = new System.Windows.Forms.Label();
            this.labelReservationResultNif = new System.Windows.Forms.Label();
            this.labelReservationResultName = new System.Windows.Forms.Label();
            this.btnReservationPrint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rBtnDinner = new System.Windows.Forms.RadioButton();
            this.rBtnLunch = new System.Windows.Forms.RadioButton();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.rBtnOthers = new System.Windows.Forms.RadioButton();
            this.rBtnDrinks = new System.Windows.Forms.RadioButton();
            this.rBtnDesserts = new System.Windows.Forms.RadioButton();
            this.rBtnSoup = new System.Windows.Forms.RadioButton();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.listBoxAvailableExtras = new System.Windows.Forms.ListBox();
            this.btnRemoveExtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectExtras = new System.Windows.Forms.Button();
            this.listBoxSelectedExtras = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarReservation
            // 
            this.monthCalendarReservation.Location = new System.Drawing.Point(37, 98);
            this.monthCalendarReservation.Name = "monthCalendarReservation";
            this.monthCalendarReservation.TabIndex = 0;
            this.monthCalendarReservation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarReservation_DateChanged);
            // 
            // btnReservationLeave
            // 
            this.btnReservationLeave.Location = new System.Drawing.Point(349, 764);
            this.btnReservationLeave.Name = "btnReservationLeave";
            this.btnReservationLeave.Size = new System.Drawing.Size(66, 32);
            this.btnReservationLeave.TabIndex = 13;
            this.btnReservationLeave.Text = "Sair";
            this.btnReservationLeave.UseVisualStyleBackColor = true;
            this.btnReservationLeave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservationRegister
            // 
            this.btnReservationRegister.Location = new System.Drawing.Point(172, 764);
            this.btnReservationRegister.Name = "btnReservationRegister";
            this.btnReservationRegister.Size = new System.Drawing.Size(66, 32);
            this.btnReservationRegister.TabIndex = 12;
            this.btnReservationRegister.Text = "Registar";
            this.btnReservationRegister.UseVisualStyleBackColor = true;
            this.btnReservationRegister.Click += new System.EventHandler(this.btnReservationRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioReservationMenuMeat);
            this.groupBox1.Controls.Add(this.radioReservationMenuVeggie);
            this.groupBox1.Controls.Add(this.radioReservationMenuFish);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu:";
            // 
            // radioReservationMenuMeat
            // 
            this.radioReservationMenuMeat.AutoSize = true;
            this.radioReservationMenuMeat.Location = new System.Drawing.Point(6, 24);
            this.radioReservationMenuMeat.Name = "radioReservationMenuMeat";
            this.radioReservationMenuMeat.Size = new System.Drawing.Size(64, 21);
            this.radioReservationMenuMeat.TabIndex = 2;
            this.radioReservationMenuMeat.TabStop = true;
            this.radioReservationMenuMeat.Text = "Carne";
            this.radioReservationMenuMeat.UseVisualStyleBackColor = true;
            this.radioReservationMenuMeat.CheckedChanged += new System.EventHandler(this.radioReservationMenuMeat_CheckedChanged);
            // 
            // radioReservationMenuVeggie
            // 
            this.radioReservationMenuVeggie.AutoSize = true;
            this.radioReservationMenuVeggie.Location = new System.Drawing.Point(6, 72);
            this.radioReservationMenuVeggie.Name = "radioReservationMenuVeggie";
            this.radioReservationMenuVeggie.Size = new System.Drawing.Size(103, 21);
            this.radioReservationMenuVeggie.TabIndex = 1;
            this.radioReservationMenuVeggie.TabStop = true;
            this.radioReservationMenuVeggie.Text = "Vegetariano";
            this.radioReservationMenuVeggie.UseVisualStyleBackColor = true;
            this.radioReservationMenuVeggie.CheckedChanged += new System.EventHandler(this.radioReservationMenuVeggie_CheckedChanged);
            // 
            // radioReservationMenuFish
            // 
            this.radioReservationMenuFish.AutoSize = true;
            this.radioReservationMenuFish.Location = new System.Drawing.Point(6, 47);
            this.radioReservationMenuFish.Name = "radioReservationMenuFish";
            this.radioReservationMenuFish.Size = new System.Drawing.Size(60, 21);
            this.radioReservationMenuFish.TabIndex = 0;
            this.radioReservationMenuFish.TabStop = true;
            this.radioReservationMenuFish.Text = "Peixe";
            this.radioReservationMenuFish.UseVisualStyleBackColor = true;
            this.radioReservationMenuFish.CheckedChanged += new System.EventHandler(this.radioReservationMenuFish_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReservationSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tBoxReservationNif);
            this.groupBox2.Location = new System.Drawing.Point(37, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa:";
            // 
            // btnReservationSearch
            // 
            this.btnReservationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationSearch.Location = new System.Drawing.Point(236, 23);
            this.btnReservationSearch.Name = "btnReservationSearch";
            this.btnReservationSearch.Size = new System.Drawing.Size(70, 30);
            this.btnReservationSearch.TabIndex = 10;
            this.btnReservationSearch.Text = "Procurar";
            this.btnReservationSearch.UseVisualStyleBackColor = true;
            this.btnReservationSearch.Click += new System.EventHandler(this.btnReservationSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "NIF:";
            // 
            // tBoxReservationNif
            // 
            this.tBoxReservationNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxReservationNif.Location = new System.Drawing.Point(70, 29);
            this.tBoxReservationNif.Name = "tBoxReservationNif";
            this.tBoxReservationNif.Size = new System.Drawing.Size(160, 23);
            this.tBoxReservationNif.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelReservationResultPrice);
            this.groupBox3.Controls.Add(this.labelReservationResultMenu);
            this.groupBox3.Controls.Add(this.labelReservationResultDate);
            this.groupBox3.Controls.Add(this.labelReservationResultNif);
            this.groupBox3.Controls.Add(this.labelReservationResultName);
            this.groupBox3.Location = new System.Drawing.Point(297, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 343);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // labelReservationResultPrice
            // 
            this.labelReservationResultPrice.AutoSize = true;
            this.labelReservationResultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationResultPrice.Location = new System.Drawing.Point(4, 181);
            this.labelReservationResultPrice.Name = "labelReservationResultPrice";
            this.labelReservationResultPrice.Size = new System.Drawing.Size(55, 17);
            this.labelReservationResultPrice.TabIndex = 5;
            this.labelReservationResultPrice.Text = "Preço:";
            // 
            // labelReservationResultMenu
            // 
            this.labelReservationResultMenu.AutoSize = true;
            this.labelReservationResultMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationResultMenu.Location = new System.Drawing.Point(6, 151);
            this.labelReservationResultMenu.Name = "labelReservationResultMenu";
            this.labelReservationResultMenu.Size = new System.Drawing.Size(52, 17);
            this.labelReservationResultMenu.TabIndex = 4;
            this.labelReservationResultMenu.Text = "Menu:";
            // 
            // labelReservationResultDate
            // 
            this.labelReservationResultDate.AutoSize = true;
            this.labelReservationResultDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationResultDate.Location = new System.Drawing.Point(12, 119);
            this.labelReservationResultDate.Name = "labelReservationResultDate";
            this.labelReservationResultDate.Size = new System.Drawing.Size(47, 17);
            this.labelReservationResultDate.TabIndex = 2;
            this.labelReservationResultDate.Text = "Data:";
            // 
            // labelReservationResultNif
            // 
            this.labelReservationResultNif.AutoSize = true;
            this.labelReservationResultNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationResultNif.Location = new System.Drawing.Point(20, 83);
            this.labelReservationResultNif.Name = "labelReservationResultNif";
            this.labelReservationResultNif.Size = new System.Drawing.Size(37, 17);
            this.labelReservationResultNif.TabIndex = 1;
            this.labelReservationResultNif.Text = "NIF:";
            // 
            // labelReservationResultName
            // 
            this.labelReservationResultName.AutoSize = true;
            this.labelReservationResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationResultName.Location = new System.Drawing.Point(4, 43);
            this.labelReservationResultName.Name = "labelReservationResultName";
            this.labelReservationResultName.Size = new System.Drawing.Size(54, 17);
            this.labelReservationResultName.TabIndex = 0;
            this.labelReservationResultName.Text = "Nome:";
            // 
            // btnReservationPrint
            // 
            this.btnReservationPrint.Location = new System.Drawing.Point(263, 764);
            this.btnReservationPrint.Name = "btnReservationPrint";
            this.btnReservationPrint.Size = new System.Drawing.Size(66, 32);
            this.btnReservationPrint.TabIndex = 16;
            this.btnReservationPrint.Text = "Imprimir";
            this.btnReservationPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rBtnDinner);
            this.groupBox4.Controls.Add(this.rBtnLunch);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(37, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 48);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horário:";
            // 
            // rBtnDinner
            // 
            this.rBtnDinner.AutoSize = true;
            this.rBtnDinner.Location = new System.Drawing.Point(110, 22);
            this.rBtnDinner.Name = "rBtnDinner";
            this.rBtnDinner.Size = new System.Drawing.Size(66, 21);
            this.rBtnDinner.TabIndex = 1;
            this.rBtnDinner.TabStop = true;
            this.rBtnDinner.Text = "Jantar";
            this.rBtnDinner.UseVisualStyleBackColor = true;
            this.rBtnDinner.CheckedChanged += new System.EventHandler(this.rBtnDinner_CheckedChanged);
            // 
            // rBtnLunch
            // 
            this.rBtnLunch.AutoSize = true;
            this.rBtnLunch.Location = new System.Drawing.Point(7, 22);
            this.rBtnLunch.Name = "rBtnLunch";
            this.rBtnLunch.Size = new System.Drawing.Size(72, 21);
            this.rBtnLunch.TabIndex = 0;
            this.rBtnLunch.TabStop = true;
            this.rBtnLunch.Text = "Almoço";
            this.rBtnLunch.UseVisualStyleBackColor = true;
            this.rBtnLunch.CheckedChanged += new System.EventHandler(this.rBtnLunch_CheckedChanged);
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.groupBoxFilters);
            this.groupBoxExtras.Controls.Add(this.listBoxAvailableExtras);
            this.groupBoxExtras.Controls.Add(this.btnRemoveExtras);
            this.groupBoxExtras.Controls.Add(this.label1);
            this.groupBoxExtras.Controls.Add(this.label5);
            this.groupBoxExtras.Controls.Add(this.btnSelectExtras);
            this.groupBoxExtras.Controls.Add(this.listBoxSelectedExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(37, 447);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(565, 289);
            this.groupBoxExtras.TabIndex = 18;
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
            this.groupBoxFilters.Location = new System.Drawing.Point(25, 29);
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
            this.rBtnOthers.Size = new System.Drawing.Size(56, 17);
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
            this.rBtnDrinks.Size = new System.Drawing.Size(63, 17);
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
            this.rBtnDesserts.Size = new System.Drawing.Size(83, 17);
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
            this.rBtnSoup.Size = new System.Drawing.Size(55, 17);
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
            this.rBtnAll.Size = new System.Drawing.Size(55, 17);
            this.rBtnAll.TabIndex = 0;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "Todos";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // listBoxAvailableExtras
            // 
            this.listBoxAvailableExtras.FormattingEnabled = true;
            this.listBoxAvailableExtras.Location = new System.Drawing.Point(22, 139);
            this.listBoxAvailableExtras.Name = "listBoxAvailableExtras";
            this.listBoxAvailableExtras.Size = new System.Drawing.Size(206, 134);
            this.listBoxAvailableExtras.TabIndex = 1;
            // 
            // btnRemoveExtras
            // 
            this.btnRemoveExtras.Location = new System.Drawing.Point(234, 190);
            this.btnRemoveExtras.Name = "btnRemoveExtras";
            this.btnRemoveExtras.Size = new System.Drawing.Size(104, 33);
            this.btnRemoveExtras.TabIndex = 6;
            this.btnRemoveExtras.Text = "<- Remover";
            this.btnRemoveExtras.UseVisualStyleBackColor = true;
            this.btnRemoveExtras.Click += new System.EventHandler(this.btnRemoveExtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extras Disponíveis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extras Selecionados:";
            // 
            // btnSelectExtras
            // 
            this.btnSelectExtras.Location = new System.Drawing.Point(234, 151);
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
            this.listBoxSelectedExtras.Location = new System.Drawing.Point(344, 139);
            this.listBoxSelectedExtras.Name = "listBoxSelectedExtras";
            this.listBoxSelectedExtras.Size = new System.Drawing.Size(206, 134);
            this.listBoxSelectedExtras.TabIndex = 4;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 825);
            this.Controls.Add(this.groupBoxExtras);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnReservationPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReservationLeave);
            this.Controls.Add(this.btnReservationRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendarReservation);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarReservation;
        private System.Windows.Forms.Button btnReservationLeave;
        private System.Windows.Forms.Button btnReservationRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioReservationMenuVeggie;
        private System.Windows.Forms.RadioButton radioReservationMenuFish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReservationSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxReservationNif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelReservationResultDate;
        private System.Windows.Forms.Label labelReservationResultNif;
        private System.Windows.Forms.Label labelReservationResultName;
        private System.Windows.Forms.RadioButton radioReservationMenuMeat;
        private System.Windows.Forms.Label labelReservationResultMenu;
        private System.Windows.Forms.Button btnReservationPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rBtnDinner;
        private System.Windows.Forms.RadioButton rBtnLunch;
        private System.Windows.Forms.Label labelReservationResultPrice;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton rBtnOthers;
        private System.Windows.Forms.RadioButton rBtnDrinks;
        private System.Windows.Forms.RadioButton rBtnDesserts;
        private System.Windows.Forms.RadioButton rBtnSoup;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.ListBox listBoxAvailableExtras;
        private System.Windows.Forms.Button btnRemoveExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectExtras;
        private System.Windows.Forms.ListBox listBoxSelectedExtras;
    }
}