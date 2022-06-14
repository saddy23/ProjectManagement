using System;
using System.Collections.Generic;
using Project_Management.Models.Objects;

namespace Project_Management.Models.DataManager
{
    public class TaskManager
    {
        /// <summary>
        /// Lists all Tasks of the Projects 
        /// Exception:Exception
        /// </summary>        
        /// <returns>list of all tasks of the Projects </returns>
        public List<Tasks> GetAllTasks()
        {
            List<Tasks> lstTasks = new List<Tasks>();
            try
            {
                Tasks tasks = new Tasks();
                tasks.name = "Development";
                tasks.employee_Id = "2";
                tasks.description = "Development";
                tasks.employee_AssigenBy= "Abdul";
                tasks.employee_AssignTo = "Mohamed";
                tasks.id = "1";
                tasks.project_Id = "1";
                tasks.startDate = DateTime.Now.AddDays(-10);
                tasks.estimatedTime = tasks.startDate.AddDays(10);

                Tasks task = new Tasks();
                task.name = "Testing";
                task.employee_Id = "3";
                task.description = "Testing";
                task.employee_AssigenBy = "Abdul";
                task.employee_AssignTo = "Syed";
                task.id = "2";
                task.project_Id = "1";
                task.startDate = DateTime.Now.AddDays(-10);
                task.estimatedTime = task.startDate.AddDays(3);

                Tasks tks = new Tasks();
                tks.name = "Development";
                tks.employee_Id = "2";
                tks.description = "Development";
                tks.employee_AssigenBy = "Abdul";
                tks.employee_AssignTo = "Mohamed";
                tks.id = "3";
                tks.project_Id = "2";
                tks.startDate = DateTime.Now.AddDays(-10);
                tks.estimatedTime = tks.startDate.AddDays(10);

                Tasks tas = new Tasks();
                tas.name = "Testing";
                tas.employee_Id = "4";
                tas.description = "Testing";
                tas.employee_AssigenBy = "Abdul";
                tas.employee_AssignTo = "Syed";
                tas.id = "5";
                tas.project_Id = "2";
                tas.startDate = DateTime.Now.AddDays(-5);
                tas.estimatedTime = tas.startDate.AddDays(3);

                lstTasks.Add(tasks);
                lstTasks.Add(task);
                lstTasks.Add(tks);
                lstTasks.Add(tas);
                return lstTasks;
            }
            catch (Exception exceptionObj)
            {
                throw exceptionObj;
            }
        }
    }
}