using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Management.Models.Objects
{
    public class User
    {
        public string userId { get; set; }
        public DateTime createDate { get; set; }
        public string userPasword { get; set; }
        public string employeeId { get; set; }
        public string userType { get; set; }
    }
}