using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickstarterADMU1.Models
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public bool gender { get; set; }
        public int age { get; set; }
        public string course { get; set; }
        public double accountBalance { get; set; }
        public DateTime dateCreated { get; set; }
    }
}