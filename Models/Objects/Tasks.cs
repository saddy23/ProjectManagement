using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Management.Models.Objects
{
    public class Tasks
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string project_Title { get; set; }
        public DateTime startDate { get; set; }
        public DateTime estimatedTime { get; set; }
        public string employee_AssignTo { get; set; }
        public string employee_AssigenBy { get; set; }
        public string project_Id { get; set; }
        public string employee_Id { get; set; }
        public string taskStatus { get; set; }
    }
}