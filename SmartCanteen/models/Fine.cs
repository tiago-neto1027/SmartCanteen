using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Fine
    {
        [Key]
        public int ID { get; set; }
        public float NumHours {  get; set; }
        public double Value {
            get
            {
                double value;
                value = NumHours * 0.8;
                return value;
            }
        }

        public Fine()
        {
            
        }
    }
}
