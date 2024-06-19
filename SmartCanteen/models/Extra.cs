using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    public enum ExtraType
    {
        Soup,
        Dessert,
        Drink,
        Other
    }
    internal class Extra
    {
        [Key]
        public int ID { get; set; }
        public string Description {  get; set; }
        public ExtraType Type { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public Extra()
        {
            Menus = new HashSet<Menu>();
            Reservations = new HashSet<Reservation>();
        }

        public Extra(string description, ExtraType extraType, double price)
        {
            Description = description;
            Type = extraType;
            Price = price;
            Active = true;
        }
    }
}
