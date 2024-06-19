﻿using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = SmartCanteen.models.Menu;

namespace SmartCanteen
{
    public partial class ReservationForm : Form
    {
        private readonly ClientController clientController = new ClientController();
        private readonly MenuController menuController = new MenuController();

        Menu selectedMenu = new Menu();
        List<Extra> selectedExtras;

        public ReservationForm()
        {
            InitializeComponent();
            selectedExtras = new List<Extra>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservationSearch_Click(object sender, EventArgs e)
        {
            string searchNif = tBoxReservationNif.Text;

            if (!ValidateNif(searchNif))
            {
                return;
            }

            Client client = clientController.SearchClient(searchNif);

            ChangeClientFields(client);
        }

        private void monthCalendarReservation_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendarReservation.SelectionStart.Date;

            labelReservationResultDate.Text = "Data: " + selectedDate.ToString("dd/MM/yyyy");

            SetButtonVisibility(selectedDate);
            ChangeMenus();
        }

        private void btnSelectExtras_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxAvailableExtras.SelectedItem;
                selectedExtras.Add(selectedExtra);
                BindListBox(listBoxSelectedExtras, selectedExtras);

                UpdateExtras(selectedMenu);
            }
        }

        private void btnRemoveExtras_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedExtras.SelectedItem != null)
            {
                Extra selectedExtra = (Extra)listBoxSelectedExtras.SelectedItem;
                selectedExtras.Remove(selectedExtra);
                BindListBox(listBoxSelectedExtras, selectedExtras);

                UpdateExtras(selectedMenu);
            }
        }

        private void rBtnLunch_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMenus();
        }

        private void rBtnDinner_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMenus();
        }
        private void radioReservationMenuMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReservationMenuMeat.Checked)
            {
                labelReservationResultMenu.Text = "Menu: " + radioReservationMenuMeat.Text;
            }
        }

        private void radioReservationMenuFish_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReservationMenuFish.Checked)
            {
                labelReservationResultMenu.Text = "Menu: " + radioReservationMenuFish.Text;
            }
        }

        private void radioReservationMenuVeggie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReservationMenuVeggie.Checked)
            {
                labelReservationResultMenu.Text = "Menu: " + radioReservationMenuVeggie.Text;
            }
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtras(selectedMenu);
        }

        private void rBtnSoup_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtras(selectedMenu);
        }

        private void rBtnDesserts_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtras(selectedMenu);
        }

        private void rBtnDrinks_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtras(selectedMenu);
        }

        private void rBtnOthers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtras(selectedMenu);
        }

        //----------------------------------------------------- Form Functions ------------------------------------------------//

        private bool ValidateNif(string nif)
        {

            if (!int.TryParse(nif, out _))
            {
                MessageBox.Show("O NIF tem de ser um valor numérico");
                return false;
            }
            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("Preencha o campo");
                return false;
            }
            if (nif.Length != 9)
            {
                MessageBox.Show("O NIF tem de ter 9 caracteres");
                return false;
            }

            return true;
        }

        private void ChangeClientFields(Client client)
        {
            labelReservationResultName.Text = "Nome: " + client.Name;
            labelReservationResultNif.Text = "NIF: " + client.NIF;
        }

        private void SetButtonVisibility(DateTime selectedDate)
        {
            if (selectedDate.Date > DateTime.Today)
            {
                rBtnLunch.Visible = true;
                rBtnDinner.Visible = true;
            }
            else
            {
                TimeSpan timeOfDay = selectedDate.TimeOfDay;

                if (timeOfDay < TimeSpan.FromHours(12))
                {
                    rBtnLunch.Visible = true;
                    rBtnDinner.Visible = false;
                }
                else if (timeOfDay < TimeSpan.FromHours(18))
                {
                    rBtnLunch.Visible = false;
                    rBtnDinner.Visible = true;
                }
                else
                {
                    rBtnLunch.Visible = false;
                    rBtnDinner.Visible = false;
                }
            }
        }

        private void ChangeMenus()
        {
            DateTime selectedDate = monthCalendarReservation.SelectionStart.Date;
            MealTime mealTime = MealTime.Dinner;

            if (rBtnLunch.Checked)
            {
                mealTime = MealTime.Lunch;
            }

            Menu menu = menuController.GetMenuByDateTime(selectedDate, mealTime);
            selectedMenu = menu;

            if (menu != null)
            {
                UpdateDishNames(menu);
                UpdateExtras(menu);
            }
            else
            {
                listBoxAvailableExtras.DataSource = null;
                listBoxSelectedExtras.DataSource = null;
                radioReservationMenuMeat.Text = "Sem menu disponível";
                radioReservationMenuFish.Text = "Sem menu disponível";
                radioReservationMenuVeggie.Text = "Sem menu disponível";
            }
        }

        private void UpdateExtras(Menu menu)
        {
            if (menu != null)
            {
                if (menu.Extras != null)
                {
                    List<Extra> availableExtras = new List<Extra>();

                    if (rBtnAll.Checked)
                        availableExtras = menu.Extras.ToList();
                    else if (rBtnSoup.Checked)
                        availableExtras = menu.Extras.Where(e => e.Type == ExtraType.Soup).ToList();
                    else if (rBtnDesserts.Checked)
                        availableExtras = menu.Extras.Where(e => e.Type == ExtraType.Dessert).ToList();
                    else if (rBtnDrinks.Checked)
                        availableExtras = menu.Extras.Where(e => e.Type == ExtraType.Drink).ToList();
                    else if (rBtnOthers.Checked)
                        availableExtras = menu.Extras.Where(e => e.Type == ExtraType.Other).ToList();

                    //Removes the selected extras from the available extras list
                    availableExtras = availableExtras
                        .Where(extra => !selectedExtras.Any(selected => selected.ID == extra.ID))
                        .ToList();

                    BindListBox(listBoxAvailableExtras, availableExtras);
                }
            }
        }

        private void UpdateDishNames(Menu menu)
        {
            foreach (var dish in menu.Dishes)
            {
                if (dish.Type == DishType.Meat)
                {
                    radioReservationMenuMeat.Text = dish.Description;
                }
                else if (dish.Type == DishType.Fish)
                {
                    radioReservationMenuFish.Text = dish.Description;
                }
                else if (dish.Type == DishType.Veggie)
                {
                    radioReservationMenuVeggie.Text = dish.Description;
                }
            }
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
