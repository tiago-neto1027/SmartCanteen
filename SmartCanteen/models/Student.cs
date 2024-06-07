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
        public int StudentID {  get; set; }

        public Student(string name, string nif, float balance, int studentID) : base(name, nif, balance)
        {
            string Name = name;
            string Nif = nif;
            float Balance = balance;
            int StudentID = studentID;
        }
    }
}
