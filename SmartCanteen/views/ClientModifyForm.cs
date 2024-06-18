using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class ClientModifyForm : Form
    {
        private List<Client> clientList;
        private Client selectedClient = null;

        public ClientModifyForm()
        {
            InitializeComponent();

            UserController userController = new UserController();

            List<Client> clientList = UserController.GetAllClients();

            listBoxClients.DataSource = null;
            listBoxClients.DataSource = clientList;
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            string searchNif = tBoxClientSearchNif.Text;
            bool NIFsuccess = int.TryParse(searchNif, out int NIFresult);
            if (!NIFsuccess)
            {
                MessageBox.Show("O NIF tem de ser um valor numerico");
                return;
            }
            if (string.IsNullOrEmpty(searchNif))
            {
                MessageBox.Show("Preencha o campo");
                return;
            }
            if (searchNif.Length != 9)
            {
                MessageBox.Show("O NIF tem de ter 9 caracteres");
                return;
            }
            List<Client> clientSearch;
            clientSearch = new List<Client>
            {
                UserController.SearchClient(searchNif)
            };

            if (clientSearch == null)
            {
                MessageBox.Show("Nao existe um cliente com esse NIF");
                return;
            }
            else
            {
                Console.WriteLine("Cliente encontrado");


                listBoxClients.DataSource = null;
                listBoxClients.DataSource = clientSearch;
            }
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxClients.SelectedIndex;
            if (index == -1)
            {
                selectedClient = null;
                return;
            }

            selectedClient = (Client)listBoxClients.SelectedItem;
            updateClientInfo();
        }

        private void btnClientChange_Click(object sender, EventArgs e)
        {
            string oldNIF = selectedClient.NIF;
            string name = tBoxClientName.Text;
            string NIF = tBoxClientNIF.Text;
            string email = null;
            string studentID = null;
            bool NIFsuccess = int.TryParse(NIF, out int NIFresult);
            if (!NIFsuccess)
            {
                MessageBox.Show("O NIF tem de ser um valor numérico.");
                return;
            }

            if (selectedClient == null)
            {
                MessageBox.Show("Selecione um cliente primeiro");
                return;
            }

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Preencha o nome");
                return;
            }   
            if (string.IsNullOrEmpty(NIF))
            {
                MessageBox.Show("Peencha o NIF");
                return;
            }
            var searchNIF = UserController.SearchClient(NIF);
            if (searchNIF != null && NIF != selectedClient.NIF)
            {
                MessageBox.Show("O NIF já esá a ser utilizador por outro cliente.");
                return;
            }
            if (NIF.Length != 9)
            {
                MessageBox.Show("O NIF tem de ter 9 caracteres");
                return;
            }

            if (radiobtnTypeStudent.Checked == true)
            {
                studentID = tBoxStudentNumber.Text;
                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Preencha o numero de estudante");
                    return;
                }
            }
            else
            {
                email = tBoxClientProfessorEmail.Text;
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Preencha o email");
                    return;
                }
            }

            if (radiobtnTypeStudent.Checked == true)
            {
                UserController.ModifClient(oldNIF, name, NIF, email);
            }
            else
            {
                UserController.ModifClient(oldNIF, name, NIF, studentID);
            }

            updateClientInfo();
            updateClientListBox();

        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Selecione um cliente primeiro");
                return;
            }
            UserController.DeleteClient(selectedClient.NIF);
            updateClientListBox();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateClientListBox();
        }

        private void btnClientLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void updateClientListBox()
        {
            int index = listBoxClients.SelectedIndex;
            clientList = UserController.GetAllClients();
            listBoxClients.DataSource = null;
            listBoxClients.DataSource = clientList;
            listBoxClients.SelectedIndex = index;
        }

        private void updateClientInfo()
        {
            if (selectedClient == null)
            {
                tBoxClientName.Text = null;
                tBoxClientNIF.Text = null; 
                radiobtnTypeProfessor.Checked = false;
                radiobtnTypeStudent.Checked = false;
                tBoxClientBalance = null;
                return;
            }

            tBoxClientName.Text = selectedClient.Name;
            tBoxClientNIF.Text = selectedClient.NIF;
            tBoxClientBalance.Text =  selectedClient.Balance + " €";
            
            if(selectedClient is Student)
            {
                updateRadioStudent();
            }
            else
            {
                updateRadioProfessor();
            }
        }

        private void radiobtnTypeStudent_Click(object sender, EventArgs e)
        {
            updateRadioStudent();
        }

        private void radiobtnTypeProfessor_Click(object sender, EventArgs e)
        {
            updateRadioProfessor();
        }

        private void updateRadioProfessor()
        {
            tBoxClientProfessorEmail.Text = (selectedClient as Professor).Email;
            radiobtnTypeStudent.Checked = false;
            radiobtnTypeProfessor.Checked = true;

            labelClientStudentNumber.Visible = false;
            tBoxStudentNumber.Visible = false;

            labelClientProfessorEmail.Visible = true;
            tBoxClientProfessorEmail.Visible = true;
        }

        private void updateRadioStudent()
        {
            tBoxStudentNumber.Text = (selectedClient as Student).StudentID;
            radiobtnTypeStudent.Checked = true;
            radiobtnTypeProfessor.Checked = false;

            labelClientProfessorEmail.Visible = false;
            tBoxClientProfessorEmail.Visible = false;

            labelClientStudentNumber.Visible = true;
            tBoxStudentNumber.Visible = true;
        }
    }
       
}
