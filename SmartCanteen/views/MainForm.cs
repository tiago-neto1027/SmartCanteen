using SmartCanteen;
using SmartCanteen.controllers;
using SmartCanteen.models;
using SmartCanteen.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SmartCanteen
{
    public partial class MainForm : Form
    {
        private readonly MenuController menuController;
        private readonly DateTime curData;
        public DateTime weekStart;
        public MainForm()
        {
            curData = DateTime.Now;
            weekStart = GetStartOfWeek(curData);
            menuController = new MenuController();
            InitializeComponent();
            updateWeekInfo();
        }


        // ------------------------------ time date timer ----------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = curData.ToLongDateString();
        }

        // ------------------------------ /time date timer ----------------------------------------


        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm();
            clientAddForm.ShowDialog();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            ClientEditForm clientEditForm = new ClientEditForm();
            clientEditForm.ShowDialog();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm();
            balanceForm.ShowDialog();
        }

        private void btnClientChange_Click(object sender, EventArgs e)
        {
            ClientEditForm clientModifyForm = new ClientEditForm();
            clientModifyForm.ShowDialog();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            MenuAddForm menuAddForm = new MenuAddForm();
            menuAddForm.ShowDialog();
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            MealAddForm mealAddForm = new MealAddForm();
            mealAddForm.ShowDialog();
        }

        private void btnExtrasAdd_Click(object sender, EventArgs e)
        {
            ExtrasAddForm extrasAddForm = new ExtrasAddForm();
            extrasAddForm.ShowDialog();
        }

        private void btnMealRegister_Click(object sender, EventArgs e)
        {
            MealRegisterForm mealRegisterForm = new MealRegisterForm();
            mealRegisterForm.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ExtrasEditForm extrasEditForm = new ExtrasEditForm();
            extrasEditForm.ShowDialog();
        }

        private void btnMealEdit_Click(object sender, EventArgs e)
        {
            MealEditForm mealEditForm = new MealEditForm();
            mealEditForm.ShowDialog();
        }

        private void btnCreateFine_Click(object sender, EventArgs e)
        {
            FineAddForm fineAddForm = new FineAddForm();
            fineAddForm.ShowDialog();
        }

        private void btnEditFine_Click(object sender, EventArgs e)
        {
            FineEditForm fineEditForm = new FineEditForm();
            fineEditForm.ShowDialog();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }
        private void btnMenuEdit_Click(object sender, EventArgs e)
        {
            MenuEditForm menuEditForm = new MenuEditForm();
            menuEditForm.ShowDialog();
        }

        private void btnMondayLunch_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart, MealTime.Lunch);
        }

        private void btnMondayDinner_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart, MealTime.Dinner);
        }

        private void btnThuesdayLunch_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(1), MealTime.Lunch);
        }

        private void btnThuesdayDinner_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(1), MealTime.Dinner);
        }

        private void btnWednesdayLunch_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(2), MealTime.Lunch);
        }

        private void btnWednesdayDinner_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(2), MealTime.Dinner);
        }

        private void btnThursdayLunch_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(3), MealTime.Lunch);
        }

        private void btnThursdayDinner_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(3), MealTime.Dinner);
        }

        private void btnFridayLunch_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(4), MealTime.Lunch);
        }

        private void btnFridayDinner_Click(object sender, EventArgs e)
        {
            OpenMenuDisplayForm(weekStart.AddDays(4), MealTime.Dinner);
        }

        private void OpenMenuDisplayForm(DateTime selectedDate, MealTime selectedMealTime)
        {
            if (menuController == null)
            {
                MessageBox.Show("MenuController is not initialized.");
                return;
            }
            var menu  = menuController.GetMenuByDateTime(selectedDate,selectedMealTime);
            if (menu == null)
            {
                string mealTimeText = selectedMealTime == MealTime.Lunch ? "almoço" : "jantar";
                MessageBox.Show($"Não existe um menu para o {mealTimeText} de dia {selectedDate.ToLongDateString()}");
                return;
            }
            
            MenuDisplay menuDisplay = new MenuDisplay(selectedDate, selectedMealTime);
            menuDisplay.ShowDialog();
        }
        public static DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        public void updateWeekInfo()
        {
            lbWeek.Text = ($"Semana:  { weekStart.ToLongDateString()} a { weekStart.AddDays(4).ToLongDateString()}");
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            weekStart = weekStart.AddDays(7);
            btnPreviousWeek.Enabled = true;
            updateWeekInfo();
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            DateTime newWeekStart = weekStart.AddDays(-7);
            if (newWeekStart <= GetStartOfWeek(curData))
            {
                btnPreviousWeek.Enabled = false;
                return;
            }
            weekStart = newWeekStart;
            updateWeekInfo();
        }
    }
}





