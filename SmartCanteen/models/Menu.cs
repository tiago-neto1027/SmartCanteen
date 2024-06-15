using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Menu
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date {  get; set; }
        public int Quantity { get; set; }
        public double StudentPrice { get; set; }
        public double TeacherPrice { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public Menu()
        {
            Dishes = new HashSet<Dish>();
            Extras = new HashSet<Extra>();
        }
    }
}
