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
    public partial class MenuEditForm : Form
    {
        private readonly MenuController menuController = new MenuController();
        private readonly DishController dishController = new DishController();
        private readonly ExtraController extraController = new ExtraController();

        private List<Extra> selectedExtras;
        private models.Menu selectedMenu = null;
       
        public MenuEditForm()
        {
            InitializeComponent();
            selectedExtras = new List<Extra>();
            LoadExistingMenus();
            LoadExtras();
        }

        private void lExistingMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lExistingMenus.SelectedIndex;
            if (index == -1)
            {
                selectedMenu = null;
                return;
            }

            selectedMenu = (models.Menu)lExistingMenus.SelectedItem;
            selectedExtras.Clear();
            selectedExtras = selectedMenu.Extras.ToList();
            
            LoadSelectedMenu();
            LoadExtras();
        }

        private void btnSelectExtras_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxAvailableExtras.SelectedItem;
                selectedExtras.Add(selectedExtra);
                updateAddedExtras();

                LoadSelectedMenu();
                LoadExtras();
            }
        }

        private void btnRemoveExtras_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxSelectedExtras.SelectedItem;
                selectedExtras.Remove(selectedExtra);

                updateAvailableExtras(selectedExtras);

                LoadSelectedMenu();
                LoadExtras();
            }
        }
        private void btnMenuEdit_Click(object sender, EventArgs e)
        {
            int id = selectedMenu.ID;
            DateTime date = dateTimePickerMenuAdd.Value;
            MealTime time;
            if (rBtnDinner.Checked)
                time = MealTime.Dinner;
            else
                time = MealTime.Lunch;

            var searchMenu = menuController.GetMenuByDateTime(date, time);
            if (searchMenu != null)
            {
                MessageBox.Show("Já existe um menu criado para esta data / refeição");
                return;
            }
            if (date == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Por favor, selecione uma data válida.");
                return;
            }

            int quantity = (int)nrQuantity.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.");
                return;
            }

            double price = (double)nrPrice.Value;
            if (price <= 0)
            {
                MessageBox.Show("Por favor, insira um preço válido.");
                return;
            }

            if (cBoxMenuAddMeat.SelectedItem == null || cBoxMenuAddFish.SelectedItem == null || cBoxMenuAddVeggie.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione pelo menos um prato de cada tipo.");
                return;
            }
            List<int> dishIds = new List<int>
            {
                ((Dish)cBoxMenuAddMeat.SelectedItem).ID,
                ((Dish)cBoxMenuAddFish.SelectedItem).ID,
                ((Dish)cBoxMenuAddVeggie.SelectedItem).ID
            };

            if (selectedExtras.Count == 0)
            {
                MessageBox.Show("Por favor, selecione pelo menos um extra.");
                return;
            }
            List<int> extraIds = selectedExtras.Select(extra => extra.ID).ToList();

           
            menuController.EditMenu(id, date, quantity, price, dishIds, extraIds, time);

            MessageBox.Show("Menu editado com sucesso");

            LoadExistingMenus();

        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenu == null)
            {
                MessageBox.Show("Selecione um menu primeiro");
                return;
            }
            menuController.DeleteMenu(selectedMenu.ID);
            LoadExistingMenus();
            MessageBox.Show("Menu eliminado com sucesso");
        }

        private void btnLeaveForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // All the radio button changed events.
        // Coupling the events in this case would be more complex than simply updating them all 1 by 1
        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtras();
        }
        private void rBtnSoup_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtras();
        }
        private void rBtnDesserts_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtras();
        }
        private void rBtnDrinks_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtras();
        }
        private void rBtnOthers_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtras();
        }

        //---------------------------- Form Functions -----------------------------//
        private void LoadExistingMenus()
        {
            lExistingMenus.DataSource = menuController.SearchExistingMenus();
        }
        private void LoadSelectedMenu()
        {
            // -----------Load Menu Dishes-----------//
            List<Dish> meatDishes = new List<Dish>();
            List<Dish> fishDishes = new List<Dish>();
            List<Dish> veggieDishes = new List<Dish>();

            BindComboBox(cBoxMenuAddMeat, LoadMenuDishes(meatDishes, selectedMenu, DishType.Meat));
            BindComboBox(cBoxMenuAddFish, LoadMenuDishes(fishDishes, selectedMenu, DishType.Fish));
            BindComboBox(cBoxMenuAddVeggie, LoadMenuDishes(veggieDishes, selectedMenu, DishType.Veggie));

            //LoadDishes();
            if (selectedMenu == null)
                return;

            if (selectedMenu.Time == MealTime.Lunch)
            {
                rBtnLunch.Checked = true;
                rBtnDinner.Checked = false;
            }
            else if (selectedMenu.Time == MealTime.Dinner)
            {
                rBtnLunch.Checked = false;
                rBtnDinner.Checked = true;
            }
            updateAddedExtras();
            dateTimePickerMenuAdd.Value = selectedMenu.Date;            
            nrQuantity.Value = selectedMenu.Quantity;
            nrPrice.Value = (decimal)selectedMenu.StudentPrice;
            LoadExtras();
        }

        private List<Dish> LoadMenuDishes(List<Dish> dishList, models.Menu menu, DishType dishType)
        {
            dishList = menuController.MenuDishesByType(menu, dishType);
            dishList.AddRange(dishController.ActiveDishesByType(dishType));
            // Remove duplicates based on dish ID
            return dishList = dishList
            .GroupBy(dish => dish.ID)
                .Select(group => group.First())
                .ToList();
        }

        private void LoadExtras()
        {
            List<Extra> availableExtras;

            if (rBtnAll.Checked)
                availableExtras = extraController.ActiveExtras();
            else if (rBtnSoup.Checked)
                availableExtras = extraController.ActiveExtrasByType(ExtraType.Soup);
            else if (rBtnDesserts.Checked)
                availableExtras = extraController.ActiveExtrasByType(ExtraType.Dessert);
            else if (rBtnDrinks.Checked)
                availableExtras = extraController.ActiveExtrasByType(ExtraType.Drink);
            else if (rBtnOthers.Checked)
                availableExtras = extraController.ActiveExtrasByType(ExtraType.Other);
            else
                availableExtras = new List<Extra>();

            //Removes the selected extras from the available extras list
            availableExtras = availableExtras
                .Where(extra => !selectedExtras.Any(selected => selected.ID == extra.ID))
                .ToList();

            updateAvailableExtras(availableExtras);
        }

        private void BindComboBox(ComboBox comboBox, object dataSource)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "ID";
        }
        
        private void updateAvailableExtras(object dataSource)
        {
            listBoxAvailableExtras.DataSource = null;
            listBoxAvailableExtras.DataSource = dataSource;

            listBoxAvailableExtras.DisplayMember = "Description";
            listBoxAvailableExtras.ValueMember = "ID";
        }

        private void updateAddedExtras()
        {
            listBoxSelectedExtras.DataSource = null;
            listBoxSelectedExtras.DataSource = selectedExtras;
            
            listBoxSelectedExtras.DisplayMember = "Description";
            listBoxSelectedExtras.ValueMember = "ID";
        }
    }
}
