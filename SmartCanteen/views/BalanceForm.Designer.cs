namespace SmartCanteen
{
    partial class BalanceForm
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
            this.btnBalanceSearch = new System.Windows.Forms.Button();
            this.labelNIF = new System.Windows.Forms.Label();
            this.tBoxBalanceNif = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBalanceCurrent = new System.Windows.Forms.Label();
            this.labelBalanceType = new System.Windows.Forms.Label();
            this.labelBalanceNif = new System.Windows.Forms.Label();
            this.labelBalancelName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBalanceLeave = new System.Windows.Forms.Button();
            this.btnBalanceAddValue = new System.Windows.Forms.Button();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.labelClients = new System.Windows.Forms.Label();
            this.AddValue = new System.Windows.Forms.NumericUpDown();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBalanceSearch);
            this.groupBox1.Controls.Add(this.labelNIF);
            this.groupBox1.Controls.Add(this.tBoxBalanceNif);
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // btnBalanceSearch
            // 
            this.btnBalanceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceSearch.Location = new System.Drawing.Point(236, 23);
            this.btnBalanceSearch.Name = "btnBalanceSearch";
            this.btnBalanceSearch.Size = new System.Drawing.Size(70, 30);
            this.btnBalanceSearch.TabIndex = 10;
            this.btnBalanceSearch.Text = "Procurar";
            this.btnBalanceSearch.UseVisualStyleBackColor = true;
            this.btnBalanceSearch.Click += new System.EventHandler(this.btnBalanceSearch_Click);
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIF.Location = new System.Drawing.Point(22, 29);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(29, 15);
            this.labelNIF.TabIndex = 9;
            this.labelNIF.Text = "NIF:";
            // 
            // tBoxBalanceNif
            // 
            this.tBoxBalanceNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBalanceNif.Location = new System.Drawing.Point(70, 29);
            this.tBoxBalanceNif.Name = "tBoxBalanceNif";
            this.tBoxBalanceNif.Size = new System.Drawing.Size(160, 21);
            this.tBoxBalanceNif.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBalanceCurrent);
            this.groupBox2.Controls.Add(this.labelBalanceType);
            this.groupBox2.Controls.Add(this.labelBalanceNif);
            this.groupBox2.Controls.Add(this.labelBalancelName);
            this.groupBox2.Location = new System.Drawing.Point(25, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado:";
            // 
            // labelBalanceCurrent
            // 
            this.labelBalanceCurrent.AutoSize = true;
            this.labelBalanceCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceCurrent.Location = new System.Drawing.Point(7, 135);
            this.labelBalanceCurrent.Name = "labelBalanceCurrent";
            this.labelBalanceCurrent.Size = new System.Drawing.Size(48, 15);
            this.labelBalanceCurrent.TabIndex = 3;
            this.labelBalanceCurrent.Text = "Saldo:";
            // 
            // labelBalanceType
            // 
            this.labelBalanceType.AutoSize = true;
            this.labelBalanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceType.Location = new System.Drawing.Point(13, 94);
            this.labelBalanceType.Name = "labelBalanceType";
            this.labelBalanceType.Size = new System.Drawing.Size(39, 15);
            this.labelBalanceType.TabIndex = 2;
            this.labelBalanceType.Text = "Tipo:";
            // 
            // labelBalanceNif
            // 
            this.labelBalanceNif.AutoSize = true;
            this.labelBalanceNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceNif.Location = new System.Drawing.Point(17, 59);
            this.labelBalanceNif.Name = "labelBalanceNif";
            this.labelBalanceNif.Size = new System.Drawing.Size(33, 15);
            this.labelBalanceNif.TabIndex = 1;
            this.labelBalanceNif.Text = "NIF:";
            // 
            // labelBalancelName
            // 
            this.labelBalancelName.AutoSize = true;
            this.labelBalancelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalancelName.Location = new System.Drawing.Point(6, 29);
            this.labelBalancelName.Name = "labelBalancelName";
            this.labelBalancelName.Size = new System.Drawing.Size(49, 15);
            this.labelBalancelName.TabIndex = 0;
            this.labelBalancelName.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddValue);
            this.groupBox3.Controls.Add(this.btnBalanceLeave);
            this.groupBox3.Controls.Add(this.btnBalanceAddValue);
            this.groupBox3.Location = new System.Drawing.Point(25, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo:";
            // 
            // btnBalanceLeave
            // 
            this.btnBalanceLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceLeave.Location = new System.Drawing.Point(274, 35);
            this.btnBalanceLeave.Name = "btnBalanceLeave";
            this.btnBalanceLeave.Size = new System.Drawing.Size(60, 30);
            this.btnBalanceLeave.TabIndex = 12;
            this.btnBalanceLeave.Text = "Sair";
            this.btnBalanceLeave.UseVisualStyleBackColor = true;
            this.btnBalanceLeave.Click += new System.EventHandler(this.btnBalanceLeave_Click);
            // 
            // btnBalanceAddValue
            // 
            this.btnBalanceAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceAddValue.Location = new System.Drawing.Point(176, 35);
            this.btnBalanceAddValue.Name = "btnBalanceAddValue";
            this.btnBalanceAddValue.Size = new System.Drawing.Size(70, 30);
            this.btnBalanceAddValue.TabIndex = 11;
            this.btnBalanceAddValue.Text = "Adicionar";
            this.btnBalanceAddValue.UseVisualStyleBackColor = true;
            this.btnBalanceAddValue.Click += new System.EventHandler(this.btnBalanceAddValue_Click);
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(425, 143);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(244, 264);
            this.listBoxClients.TabIndex = 3;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(422, 125);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(54, 15);
            this.labelClients.TabIndex = 11;
            this.labelClients.Text = "Clientes:";
            // 
            // AddValue
            // 
            this.AddValue.Location = new System.Drawing.Point(50, 41);
            this.AddValue.Name = "AddValue";
            this.AddValue.Size = new System.Drawing.Size(120, 20);
            this.AddValue.TabIndex = 13;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(475, 413);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(142, 30);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Mostrar Todos";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 461);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BalanceForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.TextBox tBoxBalanceNif;
        private System.Windows.Forms.Button btnBalanceSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelBalanceType;
        private System.Windows.Forms.Label labelBalanceNif;
        private System.Windows.Forms.Label labelBalancelName;
        private System.Windows.Forms.Label labelBalanceCurrent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBalanceAddValue;
        private System.Windows.Forms.Button btnBalanceLeave;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.NumericUpDown AddValue;
        private System.Windows.Forms.Button btnShowAll;
    }
}