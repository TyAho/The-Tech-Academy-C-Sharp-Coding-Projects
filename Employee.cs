﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Department Department { get; set; }
    }
}