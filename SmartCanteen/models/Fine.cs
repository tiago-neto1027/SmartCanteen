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
        public int NumHours {  get; set; }
        public double Value { get; set; }

        public Fine()
        {
            
        }

        public Fine(int numHours, double value)
        {
            NumHours = numHours;
            Value = value;
        }
    }
}
