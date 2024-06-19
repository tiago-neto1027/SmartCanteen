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

    public partial class MenuDisplay : Form
    {
        private DateTime date;
        private MealTime mealTime;
        private readonly MenuController menuController;
        private models.Menu selectedMenu = null;

        public MenuDisplay(DateTime date, MealTime mealTime)
        {
            InitializeComponent();
            menuController = new MenuController();
            this.date = date;
            this.mealTime = mealTime;
            ShowSelectedMenu();
        }
        private void ShowSelectedMenu()
        {
            List<Dish> meatDishes = new List<Dish>();
            List<Dish> fishDishes = new List<Dish>();
            List<Dish> veggieDishes = new List<Dish>();

            selectedMenu = menuController.GetMenuByDateTime(date,mealTime);

            dateTimePickerMenuAdd.Value=selectedMenu.Date;
            if (selectedMenu.Time == MealTime.Lunch)
            {
                rBtnLunch.Enabled = true;
            }
            else
            {
                {
                    rBtnDinner.Enabled = false;
                }
            }

            BindComboBox(cBoxMenuAddMeat, LoadMenuDishes(meatDishes, selectedMenu, DishType.Meat));
            BindComboBox(cBoxMenuAddFish, LoadMenuDishes(fishDishes, selectedMenu, DishType.Fish));
            BindComboBox(cBoxMenuAddVeggie, LoadMenuDishes(veggieDishes, selectedMenu, DishType.Veggie));

            updateExtrasList();

            nrQuantity.Value = selectedMenu.Quantity;
            nrPrice.Value = (decimal)selectedMenu.StudentPrice;
        }
        private void BindComboBox(ComboBox comboBox, object dataSource)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "ID";
        }
        private List<Dish> LoadMenuDishes(List<Dish> dishList, models.Menu menu, DishType dishType)
        {
            return dishList = menuController.MenuDishesByType(menu, dishType);
        }
            private void updateExtrasList()
        {
            listBoxAvailableExtras.DataSource = null;
            listBoxAvailableExtras.DataSource = selectedMenu.Extras.ToList();

            listBoxAvailableExtras.DisplayMember = "Description";
            listBoxAvailableExtras.ValueMember = "ID";
        }

        private void btnMenuAddRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MenuEditForm menuEditForm = new MenuEditForm();
            menuEditForm.ShowDialog();
        }

        private void btnLeaveForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
