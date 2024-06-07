namespace SmartCanteen
{
    partial class ClientAddForm
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
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxNIF = new System.Windows.Forms.TextBox();
            this.tBoxStudentID = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.AddNIFLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioClientAddProfessorType = new System.Windows.Forms.RadioButton();
            this.radioClientAddStudentType = new System.Windows.Forms.RadioButton();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.addBalanceLabel = new System.Windows.Forms.Label();
            this.BalanceInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(132, 43);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(287, 21);
            this.tBoxName.TabIndex = 0;
            // 
            // tBoxNIF
            // 
            this.tBoxNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNIF.Location = new System.Drawing.Point(132, 88);
            this.tBoxNIF.Name = "tBoxNIF";
            this.tBoxNIF.Size = new System.Drawing.Size(287, 21);
            this.tBoxNIF.TabIndex = 1;
            // 
            // tBoxStudentID
            // 
            this.tBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxStudentID.Location = new System.Drawing.Point(132, 130);
            this.tBoxStudentID.Name = "tBoxStudentID";
            this.tBoxStudentID.Size = new System.Drawing.Size(160, 21);
            this.tBoxStudentID.TabIndex = 3;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEmail.Location = new System.Drawing.Point(132, 211);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(160, 21);
            this.tBoxEmail.TabIndex = 4;
            this.tBoxEmail.Visible = false;
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNameLabel.Location = new System.Drawing.Point(69, 43);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(44, 15);
            this.AddNameLabel.TabIndex = 4;
            this.AddNameLabel.Text = "Nome:";
            // 
            // AddNIFLabel
            // 
            this.AddNIFLabel.AutoSize = true;
            this.AddNIFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNIFLabel.Location = new System.Drawing.Point(69, 88);
            this.AddNIFLabel.Name = "AddNIFLabel";
            this.AddNIFLabel.Size = new System.Drawing.Size(29, 15);
            this.AddNIFLabel.TabIndex = 5;
            this.AddNIFLabel.Text = "NIF:";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(33, 136);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(78, 15);
            this.StudentIDLabel.TabIndex = 6;
            this.StudentIDLabel.Text = "Nº Estudante";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(69, 214);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 15);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioClientAddProfessorType);
            this.groupBox1.Controls.Add(this.radioClientAddStudentType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // radioClientAddProfessorType
            // 
            this.radioClientAddProfessorType.AutoSize = true;
            this.radioClientAddProfessorType.Location = new System.Drawing.Point(164, 34);
            this.radioClientAddProfessorType.Name = "radioClientAddProfessorType";
            this.radioClientAddProfessorType.Size = new System.Drawing.Size(71, 19);
            this.radioClientAddProfessorType.TabIndex = 6;
            this.radioClientAddProfessorType.TabStop = true;
            this.radioClientAddProfessorType.Text = "Docente";
            this.radioClientAddProfessorType.UseVisualStyleBackColor = true;
            this.radioClientAddProfessorType.Click += new System.EventHandler(this.radioClientAddProfessorType_Click);
            // 
            // radioClientAddStudentType
            // 
            this.radioClientAddStudentType.AutoSize = true;
            this.radioClientAddStudentType.Location = new System.Drawing.Point(7, 34);
            this.radioClientAddStudentType.Name = "radioClientAddStudentType";
            this.radioClientAddStudentType.Size = new System.Drawing.Size(80, 19);
            this.radioClientAddStudentType.TabIndex = 5;
            this.radioClientAddStudentType.TabStop = true;
            this.radioClientAddStudentType.Text = "Estudante";
            this.radioClientAddStudentType.UseVisualStyleBackColor = true;
            this.radioClientAddStudentType.Click += new System.EventHandler(this.radioClientAddStudentType_Click);
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Location = new System.Drawing.Point(132, 388);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(66, 32);
            this.btnClientAdd.TabIndex = 7;
            this.btnClientAdd.Text = "Adicionar";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAddCreate_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(353, 388);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(66, 32);
            this.btnLeave.TabIndex = 8;
            this.btnLeave.Text = "Sair";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // addBalanceLabel
            // 
            this.addBalanceLabel.AutoSize = true;
            this.addBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBalanceLabel.Location = new System.Drawing.Point(69, 172);
            this.addBalanceLabel.Name = "addBalanceLabel";
            this.addBalanceLabel.Size = new System.Drawing.Size(42, 15);
            this.addBalanceLabel.TabIndex = 12;
            this.addBalanceLabel.Text = "Saldo:";
            // 
            // BalanceInput
            // 
            this.BalanceInput.Location = new System.Drawing.Point(132, 172);
            this.BalanceInput.Name = "BalanceInput";
            this.BalanceInput.Size = new System.Drawing.Size(73, 20);
            this.BalanceInput.TabIndex = 13;
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BalanceInput);
            this.Controls.Add(this.addBalanceLabel);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnClientAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.AddNIFLabel);
            this.Controls.Add(this.AddNameLabel);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxStudentID);
            this.Controls.Add(this.tBoxNIF);
            this.Controls.Add(this.tBoxName);
            this.Name = "ClientAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxNIF;
        private System.Windows.Forms.TextBox tBoxStudentID;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label AddNIFLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioClientAddStudentType;
        private System.Windows.Forms.RadioButton radioClientAddProfessorType;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label addBalanceLabel;
        private System.Windows.Forms.NumericUpDown BalanceInput;
    }
}