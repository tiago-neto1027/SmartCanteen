using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Staff : User
    {
        public string Username {  get; set; }
        public string Password { get; set; }

        public Staff(string name, string nif, string username, string password) : base(name, nif)
        {
             Name = name;
             NIF = nif;
             Username = username;
             Password = password;
        }

        public Staff()
        {
        }
    }
}
