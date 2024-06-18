using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Menu() { }
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
    }
}
