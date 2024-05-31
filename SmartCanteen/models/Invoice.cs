using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Invoice
    {
        [Key]
        public double total {  get; set; }
        public DateTime date { get; set; }

        public Invoice()
        {

        }
    }
}
