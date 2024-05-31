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

            string username = tBoxUserNameLogin.Text;
            string password = tBoxPasswordLogin.Text;

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
                    .FirstOrDefault(staff => staff.username == username && staff.password == password);

                if (matchingStaff != null)
                {
                    Console.WriteLine($"Staff member found: {matchingStaff.name}");
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
            /*
            context.Users.Where(staff => staff is Staff)
            .Where(staff => (staff as Staff).username == username)
            .Where(staff => (staff as Staff).password == password);

            if (query_result.Count() == 0)
            {
                MessageBox.Show("Login failed");
                return;
            }

            models.Staff user = query_result.First();
            if (user.username == "Admin")
            {

            }
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                this.Close();
            }
            */

        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
