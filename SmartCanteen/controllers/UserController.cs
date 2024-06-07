using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class UserController
    {
        public UserController()
        {

        }
        
        public void AddStaff(string name, string nif, string username, string password)
        {
            using (var db = new SmartCanteenContext())
            {
                var staff = new Staff(name, nif,username,password);
                db.Users.Add(staff);
                db.SaveChanges();
            }
        }
        /*
        public void AddProfessor(string description, DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                var dish = new Dish(description, dishType);
                db.Users.Add(dish);
                db.SaveChanges();
            }
        }

        public void AddStudent(string description, DishType dishType)
        {
            using (var db = new SmartCanteenContext())
            {
                var dish = new Dish(description, dishType);
                db.Dishes.Add(dish);
                db.SaveChanges();
            }
        }*/
    }
}
