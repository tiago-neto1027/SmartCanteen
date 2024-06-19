namespace SmartCanteen.views
{
    partial class FineEditForm
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
            this.dGridViewFines = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditFine = new System.Windows.Forms.Button();
            this.btnDeleteFine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrFine = new System.Windows.Forms.NumericUpDown();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewFines)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewFines
            // 
            this.dGridViewFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewFines.Location = new System.Drawing.Point(29, 193);
            this.dGridViewFines.Name = "dGridViewFines";
            this.dGridViewFines.ReadOnly = true;
            this.dGridViewFines.RowHeadersWidth = 47;
            this.dGridViewFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewFines.Size = new System.Drawing.Size(614, 150);
            this.dGridViewFines.TabIndex = 22;
            this.dGridViewFines.SelectionChanged += new System.EventHandler(this.dGridViewFines_SelectionChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(577, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 32);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditFine
            // 
            this.btnEditFine.Location = new System.Drawing.Point(505, 362);
            this.btnEditFine.Name = "btnEditFine";
            this.btnEditFine.Size = new System.Drawing.Size(66, 32);
            this.btnEditFine.TabIndex = 23;
            this.btnEditFine.Text = "Registar";
            this.btnEditFine.UseVisualStyleBackColor = true;
            this.btnEditFine.Click += new System.EventHandler(this.btnEditFine_Click);
            // 
            // btnDeleteFine
            // 
            this.btnDeleteFine.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteFine.Location = new System.Drawing.Point(29, 362);
            this.btnDeleteFine.Name = "btnDeleteFine";
            this.btnDeleteFine.Size = new System.Drawing.Size(66, 32);
            this.btnDeleteFine.TabIndex = 25;
            this.btnDeleteFine.Text = "Delete";
            this.btnDeleteFine.UseVisualStyleBackColor = false;
            this.btnDeleteFine.Click += new System.EventHandler(this.btnDeleteFine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmrFine);
            this.groupBox1.Controls.Add(this.nmrHours);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 147);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multa:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Horas:";
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
            // nmrHours
            // 
            this.nmrHours.Location = new System.Drawing.Point(26, 85);
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(120, 23);
            this.nmrHours.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(102, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 17);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(137, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 5;
            // 
            // FineEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteFine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditFine);
            this.Controls.Add(this.dGridViewFines);
            this.Name = "FineEditForm";
            this.Text = "FineEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewFines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewFines;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditFine;
        private System.Windows.Forms.Button btnDeleteFine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrFine;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxID;
    }
}