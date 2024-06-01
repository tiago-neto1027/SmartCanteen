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
        public int ID { get; set; }
        public DateTime Date {  get; set; }
        public int Quantity { get; set; }
        public double StudentPrice { get; set; }
        public double TeacherPrice { get; set; }

        public Menu()
        {

        }
    }
}
