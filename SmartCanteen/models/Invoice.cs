﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.models
{
    internal class Invoice
    {
        [Key]
        public int ID { get; set; }
        public double Total {  get; set; }
        public DateTime Date { get; set; }

        public Invoice()
        {

        }
    }
}
