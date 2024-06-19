using SmartCanteen.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCanteen.models;

namespace SmartCanteen
{
    public partial class MealRegisterForm : Form
    {
        private readonly ReservationController reservationController = new ReservationController();
        public MealRegisterForm()
        {
            InitializeComponent();

            LoadReservations();
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            string searchNif = tBoxClientSearchNif.Text;
            if (!ValidateNIF(searchNif))
            {
                return;
            }

            Reservation reservation = reservationController.GetReservationsToUseByNif(searchNif);
            if(reservation == null)
            {
                MessageBox.Show("Nenhuma reserva encontrada.");
                return;
            }

            listBoxReservations.DataSource = null;
            listBoxReservations.Items.Clear();
            listBoxReservations.Items.Add(reservation);
            listBoxReservations.SelectedItem = reservation;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void listBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation reservation = (Reservation)listBoxReservations.SelectedItem;

            if(reservation != null && reservation.User is Client client)
            {
                //Client
                labelClientName.Text = "Nome: " + client.Name;
                labelClientNif.Text = "NIF: " + client.NIF;
                labelClientCurrent.Text = "Saldo: " + client.Balance;
                if (client is Student)
                    labelClientType.Text = "Tipo: Aluno";
                else
                    labelClientType.Text = "Tipo: Professor";

                //Menu
                textBoxDish.Text = reservation.Dish.Description;
                textBoxPrice.Text = reservation.TotalPrice.ToString();
                textBoxExtras.Text = string.Join(Environment.NewLine, reservation.Extras.Select(extra => extra.Description));
                if (reservation.MealTime == MealTime.Lunch)
                    textBoxMealTime.Text = "Almoço";
                else
                    textBoxMealTime.Text = "Jantar";
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Reservation reservation = (Reservation)listBoxReservations.SelectedItem;

            if (reservationController.CheckInReservation(reservation))
            {
                MessageBox.Show("Reserva marcada com sucesso.");
                LoadReservations();
            }
            else
            {
                MessageBox.Show("Não foi possível marcar a reserva, por favor, tente novamente.");
            }

        }

        //--------------------------------------------- Form Functions -----------------------------------------------//
        public void LoadReservations()
        {
            List<Reservation> reservations = reservationController.GetReservationsToUse();

            if(reservations.Count == 0)
            {
                listBoxReservations.DataSource = null;
                listBoxReservations.Items.Clear();
                listBoxReservations.Items.Add("Ainda não foram registadas reservas.");
                return;
            }
            listBoxReservations.DataSource = null;
            listBoxReservations.DataSource = reservations;
        }

        private bool ValidateNIF(string nif)
        {
            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("Preencha o campo");
                return false;
            }

            if (!int.TryParse(nif, out _))
            {
                MessageBox.Show("O NIF tem de ser um valor numérico");
                return false;
            }

            if (nif.Length != 9)
            {
                MessageBox.Show("O NIF tem de ter 9 caracteres");
                return false;
            }

            return true;
        }
    }
}
