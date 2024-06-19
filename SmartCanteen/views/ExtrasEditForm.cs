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

namespace SmartCanteen
{
    public partial class ExtrasEditForm : Form
    {
        private readonly ExtraController extraController = new ExtraController();
        public ExtrasEditForm()
        {
            InitializeComponent();
            LoadDataGrid();

            dataGridViewExtras.Columns["Menus"].Visible = false;
        }

        private void btnExtrasAddLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewExtras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewExtras.SelectedRows.Count > 0)
                {
                    if (dataGridViewExtras.SelectedRows[0].DataBoundItem is Extra selectedExtra)
                    {
                        labelExtrasEditIdValue.Text = selectedExtra.ID.ToString();
                        tBoxExtrasEditDescription.Text = selectedExtra.Description;
                        numericExtrasEditStudentPrice.Value = Convert.ToDecimal(selectedExtra.Price);

                        switch (selectedExtra.Type)
                        {
                            case ExtraType.Soup:
                                radioExtrasAddTypeSoup.Checked = true;
                                break;
                            case ExtraType.Dessert:
                                radioExtrasAddTypeDessert.Checked = true;
                                break;
                            case ExtraType.Drink:
                                radioExtrasAddTypeBeverage.Checked = true;
                                break;
                            case ExtraType.Other:
                                radioExtrasAddTypeOther.Checked = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnExtrasEditRegister_Click(object sender, EventArgs e)
        {
            //Verify if fields are empty
            if (string.IsNullOrEmpty(tBoxExtrasEditDescription.Text))
            {
                MessageBox.Show("A descrição não pode estar vazia.");
                return;
            }
            if (numericExtrasEditStudentPrice.Value == 0)
            {
                MessageBox.Show("O preço do produto não pode ser 0.");
                return;
            }
            try
            {
                Extra updatedExtra = new Extra
                {
                    ID = int.Parse(labelExtrasEditIdValue.Text),
                    Description = tBoxExtrasEditDescription.Text,
                    Price = (double)numericExtrasEditStudentPrice.Value,
                    Type = GetSelectedExtraType()
                };

                extraController.UpdateExtra(updatedExtra);

                MessageBox.Show("Extra atualizado com sucesso.");

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnExtrasEditDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewExtras.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewExtras.SelectedRows[0].Cells["ID"].Value;

                extraController.DeleteExtra(selectedId);
                MessageBox.Show("Extra apagado com sucesso.");

                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Selecione um item.");
            }
        }

        //--------------------------------------------- Form Functions ----------------------------------//
        private void LoadDataGrid()
        {
            var extras = extraController.GetAllExtras();
            dataGridViewExtras.DataSource = extras;
        }

        private ExtraType GetSelectedExtraType()
        {
            if (radioExtrasAddTypeSoup.Checked)
            {
                return ExtraType.Soup;
            }
            else if (radioExtrasAddTypeDessert.Checked)
            {
                return ExtraType.Dessert;
            }
            else if (radioExtrasAddTypeBeverage.Checked)
            {
                return ExtraType.Drink;
            }
            else
            {
                return ExtraType.Other;
            }
        }
    }
}
