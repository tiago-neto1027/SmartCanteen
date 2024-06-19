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
            this.labelReservationResultMenu = new System.Windows.Forms.Label();
            this.labelReservationResultDate = new System.Windows.Forms.Label();
            this.labelReservationResultNif = new System.Windows.Forms.Label();
            this.labelReservationResultName = new System.Windows.Forms.Label();
            this.btnReservationPrint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rBtnDinner = new System.Windows.Forms.RadioButton();
            this.rBtnLunch = new System.Windows.Forms.RadioButton();
            this.labelReservationResultPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.btnReservationLeave.Location = new System.Drawing.Point(359, 480);
            this.btnReservationLeave.Name = "btnReservationLeave";
            this.btnReservationLeave.Size = new System.Drawing.Size(66, 32);
            this.btnReservationLeave.TabIndex = 13;
            this.btnReservationLeave.Text = "Sair";
            this.btnReservationLeave.UseVisualStyleBackColor = true;
            this.btnReservationLeave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservationRegister
            // 
            this.btnReservationRegister.Location = new System.Drawing.Point(182, 480);
            this.btnReservationRegister.Name = "btnReservationRegister";
            this.btnReservationRegister.Size = new System.Drawing.Size(66, 32);
            this.btnReservationRegister.TabIndex = 12;
            this.btnReservationRegister.Text = "Registar";
            this.btnReservationRegister.UseVisualStyleBackColor = true;
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
            this.btnReservationPrint.Location = new System.Drawing.Point(273, 480);
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
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 546);
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
    }
}