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

        public void AddMenu(DateTime date, int quantity, double price, List<int> dishIds, List<int> extraIds, MealTime time)
        {
            using (var db = new SmartCanteenContext())
            {
                List<Dish> dishes = db.Dishes.Where(d => dishIds.Contains(d.ID)).ToList();
                List<Extra> extras = db.Extras.Where(e => extraIds.Contains(e.ID)).ToList();

                Menu menu = new Menu(date, quantity, price, dishes, extras, time);
                db.Menus.Add(menu);
                db.SaveChanges();
            }
        }
    }
}
