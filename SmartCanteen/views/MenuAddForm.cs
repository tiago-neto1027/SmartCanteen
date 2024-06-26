﻿using SmartCanteen.controllers;
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
        private readonly MenuController menuController;
        private readonly ExtraController extraController;
        private List<Extra> selectedExtras;
        public MenuAddForm()
        {
            menuController = new MenuController();
            extraController = new ExtraController();
            InitializeComponent();
            selectedExtras = new List<Extra>();

            LoadDishes();
            LoadExtras();
        }

        private void btnLeaveForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectExtras_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxAvailableExtras.SelectedItem;
                selectedExtras.Add(selectedExtra);
                BindListBox(listBoxSelectedExtras, selectedExtras);

                LoadExtras();
            }
        }

        private void btnRemoveExtras_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxSelectedExtras.SelectedItem;
                selectedExtras.Remove(selectedExtra);
                BindListBox(listBoxSelectedExtras, selectedExtras);

                LoadExtras();
            }
        }

        private void btnMenuAddRegister_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerMenuAdd.Value;
            MealTime time;
            if (rBtnDinner.Checked)
                time = MealTime.Dinner;
            else
                time = MealTime.Lunch;
            if (date == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Por favor, selecione uma data válida.");
                return;
            }
            var searchMenu = menuController.GetMenuByDateTime(date,time);
            if (searchMenu != null)
            {
                MessageBox.Show("Já existe um menu criado para esta data / refeição");
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

            
            

            menuController.AddMenu(date, quantity, price, dishIds, extraIds, time);

            MessageBox.Show("Menu adicionado com sucesso!");
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

        private void LoadDishes()
        {
            DishController dishController = new DishController();

            BindComboBox(cBoxMenuAddMeat, dishController.ActiveDishesByType(DishType.Meat));
            BindComboBox(cBoxMenuAddFish, dishController.ActiveDishesByType(DishType.Fish));
            BindComboBox(cBoxMenuAddVeggie, dishController.ActiveDishesByType(DishType.Veggie));
        }

        private void LoadExtras()
        {
            ExtraController extraController = new ExtraController();
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

            BindListBox(listBoxAvailableExtras, availableExtras);
        }

        private void BindComboBox(ComboBox comboBox, object dataSource)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "ID";
        }

        private void BindListBox(ListBox listBox, object dataSource)
        {
            listBox.DataSource = null;
            listBox.DataSource = dataSource;
            listBox.DisplayMember = "Description";
            listBox.ValueMember = "ID";
        }
    }
}
