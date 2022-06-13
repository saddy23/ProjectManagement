using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Management.Models
{
    public class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
        public DateTime joiningDate { get; set; }
        public DateTime dOB { get; set; }
    }
}