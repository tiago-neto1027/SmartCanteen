namespace SmartCanteen
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutChangeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClientEdit = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMealEdit = new System.Windows.Forms.Button();
            this.btnExtrasEdit = new System.Windows.Forms.Button();
            this.btnMealRegister = new System.Windows.Forms.Button();
            this.btnExtrasAdd = new System.Windows.Forms.Button();
            this.btnMealAdd = new System.Windows.Forms.Button();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditFine = new System.Windows.Forms.Button();
            this.btnCreateFine = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnMenuEdit = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(884, 27);
            this.menuStripMain.Size = new System.Drawing.Size(820, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.optionsToolStripMenuItem.Text = "Opções";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutChangeUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutChangeUserToolStripMenuItem
            // 
            this.logoutChangeUserToolStripMenuItem.Name = "logoutChangeUserToolStripMenuItem";
            this.logoutChangeUserToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.logoutChangeUserToolStripMenuItem.Text = "Logout / Mudar User";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.exitToolStripMenuItem.Text = "Sair";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientEdit);
            this.groupBox1.Controls.Add(this.btnBalance);
            this.groupBox1.Controls.Add(this.btnClientAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(632, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnClientEdit
            // 
            this.btnClientModify.Location = new System.Drawing.Point(101, 23);
            this.btnClientModify.Name = "btnClientModify";
            this.btnClientModify.Size = new System.Drawing.Size(63, 40);
            this.btnClientModify.TabIndex = 2;
            this.btnClientModify.Text = "Editar";
            this.btnClientModify.UseVisualStyleBackColor = true;
            this.btnClientModify.Click += new System.EventHandler(this.btnClientModify_Click);
            this.btnClientEdit.Location = new System.Drawing.Point(107, 23);
            this.btnClientEdit.Name = "btnClientEdit";
            this.btnClientEdit.Size = new System.Drawing.Size(57, 40);
            this.btnClientEdit.TabIndex = 2;
            this.btnClientEdit.Text = "Editar";
            this.btnClientEdit.UseVisualStyleBackColor = true;
            this.btnClientEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(6, 69);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(158, 40);
            this.btnBalance.TabIndex = 1;
            this.btnBalance.Text = "Carregamento";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Location = new System.Drawing.Point(6, 23);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(89, 40);
            this.btnClientAdd.TabIndex = 0;
            this.btnClientAdd.Text = "Adicionar";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddReservation);
            this.groupBox2.Controls.Add(this.btnMenuEdit);
            this.groupBox2.Controls.Add(this.btnMealEdit);
            this.groupBox2.Controls.Add(this.btnExtrasEdit);
            this.groupBox2.Controls.Add(this.btnMealRegister);
            this.groupBox2.Controls.Add(this.btnExtrasAdd);
            this.groupBox2.Controls.Add(this.btnMealAdd);
            this.groupBox2.Controls.Add(this.btnMenuAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(632, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refeição";
            // 
            // btnMealEdit
            // 
            this.btnMealEdit.Location = new System.Drawing.Point(107, 66);
            this.btnMealEdit.Name = "btnMealEdit";
            this.btnMealEdit.Size = new System.Drawing.Size(57, 40);
            this.btnMealEdit.TabIndex = 8;
            this.btnMealEdit.Text = "Editar";
            this.btnMealEdit.UseVisualStyleBackColor = true;
            this.btnMealEdit.Click += new System.EventHandler(this.btnMealEdit_Click);
            // 
            // btnExtrasEdit
            // 
            this.btnExtrasEdit.Location = new System.Drawing.Point(107, 112);
            this.btnExtrasEdit.Name = "btnExtrasEdit";
            this.btnExtrasEdit.Size = new System.Drawing.Size(57, 40);
            this.btnExtrasEdit.TabIndex = 7;
            this.btnExtrasEdit.Text = "Editar";
            this.btnExtrasEdit.UseVisualStyleBackColor = true;
            this.btnExtrasEdit.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMealRegister
            // 
            this.btnMealRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMealRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMealRegister.Location = new System.Drawing.Point(6, 200);
            this.btnMealRegister.Name = "btnMealRegister";
            this.btnMealRegister.Size = new System.Drawing.Size(158, 40);
            this.btnMealRegister.TabIndex = 6;
            this.btnMealRegister.Text = "Registar Refeição";
            this.btnMealRegister.UseVisualStyleBackColor = false;
            this.btnMealRegister.Click += new System.EventHandler(this.btnMealRegister_Click);
            // 
            // btnExtrasAdd
            // 
            this.btnExtrasAdd.Location = new System.Drawing.Point(6, 112);
            this.btnExtrasAdd.Name = "btnExtrasAdd";
            this.btnExtrasAdd.Size = new System.Drawing.Size(95, 40);
            this.btnExtrasAdd.TabIndex = 5;
            this.btnExtrasAdd.Text = "Extras";
            this.btnExtrasAdd.UseVisualStyleBackColor = true;
            this.btnExtrasAdd.Click += new System.EventHandler(this.btnExtrasAdd_Click);
            // 
            // btnMealAdd
            // 
            this.btnMealAdd.Location = new System.Drawing.Point(6, 66);
            this.btnMealAdd.Name = "btnMealAdd";
            this.btnMealAdd.Size = new System.Drawing.Size(95, 40);
            this.btnMealAdd.TabIndex = 4;
            this.btnMealAdd.Text = "Criar Prato";
            this.btnMealAdd.UseVisualStyleBackColor = true;
            this.btnMealAdd.Click += new System.EventHandler(this.btnMealAdd_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(6, 20);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(95, 40);
            this.btnMenuAdd.TabIndex = 3;
            this.btnMenuAdd.Text = "Criar Menu";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Controls.Add(this.lbTime);
            this.groupBox3.Location = new System.Drawing.Point(58, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 442);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Semanal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartCanteen.Properties.Resources._603_6035882_clock_transparent_time_icon_png_png_download;
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(67, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Data";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(67, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(37, 16);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.Location = new System.Drawing.Point(107, 20);
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Size = new System.Drawing.Size(57, 40);
            this.btnMenuEdit.TabIndex = 9;
            this.btnMenuEdit.Text = "Editar";
            this.btnMenuEdit.UseVisualStyleBackColor = true;
            this.btnMenuEdit.Click += new System.EventHandler(this.btnMenuEdit_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(67, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(39, 18);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Data";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(67, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditFine);
            this.groupBox4.Controls.Add(this.btnCreateFine);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(632, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multas";
            // 
            // btnEditFine
            // 
            this.btnEditFine.Location = new System.Drawing.Point(101, 23);
            this.btnEditFine.Name = "btnEditFine";
            this.btnEditFine.Size = new System.Drawing.Size(63, 40);
            this.btnEditFine.TabIndex = 2;
            this.btnEditFine.Text = "Editar";
            this.btnEditFine.UseVisualStyleBackColor = true;
            this.btnEditFine.Click += new System.EventHandler(this.btnEditFine_Click);
            // 
            // btnCreateFine
            // 
            this.btnCreateFine.Location = new System.Drawing.Point(6, 23);
            this.btnCreateFine.Name = "btnCreateFine";
            this.btnCreateFine.Size = new System.Drawing.Size(89, 40);
            this.btnCreateFine.TabIndex = 0;
            this.btnCreateFine.Text = "Criar Multa";
            this.btnCreateFine.UseVisualStyleBackColor = true;
            this.btnCreateFine.Click += new System.EventHandler(this.btnCreateFine_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(6, 158);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(158, 36);
            this.btnAddReservation.TabIndex = 9;
            this.btnAddReservation.Text = "Fazer Reserva";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox4);
            this.ClientSize = new System.Drawing.Size(820, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutChangeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClientEdit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExtrasAdd;
        private System.Windows.Forms.Button btnMealAdd;
        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.Button btnMealRegister;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExtrasEdit;
        private System.Windows.Forms.Button btnMealEdit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEditFine;
        private System.Windows.Forms.Button btnCreateFine;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnMenuEdit;
    }
}