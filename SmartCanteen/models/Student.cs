using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartCanteen.models
{
    internal class Student : Client
    {
        public string StudentID {  get; set; }

        public Student(string name, string nif, decimal balance, string studentID) : base(name, nif, balance)
        {
             Name = name;
             NIF = nif;
             Balance = balance;
             StudentID = studentID;
        }
    }
}
