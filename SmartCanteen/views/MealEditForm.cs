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
        public MealEditForm()
        {
            InitializeComponent();
        }

        private void btnMealEditLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MealEditForm_Load(object sender, EventArgs e)
        {
            // Load data
            DishController dishController = new DishController();
            var dishes = dishController.GetAllDishes();

            // Bind data
            dataGridViewMeal.DataSource = dishes;
            dataGridViewMeal.Columns["Active"].Visible = false;
        }

        private void btnMealEditEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMeal = dataGridViewMeal.SelectedRows[0].DataBoundItem as Dish;

                if (selectedMeal != null)
                {
                    labelMealEditIdValue.Text = selectedMeal.ID.ToString();
                    tBoxMealEditDescription.Text = selectedMeal.Description;

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
                    Type = GetSelectedMealType()
                };

                DishController dishController = new DishController();
                dishController.UpdateDish(updatedDish);

                MessageBox.Show("prato actualizado com sucesso.");


                var dishes = dishController.GetAllDishes();
                dataGridViewMeal.DataSource = dishes;         // Reload
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar: " + ex.Message + " - " + ex.Source);
            }
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
