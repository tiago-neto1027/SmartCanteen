using SmartCanteen.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartCanteen
{
    public partial class ClientAddForm : Form
    {
        public ClientAddForm()
        {

            InitializeComponent();
            radioClientAddStudentType.Checked = true;
        }
        private void radioClientAddStudentType_Click(object sender, EventArgs e)
        {
            radioClientAddProfessorType.Checked = false;
            tBoxEmail.Text = string.Empty;

            tBoxEmail.Visible = false;
            EmailLabel.Visible = false;

            tBoxStudentID.Visible = true;
            StudentIDLabel.Visible = true;
        }

        private void radioClientAddProfessorType_Click(object sender, EventArgs e)
        {
            radioClientAddStudentType.Checked = false;
            tBoxStudentID.Text = string.Empty;

            tBoxStudentID.Visible = false;
            StudentIDLabel.Visible = false; 

            tBoxEmail.Location = new System.Drawing.Point(132, 130);
            EmailLabel.Location = new System.Drawing.Point(69, 130);

            tBoxEmail.Visible = true;
            EmailLabel.Visible = true;
        }

        private void btnClientAddCreate_Click(object sender, EventArgs e)
        {
            string name = tBoxName.Text;
            string nif = tBoxNIF.Text;
            decimal balance = BalanceInput.Value;
            string studentID = tBoxStudentID.Text;
            string email = tBoxEmail.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool NIFsuccess = int.TryParse(nif, out int NIFresult);
            if (!NIFsuccess)
            {
                MessageBox.Show("NIF has to be a numeric value.");
                return;
            }

            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(nif))
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
            if (nif.Length != 9)
            {
                MessageBox.Show("NIF needs to be 9 characters");
                return;
            }

            if (radioClientAddStudentType.Checked == true)
            {
                bool IDsuccess = int.TryParse(studentID, out int IDresult);
                if (!IDsuccess && studentID != null)
                {
                    MessageBox.Show("Student ID has to be a numeric value.");
                    return;
                }
                UserController userController = new UserController();
                userController.AddStudent(name, nif, balance, studentID);
                MessageBox.Show("Student added sucessfully");

            }
            if (radioClientAddProfessorType.Checked == true)
            {
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email needs to be filled in");
                    return;
                }

               if(!Regex.IsMatch(email, pattern))
                {
                    MessageBox.Show("Invalid email");
                    return;
                }
                UserController userController = new UserController();
                userController.AddProfessor(name, nif, balance, email);
                MessageBox.Show("Professor added sucessfully");
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

      
    }
}
