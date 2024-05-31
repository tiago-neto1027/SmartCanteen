using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            RegistryForm registryForm = new RegistryForm();
            registryForm.ShowDialog();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
