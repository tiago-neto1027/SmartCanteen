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
        public decimal Balance  {  get; set; }

        public Client(string name, string nif,decimal balance) : base(name, nif)
        {
            string Name = name;
            string Nif = nif;
            decimal Balance = balance;
        }

        public Client()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
