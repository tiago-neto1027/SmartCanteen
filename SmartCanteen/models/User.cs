using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    abstract class User
    {
        [Key]
        public int ID {  get; set; }
        public string Name { get; set; }
        public string NIF { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public User(string name, string nif)
        {
            string Name = name;
            string Nif = nif;
        }

        public User()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    }
}
