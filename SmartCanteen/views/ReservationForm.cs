using SmartCanteen.controllers;
using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
        private readonly ReservationController reservationController = new ReservationController();

        Client selectedClient = null;
        Menu selectedMenu = null;
        Dish selectedDish = null;
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

            selectedClient = clientController.SearchClient(searchNif);

            if (selectedClient != null)
                ChangeClientFields(selectedClient);
            else
                MessageBox.Show("O NIF que escreveu não está associado a um cliente.");

            if (selectedClient != null && selectedMenu != null && monthCalendarReservation.SelectionStart != DateTime.MinValue)
            {
                labelReservationResultPrice.Text = "Price: " + CalculatePrice().ToString() + "€";
            }
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

                if (selectedClient != null && selectedMenu != null && monthCalendarReservation.SelectionStart != DateTime.MinValue)
                {
                    labelReservationResultPrice.Text = "Price: " + CalculatePrice().ToString() + "€";
                }
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

                if (selectedClient != null && selectedMenu != null && monthCalendarReservation.SelectionStart != DateTime.MinValue)
                {
                    labelReservationResultPrice.Text = "Price: " + CalculatePrice().ToString() + "€";
                }
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
                selectedDish = (Dish)radioReservationMenuMeat.Tag;
            }
        }

        private void radioReservationMenuFish_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReservationMenuFish.Checked)
            {
                labelReservationResultMenu.Text = "Menu: " + radioReservationMenuFish.Text;
                selectedDish = (Dish)radioReservationMenuFish.Tag;
            }
        }

        private void radioReservationMenuVeggie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReservationMenuVeggie.Checked)
            {
                labelReservationResultMenu.Text = "Menu: " + radioReservationMenuVeggie.Text;
                selectedDish = (Dish)radioReservationMenuVeggie.Tag;
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

        private void btnReservationRegister_Click(object sender, EventArgs e)
        {
            if (selectedClient == null || selectedMenu == null || selectedDish == null || monthCalendarReservation.SelectionStart == DateTime.MinValue)
            {
                MessageBox.Show("Por favor selecione todos os campos.");
                return;
            }
            DateTime date = monthCalendarReservation.SelectionStart;
            MealTime mealTime = MealTime.Dinner;

            if (rBtnLunch.Checked)
                mealTime = MealTime.Lunch;

            double totalPrice = CalculatePrice();

            int menuID = selectedMenu.ID;
            int clientID = selectedClient.ID;
            int dishID = selectedDish.ID;

            if(selectedExtras.Count > 3)
            {
                MessageBox.Show("Pode escolher no máximo 3 extras");
                return;
            }
            List<int> extraIds = selectedExtras.Select(extra => extra.ID).ToList();

            if (reservationController.ReservationAdd(date, mealTime, totalPrice, menuID, clientID, dishID, extraIds))
            {
                MessageBox.Show("Reserva adicionada com sucesso.");

                BuildTxt();

                this.Close();
            }
            else
                MessageBox.Show("O menu que escolheu está esgotado.");
        }

        //----------------------------------------------------- Form Functions ------------------------------------------------//

        private void BuildTxt()
        {
            StringBuilder reservationDetails = new StringBuilder();

            reservationDetails.AppendLine("Detalhes da Reserva:");
            reservationDetails.AppendLine("--------------------");
            reservationDetails.AppendLine($"Nome do Cliente: {selectedClient.Name}");
            reservationDetails.AppendLine($"NIF: {selectedClient.NIF}");
            reservationDetails.AppendLine($"Data: {monthCalendarReservation.SelectionStart.ToString("dd/MM/yyyy")}");
            reservationDetails.AppendLine($"Refeição: {(rBtnLunch.Checked ? "Almoço" : "Jantar")}");
            reservationDetails.AppendLine($"Menu: {selectedDish.Description}");
            reservationDetails.AppendLine("Extras:");
            foreach (var extra in selectedExtras)
            {
                reservationDetails.AppendLine($"- {extra.Description}");
            }
            reservationDetails.AppendLine($"Preço Total: {CalculatePrice()}€");

            string fileName = Path.Combine(Path.GetTempPath(), $"Reserva_{selectedClient.NIF}_{DateTime.Now:yyyyMMddHHmmss}.txt");
            File.WriteAllText(fileName, reservationDetails.ToString());

            MessageBox.Show($"Os detalhes da reserva foram salvos em {fileName}");
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

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
                    rBtnDinner.Visible = true;
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
                if(selectedClient != null && selectedMenu != null && monthCalendarReservation.SelectionStart != DateTime.MinValue)
                {
                    labelReservationResultPrice.Text = "Price: " + CalculatePrice().ToString() + "€";
                }
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
                    BindListBox(listBoxSelectedExtras, selectedExtras);
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
                    radioReservationMenuMeat.Tag = dish;
                }
                else if (dish.Type == DishType.Fish)
                {
                    radioReservationMenuFish.Text = dish.Description;
                    radioReservationMenuFish.Tag = dish;
                }
                else if (dish.Type == DishType.Veggie)
                {
                    radioReservationMenuVeggie.Text = dish.Description;
                    radioReservationMenuVeggie.Tag = dish;
                }
            }
        }

        private double CalculatePrice()
        {
            double price = 0;

            if(selectedClient is Student)
            {
                price += selectedMenu.StudentPrice;
            }
            else if(selectedClient is Professor)
            {
                price += selectedMenu.TeacherPrice;
            }

            double fineValue = CalculateFine();
            price += fineValue;

            foreach (Extra extra in selectedExtras)
            {
                price += extra.Price;
            }

            return price;
        }

        private double CalculateFine()
        {
            DateTime now = DateTime.Now;
            int mealTime;
            if (selectedMenu.Time == MealTime.Lunch)
            {
                mealTime = 12;
            }
            else
            {
                mealTime = 19;
            }

            int hoursRemaining = mealTime - now.Hour;

            if (hoursRemaining <= 0)
            {
                return 0;
            }

            using (var db = new SmartCanteenContext())
            {
                var fine = db.Fines
                    .Where(f => f.NumHours >= hoursRemaining)
                    .OrderBy(f => f.NumHours)
                    .FirstOrDefault();

                if (fine != null)
                {
                    return fine.Value;
                }
                else
                {
                    return 0;
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
