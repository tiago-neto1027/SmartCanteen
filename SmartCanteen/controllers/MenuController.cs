using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = SmartCanteen.models.Menu;

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

        public Menu GetMenuByDateTime(DateTime selectedDate, MealTime mealTime)
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Menus
                    .Include("Dishes")
                    .Include("Extras")
                    .FirstOrDefault(m => DbFunctions.TruncateTime(m.Date) == selectedDate.Date && m.Time == mealTime);
            }
        }
        
        public bool EditMenu(int id, DateTime date, int quantity, double price, List<int> dishIds, List<int> extraIds, MealTime time)
        {

            using (var db = new SmartCanteenContext())
            {
                var menu = db.Menus.Include(m => m.Dishes).Include(m => m.Extras).FirstOrDefault(c => c.ID == id);
                if (menu == null)
                {
                    return false;
                }
                if (menu.Dishes == null)
                {
                    menu.Dishes = new List<Dish>();
                }
                if (menu.Extras == null)
                {
                    menu.Extras = new List<Extra>();
                }
                menu.Dishes.Clear();
                menu.Extras.Clear();

                List<Dish> dishes = db.Dishes.Where(d => dishIds.Contains(d.ID)).ToList();
                List<Extra> extras = db.Extras.Where(e => extraIds.Contains(e.ID)).ToList();

                menu.Date = date;
                menu.Quantity = quantity;
                menu.StudentPrice = price;
                menu.TeacherPrice = price + 0.6;
                menu.Time = time;

                foreach (var dish in dishes)
                {
                    menu.Dishes.Add(dish);
                }
                foreach (var extra in extras)
                {
                    menu.Extras.Add(extra);
                }

                db.SaveChanges();
                return true;

            }
        }
        public bool DeleteMenu(int id)
        {
            using (var db = new SmartCanteenContext())
            {
                Menu menu = db.Menus.OfType<Menu>().FirstOrDefault(c => c.ID == id);

                    if (menu == null)
                    {
                        return false;
                    }

                db.Menus.Remove(menu);
                db.SaveChanges();
                return true;
            }
        }
        public List<Menu> SearchExistingMenus()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Menus.Include(m => m.Extras).Include(n => n.Dishes).OfType<Menu>().ToList();
            }
        }
        public List<Dish> MenuDishesByType(Menu menu, DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                // Retrieve the menu including its related dishes
                var menuWithDishes = db.Menus
                    .Include(m => m.Dishes)
                    .FirstOrDefault(m => m.ID == menu.ID);

                // Check if the menu is found
                if (menuWithDishes != null)
                {
                    // Filter the dishes by the specified type
                    return menuWithDishes.Dishes
                        .Where(dish => dish.Type == dishType)
                        .ToList();
                }
                return new List<Dish>();
            }
        }

    }
}
