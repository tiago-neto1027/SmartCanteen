﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    abstract class User
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string nif { get; set; }

        public User() 
        { 
        
        }
    }
}
