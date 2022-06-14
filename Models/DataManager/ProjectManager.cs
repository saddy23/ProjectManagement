using System;
using System.Collections.Generic;
using Project_Management.Models.Objects;

namespace Project_Management.Models.DataManager
{
    public class ProjectManager
    {
        /// <summary>
        /// Lists all project 
        /// Exception:Exception
        /// </summary>        
        /// <returns>list of all project </returns>
        public List<Projects> GetAllProjects()
        {
            List<Projects> lstProjects = new List<Projects>();
            try
            {
                Projects projects = new Projects();
                projects.clientId = "1";
                projects.description = "Application to maintain Employee Payroll";
                projects.emloyee_Id = "1";
                projects.startDate = DateTime.Now;
                projects.estimateTime = projects.startDate.AddDays(20);
                projects.id = "1";
                projects.status = "InProgress";
                
                projects.title = "Payroll Management";

                Projects project = new Projects();
                project.clientId = "1";
                project.description = "Application to maintain Employee's Leave";
                project.emloyee_Id = "2";
                project.startDate = DateTime.Now.AddDays(5);
                project.estimateTime = project.startDate.AddDays(20);
                project.id = "2";
                project.status = "InProgress";
                
                project.title = "Time Management";

                
                lstProjects.Add(projects);
                lstProjects.Add(project);
                return lstProjects;
            }            
            catch (Exception exceptionObj)
            {
                throw exceptionObj;
            }
        }
    }
}