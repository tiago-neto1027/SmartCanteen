using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                var staff = new Staff(name, nif,username, password);
                db.Users.Add(staff);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidCastException("TODO: Error");
                    
                }
            }
        }

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
       
    }
}
