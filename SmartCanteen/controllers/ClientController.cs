using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class ClientController
    {
        public ClientController() { }

        public void AddProfessor(string name, string nif, decimal balance, string email)
        {
            using (var db = new SmartCanteenContext())
            {
                var professor = new Professor(name, nif, balance, email);
                db.Users.Add(professor);
                db.SaveChanges();
            }
        }


        public void AddStudent(string name, string nif, decimal balance, string studentID)
        {
            using (var db = new SmartCanteenContext())
            {
                var student = new Student(name, nif, balance, studentID);
                db.Users.Add(student);
                db.SaveChanges();
            }
        }

        public List<Client> GetAllClients()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Users.OfType<Client>().ToList();
            }
        }

        public bool UpdateClientBalance(string nif, decimal addedValue)
        {
            using (var db = new SmartCanteenContext())
            {
                var customer = db.Users.OfType<Client>().FirstOrDefault(c => c.NIF == nif);
                if (customer == null)
                {
                    return false;
                }

                customer.Balance += addedValue;

                db.SaveChanges();
                return true;
            }
        }

        public Client SearchClient(string nif)
        {
            using (var db = new SmartCanteenContext())
            {
                var customer = db.Users.OfType<Client>().FirstOrDefault(c => c.NIF == nif);
                if (customer != null)
                    return customer;
                else
                    return null;
            }
        }
    }
}
