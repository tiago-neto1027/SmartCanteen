using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class LoginForm : Form
    {
        UserController userController = new UserController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SmartCanteenContext context = new SmartCanteenContext();

            string username = tBoxLoginUser.Text;
            string password = tBoxLoginPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username não pode estar vazio!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password não pode estar vazia!");
                return;
            }

            if (userController.LoginStaff(username, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi encontrado nenhum membro da staff com essas credenciais.");
                tBoxLoginPassword.Text = string.Empty;
                tBoxLoginUser.Text = string.Empty;
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginCreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffRegistryForm registryForm = new StaffRegistryForm();
            registryForm.ShowDialog();
            this.Close();
        }
    }
}
