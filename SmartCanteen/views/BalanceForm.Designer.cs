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
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxBalanceNif = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBalanceCurrent = new System.Windows.Forms.Label();
            this.labelBalanceType = new System.Windows.Forms.Label();
            this.labelBalanceNif = new System.Windows.Forms.Label();
            this.labelBalancelName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBalanceLeave = new System.Windows.Forms.Button();
            this.btnBalanceAddValue = new System.Windows.Forms.Button();
            this.tBoxBalanceAddValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBalanceSearch);
            this.groupBox1.Controls.Add(this.label4);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "NIF:";
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
            this.groupBox3.Controls.Add(this.btnBalanceLeave);
            this.groupBox3.Controls.Add(this.btnBalanceAddValue);
            this.groupBox3.Controls.Add(this.tBoxBalanceAddValue);
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
            this.btnBalanceLeave.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // tBoxBalanceAddValue
            // 
            this.tBoxBalanceAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBalanceAddValue.Location = new System.Drawing.Point(70, 40);
            this.tBoxBalanceAddValue.Name = "tBoxBalanceAddValue";
            this.tBoxBalanceAddValue.Size = new System.Drawing.Size(100, 21);
            this.tBoxBalanceAddValue.TabIndex = 0;
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
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
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxBalanceNif;
        private System.Windows.Forms.Button btnBalanceSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelBalanceType;
        private System.Windows.Forms.Label labelBalanceNif;
        private System.Windows.Forms.Label labelBalancelName;
        private System.Windows.Forms.Label labelBalanceCurrent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBalanceAddValue;
        private System.Windows.Forms.TextBox tBoxBalanceAddValue;
        private System.Windows.Forms.Button btnBalanceLeave;
    }
}