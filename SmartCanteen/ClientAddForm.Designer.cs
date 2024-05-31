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
            this.tBoxClientAddName = new System.Windows.Forms.TextBox();
            this.tBoxClientAddSurname = new System.Windows.Forms.TextBox();
            this.tBoxClientAddIDNumber = new System.Windows.Forms.TextBox();
            this.tBoxClientAddNif = new System.Windows.Forms.TextBox();
            this.clientAddNameLabel = new System.Windows.Forms.Label();
            this.clientAddSurnameLabel = new System.Windows.Forms.Label();
            this.clientAddIDNumberLabel = new System.Windows.Forms.Label();
            this.clientAddNifLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioClientAddTeacherType = new System.Windows.Forms.RadioButton();
            this.radioClientAddStudentType = new System.Windows.Forms.RadioButton();
            this.btnClientAddCreate = new System.Windows.Forms.Button();
            this.btnClientAddLeave = new System.Windows.Forms.Button();
            this.clientAddEmailLabel = new System.Windows.Forms.Label();
            this.tBoxClientAddEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxClientAddName
            // 
            this.tBoxClientAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddName.Location = new System.Drawing.Point(132, 43);
            this.tBoxClientAddName.Name = "tBoxClientAddName";
            this.tBoxClientAddName.Size = new System.Drawing.Size(287, 21);
            this.tBoxClientAddName.TabIndex = 0;
            // 
            // tBoxClientAddSurname
            // 
            this.tBoxClientAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddSurname.Location = new System.Drawing.Point(132, 88);
            this.tBoxClientAddSurname.Name = "tBoxClientAddSurname";
            this.tBoxClientAddSurname.Size = new System.Drawing.Size(287, 21);
            this.tBoxClientAddSurname.TabIndex = 1;
            // 
            // tBoxClientAddIDNumber
            // 
            this.tBoxClientAddIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddIDNumber.Location = new System.Drawing.Point(132, 171);
            this.tBoxClientAddIDNumber.Name = "tBoxClientAddIDNumber";
            this.tBoxClientAddIDNumber.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientAddIDNumber.TabIndex = 2;
            // 
            // tBoxClientAddNif
            // 
            this.tBoxClientAddNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddNif.Location = new System.Drawing.Point(132, 222);
            this.tBoxClientAddNif.Name = "tBoxClientAddNif";
            this.tBoxClientAddNif.Size = new System.Drawing.Size(160, 21);
            this.tBoxClientAddNif.TabIndex = 3;
            // 
            // clientAddNameLabel
            // 
            this.clientAddNameLabel.AutoSize = true;
            this.clientAddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddNameLabel.Location = new System.Drawing.Point(69, 43);
            this.clientAddNameLabel.Name = "clientAddNameLabel";
            this.clientAddNameLabel.Size = new System.Drawing.Size(44, 15);
            this.clientAddNameLabel.TabIndex = 4;
            this.clientAddNameLabel.Text = "Nome:";
            // 
            // clientAddSurnameLabel
            // 
            this.clientAddSurnameLabel.AutoSize = true;
            this.clientAddSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddSurnameLabel.Location = new System.Drawing.Point(62, 88);
            this.clientAddSurnameLabel.Name = "clientAddSurnameLabel";
            this.clientAddSurnameLabel.Size = new System.Drawing.Size(51, 15);
            this.clientAddSurnameLabel.TabIndex = 5;
            this.clientAddSurnameLabel.Text = "Apelido:";
            // 
            // clientAddIDNumberLabel
            // 
            this.clientAddIDNumberLabel.AutoSize = true;
            this.clientAddIDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddIDNumberLabel.Location = new System.Drawing.Point(32, 171);
            this.clientAddIDNumberLabel.Name = "clientAddIDNumberLabel";
            this.clientAddIDNumberLabel.Size = new System.Drawing.Size(81, 30);
            this.clientAddIDNumberLabel.TabIndex = 6;
            this.clientAddIDNumberLabel.Text = "Nº Estudante/\r\n      Docente:";
            // 
            // clientAddNifLabel
            // 
            this.clientAddNifLabel.AutoSize = true;
            this.clientAddNifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddNifLabel.Location = new System.Drawing.Point(84, 222);
            this.clientAddNifLabel.Name = "clientAddNifLabel";
            this.clientAddNifLabel.Size = new System.Drawing.Size(29, 15);
            this.clientAddNifLabel.TabIndex = 7;
            this.clientAddNifLabel.Text = "NIF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioClientAddTeacherType);
            this.groupBox1.Controls.Add(this.radioClientAddStudentType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // radioClientAddTeacherType
            // 
            this.radioClientAddTeacherType.AutoSize = true;
            this.radioClientAddTeacherType.Location = new System.Drawing.Point(164, 34);
            this.radioClientAddTeacherType.Name = "radioClientAddTeacherType";
            this.radioClientAddTeacherType.Size = new System.Drawing.Size(71, 19);
            this.radioClientAddTeacherType.TabIndex = 1;
            this.radioClientAddTeacherType.TabStop = true;
            this.radioClientAddTeacherType.Text = "Docente";
            this.radioClientAddTeacherType.UseVisualStyleBackColor = true;
            // 
            // radioClientAddStudentType
            // 
            this.radioClientAddStudentType.AutoSize = true;
            this.radioClientAddStudentType.Location = new System.Drawing.Point(7, 34);
            this.radioClientAddStudentType.Name = "radioClientAddStudentType";
            this.radioClientAddStudentType.Size = new System.Drawing.Size(80, 19);
            this.radioClientAddStudentType.TabIndex = 0;
            this.radioClientAddStudentType.TabStop = true;
            this.radioClientAddStudentType.Text = "Estudante";
            this.radioClientAddStudentType.UseVisualStyleBackColor = true;
            // 
            // btnClientAddCreate
            // 
            this.btnClientAddCreate.Location = new System.Drawing.Point(132, 388);
            this.btnClientAddCreate.Name = "btnClientAddCreate";
            this.btnClientAddCreate.Size = new System.Drawing.Size(66, 32);
            this.btnClientAddCreate.TabIndex = 9;
            this.btnClientAddCreate.Text = "Adicionar";
            this.btnClientAddCreate.UseVisualStyleBackColor = true;
            // 
            // btnClientAddLeave
            // 
            this.btnClientAddLeave.Location = new System.Drawing.Point(353, 388);
            this.btnClientAddLeave.Name = "btnClientAddLeave";
            this.btnClientAddLeave.Size = new System.Drawing.Size(66, 32);
            this.btnClientAddLeave.TabIndex = 10;
            this.btnClientAddLeave.Text = "Sair";
            this.btnClientAddLeave.UseVisualStyleBackColor = true;
            this.btnClientAddLeave.Click += new System.EventHandler(this.button2_Click);
            // 
            // clientAddEmailLabel
            // 
            this.clientAddEmailLabel.AutoSize = true;
            this.clientAddEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddEmailLabel.Location = new System.Drawing.Point(62, 131);
            this.clientAddEmailLabel.Name = "clientAddEmailLabel";
            this.clientAddEmailLabel.Size = new System.Drawing.Size(42, 15);
            this.clientAddEmailLabel.TabIndex = 12;
            this.clientAddEmailLabel.Text = "Email:";
            // 
            // tBoxClientAddEmail
            // 
            this.tBoxClientAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddEmail.Location = new System.Drawing.Point(132, 131);
            this.tBoxClientAddEmail.Name = "tBoxClientAddEmail";
            this.tBoxClientAddEmail.Size = new System.Drawing.Size(287, 21);
            this.tBoxClientAddEmail.TabIndex = 11;
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.clientAddEmailLabel);
            this.Controls.Add(this.tBoxClientAddEmail);
            this.Controls.Add(this.btnClientAddLeave);
            this.Controls.Add(this.btnClientAddCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientAddNifLabel);
            this.Controls.Add(this.clientAddIDNumberLabel);
            this.Controls.Add(this.clientAddSurnameLabel);
            this.Controls.Add(this.clientAddNameLabel);
            this.Controls.Add(this.tBoxClientAddNif);
            this.Controls.Add(this.tBoxClientAddIDNumber);
            this.Controls.Add(this.tBoxClientAddSurname);
            this.Controls.Add(this.tBoxClientAddName);
            this.Name = "ClientAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxClientAddName;
        private System.Windows.Forms.TextBox tBoxClientAddSurname;
        private System.Windows.Forms.TextBox tBoxClientAddIDNumber;
        private System.Windows.Forms.TextBox tBoxClientAddNif;
        private System.Windows.Forms.Label clientAddNameLabel;
        private System.Windows.Forms.Label clientAddSurnameLabel;
        private System.Windows.Forms.Label clientAddIDNumberLabel;
        private System.Windows.Forms.Label clientAddNifLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioClientAddStudentType;
        private System.Windows.Forms.RadioButton radioClientAddTeacherType;
        private System.Windows.Forms.Button btnClientAddCreate;
        private System.Windows.Forms.Button btnClientAddLeave;
        private System.Windows.Forms.Label clientAddEmailLabel;
        private System.Windows.Forms.TextBox tBoxClientAddEmail;
    }
}