using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class InvoiceItem
    {
        public string description {  get; set; }
        public double price { get; set; }

        public InvoiceItem()
        {

        }
    }
}
