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
            this.tBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.tBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxUserNameLogin
            // 
            this.tBoxUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUserNameLogin.Location = new System.Drawing.Point(81, 100);
            this.tBoxUserNameLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxUserNameLogin.Name = "tBoxUserNameLogin";
            this.tBoxUserNameLogin.Size = new System.Drawing.Size(151, 21);
            this.tBoxUserNameLogin.TabIndex = 0;
            // 
            // tBoxPasswordLogin
            // 
            this.tBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLogin.Location = new System.Drawing.Point(81, 157);
            this.tBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPasswordLogin.Name = "tBoxPasswordLogin";
            this.tBoxPasswordLogin.PasswordChar = '*';
            this.tBoxPasswordLogin.Size = new System.Drawing.Size(151, 21);
            this.tBoxPasswordLogin.TabIndex = 1;
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
            // btnExitLogin
            // 
            this.btnExitLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitLogin.Location = new System.Drawing.Point(118, 332);
            this.btnExitLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(75, 24);
            this.btnExitLogin.TabIndex = 6;
            this.btnExitLogin.Text = "Exit";
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.tBoxPasswordLogin);
            this.Controls.Add(this.tBoxUserNameLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxUserNameLogin;
        private System.Windows.Forms.TextBox tBoxPasswordLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExitLogin;
    }
}