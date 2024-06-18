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
                Dish dish = new Dish(description, dishType);
                db.Dishes.Add(dish);
                db.SaveChanges();
            }
        }

        public void UpdateDish(Dish updatedDish)
        {
            using (var db = new SmartCanteenContext())
            {
                Dish existingDish = db.Dishes.SingleOrDefault(d => d.ID == updatedDish.ID);

                if (existingDish != null)
                {
                    existingDish.Description = updatedDish.Description;
                    existingDish.Type = updatedDish.Type;
                    existingDish.Active = updatedDish.Active;

                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException($"Dish with ID {existingDish.ID} not found.");
                }
            }
        }

        public void DeleteDish(int dishId)
        {
            using (var db = new SmartCanteenContext())
            {
                Dish dish = db.Dishes.Include("Menus").SingleOrDefault(d => d.ID == dishId);

                if (dish != null)
                {
                    //Deletes the associated menus before deleting the dish
                    foreach (Menu menu in dish.Menus.ToList())
                    {
                        db.Menus.Remove(menu);
                    }

                    db.Dishes.Remove(dish);
                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException($"Dish with ID {dishId} not found.");
                }
            }
        }

        public List<Dish> ActiveDishesByType(DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Dishes.Where(d => d.Active && d.Type == dishType).ToList();
            }
        }

        public List<Dish> GetAllDishes()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Dishes.ToList();
            }
        }
    }
}
