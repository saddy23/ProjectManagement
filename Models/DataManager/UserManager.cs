using System;
using System.Collections.Generic;
using Project_Management.Models.Objects;

namespace Project_Management.Models.DataManager
{
    public class UserManager
    {

        /// <summary>
        /// Lists all User details 
        /// Exception:Exception
        /// </summary>        
        /// <returns>list of all users </returns>
        public List<User> GetAllUsers()
        {
            List<User> lstUsers = new List<User>();
            try
            {
                User users = new User();
                users.employeeId = "1";
                users.userId = "Employee";
                users.userPasword = "12345";
                users.userType = "Employee";
                users.createDate = DateTime.Now;

                User user = new User();
                user.employeeId = "2";
                user.userId = "Admin";
                user.userPasword = "1234";
                user.userType = "Admin";
                user.createDate = DateTime.Now;

                User urs = new User();
                urs.employeeId = "3";
                urs.userId = "Emp1";
                urs.userPasword = "1111";
                urs.userType = "Employee";
                urs.createDate = DateTime.Now;

                User usr = new User();
                usr.employeeId = "4";
                usr.userId = "Emp2";
                usr.userPasword = "222";
                usr.userType = "Employee";
                usr.createDate = DateTime.Now;


                lstUsers.Add(users);
                return lstUsers;
            }
            catch (Exception exceptionObj)
            {
                throw exceptionObj;
            }
        }
    }
}