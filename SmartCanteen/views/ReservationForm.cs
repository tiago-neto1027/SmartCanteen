using SmartCanteen.controllers;
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
        public ReservationForm()
        {
            InitializeComponent();
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

            if (menu != null)
            {
                UpdateRadioButtons(menu);
            }
            else
            {
                radioReservationMenuMeat.Text = "Sem menu disponível";
                radioReservationMenuFish.Text = "Sem menu disponível";
                radioReservationMenuVeggie.Text = "Sem menu disponível";
            }
        }

        private void UpdateRadioButtons(Menu menu)
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
    }
}
