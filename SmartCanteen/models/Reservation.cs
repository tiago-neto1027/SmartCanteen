using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    //Even though I didn't completely normalize this table this helps both in performance and in writing code   
    internal class Reservation
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public MealTime MealTime { get; set; }
        public double TotalPrice { get; set; }
        public bool Used { get; set; }
        //Menu
        public int MenuID { get; set; }
        public virtual Menu Menu { get; set; }
        //User
        public int UserID { get; set; }
        public virtual User User { get; set; }
        //Dish
        public int DishID { get; set; }
        public virtual Dish Dish { get; set; }
        //Extra
        public virtual ICollection<Extra> Extras { get; set; }

        public Reservation() { Extras = new HashSet<Extra>(); }

        public Reservation(DateTime date, MealTime mealTime, double totalPrice, int menuId, int clientId, int dishId, List<Extra> extras)
        {
            Date = date;
            MealTime = mealTime;
            TotalPrice = totalPrice;
            MenuID = menuId;
            UserID = clientId;
            DishID = dishId;
            Extras = extras;
            Used = false;
        }

        public override string ToString()
        {
            return "ID Reserva: " + ID + " | NIF: " + User.NIF;
        }
    }
}
