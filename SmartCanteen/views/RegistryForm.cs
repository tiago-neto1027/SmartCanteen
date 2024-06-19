using SmartCanteen.controllers;
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
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void btnCreateRegistry_Click(object sender, EventArgs e)
        {
            SmartCanteenContext context = new SmartCanteenContext();

            string name = tBoxName.Text;
            string nif = tBoxNIF.Text;
            string username = tBoxUserName.Text;
            string password = tBoxPassword.Text;
            string confirmedPassword = tBoxPasswordConfirmation.Text;
            string managementPassword = tBoxManagementPassword.Text;

            bool success = int.TryParse(nif, out int result);
            if (!success)
            {
                MessageBox.Show("NIF tem de ser um valor numérico.");
                return;
            }

            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(nif)
                || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password) 
                || string.IsNullOrEmpty(confirmedPassword) 
                || string.IsNullOrEmpty(managementPassword))
            {
                MessageBox.Show("Todos os campos são requeridos");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nome está vazio!");
                return;
            }
            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("NIF está vazio!");
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username está vazio!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password está vazio!");
                return;
            }
            if (string.IsNullOrEmpty(confirmedPassword))
            {
                MessageBox.Show("Necessário confirmar Password!");
                return;
            }
            if (string.IsNullOrEmpty(managementPassword))
            {
                MessageBox.Show("Necessário confirmar com Password de Gerência!");
                return;
            }

            if (managementPassword != "Admin2024")
            {
                MessageBox.Show("Password de Gerência inválida");
                return;                   
            }

            if (password != confirmedPassword)
            {
                MessageBox.Show("Passwords não são idênticas");
                return;
            }

            if (nif.Length!=9)
            {
                MessageBox.Show("NIF tem de ser 9 caracteres");
                return;
            }
            
            UserController userController = new UserController();
            userController.AddStaff(name, nif, username, password);
            MessageBox.Show("Staff adicionado com sucesso");

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
