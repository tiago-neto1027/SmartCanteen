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
    public partial class ExtrasAddForm : Form
    {
        public ExtrasAddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the btnExtrasAddRegister button.
        /// Gathers the description and the price from the text box and determines the
        /// selected extra type from the radio buttons. Then, it creates an instance of
        /// DishController to add a new dish with the provided description and dish type 
        /// to the database. Displays a message box indicating the success or failure 
        /// of the operation. Closes the current form after the operation is completed.
        /// </summary>
        private void btnExtrasAddRegister_Click(object sender, EventArgs e)
        {
            string description = tBoxExtrasAddDescription.Text;
            ExtraType extraType = new ExtraType();
            double price = (double)numericExtrasAddStudentPrice.Value;

            if (radioExtrasAddTypeSoup.Checked)
            {
                extraType = ExtraType.Soup;
            }
            else if (radioExtrasAddTypeDessert.Checked)
            {
                extraType = ExtraType.Dessert;
            }
            else if (radioExtrasAddTypeBeverage.Checked)
            {
                extraType = ExtraType.Drink;
            }
            else if (radioExtrasAddTypeOther.Checked)
            {
                extraType = ExtraType.Other;
            }

            ExtraController extraController = new ExtraController();
            extraController.AddExtra(description, extraType, price);

            MessageBox.Show("Extra adicionado com sucesso!");
            this.Close();
        }
    }
}
