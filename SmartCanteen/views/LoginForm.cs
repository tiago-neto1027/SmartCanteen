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
                MessageBox.Show("Username is empty!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty!");
                return;
            }
            using (context = new SmartCanteenContext())
            {
                var matchingStaff = context.Users
                    .OfType<Staff>()
                    .FirstOrDefault(staff => staff.Username == username && staff.Password == password);

                if (matchingStaff != null)
                {
                    Console.WriteLine($"Staff member found: {matchingStaff.Name}");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    Console.WriteLine("No matching staff member found.");
                    this.Close();
                }
            }
            

        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginCreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistryForm registryForm = new RegistryForm();
            registryForm.ShowDialog();
            this.Close();
        }
    }
}
