﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Employee_Transactions
    {
        //public int id { get; set; }
        public int emp_no { get; set; }
        public string item { get; set; }
        public string subcat { get; set; }
        public decimal unit_price { get; set; }
        public decimal quantity { get; set; }
        public string delivery_date { get; set; }
        public string remarks { get; set; }
    }
}
