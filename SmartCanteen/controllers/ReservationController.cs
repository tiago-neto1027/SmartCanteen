using SmartCanteen.models;
using System;
using System.Collections.Generic;
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

                Reservation reservation = new Reservation(date, mealTime, totalPrice, menuID, clientID, dishID, extras);
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
            return true;
        }
    }
}
