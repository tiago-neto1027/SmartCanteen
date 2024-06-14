﻿using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
                var staff = new Staff(name, nif, username, password);
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

        public bool LoginStaff(string username, string password)
        {
            using (var db = new SmartCanteenContext())
            {
                var matchingStaff = db.Users
                    .OfType<Staff>()
                    .FirstOrDefault(staff => staff.Username == username && staff.Password == password);

                if (matchingStaff != null)
                {
                    Console.WriteLine($"Staff member found: {matchingStaff.Name}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}