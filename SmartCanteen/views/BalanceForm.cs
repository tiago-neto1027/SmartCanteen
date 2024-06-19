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
    public partial class BalanceForm : Form
    {
        ClientController clientController = new ClientController();
        private List<Client> clientList;
        private Client selectedClient = null;

        public BalanceForm()
        {
            InitializeComponent();

            List<Client> clientList = clientController.GetAllClients();

            listBoxClients.DataSource = null;
            listBoxClients.DataSource = clientList;
        }

        private void btnBalanceLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(); 
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnBalanceAddValue_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Selecione um cliente primeiro");
                return;
            }

            decimal addedvalue = AddValue.Value;
            bool result = clientController.UpdateClientBalance(selectedClient.NIF, addedvalue);

            if (addedvalue == 0)
            {
                MessageBox.Show("Insira um valor maior que 0");
                return;
            }
            if (result)
            {
                Console.WriteLine("Valor adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro");
            }
            AddValue.Value = 0;
            updateClientInfo();
            updateClientListBox();

        }

        private void btnBalanceSearch_Click(object sender, EventArgs e)
        {
            string searchNif = tBoxBalanceNif.Text;
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
            clientSearch = new List<Client>();
            clientSearch.Add(clientController.SearchClient(searchNif));
            
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

        private void updateClientListBox()
        {
            int index = listBoxClients.SelectedIndex;
            clientList = clientController.GetAllClients();
            listBoxClients.DataSource = null;
            listBoxClients.DataSource = clientList;
            listBoxClients.SelectedIndex = index;
        }

        private void updateClientInfo()
        {
            if (selectedClient == null)
            {
                labelBalancelName.Text = "Nome: ";
                labelBalanceNif.Text = "NIF: ";
                labelBalanceCurrent.Text = "Saldo: ";
                labelBalanceType.Text = "Tipo: ";
                return;
            }

            labelBalancelName.Text = "Nome: " + selectedClient.Name;
            labelBalanceNif.Text = "NIF: " + selectedClient.NIF;
            labelBalanceCurrent.Text = "Saldo: " + selectedClient.Balance + "€";
            if(selectedClient is Student)
            {
                labelBalanceType.Text = "Tipo: Aluno";
            }
            else
            {
                labelBalanceType.Text = "Tipo: Professor";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateClientListBox();
        }
    }
}
