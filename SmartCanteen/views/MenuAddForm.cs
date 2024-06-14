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
    public partial class MenuAddForm : Form
    {
        public MenuAddForm()
        {
            InitializeComponent();

            LoadDishes();
            LoadExtras();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDishes()
        {
            DishController dishController = new DishController();

            BindComboBox(cBoxMenuAddMeat, dishController.FetchDishesByType(DishType.Meat));
            BindComboBox(cBoxMenuAddFish, dishController.FetchDishesByType(DishType.Fish));
            BindComboBox(cBoxMenuAddVeggie, dishController.FetchDishesByType(DishType.Veggie));
        }

        private void LoadExtras()
        {
            ExtraController extraController = new ExtraController();

            BindComboBox(cBoxMenuAddSoup, extraController.FetchExtrasByType(ExtraType.Soup));
            BindComboBox(cBoxMenuAddDessert, extraController.FetchExtrasByType(ExtraType.Dessert));
        }

        private void BindComboBox(ComboBox comboBox, object dataSource)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "ID";
        }
    }
}
