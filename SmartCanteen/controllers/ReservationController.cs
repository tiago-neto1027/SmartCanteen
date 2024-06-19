using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class ReservationController
    {
        public ReservationController() { }

        public bool ReservationAdd(DateTime date, MealTime mealTime, 
            double totalPrice, int menuID, int clientID, int dishID, List<int> extraIds)
        {
            using (var db = new SmartCanteenContext())
            {
                List<Extra> extras = db.Extras.Where(e => extraIds.Contains(e.ID)).ToList();

                //Remove the quantity
                Menu menu = db.Menus.SingleOrDefault(m => m.ID == menuID);
                if(menu.Quantity > 0)
                {
                    menu.Quantity = menu.Quantity - 1;
                }
                else
                {
                    return false;
                }

                //Deduct the balance
                User user = db.Users.SingleOrDefault(u => u.ID == clientID);
                if(user != null && user is Client client)
                {
                    client.Balance -= (decimal)totalPrice;
                }
                else
                {
                    return false;
                }

                Reservation reservation = new Reservation(date, mealTime, totalPrice, menuID, clientID, dishID, extras);
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
            return true;
        }

        public List<Reservation> GetReservationsToUse()
        {
            using (var db = new SmartCanteenContext())
            {
                List<Reservation> reservations  = 
                    db.Reservations.Where(
                        r => r.Used == false && 
                        r.Date == DateTime.Today)
                    .Include(r => r.User)
                    .Include(r => r.Dish)
                    .Include(r => r.Menu)
                    .Include(r => r.Extras)
                    .ToList();

                return reservations;
            }
        }

        public Reservation GetReservationsToUseByNif(string NIF)
        {
            using (var db = new SmartCanteenContext())
            {
                Reservation reservation =
                    db.Reservations
                    .Include(r => r.User)
                    .Include(r => r.Dish)
                    .Include(r => r.Menu)
                    .Include(r => r.Extras)
                    .FirstOrDefault(
                        r => r.Used == false &&
                        r.Date == DateTime.Today &&
                        r.User.NIF == NIF);

                return reservation;
            }
        }

        public bool CheckInReservation(Reservation reservation)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingReservation = db.Reservations.SingleOrDefault(r => r.ID == reservation.ID);

                if (existingReservation != null)
                {
                    if (existingReservation.Used == true)
                        return false;

                    existingReservation.Used = true;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
