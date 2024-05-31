namespace SmartCanteen
{
    partial class LoginForm
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
            this.tBoxLoginUser = new System.Windows.Forms.TextBox();
            this.tBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCreateUser = new System.Windows.Forms.Button();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxLoginUser
            // 
            this.tBoxLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLoginUser.Location = new System.Drawing.Point(81, 100);
            this.tBoxLoginUser.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxLoginUser.Name = "tBoxLoginUser";
            this.tBoxLoginUser.Size = new System.Drawing.Size(151, 21);
            this.tBoxLoginUser.TabIndex = 0;
            // 
            // tBoxLoginPassword
            // 
            this.tBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLoginPassword.Location = new System.Drawing.Point(81, 157);
            this.tBoxLoginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxLoginPassword.Name = "tBoxLoginPassword";
            this.tBoxLoginPassword.Size = new System.Drawing.Size(151, 21);
            this.tBoxLoginPassword.TabIndex = 1;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLogin.Location = new System.Drawing.Point(78, 81);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(36, 15);
            this.labelUserLogin.TabIndex = 2;
            this.labelUserLogin.Text = "User:";
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogin.Location = new System.Drawing.Point(78, 138);
            this.labelPasswordLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(64, 15);
            this.labelPasswordLogin.TabIndex = 3;
            this.labelPasswordLogin.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(81, 198);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginCreateUser
            // 
            this.btnLoginCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCreateUser.Location = new System.Drawing.Point(81, 302);
            this.btnLoginCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginCreateUser.Name = "btnLoginCreateUser";
            this.btnLoginCreateUser.Size = new System.Drawing.Size(150, 24);
            this.btnLoginCreateUser.TabIndex = 5;
            this.btnLoginCreateUser.Text = "Create User";
            this.btnLoginCreateUser.UseVisualStyleBackColor = true;
            this.btnLoginCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginExit.Location = new System.Drawing.Point(118, 332);
            this.btnLoginExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(75, 24);
            this.btnLoginExit.TabIndex = 6;
            this.btnLoginExit.Text = "Exit";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnLoginCreateUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.tBoxLoginPassword);
            this.Controls.Add(this.tBoxLoginUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxLoginUser;
        private System.Windows.Forms.TextBox tBoxLoginPassword;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginCreateUser;
        private System.Windows.Forms.Button btnLoginExit;
    }
}