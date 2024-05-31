using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Student : Client
    {
        [Key]
        public int StudentID {  get; set; }

        public Student() 
        {
            
        }
    }
}
