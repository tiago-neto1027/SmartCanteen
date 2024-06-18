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
        public void AddStudent(string name, string nif, decimal balance, string studentID)
        {
            using (var db = new SmartCanteenContext())
            {
                var student = new Student(name, nif, balance, studentID);
                db.Users.Add(student);
                db.SaveChanges();
            }
        }

        public static bool ModifClient(string oldNIF, string name, string nif, string extra)
        {
            using (var db = new SmartCanteenContext())
            {
                var client = db.Users.OfType<Client>().FirstOrDefault(c => c.NIF == oldNIF);
                if (client == null)
                {
                    return false;
                }

                client.Name = name;
                client.NIF = nif;

                if (client is Professor professor)
                {
                    professor.Email = extra;
                }
                else if (client is Student student)
                {
                    student.StudentID = extra;
                }
                db.SaveChanges();
                return true;
            }
        }

        public static List<Client> GetAllClients()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Users.OfType<Client>().ToList();
            }
        }

        public static bool DeleteClient(string nif)
        {
            using (var db = new SmartCanteenContext())
            {
                var customer = db.Users.OfType<Client>().FirstOrDefault(c => c.NIF == nif);
                if (customer == null)
                {
                    return false;
                }

                db.Users.Remove(customer);
                db.SaveChanges();
                return true;
            }
        }

        public static bool UpdateClientBalance(string nif, decimal addedValue)
        {
            using (var db = new SmartCanteenContext())
            {
                var customer = db.Users.OfType<Client>().FirstOrDefault(c => c.NIF == nif);
                if (customer == null)
                {
                    return false;
                }
            }
        }
        
        public static Client SearchClient(string nif)
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
