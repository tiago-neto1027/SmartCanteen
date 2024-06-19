namespace SmartCanteen
{
    partial class StaffRegistryForm
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
            this.btnCreateRegistry = new System.Windows.Forms.Button();
            this.labelPasswordRegistry = new System.Windows.Forms.Label();
            this.labelUserRegistry = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirmationRegistry = new System.Windows.Forms.Label();
            this.tBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.labelManagementPasswordRegistry = new System.Windows.Forms.Label();
            this.tBoxManagementPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxNIF = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateRegistry
            // 
            this.btnCreateRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRegistry.Location = new System.Drawing.Point(21, 306);
            this.btnCreateRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRegistry.Name = "btnCreateRegistry";
            this.btnCreateRegistry.Size = new System.Drawing.Size(106, 32);
            this.btnCreateRegistry.TabIndex = 7;
            this.btnCreateRegistry.Text = "Criar  User";
            this.btnCreateRegistry.UseVisualStyleBackColor = true;
            this.btnCreateRegistry.Click += new System.EventHandler(this.btnCreateRegistry_Click);
            // 
            // labelPasswordRegistry
            // 
            this.labelPasswordRegistry.AutoSize = true;
            this.labelPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordRegistry.Location = new System.Drawing.Point(201, 19);
            this.labelPasswordRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordRegistry.Name = "labelPasswordRegistry";
            this.labelPasswordRegistry.Size = new System.Drawing.Size(64, 15);
            this.labelPasswordRegistry.TabIndex = 8;
            this.labelPasswordRegistry.Text = "Password:";
            // 
            // labelUserRegistry
            // 
            this.labelUserRegistry.AutoSize = true;
            this.labelUserRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRegistry.Location = new System.Drawing.Point(6, 80);
            this.labelUserRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserRegistry.Name = "labelUserRegistry";
            this.labelUserRegistry.Size = new System.Drawing.Size(70, 15);
            this.labelUserRegistry.TabIndex = 7;
            this.labelUserRegistry.Text = "UserName:";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPassword.Location = new System.Drawing.Point(204, 38);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(150, 21);
            this.tBoxPassword.TabIndex = 4;
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUserName.Location = new System.Drawing.Point(9, 99);
            this.tBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.Size = new System.Drawing.Size(150, 21);
            this.tBoxUserName.TabIndex = 2;
            // 
            // labelPasswordConfirmationRegistry
            // 
            this.labelPasswordConfirmationRegistry.AutoSize = true;
            this.labelPasswordConfirmationRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmationRegistry.Location = new System.Drawing.Point(201, 80);
            this.labelPasswordConfirmationRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordConfirmationRegistry.Name = "labelPasswordConfirmationRegistry";
            this.labelPasswordConfirmationRegistry.Size = new System.Drawing.Size(124, 15);
            this.labelPasswordConfirmationRegistry.TabIndex = 11;
            this.labelPasswordConfirmationRegistry.Text = "Confirmar Password :";
            // 
            // tBoxPasswordConfirmation
            // 
            this.tBoxPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordConfirmation.Location = new System.Drawing.Point(204, 99);
            this.tBoxPasswordConfirmation.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPasswordConfirmation.Name = "tBoxPasswordConfirmation";
            this.tBoxPasswordConfirmation.PasswordChar = '*';
            this.tBoxPasswordConfirmation.Size = new System.Drawing.Size(150, 21);
            this.tBoxPasswordConfirmation.TabIndex = 5;
            // 
            // labelManagementPasswordRegistry
            // 
            this.labelManagementPasswordRegistry.AutoSize = true;
            this.labelManagementPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagementPasswordRegistry.Location = new System.Drawing.Point(18, 235);
            this.labelManagementPasswordRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagementPasswordRegistry.Name = "labelManagementPasswordRegistry";
            this.labelManagementPasswordRegistry.Size = new System.Drawing.Size(134, 15);
            this.labelManagementPasswordRegistry.TabIndex = 13;
            this.labelManagementPasswordRegistry.Text = "Password de Gerência:";
            // 
            // tBoxManagementPassword
            // 
            this.tBoxManagementPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxManagementPassword.Location = new System.Drawing.Point(21, 255);
            this.tBoxManagementPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxManagementPassword.Name = "tBoxManagementPassword";
            this.tBoxManagementPassword.PasswordChar = '*';
            this.tBoxManagementPassword.Size = new System.Drawing.Size(150, 21);
            this.tBoxManagementPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(9, 38);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(150, 21);
            this.tBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "NIF:";
            // 
            // tBoxNIF
            // 
            this.tBoxNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNIF.Location = new System.Drawing.Point(9, 156);
            this.tBoxNIF.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNIF.Name = "tBoxNIF";
            this.tBoxNIF.Size = new System.Drawing.Size(150, 21);
            this.tBoxNIF.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(260, 306);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 32);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxUserName);
            this.groupBox1.Controls.Add(this.tBoxNIF);
            this.groupBox1.Controls.Add(this.tBoxPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelUserRegistry);
            this.groupBox1.Controls.Add(this.labelPasswordRegistry);
            this.groupBox1.Controls.Add(this.tBoxPasswordConfirmation);
            this.groupBox1.Controls.Add(this.labelPasswordConfirmationRegistry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 202);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User:";
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelManagementPasswordRegistry);
            this.Controls.Add(this.tBoxManagementPassword);
            this.Controls.Add(this.btnCreateRegistry);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRegistry;
        private System.Windows.Forms.Label labelPasswordRegistry;
        private System.Windows.Forms.Label labelUserRegistry;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxUserName;
        private System.Windows.Forms.Label labelPasswordConfirmationRegistry;
        private System.Windows.Forms.TextBox tBoxPasswordConfirmation;
        private System.Windows.Forms.Label labelManagementPasswordRegistry;
        private System.Windows.Forms.TextBox tBoxManagementPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxNIF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}