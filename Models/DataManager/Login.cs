using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Management.Models.DataManager
{
    public class LoginManager
    {

        [Required]
        public string LoginId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string ValidateUser(LoginManager p_loginManager)
        {
            string userType = null;
            try
            {
                switch (p_loginManager.LoginId)
                {
                    case "Admin":
                        userType = p_loginManager.LoginId;
                        break;
                    case "Employee":
                        userType = p_loginManager.LoginId;
                        break;
                    default:                        
                        break;
                }
                return userType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}