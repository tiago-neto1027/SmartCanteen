using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class MenuController
    {
        public MenuController() { }

        public void AddMenu(DateTime date, int quantity, double price, List<Dish> dishes, List<Extra> extras, MealTime time)
        {
            using (var db = new SmartCanteenContext())
            {
                Menu menu = new Menu(date, quantity, price, dishes, extras, time);
                db.Menus.Add(menu);
                db.SaveChanges();
            }
        }
    }
}
