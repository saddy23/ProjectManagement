using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Management.Models.Objects
{
    public class Projects
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime estimateTime { get; set; }
        public string clientId { get; set; }
        public string emloyee_Id { get; set; }
        public string status { get; set; }
    }
}