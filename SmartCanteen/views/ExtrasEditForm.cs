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
        public ExtrasEditForm()
        {
            InitializeComponent();
        }

        private void ExtrasEditForm_Load(object sender, EventArgs e)
        {
            // Load data
            ExtraController extraController = new ExtraController();
            var extras = extraController.GetAllExtras();

            // Bind data 
            dataGridViewExtras.DataSource = extras;

            dataGridViewExtras.Columns["Active"].Visible = false;
            
        }

        private void btnExtrasEditEdit_Click(object sender, EventArgs e)        //atribute values back to the form for editing
        {
            try
            {
                var selectedExtra = dataGridViewExtras.SelectedRows[0].DataBoundItem as Extra;

                if (selectedExtra != null)
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnExtrasAddLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExtrasEditRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedExtra = new Extra
                {
                    ID = int.Parse(labelExtrasEditIdValue.Text),
                    Description = tBoxExtrasEditDescription.Text,
                    Price = (double)numericExtrasEditStudentPrice.Value,
                    Type = GetSelectedExtraType()
                };

                ExtraController extraController = new ExtraController();
                extraController.UpdateExtra(updatedExtra);

                MessageBox.Show("Extra atualizado com sucesso.");
                

                var extras = extraController.GetAllExtras();
                dataGridViewExtras.DataSource = extras;         // Reload
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }

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
            else if (radioExtrasAddTypeOther.Checked)
            {
                return ExtraType.Other;
            }

            throw new InvalidOperationException("nenhum tipo selecionado.");
        }

        private void btnExtrasEditDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
