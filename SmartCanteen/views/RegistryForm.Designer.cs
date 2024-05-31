namespace SmartCanteen
{
    partial class RegistryForm
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
            this.tBoxPasswordRegistry = new System.Windows.Forms.TextBox();
            this.tBoxUserRegistry = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirmationRegistry = new System.Windows.Forms.Label();
            this.tBoxPasswordConfirmationRegistry = new System.Windows.Forms.TextBox();
            this.labelManagementPasswordRegistry = new System.Windows.Forms.Label();
            this.tBoxManagementPasswordRegistry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateRegistry
            // 
            this.btnCreateRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRegistry.Location = new System.Drawing.Point(82, 313);
            this.btnCreateRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRegistry.Name = "btnCreateRegistry";
            this.btnCreateRegistry.Size = new System.Drawing.Size(150, 27);
            this.btnCreateRegistry.TabIndex = 13;
            this.btnCreateRegistry.Text = "Create User";
            this.btnCreateRegistry.UseVisualStyleBackColor = true;
            this.btnCreateRegistry.Click += new System.EventHandler(this.btnCreateRegistry_Click);
            // 
            // labelPasswordRegistry
            // 
            this.labelPasswordRegistry.AutoSize = true;
            this.labelPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordRegistry.Location = new System.Drawing.Point(79, 112);
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
            this.labelUserRegistry.Location = new System.Drawing.Point(79, 55);
            this.labelUserRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserRegistry.Name = "labelUserRegistry";
            this.labelUserRegistry.Size = new System.Drawing.Size(36, 15);
            this.labelUserRegistry.TabIndex = 7;
            this.labelUserRegistry.Text = "User:";
            // 
            // tBoxPasswordRegistry
            // 
            this.tBoxPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordRegistry.Location = new System.Drawing.Point(82, 131);
            this.tBoxPasswordRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPasswordRegistry.Name = "tBoxPasswordRegistry";
            this.tBoxPasswordRegistry.Size = new System.Drawing.Size(150, 21);
            this.tBoxPasswordRegistry.TabIndex = 6;
            // 
            // tBoxUserRegistry
            // 
            this.tBoxUserRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUserRegistry.Location = new System.Drawing.Point(82, 74);
            this.tBoxUserRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxUserRegistry.Name = "tBoxUserRegistry";
            this.tBoxUserRegistry.Size = new System.Drawing.Size(150, 21);
            this.tBoxUserRegistry.TabIndex = 5;
            // 
            // labelPasswordConfirmationRegistry
            // 
            this.labelPasswordConfirmationRegistry.AutoSize = true;
            this.labelPasswordConfirmationRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmationRegistry.Location = new System.Drawing.Point(79, 170);
            this.labelPasswordConfirmationRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordConfirmationRegistry.Name = "labelPasswordConfirmationRegistry";
            this.labelPasswordConfirmationRegistry.Size = new System.Drawing.Size(110, 15);
            this.labelPasswordConfirmationRegistry.TabIndex = 11;
            this.labelPasswordConfirmationRegistry.Text = "Confirm Password:";
            // 
            // tBoxPasswordConfirmationRegistry
            // 
            this.tBoxPasswordConfirmationRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordConfirmationRegistry.Location = new System.Drawing.Point(82, 189);
            this.tBoxPasswordConfirmationRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPasswordConfirmationRegistry.Name = "tBoxPasswordConfirmationRegistry";
            this.tBoxPasswordConfirmationRegistry.Size = new System.Drawing.Size(150, 21);
            this.tBoxPasswordConfirmationRegistry.TabIndex = 10;
            // 
            // labelManagementPasswordRegistry
            // 
            this.labelManagementPasswordRegistry.AutoSize = true;
            this.labelManagementPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagementPasswordRegistry.Location = new System.Drawing.Point(79, 257);
            this.labelManagementPasswordRegistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagementPasswordRegistry.Name = "labelManagementPasswordRegistry";
            this.labelManagementPasswordRegistry.Size = new System.Drawing.Size(141, 15);
            this.labelManagementPasswordRegistry.TabIndex = 13;
            this.labelManagementPasswordRegistry.Text = "Management Password:";
            // 
            // tBoxManagementPasswordRegistry
            // 
            this.tBoxManagementPasswordRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxManagementPasswordRegistry.Location = new System.Drawing.Point(82, 276);
            this.tBoxManagementPasswordRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxManagementPasswordRegistry.Name = "tBoxManagementPasswordRegistry";
            this.tBoxManagementPasswordRegistry.Size = new System.Drawing.Size(150, 21);
            this.tBoxManagementPasswordRegistry.TabIndex = 12;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.labelManagementPasswordRegistry);
            this.Controls.Add(this.tBoxManagementPasswordRegistry);
            this.Controls.Add(this.labelPasswordConfirmationRegistry);
            this.Controls.Add(this.tBoxPasswordConfirmationRegistry);
            this.Controls.Add(this.btnCreateRegistry);
            this.Controls.Add(this.labelPasswordRegistry);
            this.Controls.Add(this.labelUserRegistry);
            this.Controls.Add(this.tBoxPasswordRegistry);
            this.Controls.Add(this.tBoxUserRegistry);
            this.Name = "RegistryForm";
            this.Text = "RegistryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRegistry;
        private System.Windows.Forms.Label labelPasswordRegistry;
        private System.Windows.Forms.Label labelUserRegistry;
        private System.Windows.Forms.TextBox tBoxPasswordRegistry;
        private System.Windows.Forms.TextBox tBoxUserRegistry;
        private System.Windows.Forms.Label labelPasswordConfirmationRegistry;
        private System.Windows.Forms.TextBox tBoxPasswordConfirmationRegistry;
        private System.Windows.Forms.Label labelManagementPasswordRegistry;
        private System.Windows.Forms.TextBox tBoxManagementPasswordRegistry;
    }
}