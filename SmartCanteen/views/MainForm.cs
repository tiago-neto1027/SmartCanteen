using SmartCanteen;
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
using SmartCanteen.views;

namespace SmartCanteen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // ------------------------------ time date timer ----------------------------------------
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        // ------------------------------ /time date timer ----------------------------------------


        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm();
            clientAddForm.ShowDialog();
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

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            ClientEditForm clientModifyForm = new ClientEditForm();
            clientModifyForm.ShowDialog();
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
    }
}





