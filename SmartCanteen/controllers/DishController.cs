using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class DishController
    {
        public DishController() 
        {
        
        }
        public void AddDish(string description, DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                var dish = new Dish(description, dishType);
                db.Dishes.Add(dish);
                db.SaveChanges();
            }
        }

        public List<Dish> ActiveDishesByType(DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Dishes.Where(d => d.Active && d.Type == dishType).ToList();
            }
        }

        //listing for dataGrid
        public List<Dish> GetAllDishes()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Dishes.ToList();
            }
        }

        public void UpdateDish(Dish updatedDish)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingDish = db.Dishes.SingleOrDefault(e => e.ID == updatedDish.ID);

                if (existingDish == null)
                {
                    throw new InvalidOperationException("Prato não encontrado.");
                }

                // properties
                existingDish.Description = updatedDish.Description;
                existingDish.Type = updatedDish.Type;

                db.SaveChanges();
            }
        }
    }
}
