namespace SmartCanteen
{
    partial class MealRegisterForm
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
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelClientCurrent = new System.Windows.Forms.Label();
            this.labelClientType = new System.Windows.Forms.Label();
            this.labelClientNif = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.labelNIF = new System.Windows.Forms.Label();
            this.tBoxClientSearchNif = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDish = new System.Windows.Forms.TextBox();
            this.textBoxExtras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMealTime = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.Location = new System.Drawing.Point(478, 66);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(194, 381);
            this.listBoxReservations.TabIndex = 0;
            this.listBoxReservations.SelectedIndexChanged += new System.EventHandler(this.listBoxReservations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservas por marcar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelClientCurrent);
            this.groupBox2.Controls.Add(this.labelClientType);
            this.groupBox2.Controls.Add(this.labelClientNif);
            this.groupBox2.Controls.Add(this.labelClientName);
            this.groupBox2.Location = new System.Drawing.Point(36, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente:";
            // 
            // labelClientCurrent
            // 
            this.labelClientCurrent.AutoSize = true;
            this.labelClientCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientCurrent.Location = new System.Drawing.Point(13, 147);
            this.labelClientCurrent.Name = "labelClientCurrent";
            this.labelClientCurrent.Size = new System.Drawing.Size(54, 17);
            this.labelClientCurrent.TabIndex = 3;
            this.labelClientCurrent.Text = "Saldo:";
            // 
            // labelClientType
            // 
            this.labelClientType.AutoSize = true;
            this.labelClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientType.Location = new System.Drawing.Point(13, 111);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(45, 17);
            this.labelClientType.TabIndex = 2;
            this.labelClientType.Text = "Tipo:";
            // 
            // labelClientNif
            // 
            this.labelClientNif.AutoSize = true;
            this.labelClientNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNif.Location = new System.Drawing.Point(17, 72);
            this.labelClientNif.Name = "labelClientNif";
            this.labelClientNif.Size = new System.Drawing.Size(37, 17);
            this.labelClientNif.TabIndex = 1;
            this.labelClientNif.Text = "NIF:";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(6, 29);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(54, 17);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientSearch);
            this.groupBox1.Controls.Add(this.labelNIF);
            this.groupBox1.Controls.Add(this.tBoxClientSearchNif);
            this.groupBox1.Location = new System.Drawing.Point(36, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch.Location = new System.Drawing.Point(236, 23);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(70, 30);
            this.btnClientSearch.TabIndex = 10;
            this.btnClientSearch.Text = "Procurar";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIF.Location = new System.Drawing.Point(22, 29);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(33, 17);
            this.labelNIF.TabIndex = 9;
            this.labelNIF.Text = "NIF:";
            // 
            // tBoxClientSearchNif
            // 
            this.tBoxClientSearchNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientSearchNif.Location = new System.Drawing.Point(61, 27);
            this.tBoxClientSearchNif.Name = "tBoxClientSearchNif";
            this.tBoxClientSearchNif.Size = new System.Drawing.Size(160, 23);
            this.tBoxClientSearchNif.TabIndex = 8;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(478, 452);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(194, 27);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Mostrar Todas";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.textBoxMealTime);
            this.groupBoxMenu.Controls.Add(this.label5);
            this.groupBoxMenu.Controls.Add(this.textBoxPrice);
            this.groupBoxMenu.Controls.Add(this.label4);
            this.groupBoxMenu.Controls.Add(this.textBoxExtras);
            this.groupBoxMenu.Controls.Add(this.textBoxDish);
            this.groupBoxMenu.Controls.Add(this.label3);
            this.groupBoxMenu.Controls.Add(this.label2);
            this.groupBoxMenu.Location = new System.Drawing.Point(36, 358);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(361, 153);
            this.groupBoxMenu.TabIndex = 5;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extras:";
            // 
            // textBoxDish
            // 
            this.textBoxDish.Location = new System.Drawing.Point(7, 37);
            this.textBoxDish.Name = "textBoxDish";
            this.textBoxDish.ReadOnly = true;
            this.textBoxDish.Size = new System.Drawing.Size(180, 20);
            this.textBoxDish.TabIndex = 6;
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.Location = new System.Drawing.Point(193, 37);
            this.textBoxExtras.Multiline = true;
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.ReadOnly = true;
            this.textBoxExtras.Size = new System.Drawing.Size(150, 105);
            this.textBoxExtras.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(7, 86);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(180, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Horário:";
            // 
            // textBoxMealTime
            // 
            this.textBoxMealTime.Location = new System.Drawing.Point(79, 122);
            this.textBoxMealTime.Name = "textBoxMealTime";
            this.textBoxMealTime.ReadOnly = true;
            this.textBoxMealTime.Size = new System.Drawing.Size(108, 20);
            this.textBoxMealTime.TabIndex = 11;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheckIn.Location = new System.Drawing.Point(478, 484);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(194, 27);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Registar Reserva";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // MealRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 538);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReservations);
            this.Name = "MealRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MealRegisterForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelClientCurrent;
        private System.Windows.Forms.Label labelClientType;
        private System.Windows.Forms.Label labelClientNif;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.TextBox tBoxClientSearchNif;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExtras;
        private System.Windows.Forms.TextBox textBoxDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMealTime;
        private System.Windows.Forms.Button btnCheckIn;
    }
}