namespace SmartCanteen
{
    partial class ClientEditForm
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
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.labelNIF = new System.Windows.Forms.Label();
            this.tBoxClientSearchNif = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxClientProfessorEmail = new System.Windows.Forms.TextBox();
            this.labelClientProfessorEmail = new System.Windows.Forms.Label();
            this.tBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.labelClientStudentNumber = new System.Windows.Forms.Label();
            this.radiobtnTypeProfessor = new System.Windows.Forms.RadioButton();
            this.radiobtnTypeStudent = new System.Windows.Forms.RadioButton();
            this.tBoxClientBalance = new System.Windows.Forms.TextBox();
            this.tBoxClientNIF = new System.Windows.Forms.TextBox();
            this.tBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientCurrent = new System.Windows.Forms.Label();
            this.labelClientType = new System.Windows.Forms.Label();
            this.labelClientNif = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.btnBalanceLeave = new System.Windows.Forms.Button();
            this.btnClientEdit = new System.Windows.Forms.Button();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.labelClients = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientSearch);
            this.groupBox1.Controls.Add(this.labelNIF);
            this.groupBox1.Controls.Add(this.tBoxClientSearchNif);
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 68);
            this.groupBox1.TabIndex = 0;
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
            this.labelNIF.Size = new System.Drawing.Size(29, 15);
            this.labelNIF.TabIndex = 9;
            this.labelNIF.Text = "NIF:";
            // 
            // tBoxClientSearchNif
            // 
            this.tBoxClientSearchNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientSearchNif.Location = new System.Drawing.Point(70, 29);
            this.tBoxClientSearchNif.Name = "tBoxClientSearchNif";
            this.tBoxClientSearchNif.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientSearchNif.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxClientProfessorEmail);
            this.groupBox2.Controls.Add(this.labelClientProfessorEmail);
            this.groupBox2.Controls.Add(this.tBoxStudentNumber);
            this.groupBox2.Controls.Add(this.labelClientStudentNumber);
            this.groupBox2.Controls.Add(this.radiobtnTypeProfessor);
            this.groupBox2.Controls.Add(this.radiobtnTypeStudent);
            this.groupBox2.Controls.Add(this.tBoxClientBalance);
            this.groupBox2.Controls.Add(this.tBoxClientNIF);
            this.groupBox2.Controls.Add(this.tBoxClientName);
            this.groupBox2.Controls.Add(this.labelClientCurrent);
            this.groupBox2.Controls.Add(this.labelClientType);
            this.groupBox2.Controls.Add(this.labelClientNif);
            this.groupBox2.Controls.Add(this.labelClientName);
            this.groupBox2.Location = new System.Drawing.Point(25, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado:";
            // 
            // tBoxClientProfessorEmail
            // 
            this.tBoxClientProfessorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientProfessorEmail.Location = new System.Drawing.Point(71, 217);
            this.tBoxClientProfessorEmail.Name = "tBoxClientProfessorEmail";
            this.tBoxClientProfessorEmail.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientProfessorEmail.TabIndex = 22;
            // 
            // labelClientProfessorEmail
            // 
            this.labelClientProfessorEmail.AutoSize = true;
            this.labelClientProfessorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientProfessorEmail.Location = new System.Drawing.Point(17, 223);
            this.labelClientProfessorEmail.Name = "labelClientProfessorEmail";
            this.labelClientProfessorEmail.Size = new System.Drawing.Size(48, 15);
            this.labelClientProfessorEmail.TabIndex = 21;
            this.labelClientProfessorEmail.Text = "Email:";
            // 
            // tBoxStudentNumber
            // 
            this.tBoxStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxStudentNumber.Location = new System.Drawing.Point(113, 146);
            this.tBoxStudentNumber.Name = "tBoxStudentNumber";
            this.tBoxStudentNumber.Size = new System.Drawing.Size(160, 21);
            this.tBoxStudentNumber.TabIndex = 20;
            // 
            // labelClientStudentNumber
            // 
            this.labelClientStudentNumber.AutoSize = true;
            this.labelClientStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientStudentNumber.Location = new System.Drawing.Point(17, 149);
            this.labelClientStudentNumber.Name = "labelClientStudentNumber";
            this.labelClientStudentNumber.Size = new System.Drawing.Size(90, 15);
            this.labelClientStudentNumber.TabIndex = 19;
            this.labelClientStudentNumber.Text = "Nº Estudante";
            // 
            // radiobtnTypeProfessor
            // 
            this.radiobtnTypeProfessor.AutoSize = true;
            this.radiobtnTypeProfessor.Enabled = false;
            this.radiobtnTypeProfessor.Location = new System.Drawing.Point(179, 109);
            this.radiobtnTypeProfessor.Name = "radiobtnTypeProfessor";
            this.radiobtnTypeProfessor.Size = new System.Drawing.Size(66, 17);
            this.radiobtnTypeProfessor.TabIndex = 18;
            this.radiobtnTypeProfessor.Text = "Docente";
            this.radiobtnTypeProfessor.UseVisualStyleBackColor = true;
            // 
            // radiobtnTypeStudent
            // 
            this.radiobtnTypeStudent.AutoSize = true;
            this.radiobtnTypeStudent.Enabled = false;
            this.radiobtnTypeStudent.Location = new System.Drawing.Point(66, 111);
            this.radiobtnTypeStudent.Name = "radiobtnTypeStudent";
            this.radiobtnTypeStudent.Size = new System.Drawing.Size(52, 17);
            this.radiobtnTypeStudent.TabIndex = 17;
            this.radiobtnTypeStudent.TabStop = true;
            this.radiobtnTypeStudent.Text = "Aluno";
            this.radiobtnTypeStudent.UseVisualStyleBackColor = true;
            // 
            // tBoxClientBalance
            // 
            this.tBoxClientBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientBalance.Location = new System.Drawing.Point(70, 183);
            this.tBoxClientBalance.Name = "tBoxClientBalance";
            this.tBoxClientBalance.ReadOnly = true;
            this.tBoxClientBalance.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientBalance.TabIndex = 14;
            // 
            // tBoxClientNIF
            // 
            this.tBoxClientNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientNIF.Location = new System.Drawing.Point(61, 69);
            this.tBoxClientNIF.Name = "tBoxClientNIF";
            this.tBoxClientNIF.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientNIF.TabIndex = 12;
            // 
            // tBoxClientName
            // 
            this.tBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientName.Location = new System.Drawing.Point(61, 29);
            this.tBoxClientName.Name = "tBoxClientName";
            this.tBoxClientName.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientName.TabIndex = 11;
            // 
            // labelClientCurrent
            // 
            this.labelClientCurrent.AutoSize = true;
            this.labelClientCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientCurrent.Location = new System.Drawing.Point(16, 183);
            this.labelClientCurrent.Name = "labelClientCurrent";
            this.labelClientCurrent.Size = new System.Drawing.Size(48, 15);
            this.labelClientCurrent.TabIndex = 3;
            this.labelClientCurrent.Text = "Saldo:";
            // 
            // labelClientType
            // 
            this.labelClientType.AutoSize = true;
            this.labelClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientType.Location = new System.Drawing.Point(13, 111);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(39, 15);
            this.labelClientType.TabIndex = 2;
            this.labelClientType.Text = "Tipo:";
            // 
            // labelClientNif
            // 
            this.labelClientNif.AutoSize = true;
            this.labelClientNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNif.Location = new System.Drawing.Point(17, 72);
            this.labelClientNif.Name = "labelClientNif";
            this.labelClientNif.Size = new System.Drawing.Size(33, 15);
            this.labelClientNif.TabIndex = 1;
            this.labelClientNif.Text = "NIF:";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(6, 29);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(49, 15);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Nome:";
            // 
            // btnBalanceLeave
            // 
            this.btnBalanceLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceLeave.Location = new System.Drawing.Point(311, 416);
            this.btnBalanceLeave.Name = "btnBalanceLeave";
            this.btnBalanceLeave.Size = new System.Drawing.Size(75, 30);
            this.btnBalanceLeave.TabIndex = 12;
            this.btnBalanceLeave.Text = "Sair";
            this.btnBalanceLeave.UseVisualStyleBackColor = true;
            this.btnBalanceLeave.Click += new System.EventHandler(this.btnClientLeave_Click);
            // 
            // btnClientEdit
            // 
            this.btnClientEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientEdit.Location = new System.Drawing.Point(32, 396);
            this.btnClientEdit.Name = "btnClientEdit";
            this.btnClientEdit.Size = new System.Drawing.Size(100, 30);
            this.btnClientEdit.TabIndex = 11;
            this.btnClientEdit.Text = "Editar";
            this.btnClientEdit.UseVisualStyleBackColor = true;
            this.btnClientEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(425, 58);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(244, 355);
            this.listBoxClients.TabIndex = 3;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(422, 39);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(54, 15);
            this.labelClients.TabIndex = 11;
            this.labelClients.Text = "Clientes:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(475, 416);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(142, 30);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Mostrar Todos";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClientDelete
            // 
            this.btnClientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDelete.Location = new System.Drawing.Point(151, 416);
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.Size = new System.Drawing.Size(100, 30);
            this.btnClientDelete.TabIndex = 13;
            this.btnClientDelete.Text = "Apagar";
            this.btnClientDelete.UseVisualStyleBackColor = true;
            this.btnClientDelete.Click += new System.EventHandler(this.btnClientDelete_Click);
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 461);
            this.Controls.Add(this.btnClientDelete);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnBalanceLeave);
            this.Controls.Add(this.btnClientEdit);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BalanceForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.TextBox tBoxClientSearchNif;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelClientType;
        private System.Windows.Forms.Label labelClientNif;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientCurrent;
        private System.Windows.Forms.Button btnClientEdit;
        private System.Windows.Forms.Button btnBalanceLeave;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox tBoxClientBalance;
        private System.Windows.Forms.TextBox tBoxClientNIF;
        private System.Windows.Forms.TextBox tBoxClientName;
        private System.Windows.Forms.RadioButton radiobtnTypeProfessor;
        private System.Windows.Forms.RadioButton radiobtnTypeStudent;
        private System.Windows.Forms.TextBox tBoxStudentNumber;
        private System.Windows.Forms.Label labelClientStudentNumber;
        private System.Windows.Forms.TextBox tBoxClientProfessorEmail;
        private System.Windows.Forms.Label labelClientProfessorEmail;
        private System.Windows.Forms.Button btnClientDelete;
    }
}