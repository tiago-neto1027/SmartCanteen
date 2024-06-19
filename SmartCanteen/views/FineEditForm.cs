using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen.views
{
    public partial class FineEditForm : Form
    {
        private readonly FineController fineController = new FineController();
        public FineEditForm()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGridViewFines_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dGridViewFines.SelectedRows.Count > 0)
                {
                    if (dGridViewFines.SelectedRows[0].DataBoundItem is Fine selectedFine)
                    {
                        textBoxID.Text = selectedFine.ID.ToString();
                        nmrHours.Value = (decimal)selectedFine.Value;
                        nmrFine.Value = (decimal)selectedFine.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnEditFine_Click(object sender, EventArgs e)
        {
            try
            {
                Fine updatedFine = new Fine
                {
                    ID = int.Parse(textBoxID.Text),
                    NumHours = (int)nmrHours.Value,
                    Value = (double)nmrFine.Value
                };

                fineController.UpdateFine(updatedFine);

                MessageBox.Show("Multa atualizada com sucesso.");

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnDeleteFine_Click(object sender, EventArgs e)
        {
            if (dGridViewFines.SelectedRows.Count > 0)
            {
                int selectedID = (int)dGridViewFines.SelectedRows[0].Cells["ID"].Value;

                fineController.DeleteFine(selectedID);
                MessageBox.Show("Multa apagada com sucesso.");

                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Selecione uma multa.");
            }
        }

        //--------------------------------------------- Form Functions ----------------------------------//
        private void LoadDataGrid()
        {
            var fines = fineController.GetAllFines();
            dGridViewFines.DataSource = fines;
        }
    }
}
