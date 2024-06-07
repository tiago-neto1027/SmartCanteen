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
    }
}
