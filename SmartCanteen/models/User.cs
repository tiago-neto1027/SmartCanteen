using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    abstract class User
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string NIF { get; set; }

        public User(string name, string nif)
        {
            string Name = name;
            string Nif = nif;
        }
    }
}
