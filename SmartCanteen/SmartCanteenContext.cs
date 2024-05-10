using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen
{
    internal class SmartCanteenContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staff{ get; set; }    
        public DbSet<Client> Client { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Fine> Fine { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoicesItem { get; set; }
    }
}
