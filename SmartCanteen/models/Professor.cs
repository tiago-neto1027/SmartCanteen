using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Professor : Client
    {
        public string Email { get; set; }
        public Professor(string name, string nif, decimal balance, string email) : base(name, nif,balance)
        {
             Name = name;
             NIF = nif;
             Balance = balance;
             Email = email;
        }

        public Professor()
        {

        }

        public override string ToString()
        {
            return "Professor: " + Name + " - " + Email;
        }
    }
}
