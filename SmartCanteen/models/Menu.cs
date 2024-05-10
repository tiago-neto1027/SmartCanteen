using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Menu
    {
        public DateTime date {  get; set; }
        public int quantity { get; set; }
        public double studentPrice { get; set; }  
        public double teacherPrice {  get; set; }

        public Menu()
        {

        }
    }
}
