using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class InvoiceItem
    {
        [Key]
        public int ID { get; set; }
        public string Description {  get; set; }
        public double Price { get; set; }

        public InvoiceItem()
        {

        }
    }
}
