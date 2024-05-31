using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Dish
    {
        [Key]
        public string description { get; set; }
        public enum type { meat, fish, veggie }
        public bool active { get; set; }


    public Dish()
    {
    }

    }
}
