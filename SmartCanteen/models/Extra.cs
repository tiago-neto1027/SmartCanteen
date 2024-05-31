using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Extra
    {
        [Key]
        public string description {  get; set; }
        public double price { get; set; }
        public bool active { get; set; }

        public Extra()
        {

        }
    }
}
