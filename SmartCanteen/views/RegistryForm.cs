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
                MessageBox.Show("NIF has to be a numeric value.");
                return;
            }

            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(nif)
                || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password) 
                || string.IsNullOrEmpty(confirmedPassword) 
                || string.IsNullOrEmpty(managementPassword))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty!");
                return;
            }
            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("NIF is empty!");
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is empty!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty!");
                return;
            }
            if (string.IsNullOrEmpty(confirmedPassword))
            {
                MessageBox.Show("Confirmation password is empty!");
                return;
            }
            if (string.IsNullOrEmpty(managementPassword))
            {
                MessageBox.Show("Management Password password is empty!");
                return;
            }

            if (managementPassword != "Admin2024")
            {
                MessageBox.Show("Management Password is invalid");
                return;                   
            }

            if (password != confirmedPassword)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            if (nif.Length!=9)
            {
                MessageBox.Show("NIF needs to be 9 characters");
                return;
            }
            
            UserController userController = new UserController();
            userController.AddStaff(name, nif, username, password);
            MessageBox.Show("Staff added sucessfully");

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
