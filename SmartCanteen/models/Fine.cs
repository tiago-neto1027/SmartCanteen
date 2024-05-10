using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Fine
    {
        public float numHours {  get; set; }
        public double Value {
            get
            {
                double value;
                value = numHours * 0.8;
                return value;
            }
        }

        public Fine()
        {
            
        }
    }
}
