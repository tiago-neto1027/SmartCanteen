using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartCanteen.models
{
    public enum MealTime
    {
        Lunch,
        Dinner
    }
    internal class Menu
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date {  get; set; }
        public int Quantity { get; set; }
        public double StudentPrice { get; set; }
        public double TeacherPrice { get; set; }
        public MealTime Time { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Menu() 
        {
            this.Reservations = new HashSet<Reservation>();
        }
        public Menu(DateTime date, int quantity, double price, List<Dish> dishes, List<Extra> extras, MealTime time)
        {
            Date = date;
            Quantity = quantity;
            StudentPrice = price;
            TeacherPrice = price + 0.6;
            Dishes = dishes;
            Extras = extras;
            Time = time;
        }
        public override string ToString()
        {
            string meatDishes = string.Join(", ", Dishes
                .Where(dish => dish.Type == DishType.Meat)
                .Select(dish => dish.Description));
            if (Time == MealTime.Dinner)
                return $"Menu: {Date.ToString("dd-MM-yyyy")} - Jantar";
            else
                return $"Menu: {Date.ToString("dd-MM-yyyy")} - Almoço";
        }
    }
}
