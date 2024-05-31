using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    abstract class Client : User
    {
        public float balance  {  get; set; }
    
        public Client()
        {

        }
    }

}
