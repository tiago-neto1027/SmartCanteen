﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Professor : Client
    {
        public string Email { get; set; }
        public Professor() 
        {
            
        }
    }
}
