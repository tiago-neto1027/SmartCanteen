using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen.controllers
{
    internal class UserController
    {
        public UserController()
        {
        }

        public void AddStaff(string name, string nif, string username, string password)
        {
            using (var db = new SmartCanteenContext())
            {
                var staff = new Staff(name, nif, username, password);
                db.Users.Add(staff);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidCastException("TODO: " + ex.Message);
                }
            }
        }

        public bool LoginStaff(string username, string password)
        {
            using (var db = new SmartCanteenContext())
            {
                var matchingStaff = db.Users
                    .OfType<Staff>()
                    .FirstOrDefault(staff => staff.Username == username && staff.Password == password);

                if (matchingStaff != null)
                {
                    Console.WriteLine($"User encontrado: {matchingStaff.Name}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Staff> GetAllStaff()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Users.OfType<Staff>().ToList();
            }
        }

        public void UpdateUser(Staff updatedUser)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingUser = db.Users.OfType<Staff>().SingleOrDefault(e => e.ID == updatedUser.ID);

                if (existingUser != null)
                {
                    existingUser.Name = updatedUser.Name;
                    existingUser.Username = updatedUser.Username;
                    existingUser.NIF = updatedUser.NIF;
                    existingUser.Password = updatedUser.Password;

                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("User não encontrado.");
                }
            }
        }

        public void DeleteUser(int userId)
        {
            using (var db = new SmartCanteenContext())
            {
                var user = db.Users.OfType<Staff>().SingleOrDefault(e => e.ID == userId);

                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("User não encontrado.");
                }
            }
        }
    }
}
