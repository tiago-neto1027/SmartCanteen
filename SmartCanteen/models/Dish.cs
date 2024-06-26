﻿using System;
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
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public DishType Type { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public Dish()
        {
            Menus = new HashSet<Menu>();
            Reservations = new HashSet<Reservation>();
        }

        public Dish(string description,DishType dishType)
        {
            Description = description;
            Type = dishType;
            Active = true;
        }
    }
}
