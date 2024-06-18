using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class MealEditForm : Form
    {
        private readonly DishController dishController = new DishController();
        public MealEditForm()
        {
            InitializeComponent();
            LoadDataGrid();

            dataGridViewMeals.Columns["Menus"].Visible = false;
        }

        private void btnMealEditLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewMeals_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMeals.SelectedRows.Count > 0)
                {
                    if (dataGridViewMeals.SelectedRows[0].DataBoundItem is Dish selectedMeal)
                    {
                        labelMealEditIdValue.Text = selectedMeal.ID.ToString();
                        tBoxMealEditDescription.Text = selectedMeal.Description;
                        checkBoxActive.Checked = selectedMeal.Active;

                        switch (selectedMeal.Type)
                        {
                            case DishType.Meat:
                                radioMealEditCategoryMeat.Checked = true;
                                break;
                            case DishType.Fish:
                                radioMealEditCategoryFish.Checked = true;
                                break;
                            case DishType.Veggie:
                                radioMealEditCategoryVeggie.Checked = true;
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

        private void btnMealEditRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedDish = new Dish
                {
                    ID = int.Parse(labelMealEditIdValue.Text),
                    Description = tBoxMealEditDescription.Text,
                    Type = GetSelectedMealType(),
                    Active = checkBoxActive.Checked
                };

                dishController.UpdateDish(updatedDish);

                MessageBox.Show("prato actualizado com sucesso.");

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnMealEditDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMeals.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Todos os Menus associados a este Prato Serão apagados, pretende prosseguir?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedId = (int)dataGridViewMeals.SelectedRows[0].Cells["ID"].Value;

                    dishController.DeleteDish(selectedId);
                    MessageBox.Show("Prato apagado com sucesso.");

                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item.");
            }
        }
        //----------------------------------------- Form Functions ---------------------------------------------------//
        private void LoadDataGrid()
        {
            var dishes = dishController.GetAllDishes();
            dataGridViewMeals.DataSource = dishes;
        }

        private DishType GetSelectedMealType()
        {
            if (radioMealEditCategoryMeat.Checked)
            {
                return DishType.Meat;
            }
            else if (radioMealEditCategoryFish.Checked)
            {
                return DishType.Fish;
            }
            else if (radioMealEditCategoryVeggie.Checked)
            {
                return DishType.Veggie;
            }

            throw new InvalidOperationException("nenhum tipo selecionado.");
        }
    }
}
