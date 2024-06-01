using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    public enum DishType
    {
        Meat,
        Fish,
        Veggie
    }
    internal class Dish
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DishType Type { get; set; }
        public bool Active { get; set; }


        public Dish(string description,DishType dishType)
        {
            Description = description;
            Type = dishType;
            Active = true;
        }
    }
}
