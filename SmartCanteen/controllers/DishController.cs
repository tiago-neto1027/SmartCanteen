﻿using SmartCanteen.models;
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

        public List<Dish> FetchDishes(DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Dishes.Where(d => d.Active && d.Type == dishType).ToList();
            }
        }
    }
}
