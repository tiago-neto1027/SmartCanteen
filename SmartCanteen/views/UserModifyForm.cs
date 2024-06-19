using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace SmartCanteen
{
    public partial class UserModifyForm : Form
    {
        private UserController userController = new UserController();

        public UserModifyForm()
        {
            InitializeComponent();

            LoadDataGrid();
            dataGridViewStaff.Columns["Password"].Visible = false;
        }

        private void btnExitUserModify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGrid()
        {
            var Users = userController.GetAllStaff();
            dataGridViewStaff.DataSource = Users;
        }


        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStaff.SelectedRows.Count > 0)
                {
                    if (dataGridViewStaff.SelectedRows[0].DataBoundItem is Staff selectedUser)
                    {
                        labelUsersModifyIdValue.Text = selectedUser.ID.ToString();
                        tBoxUserModifyName.Text = selectedUser.Name;
                        tBoxUserModifyUserName.Text = selectedUser.Username;
                        tBoxUserModifyNIF.Text = selectedUser.NIF;
                        tBoxUserModifyPassword.Text = selectedUser.Password;;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            string AdminPassword = "Admin2024";
            string inputPassword = tBoxUserModifyManagementPassword.Text;

            //--------------------- Validation ---------------------//
            string name = tBoxUserModifyName.Text;
            string nif = tBoxUserModifyNIF.Text;
            string username = tBoxUserModifyUserName.Text;
            string password = tBoxUserModifyPassword.Text;

            bool success = int.TryParse(nif, out int result);
            if (!success)
            {
                MessageBox.Show("NIF tem de ser um valor numérico.");
                return;
            }

            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(nif)
                || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password))
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

            if (nif.Length != 9)
            {
                MessageBox.Show("NIF tem de ser 9 caracteres");
                return;
            }
            //--------------------- /Validation ---------------------//

            if (inputPassword != AdminPassword)
            {
                MessageBox.Show("Password de Gerência Errada");
            }
            else
            {
                UpdateUser();
            }
        }

        private void UpdateUser()
        {
            try
            {
                Staff updatedUser = new Staff
                {
                    ID = int.Parse(labelUsersModifyIdValue.Text),
                    Name = tBoxUserModifyName.Text,
                    Username = tBoxUserModifyUserName.Text,
                    NIF = tBoxUserModifyNIF.Text,
                    Password = tBoxUserModifyPassword.Text
                };

                userController.UpdateUser(updatedUser);

                MessageBox.Show("User atualizado com sucesso.");

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnDeleteUserModify_Click(object sender, EventArgs e)
        {
            string AdminPassword = "Admin2024";
            string inputPassword = tBoxUserModifyManagementPassword.Text;

            if (inputPassword != AdminPassword)
            {
                MessageBox.Show("Password de Gerência Errada");
            }
            else
            {
                RemoveUser();
            }
        }

        private void RemoveUser()
        {
            var confirmResult = MessageBox.Show("Irá apagar o User.",
                                     "Continuar?",
                                     MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                if (dataGridViewStaff.SelectedRows.Count > 0)
                {
                    int userId = (int)dataGridViewStaff.SelectedRows[0].Cells["ID"].Value;

                    userController.DeleteUser(userId);
                    MessageBox.Show("User apagado com sucesso.");

                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Selecione um User.");
                }
            }
            else
            {

            }
        }
    }
}
