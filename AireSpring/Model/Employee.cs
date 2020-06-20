﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AireSpring.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public DateTime HireDate { get; set; }
    }
}