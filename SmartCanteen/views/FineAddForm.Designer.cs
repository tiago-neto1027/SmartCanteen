namespace SmartCanteen.views
{
    partial class FineAddForm
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
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.nmrFine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFineRegister = new System.Windows.Forms.Button();
            this.btnFineLeave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmrFine);
            this.groupBox1.Controls.Add(this.nmrHours);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multa:";
            // 
            // nmrHours
            // 
            this.nmrHours.Location = new System.Drawing.Point(26, 85);
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(120, 23);
            this.nmrHours.TabIndex = 0;
            // 
            // nmrFine
            // 
            this.nmrFine.DecimalPlaces = 2;
            this.nmrFine.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrFine.Location = new System.Drawing.Point(193, 85);
            this.nmrFine.Name = "nmrFine";
            this.nmrFine.Size = new System.Drawing.Size(120, 23);
            this.nmrFine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Horas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor da Multa:";
            // 
            // btnFineRegister
            // 
            this.btnFineRegister.Location = new System.Drawing.Point(250, 209);
            this.btnFineRegister.Name = "btnFineRegister";
            this.btnFineRegister.Size = new System.Drawing.Size(66, 32);
            this.btnFineRegister.TabIndex = 15;
            this.btnFineRegister.Text = "Registar";
            this.btnFineRegister.UseVisualStyleBackColor = true;
            this.btnFineRegister.Click += new System.EventHandler(this.btnFineRegister_Click);
            // 
            // btnFineLeave
            // 
            this.btnFineLeave.Location = new System.Drawing.Point(322, 209);
            this.btnFineLeave.Name = "btnFineLeave";
            this.btnFineLeave.Size = new System.Drawing.Size(66, 32);
            this.btnFineLeave.TabIndex = 16;
            this.btnFineLeave.Text = "Sair";
            this.btnFineLeave.UseVisualStyleBackColor = true;
            this.btnFineLeave.Click += new System.EventHandler(this.btnFineLeave_Click);
            // 
            // FineAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 254);
            this.Controls.Add(this.btnFineLeave);
            this.Controls.Add(this.btnFineRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "FineAddForm";
            this.Text = "FineAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.NumericUpDown nmrFine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFineRegister;
        private System.Windows.Forms.Button btnFineLeave;
    }
}