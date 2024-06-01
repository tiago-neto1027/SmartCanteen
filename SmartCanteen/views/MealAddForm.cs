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
using System.Xml.Linq;

namespace SmartCanteen
{
    public partial class MealAddForm : Form
    {
        public MealAddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the btnMealAddRegister button.
        /// Gathers the description from the text box and determines the selected dish type 
        /// from the radio buttons. Then, it creates an instance of DishController to 
        /// add a new dish with the provided description and dish type to the database.
        /// Displays a message box indicating the success or failure of the operation.
        /// Closes the current form after the operation is completed.
        /// </summary>
        private void btnMealAddRegister_Click(object sender, EventArgs e)
        {
            //Verify if description is empty
            if (string.IsNullOrEmpty(tBoxMealAddDescription.Text))
            {
                MessageBox.Show("A descrição não pode estar vazia.");
                return;
            }

            //Fetches the data
            string description = tBoxMealAddDescription.Text;
            DishType dishType = DishType.Meat;

            if (radioMealAddCategoryMeat.Checked)
            {
                dishType = DishType.Meat;   
            }
            else if (radioMealAddCategoryFish.Checked)
            {
                dishType = DishType.Fish;
            }
            else if (radioMealAddCategoryVeggie.Checked)
            {
                dishType = DishType.Veggie;
            }

            DishController dishController = new DishController();
            dishController.AddDish(description, dishType);

            MessageBox.Show("Prato adicionado com sucesso!");
            this.Close();
        }
    }
}
