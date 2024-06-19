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
        ClientController clientController = new ClientController();
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
            tBoxStudentID.Text = 0.ToString();

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
                MessageBox.Show("NIF tem de ser um valor numérico.");
                return;
            }

            var searchNIF = clientController.SearchClient(nif);
            if (searchNIF != null)
            {
                MessageBox.Show("O NIF já está a ser usado.");
                return;
            }

            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(nif))
                { 
                MessageBox.Show("Tem de preencher todos os campos.");
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
            if (nif.Length != 9)
            {
                MessageBox.Show("NIF precisa de ter 9 caracteres");
                return;
            }

            if (radioClientAddStudentType.Checked == true)
            {
                bool IDsuccess = int.TryParse(studentID, out int IDresult);
                if (!IDsuccess && studentID != null)
                {
                    MessageBox.Show("Student ID tem de ser numérico.");
                    return;
                }
                clientController.AddStudent(name, nif, balance, studentID);
                MessageBox.Show("Estudante adicionado com sucesso");
            }
            if (radioClientAddProfessorType.Checked == true)
            {
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email não pode estar vazio!");
                    return;
                }

               if(!Regex.IsMatch(email, pattern))
                {
                    MessageBox.Show("Email inválido.");
                    return;
                }
                clientController.AddProfessor(name, nif, balance, email);
                MessageBox.Show("Professor adicionado com sucesso");
            }
            tBoxEmail.Text = "";
            tBoxName.Text = "";
            tBoxNIF.Text = "";
            tBoxStudentID.Text = "";
            BalanceInput.Value = 0;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
