using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickstarterADMU1.Models
{
    public class Students
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string course { get; set; }
        public double accountBalance { get; set; }
        public DateTime dateCreated { get; set; }
    }
}